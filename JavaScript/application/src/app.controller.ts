import { All, Controller, Get, Req, Post, Res, StreamableFile, Param, Render, Body } from "@nestjs/common";
import { FingerPrintService } from "./app.service";
import { Request } from "express";
const fs = require("graceful-fs");
const fsp = require('fs/promises');
import jade = require('jade');
import { GetFpFunction } from "./fp.dto";
import { createReadStream } from 'graceful-fs';
import { join } from 'path';
const CryptoJS = require("crypto-js");
const AES = require("crypto-js");
import * as crypto from 'crypto';

@Controller()
export class AppController {
  constructor(private readonly appService: FingerPrintService) { }

  @Post("registerfp")
  getFingerPrintFunction(
    @Req() request: Request,
    @Body() fp: GetFpFunction
  ): any {
    let filedata = fs.readFileSync('fpTemplate.json', {
      encoding: 'utf8',
    });
    console.log('Message from Java server: ', fp);
    if (filedata.length != 0) {
      let fpdata = JSON.parse(filedata.toString());
      let newdata = JSON.stringify(fp['Register']);
      let newdatajson = JSON.parse(newdata);
      fpdata['Register'].push(newdatajson[0]);
      // fsp.writeFile("fpTemplate.json", JSON.stringify(fpdata));
      console.log('save success');
      return "Message from nestjs: save success"
    }
    else {
      fsp.writeFile("fpTemplate.json", JSON.stringify(fp));
      console.log('save success');
    }
  }

  @Get('getfp')
  getFile(@Res({ passthrough: true }) res: Response): any {
    let filedata = fs.readFileSync('fpTemplate.json', {
      encoding: 'utf8',
    });
    if (filedata.length != 0) {
      let fpdata = JSON.parse(filedata.toString());

      // const key = 'Z5OO0FWfkCWuUqalU4AwlA==';
      const key = 'axtQjz7QRHCV7yOrnNK7gp==';
      const keyBuffer = Buffer.from(key, 'base64');
      console.log(crypto.randomBytes(16).toString('base64'));

      // The plaintext data to encrypt
      const plaintext = fpdata['Register'][0].fingerprintTemplate;

      // The IV (initialization vector) to use for CBC mode
      const iv = 'Os28pvyLTO00JHdxsBA3sw==';
      const ivBuffer = Buffer.from(iv, 'base64');


      // Create the AES cipher using CBC mode with the generated key and IV
      const cipher = crypto.createCipheriv('aes-128-cbc', keyBuffer, ivBuffer);

      // Encrypt the plaintext
      let ciphertext = cipher.update(plaintext, 'utf8', 'base64');
      ciphertext += cipher.final('base64');

      // Send the ciphertext, IV, and key to the Android app
      const dataToSend = {
        ciphertext: ciphertext,
      };
      return dataToSend;
    }
    else {
      return 'File is empty!';
    }
  }

  @Get('message')
  getMessage(@Req() req, @Res() res): string {
    const jadeargument: any = {};
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