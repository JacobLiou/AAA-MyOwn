import cv2

image = cv2.imread('./img/1.png')
(b, g, r) = cv2.split(image)

image_copy = cv2.merge((b, g, r))

# 图像的几何变换
#  缩放图像
#   平移图像
#   旋转图像
#   滤q