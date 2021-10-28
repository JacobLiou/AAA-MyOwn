# https://stackoverflow.com/questions/29664399/capturing-video-from-two-cameras-in-opencv-at-once

# 背景：当时针对工厂的多摄像头扫码 从同时获取多个摄像头 得到图片 然后解析条形码
# 整个从C# 采用Afoge VLC OpenCV进行多摄像头驱动  然后采用Zxing Zbar解码
# 到后面多进程思考 一个进程驱动一个摄像头  一个 线程驱动一个摄像头

import cv2
import threading

class camThread(threading.Thread):
    def __init(self, previewName, camId):
        self.previewName=previewName
        self.camId=camId
    
    def run(self):
        print("开启一个线程驱动一个摄像头")
        camPreview(self.previewName, self.camId)
        
def camPreview(previewName, camId):
    cv2.namedWindow(previewName)
    cam = cv2.VideoCapture(camId)
    if cam.isOpened():
        rval, frame = cam.read()
    else:
        rval = False
    
    while rval:
        cv2.imshow(previewName, frame)
        rval, frame = cam.read()
        key = cv2.waitKey()
        if key == 27: #按键ESC推出
            break
    
    cv2.destroyWindow(previewName)

cap0 = cv2.VideoCapture(0)
cap1 = cv2.VideoCapture(1)
cv2.namedWindow("previewName1")
cv2.namedWindow("previewName2")
rval1, frame1 = cap0.read()
rval2, frame2 = cap1.read()
while rval1 and rval2:
        cv2.imshow("previewName1", frame1)
        cv2.imshow("previewName2", frame2)
        rval1, frame1 = cap0.read()
        rval2, frame2 = cap1.read()
        key = cv2.waitKey()
        if key == 27: #按键ESC推出
            break

cv2.destroyAllWindows()

# thread1 = camThread("camera1", 0)
# thread2 = camThread("camera2", 1)
# thread1.start()
# thread2.start()