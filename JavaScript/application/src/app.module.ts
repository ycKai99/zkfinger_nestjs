import { Module } from '@nestjs/common';
import { AppController } from './app.controller';
import { FingerPrintService } from './app.service';

@Module({
  imports: [],
  controllers: [AppController],
  providers: [FingerPrintService],
})
export class AppModule {}
