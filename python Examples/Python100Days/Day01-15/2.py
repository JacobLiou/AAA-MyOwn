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


