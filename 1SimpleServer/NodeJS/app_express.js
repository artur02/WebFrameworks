var  express = require('express'),
       app = express();
       
app.get('/', function(req, res){
  var body = 'Hello World';
  
  //res.setHeader('Content-Type', 'text/plain');
  //res.setHeader('Content-Length', Buffer.byteLength(body));
  //res.end(body);
  
  res.send(body);
});

app.listen(3000);

console.log('Listening on port 3000');