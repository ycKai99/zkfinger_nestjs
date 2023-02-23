import { All, Controller, Get, Req, Post, Res, StreamableFile, Param, Render } from "@nestjs/common";
import { FingerPrintService } from "./app.service";
import { Request } from "express";
const fs = require("graceful-fs");
const fsp = require('fs/promises');
import jade = require('jade');


@Controller()
export class AppController {
  constructor(private readonly appService: FingerPrintService) { }


  @Get('message')
  getMessage(@Req() req, @Res() res): string {
    const jadeargument: any = {};
    // console.log(JSON.stringify(fptemp));
    let data = fs.readFileSync('message.json', {
      encoding: 'utf8',
    });
    let msg = JSON.parse(data);
    jadeargument['message'] = msg['Notification'];
    return res.send(res_render('message', res, jadeargument));
  }

  @Get('status')
  getStatus(@Req() req, @Res() res): string {
    const jadeargument: any = {};
    // console.log(JSON.stringify(fptemp));
    let data = fs.readFileSync('fpTemplate.json', {
      encoding: 'utf8',
    });
    let fpdata = JSON.parse(data);
    jadeargument['dataSet1'] = fpdata['Register'];
    return res.send(res_render('fp', res, jadeargument));
  }

  @Post('status')
  postStatus(@Req() req: Request, @Res() res): string {
    const jadeargument: any = {};
    console.log("Message from java server: ", JSON.stringify(req.body, null, 2));
    let data = fs.readFileSync('fpTemplate.json', {
      encoding: 'utf8',
    });
    let fpdata = JSON.parse(data);
    jadeargument['dataSet1'] = fpdata['Register'];
    let newdata = JSON.stringify(req.body, null, 2);
    let newdatajson = JSON.parse(newdata);

    //Push the new data to the json object
    for (let i = 0; i < fpdata['Register'].length; i++) {
      let fpDataString = JSON.stringify(fpdata['Register'][i]);
      let fpDataJson = JSON.parse(fpDataString);
      newdatajson['Register'].push(fpDataJson);

    }
    fs.writeFileSync("fpTemplate.json", JSON.stringify(newdatajson));
    //console.log(JSON.stringify(req.body, null, 2));
    console.log("Save success");
    jadeargument['dataSet1'] = newdatajson['Register'];
    return res.send(res_render('fp', res, jadeargument));
  }
}

export function res_render(jadefile: any, res: any, jadeargument: any) {
  // Compile a function
  let data = fs.readFileSync('views/' + jadefile + '.jade', {
    encoding: 'utf8',
  });
  let renderer = jade.compile(data);

  // Render the function
  let html = renderer({ jadeargument });

  return html;
}



