import { Injectable, Req, StreamableFile } from '@nestjs/common';
import { Body, Get, Res } from '@nestjs/common/decorators';
import { Post } from '@nestjs/common/decorators';
import { Request } from 'express';
import { GetJsonFunction } from './app.dto';
import { GetFpFunction } from './fp.dto';
import { createReadStream } from 'fs';
import { join } from 'path';
import { Socket, Manager } from 'socket.io-client';
const fs = require("graceful-fs");
const fsp = require('fs/promises');
const io = require('socket.io-client');
import * as net from 'net';

@Injectable()
export class FingerPrintService {
  private socket: net.Socket;
  constructor() {
    console.log('FingerPrint Service.');
    const RETRY_INTERVAL = 5000;

    this.socket = new net.Socket();
    function connect() {
      this.socket.connect(8080, 'localhost', () => {
        console.log('Connected to Java server');
        // const file = fsp.readFile("fpTemplate.json", 'utf-8');
        let file = fs.readFileSync('fpTemplate.json', {
          encoding: 'utf8',
        });
        if (file.length != 0) {
          console.log(JSON.parse(file));
          this.socket.write(file.toString());
        }
        else {
          console.log("File is empty");
          this.socket.write(file.toString());
        }
      });
    }

    this.socket.on('data', (serverdata) => {
      console.log(`Message from Java server: ${serverdata.toString().slice(2)}`);
      let filedata = fs.readFileSync('fpTemplate.json', {
        encoding: 'utf8',
      });
      if (serverdata.toString().includes("Register")) {
        if (filedata.length != 0) {
          let fpdata = JSON.parse(filedata.toString());
          let serverDataObj = JSON.parse(serverdata.toString().slice(2));
          let newdata = JSON.stringify(serverDataObj['Register']);
          let newdatajson = JSON.parse(newdata);
          fpdata['Register'].push(newdatajson[0]);
          console.log("after push: ", fpdata);
          fsp.writeFile("fpTemplate.json", JSON.stringify(fpdata));
          console.log('save success');
        }
        else {
          fsp.writeFile("fpTemplate.json", serverdata.toString().slice(2));
          console.log('save success');
        }
      }
      else {
        fsp.writeFile("message.json", serverdata.toString().slice(2));
        console.log('Message from Java server: ', JSON.parse(serverdata.toString().slice(2)));
      }
    });

    this.socket.on('error', (err) => {
      console.error(`Socket error: ${err.message}`);
      // setTimeout(connect, RETRY_INTERVAL);
    });

    this.socket.on('end', () => {
      console.log('disconnected from java server');
      setTimeout(connect, RETRY_INTERVAL);
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
    if (file.toString() != null) {
      console.log("File is not empty");
    }
    else {
      console.log("File is empty");
    }
    // var fp_json = JSON.stringify(file);
    console.log('fingerprint get');

    // const obj = JSON.stringify(fsp.readFile("fpTemplate.json", 'utf-8'));
    return file;
  }


  savefp(fpLength: GetFpFunction): string {
    // fsp.writeFile("fpTemplate.json", JSON.stringify(fpLength));
    //fs.writeFile("fpTemplate.json", JSON.stringify(fpLength));
    console.log(fpLength.toString());
    return "Nestjs save success";
  }

}


