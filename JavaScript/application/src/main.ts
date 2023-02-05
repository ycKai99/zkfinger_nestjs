/* eslint-disable prettier/prettier */
import { NestApplication, NestFactory } from '@nestjs/core';
import { NestExpressApplication } from '@nestjs/platform-express';
import { AppModule } from './app.module';

const port = 3000;

async function bootstrap() {
  const app = await NestFactory.create(AppModule);

  console.log('Server alive at http:/localhost:' + port);
  console.log('Server alive at http:/localhost:' + port + '/fingerprint');
  console.log('Server alive at http:/localhost:' + port + '/comparefingerprint');
  console.log('Server alive at http:/localhost:' + port + '/test');
  await app.listen(port);
}
bootstrap();
