import { Injectable, Req } from '@nestjs/common'; 
import { Get } from '@nestjs/common/decorators';
import { Request } from 'express';

@Injectable()
export class FingerPrintService {
  constructor() {
    console.log('FingerPrint Service.');
  }

  getHello(): string {
    return 'Hello World!';
  }

  getFingerPrintFunction(@Req() request: Request): string {
    return 'Some operation done!';
  }
}
