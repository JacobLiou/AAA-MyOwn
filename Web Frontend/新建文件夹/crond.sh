#!/bin/bash
# this is check crond
# by author rivers on 2021-9.23

#定义变量
name = crond
num = $(ps -ef|grep $name | grep -vc grep)
if [$num -eq 1];then
    echo "$num running"
else
    echo "Not running"