/* eslint-disable prettier/prettier */
import { NestFactory } from '@nestjs/core';
import { AppModule } from './app.module';

const port = 3000;

async function bootstrap() {
  const app = await NestFactory.create(AppModule);

  console.log('Server alive at http:/localhost:' + port);
  console.log('Server alive at http:/localhost:' + port + '/fingerprint');
  console.log('Server alive at http:/localhost:' + port + '/comparefingerprint');
  await app.listen(port);
}
bootstrap();
