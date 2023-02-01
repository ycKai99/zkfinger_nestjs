import { All, Controller, Get, Req } from '@nestjs/common';
import { FingerPrintService } from './app.service';
import { Request } from 'express';

@Controller()
export class AppController {
  constructor(private readonly appService: FingerPrintService) {} 
  
  @Get()
  getHello(): string {
    return this.appService.getHello();
  }

  @All('fingerprint')
  getFingerPrintFunction(@Req() request: Request): string {
    return this.appService.getFingerPrintFunction(request);
  }

  
  @All('comparefingerprint')
  getCompareFingerPrintFunction(@Req() request: Request): string {
    return this.appService.getCompareFingerPrintFunction(request);
  }
}
