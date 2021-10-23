import requests

base_url = 'https://www.baidu.com/more/'

headers = {
    "user-agent": 'Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/77.0.3865.90 Safari/537.36'
}

#HTTP 库的典型请求响应 使用 get post put delete
response = requests.get(base_url)
response.encoding = 'utf-8'

with open('./hahaindex.html', 'w', encoding='utf=8') as  fp:
    fp.write(response.content.decode('utf-8'))

print(response.content)
# requests.post(base_url, data="dsfdsfsd")


from lxml import etree 

base_url = 'https://www.runoob.com/python/python-exercise-example%s.html'


def write_py(i, text):
    with open('练习题%s.py' % i, 'w', encoding='utf-8') as fp:
        fp.write(text)

def get_element(url):
    headers = {
        'cookie': '__gads=Test; Hm_lvt_3eec0b7da6548cf07db3bc477ea905ee=1573454862,1573470948,1573478656,1573713819; Hm_lpvt_3eec0b7da6548cf07db3bc477ea905ee=1573714018; SERVERID=fb669a01438a4693a180d7ad8d474adb|1573713997|1573713863',
        'referer': 'https://www.runoob.com/python/python-100-examples.html',
        'user-agent': 'Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/77.0.3865.90 Safari/537.36'

    }
    response = requests.get(url, headers=headers)
    return etree.HTML(response.text)

# import pymysql #hun'混装环境 python 2 /3   环境搭建和以来解决
