import selenium
import selenium.webdriver

from selenium import webdriver  # 用来驱动浏览器的
from selenium.webdriver import ActionChains  # 破解滑动验证码的时候用的 可以拖动图片
from selenium.webdriver.common.by import By  # 按照什么方式查找，By.ID,By.CSS_SELECTOR
from selenium.webdriver.common.keys import Keys  # 键盘按键操作
from selenium.webdriver.support import expected_conditions as EC  # 和下面WebDriverWait一起用的
from selenium.webdriver.support.wait import WebDriverWait  # 等待页面加载某些元素
import time
from msedge.selenium_tools import Edge


driver = Edge(executable_path="D:\Downloads\edgedriver_win64\msedgedriver.exe")
driver.get("https://www.baidu.com/")

driver.get('http://www.bing.com')
# # click  button
# python_button = driver.find_elements_by_xpath("//input[@name='lang' and @value='Python']")[0]
# python_button.click()
est_cn = driver.find_element_by_id("est_cn")
est_cn.click()
time.sleep(3)
est_en = driver.find_element_by_id("est_en")
est_en.click()
time.sleep(3)
driver.back()#前进后退   按键精灵对比selenium自动化
#sel_tag=wait.until(EC.presence_of_element_located((By.ID,"est_cn")))

# driver = webdriver.Chrome()

try:
    wait=WebDriverWait(driver,10)
    #1、访问百度
    driver.get('https://www.baidu.com/')
    driver.set_window_size(500, 500)
    driver.maximize_window()#最大化窗口
    #2、查找输入框
    #     input_tag = wait.until(
    #         # 调用EC的presence_of_element_located()
    #         EC.presence_of_element_located(
    #             # 此处可以写一个元组
    #             # 参数1: 查找属性的方式
    #             # 参数2: 属性的名字
    #             (By.ID, "kw")
    #         )
    #     )
    input_tag=wait.until(EC.presence_of_element_located((By.ID,"kw")))

    #3、在搜索框在输入要搜索的内容
    input_tag.send_keys('秦时明月')

    # 4、按键盘回车键
    input_tag.send_keys(Keys.ENTER)

    time.sleep(3)

finally:
    driver.close()

