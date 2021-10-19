import cv2
import matplotlib.pyplot as plt


def show_with_matplotlib(color_img, title, pos):
    img_RGB = color_img[:, :, ::-1]

    ax = plt.subplot(2, 4, pos)
    plt.imshow(img_RGB)
    plt.title(title, fontdict=10)
    plt.axis('off')


def sketch_image(img):
    # 转换为灰度图
    img_gray = cv2.cvtColor(img, cv2.CALIB_CB_BGR2GRAY)
    img_gray = cv2.medianBlur(img_gray, 5)

    # 拉普拉斯边缘处理
    edges = cv2.Laplacian(img_gray, cv2.CV_8U, ksize=5)
    ret, threshold = cv2.threshold(edges, 145, 255, cv2.THRESH_BINARY_INV)
    return threshold

# 自定义函数实现卡通化


def cartonize_image(img, gray_mode=False):
    # 提取图像的中的边
    threshold = sketch_image(img)
    # 双边滤波
    filtered = cv2.bilateralFilter(img, 10, 250, 250)
    # 卡通化
    cartoonized = cv2.bitwise_and(filtered, filtered, mask=threshold)

    if gray_mode:
        return cv2.cvtColor(cartoonized, cv2.COLOR_BGR2GRAY)

    return cartoonized


plt.figure(figsize=(14, 6))
plt.suptitle("Cartoonizing images", fontsize=14, fontweight='bold')

image = cv2.imread('sigonghuiye.jpeg')

custom_sketch_image = sketch_image(image)
custom_cartonized_image = cartonize_image(image)
custom_cartonized_image_gray = cartonize_image(image, True)

# 使用OpenCV函数实现卡通化
sketch_gray, sketch_color = cv2.pencilSketch(
    image, sigma_s=20, sigma_r=0.1, shade_factor=0.1)
stylizated_image = cv2.stylization(image, sigma_s=60, sigma_r=0.07)

show_with_matplotlib(image, "image", 1)
show_with_matplotlib(cv2.cvtColor(custom_sketch_image,
                                  cv2.COLOR_GRAY2BGR), 'custom sketch', 2)
show_with_matplotlib(cv2.cvtColor(
    sketch_gray, cv2.COLOR_GRAY2BGR), 'sketch gray cv2.pencilSketch()', 3)
show_with_matplotlib(sketch_color, 'sketch color cv2.pencilSketch()', 4)
show_with_matplotlib(stylizated_image, 'cartoonized cv2.stylization()', 5)
show_with_matplotlib(custom_cartonized_image, 'custom cartoonized', 6)
show_with_matplotlib(cv2.cvtColor(custom_cartonized_image_gray,
                                  cv2.COLOR_GRAY2BGR), 'custom cartoonized gray', 7)

# img_RGB = custom_cartonized_image[:, :, ::-1]
# plt.imshow(img_RGB)
# plt.title('custom cartoonized')
# plt.axis('off')
plt.show()
