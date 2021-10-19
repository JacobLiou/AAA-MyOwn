key_list = [1, 2, 3]
value_list = ["good", "bad", "evil"]

dic = dict(zip(key_list, value_list))
print(dic)

merge_list = key_list + value_list
print(merge_list)


def merge(*args, missing_val = None):
    max_length = max([len(lst) for lst in args])
    outList = []
    for i in range(max_length):
        subList = []
        for k in range(len(args)):
            subList.append(args[k][i])
        outList.append(subList)
    return outList

print(merge([1,2,3],[ 'a' , 'b' , 'c' ], [ 'h' , 'e' , 'y' ],[4,5,6]))

# 可变参数
# #args适配元组
def cal(*args):
    sum = 0
    for n in args:
        sum += n
    return sum

print(cal(10, 9 ,0))

#**kwargs 匹配字典
def record(str, **kwargs):
    print("str=", str)
    print('kwargs=', kwargs)

record('测试', name = "john", age = 10)

def param_test(name, age):
    print('name=', name)
    print('age=', age)

data = ['码农飞哥', 18]
# 逆向参数收集
param_test(*data)