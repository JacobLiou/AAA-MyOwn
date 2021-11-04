import http
# import httplib2
import requests

# 网络编程基本上采用requests
from time import time
from threading import Thread

url = "https://bing.com"
res = requests.get(url=url)
print(res)
print(res.content)

class DownLoader(Thread):
    def __init__(self, url):
        super().__init()
        self._url = url
    
    def run(self):
        pass