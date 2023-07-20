import cv2
from PIL import Image
import numpy as np


filehinh = r'lena.jpg'

img=cv2.imread(filehinh,cv2.IMREAD_COLOR)

imgPIL = Image.open(filehinh)

Sharpening=Image.new(imgPIL.mode,imgPIL.size)
#Tạo ma trận 
matrix =np.array([ [ 0, -1, 0 ], [ -1, 4, -1 ], [ 0, -1, 0 ]] )
#Lấy kích thước ảnh từ thư viên ImgPIL
width = imgPIL.size[0]
height =imgPIL.size[1]
#Do mỗi ảnh là ma trận 2 chiều nên ta dùng 2 lần vòng lặp for để quét điểm ảnh
for x in range(1,width-1):
    for y in range(1,height-1):
        Rs=0
        Gs=0
        Bs=0
        for i in range(x-1,x+2):
            for j in range(y-1,y+2):

             R,B,G =imgPIL.getpixel((i,j))
            
             #tổng các kênh màu sau khi nhân tích chập với ma trận
             Rs += R*matrix[i - x + 1, j - y + 1]
             Gs += G*matrix[i - x + 1, j - y + 1]
             Bs += B*matrix[i - x + 1, j - y + 1]
        #Lấy giá trị các kênh ở hình gốc     
        R1,G1,B1=imgPIL.getpixel((x,y))
        #Lấy giá trị màu gốc cộng với giá trị màu nhân ma trận 
        SharpR=R1+Rs
        SharpG=G1+Gs
        SharpB=B1+Bs

        if (SharpR < 0):
          SharpR = 0
        elif (SharpR > 255):
          SharpR = 255

        if (SharpG < 0):
          SharpG = 0
        elif (SharpG > 255):
          SharpG = 255

        if (SharpB < 0):
          SharpB = 0
        elif (SharpB > 255):
          SharpB = 255

        Sharpening.putpixel((x,y),(SharpB,SharpG,SharpR))

ImageSharp=np.array(Sharpening)

cv2.imshow('Hinh goc',img)
cv2.imshow('HinhHighSolution',ImageSharp)

cv2.waitKey(0)
cv2.destroyAllWindows()