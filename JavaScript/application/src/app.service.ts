import { Injectable, Req } from '@nestjs/common';
import { Body, Get, Res } from '@nestjs/common/decorators';
import { Post } from '@nestjs/common/decorators';
import { Request } from 'express';
import { GetJsonFunction } from './app.dto';
import { GetFpFunction } from './fp.dto';
const fs = require("fs");
@Injectable()
export class FingerPrintService {
  constructor() {
    console.log('FingerPrint Service.');

    // read storage
    //this.fingerprints = fs.read('filename') ;
  }
  fingerprint = [
    {
      name: 'userone',
      fingerprintTemplate: 'test',
    }

  ]

  getHello(): string {
    return 'Hello World!';
  }

  getJsonFunction(): any { }

  getFingerPrintFunction(@Req() request: Request, @Body() fp: GetFpFunction): any {
    let fingerprint: string = JSON.stringify(fp);
    //const json = JSON.parse(request.body);
    // var fp_txt = JSON.stringify(json)
    // read storage 
    //this.fingerprints.push(fingerprint);

    // write storage
    //fs.write(this.fingerprints);
    //console.log(request);

    return fingerprint;
  }

  getCompareFingerPrintFunction(@Req() request: Request): string {
    const compareresult = 'Fingerprint same';
    //..
    //request.body
    // compareresult = 'Fingerprint different';

    return compareresult;
  }
}
