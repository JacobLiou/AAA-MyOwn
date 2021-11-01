from PIL import Image, ImageDraw, ImageSequence
import imageio
import os

# images = []
# filenames = sorted(os.listdir("./img")) 
# for filename in filenames:
#     if filename.endswith('.png'):
#         file_path = os.path.join("./img", filename)
#         images.append(imageio.read(file_path))

# imageio.mimsave('./img/balabala.gif', images)

#图片合成到GIF
png_dir = './img'
images = []
for file_name in sorted(os.listdir(png_dir)):
    if file_name.endswith('.png'):
        file_path = os.path.join(png_dir, file_name)
        images.append(imageio.imread(file_path))
imageio.mimsave('./img/movie.gif', images)

#GIF分解到图片 python 将GIF拆分成图片方法 使用Pillow
im = Image.open('./img/movie.gif')
#获取GIF图片流的迭代器
iter = ImageSequence.Iterator(im)
png_dir = './img/new'
#判断目录
if not os.path.exists(png_dir):
    os.makedirs(png_dir)

index = 1
for frame in iter:
    frame.save(".img/new/frame%d.png" % index)
    index += 1





