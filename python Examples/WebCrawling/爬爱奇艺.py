import json
import re
import lxml
import requests
import scrapy

import urllib
import re
import os
import requests

from utils.header import get_ua

base_url = 'http://sc.chinaz.com/tupian/'
url = f'{base_url}shuaigetupian.html'

headers = {
    'User-Agent': get_ua()
}

header = {

}

class IqySpider(scrapy.Spider):
    def __init__(self) -> None:
        super().__init__()

    def parse(self):
        pass