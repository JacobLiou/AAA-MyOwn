import numpy as np
import cv2
import datetime
import math


def array_to_tuple(arr):
    return tuple(arr.reshape(1, -1)[0])


colors = {'blue': (255, 0, 0), 'green': (0, 255, 0), 'red': (0, 0, 255), 'yellow': (0, 255, 255),
          'magenta': (255, 0, 255), 'cyan': (255, 255, 0), 'white': (255, 255, 255), 'black': (0, 0, 0),
          'gray': (125, 125, 125), 'rand': np.random.randint(0, high=256, size=(3,)).tolist(),
          'dark_gray': (50, 50, 50), 'light_gray': (220, 220, 220)}

image = np.zeros((640, 640, 3), dtype='uint8')
image[:] = colors['light_gray']

# 定义时针刻度数组
hours_orig = np.array(
    [(620, 320), (580, 470), (470, 580), (320, 620), (170, 580), (60, 470), (20, 320), (60, 170), (169, 61), (319, 20),
     (469, 60), (579, 169)])

hours_dest = np.array(
    [(600, 320), (563, 460), (460, 562), (320, 600), (180, 563), (78, 460), (40, 320), (77, 180), (179, 78), (319, 40),
     (459, 77), (562, 179)])


# hahs =  hours_orig.reshape(2, -1)
a = np.array([1, 2, 3], [4, 5, 6])
a.reshape(6)
a.reshape(6, order='F')


for i in range(0, 12):
    cv2.line(image, array_to_tuple(hours_orig[i]), array_to_tuple(
        hours_dest[i]), colors['black'], 3)

cv2.circle(image, (320, 320), 310, colors['black'], 8)

cv2.putText(image, "OpenCV-Python", (200, 200), 1,
            1.8, colors['magenta'], 1, cv2.LINE_AA)
cv2.putText(image, "DIY clocks and watches", (150, 440),
            1, 1.8, colors['magenta'], 1, cv2.LINE_AA)

image_original = image.copy()

# 模拟时钟显示当前时间
while True:
    date_time_now = datetime.datetime.now()
    # 获取当前时间
    time_now = date_time_now.time()
    # 计算当前时分秒
    hour = math.fmod(time_now.hour, 12)
    minute = time_now.minute
    second = time_now.second

    print("hour:'{}' minute:'{}' second: '{}'".format(hour, minute, second))

    # 获取时、分、秒角度
    second_angle = math.fmod(second * 6 + 270, 360)
    minute_angle = math.fmod(minute * 6 + 270, 360)
    hour_angle = math.fmod((hour * 30) + (minute / 2) + 270, 360)

    print("hour_angle:'{}' minute_angle:'{}' second_angle: '{}'".format(
        hour_angle, minute_angle, second_angle))

    # 绘制时针
    second_x = round(320 + 310 * math.cos(second_angle * 3.14 / 180))
    second_y = round(320 + 310 * math.sin(second_angle * 3.14 / 180))
    cv2.line(image, (320, 320), (second_x, second_y), colors['cyan'], 2)

    # 绘制分针
    minute_x = round(320 + 260 * math.cos(minute_angle * 3.14 / 180))
    minute_y = round(320 + 260 * math.sin(minute_angle * 3.14 / 180))
    cv2.line(image, (320, 320), (minute_x, minute_y), colors['cyan'], 8)

    # 绘制秒针
    hour_x = round(320 + 220 * math.cos(hour_angle * 3.14 / 180))
    hour_y = round(320 + 220 * math.sin(hour_angle * 3.14 / 180))
    cv2.line(image, (320, 320), (hour_x, hour_y), colors['cyan'], 10)

    cv2.circle(image, (320, 320), 10, colors['black'], -1)

    cv2.imshow("clock", image)

    # 获取带有静态信息的图像 :
    image = image_original.copy()

    if cv2.waitKey(500) & 0xFF == ord('q'):
        break

# Release everything:
cv2.destroyAllWindows()

# a = [1, 3, 6, 4]
# a.sort()
