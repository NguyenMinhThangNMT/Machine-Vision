import cv2
from PIL import Image
import numpy

#khai báo file hình
filehinh = r'Lena.jpg'
#Đọc ảnh màu bằng thư viên OpenCv
img = cv2.imread(filehinh,cv2.IMREAD_COLOR)
#Đọc ảnh màu bằng thư viện PILLOW để tính toán và xử lí ảnh
imgPIL = Image.open(filehinh)
#Tạo một ảnh có cùng kích thước và mode với Ảnh của thư viện Pillow
KY= Image.new(imgPIL.mode,imgPIL.size)
KCb = Image.new(imgPIL.mode,imgPIL.size)
KCr = Image.new(imgPIL.mode,imgPIL.size)
KYCbCr = Image.new(imgPIL.mode,imgPIL.size)

#Lấy kích thước ảnh từ thư viên ImgPIL
width = imgPIL.size[0]
height = imgPIL.size[1]

#Do mỗi ảnh là ma trận 2 chiều nên ta dùng 2 lần vòng lặp for để quét điểm ảnh
#Phương pháp Average
for x in range(width):
    for y in range(height):
        #Lấy giá trị điểm ảnh tại điểm x,y
        R,G,B = imgPIL.getpixel((x,y))
        #Cong thuc Y  Cb Cr
        Y=numpy.uint8(16+(65.738*R)/256 + (129.057*G)/256 + (25.064*B)/256 )
        Cb=numpy.uint8(128-(37.945*R)/256 - (74.494*G)/256 + (112.439*B)/256) 
        Cr=numpy.uint8(128+(112.439*R)/256 - (94.154*G)/256 - (18.285*B)/256) 
        #Gan gia tri
        KY.putpixel((x,y),(Y,Y,Y))
        KCb.putpixel((x,y),(Cb,Cb,Cb))
        KCr.putpixel((x,y),(Cr,Cr,Cr))
        KYCbCr.putpixel((x,y),(Cr,Cb,Y))
#CHuyen Hinh Tu PIL sang OpenCV
HX=numpy.array(KY)
HY=numpy.array(KCb)
HZ=numpy.array(KCr)
HXYZ=numpy.array(KYCbCr)


#Hiển thị hình ảnh
cv2.imshow('Hinh goc',img)
cv2.imshow('AnhKenhX',HX)
cv2.imshow('AnhKenhY',HY)
cv2.imshow('AnhKenhZ',HZ)
cv2.imshow('AnhKenhXYZ',HXYZ)

cv2.waitKey(0)
cv2.destroyAllWindows()
