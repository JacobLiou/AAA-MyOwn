import math

def PrintLotusNumber():
    for num in range(100, 1000):
        a = num % 10
        b = (num // 10) % 10
        c= num // 100
        if num == (a ** 3 + b ** 3 + c ** 3):
            print(num)

PrintLotusNumber()


def reverseInteger(num):
    numstr = str(num)
    numstr = numstr[::-1]
    return int(numstr)

print(reverseInteger(12345))
print(reverseInteger(10000))

def reverseInteger2(num):   
    a= num % 10
    b= num // 10
    reverse = a
    while b != 0:
        a = b % 10
        b = b // 10
        reverse  = reverse * 10 + a
    
    return reverse

print(reverseInteger2(12345))
print(reverseInteger2(10000))


str1 = "sdfdsfsdf2342gery547hfhwrewr"
print(str1[::-1])
print(str1[-4:-1:2])

a = 1
b = 2
#高阶格式化输出
print(f'{1} * {b} = {a*b}')
print(f'{a} * {b} = {a*b}')


import time
import os
import keyboard

def carosel():
    content = "afhsfz直接过来就是两个垃圾图片问题及时给"
    while True:
        print(content)
        time.sleep(1)
        content = content[1::]
        if content == '':
            break

def carosel1():
    content = "afhsfz直接过来就是两个垃圾图片问题及时给"
    while True:
        os.system('cls')
        print(content)
        time.sleep(1)
        content = content[1::] + content[0]  
        if keyboard.is_pressed('q'):
            break


# carosel()
# carosel1()

import random
def genVerfiCode(length):
    all_chars = '0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ'
    count = len(all_chars)
    lst = []
    for _ in range(length):
        lst.append(all_chars[random.randint(0, count-1)])
    
    #这里思考一下 字符串不断相加 和 list 转换哪个更优越
    return str.join("", lst)

print(genVerfiCode(5))
print(genVerfiCode(5))
print(genVerfiCode(5))
print(genVerfiCode(5))
print(genVerfiCode(5))


def getFileExtension(fileName):
    pos = 0
    # for i in range(len(fileName)-1, 0, -1):
    #     if fileName[i] == ".":
    #         pos = i
    #         break

    pos = fileName.rfind('.')
    return fileName[pos::]

print(getFileExtension("1.txt"))
print(getFileExtension("sdafhwhtlkaghlsadkgj.cpp"))


def getTop2Number(numList):
    numList = sorted(numList,)
    return[numList[-1], numList[-2]]

print(getTop2Number([1, 2, 5, 2, 9 , 18 , 33, 2, 1,6]))


