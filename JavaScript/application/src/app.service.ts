import { Injectable, Req, StreamableFile } from '@nestjs/common';
import { Body, Get, Res } from '@nestjs/common/decorators';
import { GetFpFunction } from './fp.dto';
const fs = require("graceful-fs");
const fsp = require('fs/promises');
import * as net from 'net';
import { check } from 'prettier';
import { createServer } from 'net';

@Injectable()
export class FingerPrintService {
  private socket: net.Socket;
  constructor() {
    console.log('FingerPrint Service.');
    const RETRY_INTERVAL = 5000;

    let socket = new net.Socket();
    setTimeout(connect, 1000);
    function connect() {
      socket.connect(8080, 'localhost', () => {
        console.log('Connected to Java server');
        let file = fs.readFileSync('fpTemplate.json', {
          encoding: 'utf8',
        });
        if (file.length != 0) {
          let filejson = JSON.parse(file);
          let fpTemplate = filejson['Register'][0].fingerprintTemplate;
          console.log(JSON.parse(file));
          socket.write(fpTemplate);
        }
        else {
          console.log("File is empty");
          socket.write(file.toString());
        }
      });
    }

    socket.on('data', (serverdata) => {
      console.log(`Message from Java server: ${serverdata.toString()}`);
      let filedata = fs.readFileSync('fpTemplate.json', {
        encoding: 'utf8',
      });
      let filejson = JSON.parse(filedata);

      for (let i = 1; i < filejson['Register'].length; i++) {
        if (serverdata.toString().includes("False")) {
          socket.write(filejson['Register'][i].fingerprintTemplate);
          console.log("Not match");
        }
        else {
          console.log('match');
          return;
        }
      }


      // if (serverdata.toString().includes("Register")) {
      //   if (filedata.length != 0) {
      //     let fpdata = JSON.parse(filedata.toString());
      //     let serverDataObj = JSON.parse(serverdata.toString().slice(2));
      //     let newdata = JSON.stringify(serverDataObj['Register']);
      //     let newdatajson = JSON.parse(newdata);
      //     fpdata['Register'].push(newdatajson[0]);
      //     console.log("after push: ", fpdata);
      //     fsp.writeFile("fpTemplate.json", JSON.stringify(fpdata));
      //     console.log('save success');
      //   }
      //   else {
      //     fsp.writeFile("fpTemplate.json", serverdata.toString().slice(2));
      //     console.log('save success');
      //   }
      // }
      // else {
      //   let messageData = fs.readFileSync('message.json', {
      //     encoding: 'utf8',
      //   });
      //   if (messageData.length != 0) {
      //     let fpdata = JSON.parse(messageData.toString());
      //     let serverDataObj = JSON.parse(serverdata.toString().slice(2));
      //     let newdata = JSON.stringify(serverDataObj['Notification']);
      //     let newdatajson = JSON.parse(newdata);
      //     fpdata['Notification'].push(newdatajson[0]);
      //     fsp.writeFile("message.json", JSON.stringify(fpdata));
      //     console.log('save success');
      //   }
      //   else {
      //     fsp.writeFile("message.json", serverdata.toString().slice(2));
      //     console.log('Message from Java server: ', JSON.parse(serverdata.toString().slice(2)));
      //   }

      // }
    });

    socket.on('error', (err) => {
      console.error(`Socket error: ${err.message}`);
      setTimeout(connect, RETRY_INTERVAL);
    });

    socket.on('end', () => {
      console.log('disconnected from java server');
      setTimeout(connect, RETRY_INTERVAL);
    })




    // const server = createServer(socket => {
    //   let message = fs.readFileSync('message.json', {
    //     encoding: 'utf8',
    //   });
    //   let fpData = fs.readFileSync('fpTemplate.json', {
    //     encoding: 'utf8',
    //   });

    //   socket.write(message.toString());
    // });

    // server.listen(3010, () => {
    //   console.log('Server listening on port 3010');
    // });

    // server.on('connection', (stream) => {
    //   console.log('Client connected');

    //   stream.on('data', (data) => {
    //     console.log('Received data from client: ', data.toString());
    //   });
    // });


  }

}


