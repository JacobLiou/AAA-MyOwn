import time 

try:

    with open('rebase.txt', 'r', encoding='utf-8') as f:
        print(f.read())#一次性读取内容

    with open('rebase.txt', 'r', encoding='utf-8') as f:
        for line in f:
            print(line, end=" ")

    with open('index.html', 'r', encoding='utf-8') as f:
        lines = f.readlines()
    
    print(lines)
except:
    print("Error")


f1 = open("a.txt", "w", encoding='utf-8')
f2 = open("b.txt", "w", encoding='utf-8')
f3 = open("c.txt", "w", encoding='utf-8')

for i in range(1, 10000):
    if i < 100:
        f1.write(str(i) + '\n')
    elif i >= 100 and i < 1000:
        f2.write(str(i) + '\n')
    elif i >= 1000:
        f3.write(str(i) + '\n')

f1.close()
f2.close()
f3.close()


import json
mydict = {
    'Name' : "BB",
    'age': 38,
        'qq': 957658,
        'friends': ['王大锤', '白元芳'],
        'cars': [
            {'brand': 'BYD', 'max_speed': 180},
            {'brand': 'Audi', 'max_speed': 280},
            {'brand': 'Benz', 'max_speed': 320}
        ]
}

with open("data.json", 'w', encoding='utf-8') as f:
    json.dump(mydict, f)

with open("data.json", 'r', encoding='utf-8') as f:
    mydict2 = json.load(f)