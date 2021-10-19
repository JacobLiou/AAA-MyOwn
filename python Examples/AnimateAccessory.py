from PIL import Image
import os
gifFileName = "./demo.gif"
im = Image.open(gifFileName)
#获取名字
pngDir = './img'
if not os.path.exists(pngDir):
    os.makedirs(pngDir)  # 用图片名创建一个文件夹，用来存放每帧图片，名字为pngDir的值

try:
  while True:  # 死循环
    current = im.tell()  # 用tell函数保存当前帧图片，赋值给current
    im.save(pngDir+'/'+str(current+1)+'.png')  # 调用save函数保存该帧图片
    im.seek(current+1)  # 调用seek函数获取下一帧图片，参数变为current帧图片+1
    # 这里再次进入循环，当为最后一帧图片时，seek会抛出异常，代码执行except
except EOFError:
    pass  # 最后一帧时，seek抛出异常，进入这里，pass跳过


#将视频通过openCV解析到各个图片桢
def video2images():
  import cv2
  videoFilename = "./demo.mp4"
  pngDir = videoFilename[:-4]
  if not os.path.exists(pngDir):
    os.makedirs(pngDir)
  
  cap = cv2.VideoCapture(videoFilename)
  num = 1
  while True:
    ret, frame = cap.read()
    if ret:
      cv2.imwrite(f"{pngDir}/{num}.png")
      num += 1
    else:
        break
  cap.release()
