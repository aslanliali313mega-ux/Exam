from http.server import ThreadingHTTPServer, SimpleHTTPRequestHandler
from urllib.parse import urlsplit
import os
import sys

ROOT = os.path.dirname(os.path.abspath(__file__))


class AdminAwareHandler(SimpleHTTPRequestHandler):
    def send_head(self):
        parsed = urlsplit(self.path)
        if parsed.path in ("/admin", "/admin/"):
            self.path = "/admin/index.html"
        return super().send_head()

    def log_message(self, format, *args):
        return


if __name__ == "__main__":
    port = int(sys.argv[1]) if len(sys.argv) > 1 else 8000
    os.chdir(ROOT)
    server = ThreadingHTTPServer(("0.0.0.0", port), AdminAwareHandler)
    print(f"Serving on http://127.0.0.1:{port}")
    server.serve_forever()
