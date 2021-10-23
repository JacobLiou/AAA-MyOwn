import bs4
import requests
from lxml import etree
import lxml
import re
import json
# import pymysql

url = 'https://music.163.com/discover/artist'
singer_infos =[]

# 通过URL获取网页内容，返回xpath对象
def get_xpath(url):
    headers = {
        'User-Agent': 'Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.70 Safari/537.36'
    }

    reponse = requests.get(url, headers=headers)
    return etree.HTML(reponse.text)

def parse():
    html = get_xpath(url)
    fenlei_url_list = html.xpath('//ul[@class="nav f-cb"]/li/a/@href')

    new_list = [i for i in fenlei_url_list if 'id' in i]
    for i in new_list:
        fenlei_url = 'https://music.163.com' + i
        # print(fenlei_url)
        parse_fenlei(fenlei_url)

def parse_fenlei(url):
    html = get_xpath(url)
    zimu_url_list = html.xpath('//ul[@id="initial-selector"]/li[position()>1]/a/@href')
    for i in zimu_url_list:
        zimu_url = 'https://music.163.com' + i
        parse_singer(zimu_url)
        print(zimu_url)

def parse_singer(url):
    html = get_xpath(url)
    item = {}
    singer_names = html.xpath('//ul[@id="m-artist-box"]/li/p/a/text()')
    # --详情页看到页面结构会有两个a标签，所以取第一个
    singer_href = html.xpath('//ul[@id="m-artist-box"]/li/p/a[1]/@href')
    # print(singer_names,singer_href)
    for i, name in enumerate(singer_names):
        item['歌手名'] = name
        item['音乐链接'] = 'https://music.163.com' + singer_href[i].strip()
        # 获取歌手详情页的链接
        url = item['音乐链接'].replace(r'?id', '/desc?id')
        # print(url)
        parse_detail(url, item)
 
# ---------获取详情页url和存着歌手名字和音乐列表的字典，在字典中添加详情页数据
def parse_detail(url, item):
    html = get_xpath(url)
    desc_list = html.xpath('//div[@class="n-artdesc"]/p/text()')
    item['歌手信息'] = desc_list
    singer_infos.append(item)
    write_singer(item)
 
 
# ----------------将数据字典写入歌手文件
def write_singer(item):
    with open('singer.json', 'a+', encoding='utf-8') as file:
        json.dump(item,file)
 
 
if __name__ == '__main__':
    parse()
