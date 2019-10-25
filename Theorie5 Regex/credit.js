const fs = require("fs");

fs.readFile("credit.txt", (err, buff) => {
  let result = buff.toString().match(/\d{13,16}/g);
  console.log(result);
});
