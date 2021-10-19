import numpy as np
import cv2
import datetime
import math

img = cv2.imread(r"E:\Demo\AAA MyOwn\python Examples\gaussnoise.png")
result_5 = cv2.GaussianBlur(img, (5, 5), 0)
result_9 = cv2.GaussianBlur(img, (9, 9), 0)

cv2.imshow('orginal_pic', img)
cv2.imshow('5X5_gaussblur_pic', result_5)
cv2.imshow('9X9_gaussblur_pic', result_9)
cv2.waitKey(0)