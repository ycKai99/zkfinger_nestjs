import { Injectable, Req, StreamableFile } from '@nestjs/common';
import { Body, Get, Res } from '@nestjs/common/decorators';
import { Post } from '@nestjs/common/decorators';
import { Request } from 'express';
import { GetJsonFunction } from './app.dto';
import { GetFpFunction } from './fp.dto';
import { createReadStream } from 'fs';
import { join } from 'path';
import { Socket, Manager } from 'socket.io-client';
const fs = require("fs");
const fsp = require('fs/promises');
const WebSocket = require('ws');
const io = require('socket.io-client');
import * as net from 'net';

@Injectable()
export class FingerPrintService {
  private socket: net.Socket;
  constructor() {
    console.log('FingerPrint Service.');

    this.socket = new net.Socket();
    this.socket.connect(3000, '192.168.200.2', () => {
      console.log('Connected to Java server');
      const file = fsp.readFile("fpTemplate.json", 'utf-8');
      this.socket.write("message from client", file);
    });
    this.socket.on('data', (data) => {
      console.log(`Received from Java server: ${data.toString()}`);
    });
    this.socket.on('end', () => {
      console.log('disconnected from server')
    })



  }


  fingerprint = [
    {
      name: 'userone',
      fingerprintTemplate: 'test',
    }
  ]





  getHello(): string {
    return 'Test';
  }

  getfp(@Res({ passthrough: true }) res: Response): StreamableFile {
    //const file = createReadStream(join(process.cwd(), 'fpTemplate.json'));
    //return new StreamableFile(file);
    const file = fsp.readFile("fpTemplate.json", 'utf-8');
    console.log('data get');
    // const obj = JSON.stringify(fsp.readFile("fpTemplate.json", 'utf-8'));
    return file;

  }


  savefp(fpLength: GetFpFunction): string {
    // fsp.writeFile("fpTemplate.json", JSON.stringify(fpLength));
    //fs.writeFile("fpTemplate.json", JSON.stringify(fpLength));
    return JSON.stringify(fpLength);
  }

  saveRecord(record: GetJsonFunction): string {
    console.log(JSON.stringify(record));
    return JSON.stringify(record);
  }
}
