var http = require('http');

http.createServer(function (req, res) {
  var body = 'Hello World';
  
  res.writeHead(200, {
    'Content-Type': 'text/plain',
    'Content-Length', Buffer.byteLength(body)
  });
  res.end(body);
}).listen(3000);

console.log('Listening on port 3000');