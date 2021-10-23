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