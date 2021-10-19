import poplib
import email
from email.header import decode_header

# 获取邮件标题
def get_email_subject(addr, password):
    read = poplib.POP3('pop.163.com', timeout=3600)
    read.user(addr)  # 163邮箱用户名
    read.pass_(password)  # 163邮箱设置中的客户端授权密码
    total_num, total_size = read.stat()


    top_email = read.top(total_num, 1)
    tmp = []
    for s in top_email[1]:
        tmp.append(s.decode())
    ​
    # 将解码后的邮件内容拼接为字符串
    email_str = '\n'.join(tmp)
    # print(email_str)
    # 将字符串类型解析为Message类型
    message = email.message_from_string(email_str)
    ​
    # 获取邮件主题
    subject_str = message['subject']
    subject = decode_header(subject_str)
    content = subject[0][0]
    enc_type = subject[0][1]
    if enc_type:
        subject_decode = content.decode(enc_type)
    else:
        subject_decode = content
    return subject_decode, read, total_num
