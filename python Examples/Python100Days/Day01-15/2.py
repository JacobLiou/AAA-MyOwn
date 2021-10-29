a = 11
b = 98
print(a + b)
print(a - b)
print(a * b)
print(a / b)

print(b ** a)

print(type(a))

a = 11.1
print(type(a))
b = int(a)
print(b)

s = str(b)
print(s)

# try:
#     a = int(input("请输入第一个整数："))
#     b = int(input("请输入第二个整数："))
#     # print("两个整数之和为：", a+b)
#     print("%d + %d = %d" %(a, b, a+b))
# except:
#     print("输入错误")


# a = 3
# b =10
# a += b
# a *= a + 2
# print(a)

# if True and False or True and not True:
#     print("haha")
# else:
#     print("hoho")


import math
from random import randint
perimeter = 8 * 2 * math.pi
print(perimeter)

def isLeapYear(year):
    if year % 400 == 0 or (year % 100 != 0 and year % 4 == 0):
        return True
    return False

print(isLeapYear(2000))
print(isLeapYear(2100))
print(isLeapYear(2020))
print(isLeapYear(2021))

lst = [i+1 for i in range(100)]
print(sum(lst))

i =1
sum_add = 0 
# for i in range(101):
#     sum_add +=i
#     i+=1
# print(sum_add)

while i <= 100:
    sum_add += i
    i+=1
print(sum_add)

sum_0 = 0
for i in range(101):
    sum_0 += i
print(sum_0)


# import random

# # ran = int(random.random() * 100)
# ran = random.randint(0, 100)
# count = 0
# while True:
#     num = int(input("请输入要猜的整数{0-100}"))
#     count +=1
#     if ran == num:
#         print("猜中了")
#         break
#     elif num < ran:
#         print("猜的小了点")
#     else:
#         print("猜的大了点")

# print("一共猜了%d次" % count)

#九九乘法表
for i in range(1, 10):
    for j in range(1, i+1):
        print("%d * %d = %d" % (i, j, i * j), end='\t')
    #换行
    print()
