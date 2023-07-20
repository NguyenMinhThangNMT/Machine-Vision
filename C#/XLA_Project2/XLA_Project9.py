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
KX= Image.new(imgPIL.mode,imgPIL.size)
KY = Image.new(imgPIL.mode,imgPIL.size)
KZ = Image.new(imgPIL.mode,imgPIL.size)
KXYZ = Image.new(imgPIL.mode,imgPIL.size)

#Lấy kích thước ảnh từ thư viên ImgPIL
width = imgPIL.size[0]
height = imgPIL.size[1]

#Do mỗi ảnh là ma trận 2 chiều nên ta dùng 2 lần vòng lặp for để quét điểm ảnh

for x in range(width):
    for y in range(height):
        #Lấy giá trị điểm ảnh tại điểm x,y
        R,G,B = imgPIL.getpixel((x,y))
        #Cong thuc XYZ
        X=numpy.uint8(0.4124564*R + 0.3575761*G + 0.1804375*B )
        Y=numpy.uint8(0.2126729*R + 0.7151522*G + 0.0721750*B )
        Z=numpy.uint8(0.0193339*R + 0.1191920*G + 0.9503041*B )
        #Gan gia tri cho cac kenh
        KX.putpixel((x,y),(X,X,X))
        KY.putpixel((x,y),(Y,Y,Y))
        KZ.putpixel((x,y),(Z,Z,Z))
        KXYZ.putpixel((x,y),(Z,Y,X))
#Chuyen anh tu PIL sang OpenCV
HX=numpy.array(KX)
HY=numpy.array(KY)
HZ=numpy.array(KZ)
HXYZ=numpy.array(KXYZ)


#Hiển thị hình ảnh
cv2.imshow('Hinh goc',img)
cv2.imshow('AnhKenhX',HX)
cv2.imshow('AnhKenhY',HY)
cv2.imshow('AnhKenhZ',HZ)
cv2.imshow('AnhKenhXYZ',HXYZ)

cv2.waitKey(0)
cv2.destroyAllWindows()
