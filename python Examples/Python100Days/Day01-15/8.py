"""
验证输入用户名和QQ号是否有效并给出对应的提示信息

要求：用户名必须由字母、数字或下划线构成且长度在6~20个字符之间，QQ号是5~12的数字且首位不能为0
"""

import re

ure = r"^[0-9a-zA-Z_]{6, 20}$"
qqre = r"[1-9][0-9]{4,11}"

username = input("请输入用户名:")
r = re.match(ure, username)
if not r:
    print("用户名输入格式不正确")

qq = input("请输入QQ:")
r = re.match(qqre, qq)
if not r:
    print("QQ输入格式不正确")

phoneRe = r"1[35678][0-9]{9}"
sentence = '''
    重要的事情说8130123456789遍，我的手机号是13512346789这个靓号，
    不是15600998765，也是110或119，王大锤的手机号才是15600998765。
    '''
print(re.findall(phoneRe, sentence))

