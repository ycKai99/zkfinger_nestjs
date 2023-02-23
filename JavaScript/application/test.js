
const fs = require("graceful-fs");
const fsp = require('fs/promises');

let filedata = fs.readFileSync('fpTemplate.json', {
    encoding: 'utf8',
});
let filejson = JSON.parse(filedata);
let fpTemplate = filejson['Register'][0].fingerprintTemplate;

for (let i = 0; i < filejson['Register'].length; i++) {
    console.log(filejson['Register'][i].fingerprintTemplate);
}