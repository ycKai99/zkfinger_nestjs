import { Injectable, Req } from '@nestjs/common'; 
import { Get } from '@nestjs/common/decorators';
import { Request } from 'express'; 

@Injectable()
export class FingerPrintService {
  constructor() {
    console.log('FingerPrint Service.');

    // read storage
    //this.fingerprints = fs.read('filename') ;
  }

  //fingerprints:string[] = [];

  getHello(): string {
    return 'Hello World!';
  }

  getFingerPrintFunction(@Req() request: Request): string {

    //let fingerprint:string = request.body;

    // read storage 
    //this.fingerprints.push(fingerprint);
    
    // write storage
    //fs.write(this.fingerprints);

    return 'Some operation done!';
  }

  getCompareFingerPrintFunction(@Req() request: Request): string {
    const compareresult = 'Fingerprint same';
    //..
    //request.body
    // compareresult = 'Fingerprint different';

    return compareresult;
  }
}
