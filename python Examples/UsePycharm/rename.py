# utf-8
import os
import random
import sys
import path


# 在目录中查找文件名字然后替换到目标
def getdirnames(dir, pattern, replace):
    files = os.listdir(dir)
    for file in files:
        name = file.split('.')[0]
        ext = file.split('.')[1]

        if name.find(pattern):
            newname = name.replace(pattern, replace)

        filename = dir + '\\' + file
        newname = dir + '\\' + newname + "." + ext
        os.rename(filename, newname)
        print(newname)
