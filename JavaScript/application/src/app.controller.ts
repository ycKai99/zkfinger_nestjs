import { All, Controller, Get, Req, Post, Res, StreamableFile, Param } from "@nestjs/common";
import { FingerPrintService } from "./app.service";
import { Request } from "express";
import { Body } from "@nestjs/common/decorators";
import { GetFpFunction } from "./fp.dto";
import { GetJsonFunction } from "./app.dto";
import { createReadStream } from 'fs';
import { join } from 'path';
import { Stream } from "stream";
const fs = require("fs");
@Controller()
export class AppController {
  constructor(private readonly appService: FingerPrintService) { }

  @Get()
  getHello(): any {
    return this.appService.getHello();
  }

  // retrieve json data from file
  @All('getfp')
  getfp(@Res({ passthrough: true }) res: Response): StreamableFile {
    const file = createReadStream(join(process.cwd(), 'fpTemplate.json'));
    return new StreamableFile(file);
    // return this.appService.getfp(res);
  }


  @All("savefp")
  savefp(@Body() fp: GetFpFunction): any {
    return this.appService.savefp(fp);
    // fs.writeFile("fpTemplate.json", JSON.stringify(fp), (err) => {
    //   if (err) {
    //     console.log(err);
    //   } else {
    //     const fpLength = JSON.stringify(fp);
    //     if (fpLength.length != 2) {
    //       return this.appService.getFingerPrintFunction(fpLength.length);
    //     }
    //     else {
    //       console.log('length: ', fpLength.length, 'Content:', fp);
    //       console.log("File saved");
    //       return this.appService.getFingerPrintFunction(fpLength.length);
    //     }
    //   }
    // });
  }

  @All("records")
  saveRecord(@Body() record: GetJsonFunction): any {
    return this.appService.saveRecord(record);
  }

}