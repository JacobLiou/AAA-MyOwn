import re
import csv
import requests

import pandas
import lxml
import bs4
from selenium import webdriver

import time
import pprint

def get_jav_info(javUrl):
    headers = {

    }

    response = requests.get(url=javUrl, headers=headers)
    #解析response
    # result = response.text
    javDict = dict()
    result = response.json()['data']
    for index in result:
        actress = index['name']
        popularity = index['pop']
        javDict[actress] = popularity
    
    return javDict