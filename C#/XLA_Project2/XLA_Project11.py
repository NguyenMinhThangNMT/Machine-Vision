import cv2
from PIL import Image
import numpy as np


filehinh = r'lena.jpg'

img=cv2.imread(filehinh,cv2.IMREAD_COLOR)

imgPIL = Image.open(filehinh)


smooth3=Image.new(imgPIL.mode,imgPIL.size)
smooth5=Image.new(imgPIL.mode,imgPIL.size)
smooth7=Image.new(imgPIL.mode,imgPIL.size)
smooth9=Image.new(imgPIL.mode,imgPIL.size)

width = imgPIL.size[0]
height =imgPIL.size[1]

for x in range(1,width-1):
    for y in range(1,height-1):
        Rs=0
        Gs=0
        Bs=0

        for i in range(x-1,x+2):
            for j in range(y-1,y+2):

             R,B,G =imgPIL.getpixel((i,j))

             Rs +=R
             Gs +=G
             Bs +=B

             
        Rs = np.uint8(Rs/9)
        Gs = np.uint8(Gs/9)
        Bs = np.uint8(Bs/9)

        smooth3.putpixel((x,y),(Bs,Gs,Rs))


for x in range(2,width-2):
    for y in range(2,height-2):
        Rs=0
        Gs=0
        Bs=0

        for i in range(x-2,x+3):
            for j in range(y-2,y+3):

             R,B,G =imgPIL.getpixel((i,j))

             Rs +=R
             Gs +=G
             Bs +=B

             
        Rs = np.uint8(Rs/25)
        Gs = np.uint8(Gs/25)
        Bs = np.uint8(Bs/25)

        smooth5.putpixel((x,y),(Bs,Gs,Rs))


for x in range(3,width-3):
    for y in range(3,height-3):
        Rs=0
        Gs=0
        Bs=0

        for i in range(x-3,x+4):
            for j in range(y-3,y+4):

             R,B,G =imgPIL.getpixel((i,j))

             Rs +=R
             Gs +=G
             Bs +=B

             
        Rs = np.uint8(Rs/49)
        Gs = np.uint8(Gs/49)
        Bs = np.uint8(Bs/49)

        smooth7.putpixel((x,y),(Bs,Gs,Rs))


for x in range(4,width-4):
    for y in range(4,height-4):
        Rs=0
        Gs=0
        Bs=0

        for i in range(x-4,x+5):
            for j in range(y-4,y+5):

             R,B,G =imgPIL.getpixel((i,j))

             Rs +=R
             Gs +=G
             Bs +=B

             
        Rs1 = np.uint8(Rs/81)
        Gs1 = np.uint8(Gs/81)
        Bs1 = np.uint8(Bs/81)

        smooth9.putpixel((x,y),(Bs1,Gs1,Rs1))


anh3=np.array(smooth3)
anh5=np.array(smooth5)
anh7=np.array(smooth7)
anh9=np.array(smooth9)

cv2.imshow('Hinh goc',img)
cv2.imshow('Hinh3x3',anh3)
cv2.imshow('Hinh5x5',anh5)
cv2.imshow('Hinh7x7',anh7)
cv2.imshow('Hinh9x9',anh9)

cv2.waitKey(0)

cv2.destroyAllWindows()