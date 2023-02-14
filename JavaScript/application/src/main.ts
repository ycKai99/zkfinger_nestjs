/* eslint-disable prettier/prettier */
import { NestApplication, NestFactory } from '@nestjs/core';
import { AppModule } from './app.module';

const port = 3000;

async function bootstrap() {
  const app = await NestFactory.create(AppModule);

  console.log('Server alive at http:/localhost:' + port);
  console.log('Server alive at http:/localhost:' + port + '/getfp');
  console.log('Server alive at http:/localhost:' + port + '/savefp');
  await app.listen(port);
}
bootstrap();
