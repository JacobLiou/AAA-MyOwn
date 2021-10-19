import numpy
import cv2
import requests

cv2.namedWindow("preview")
vc = cv2.VideoCapture(0)

if vc.isOpened():
    rval, frame = vc.read()
else:
    rval = False

while rval:
    cv2.imshow("preview", frame)
    rval, frame = vc.read()
    key = cv2.waitKey(20)
    if key == 27:
        # ESC退出
        break
vc.release()
cv2.destroyWindow("preview")

def get_token():
    host = 'https://aip.baidubce.com/oauth/2.0/token?grant_type=client_credentials&client_id=' + self.client_id + '&client_secret=' + self.client_secret
    response = requests.get(host)
    if response:
        token_info = response.json()
        token_key = token_info['access_token']
    return token_key

def get_license_plate(car_pic):
    pass

