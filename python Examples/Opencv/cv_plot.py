import cv2
import matplotlib.pyplot as plt

img0= cv2.imread("./img/1.png")
#转换为灰度图
img1 = cv2.cvtColor(img0, cv2.COLOR_BGR2GRAY)
# cv2.imwrite("google.png", img1)
h, w = img1.shape[:2]
print(h, w)

# cv2.namedWindow('w0')
# cv2.imshow('w0', img1)
# cv2.waitKey()

hist = cv2.calcHist([img1], [0], None, [256], [0, 255])
plt.plot(hist, color='lime', label='直方图', lineStyle='--')
plt.legend()
plt.savefig("./img/hehe.png")
plt.show()
