import cv2
from PIL import Image
import numpy

filehinh = r'Lena.jpg'

img = cv2.imread(filehinh,cv2.IMREAD_COLOR)

imgPIL = Image.open(filehinh)

average = Image.new(imgPIL.mode,imgPIL.size)

width = average.size[0]
height = average.size[1]


for x in range(width):
    for y in range(height):
        R,G,B = imgPIL.getpixel((x,y))

        Min=min(R,G,B)
        Max=max(R,G,B)
        gray = numpy.uint8( ( Min + Max  ) / 2 )

        average.putpixel((x,y),(gray,gray,gray))


anhxam=numpy.array(average)

cv2.imshow('Hinh goc',img)
cv2.imshow('Hinh xam',anhxam)


cv2.waitKey(0)
cv2.destroyAllWindows()
