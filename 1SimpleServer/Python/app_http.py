import BaseHTTPServer

class MyHandler(BaseHTTPServer.BaseHTTPRequestHandler):
    def do_GET(s):
        s.send_response(200)
        s.send_header("Content-type", "text/plain")
        s.end_headers()
        s.wfile.write("Hello World")
        

def listener(server_class=BaseHTTPServer.HTTPServer,
        handler_class=MyHandler):
    server_address = ('', 3000)
    httpd = server_class(server_address, handler_class)
    return httpd
    
    
if __name__ == '__main__':
    try:
        print 'Listening on port 3000'
        httpd = listener()
        httpd.serve_forever()
    except KeyboardInterrupt:
        pass
    