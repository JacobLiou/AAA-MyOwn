from selenium import webdriver
from selenium.webdriver import ActionChains  # 破解滑动验证码的时候用的 可以拖动图片
from selenium.webdriver.common.by import By  # 按照什么方式查找，By.ID,By.CSS_SELECTOR
from selenium.webdriver.common.keys import Keys  # 键盘按键操作
from selenium.webdriver.support import expected_conditions as EC  # 和下面WebDriverWait一起用的
from selenium.webdriver.support.wait import WebDriverWait  # 等待页面加载某些元素
import time

from msedge.selenium_tools import Edge


driver = Edge(executable_path="D:\Downloads\edgedriver_win64\msedgedriver.exe")
driver.get('http://www.jd.com')

#转到登录页面
driver.find_element_by_link_text('你好，请登录').click()
#在页面选择输入账号密码登录
driver.find_element_by_link_text('账户登录').click()
driver.find_element_by_name("loginname").send_keys("输入用户名")
driver.find_element_by_name('nloginpwd').send_keys('blah')
driver.find_element_by_id("loginsubmit").click()
time.sleep(3)


