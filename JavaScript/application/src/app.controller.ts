import { All, Controller, Get, Req, Post, Res, StreamableFile } from "@nestjs/common";
import { FingerPrintService } from "./app.service";
import { Request } from "express";
import { Body } from "@nestjs/common/decorators";
import { GetFpFunction } from "./fp.dto";
import { createReadStream } from 'fs';
import { join } from 'path';
const fs = require("fs");
@Controller()
export class AppController {
  constructor(private readonly appService: FingerPrintService) { }

  @Get()
  getHello(): any {
    return this.appService.getHello();
  }

  // retrieve json data from file
  @All('retrieve')
  getFile(@Res({ passthrough: true }) res: Response): StreamableFile {
    const file = createReadStream(join(process.cwd(), 'fpTemplate.json'));
    console.log('Return data');
    return new StreamableFile(file);
  }

  @Post("savefp")
  getFingerPrintFunction(
    @Req() request: Request,
    @Body() fp: GetFpFunction
  ): any {
    fs.writeFile("fp.json", JSON.stringify(fp), (err) => {
      if (err) {
        console.log(err);
      } else {
        console.log(fp);
        console.log("File saved");
      }
    });
    return this.appService.getFingerPrintFunction(request, fp);
  }

  @Get()
  getJsonFunction(): any {
    return this.appService.getJsonFunction();
  }

  @All("comparefingerprint")
  getCompareFingerPrintFunction(@Req() request: Request): string {
    return this.appService.getCompareFingerPrintFunction(request);
  }
}