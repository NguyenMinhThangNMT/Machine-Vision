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
Cyan = Image.new(imgPIL.mode,imgPIL.size)
Magenta = Image.new(imgPIL.mode,imgPIL.size)
Yellow = Image.new(imgPIL.mode,imgPIL.size)
Black = Image.new(imgPIL.mode,imgPIL.size)

#Lấy kích thước ảnh từ thư viên ImgPIL
width = imgPIL.size[0]
height = imgPIL.size[1]

#Do mỗi ảnh là ma trận 2 chiều nên ta dùng 2 lần vòng lặp for để quét điểm ảnh
for x in range(width):
    for y in range(height):
        #Lấy giá trị điểm ảnh tại điểm x,y
        R,G,B = imgPIL.getpixel((x,y))
        #Gan gia tri 
        Cyan.putpixel((x,y),(B,G,0))
        Magenta.putpixel((x,y),(B,0,R))
        Yellow.putpixel((x,y),(0,G,R))
        Bk=min(R,G,B)
        Black.putpixel((x,y),(Bk,Bk,Bk))
#Chuyen doi PIL sang openCV de
Cyan=numpy.array(Cyan)
Magenta=numpy.array(Magenta)
Yellow=numpy.array(Yellow)
Black=numpy.array(Black)


#Hiển thị hình ảnh
cv2.imshow('Hinh goc',img)
cv2.imshow('AnhCyan',Cyan)
cv2.imshow('AnhMagenta',Magenta)
cv2.imshow('AnhYellow',Yellow)
cv2.imshow('AnhBlack',Black)

cv2.waitKey(0)
cv2.destroyAllWindows()

