/* eslint-disable prettier/prettier */
import { NestApplication, NestFactory } from '@nestjs/core';
import { AppModule } from './app.module';
import * as express from 'express';
import { join } from 'path';
import { NestExpressApplication } from '@nestjs/platform-express';
const port = 2000;

async function bootstrap() {
  const app = await NestFactory.create<NestExpressApplication>(AppModule);

  console.log('Server alive at http:/localhost:' + port);
  console.log('Server alive at http:/localhost:' + port + '/getfp');
  console.log('Server alive at http:/localhost:' + port + '/savefp');
  app.setBaseViewsDir(join(__dirname, '..', 'view'));
  app.setViewEngine('jade');
  await app.listen(port);
}
bootstrap();
