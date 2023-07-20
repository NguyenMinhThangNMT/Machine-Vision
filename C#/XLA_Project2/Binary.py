import cv2
from PIL import Image
import numpy

#khai báo file hình
filehinh = r'Lena.jpg'
#Đọc ảnh màu bằng thư viên OpenCv
img = cv2.imread(filehinh,cv2.IMREAD_COLOR)
#Đọc ảnh màu bằng thư viện PILLOW để tính toán và xử lí ảnh
imgPIL = Image.open(filehinh)
#Tạo 1 biến nguong với giá trị bằng 130
Nguong =130
#Tạo ra một hình Binary mới với mode và size giống như ảnh ở thư viện Pillow
Binary = Image.new(imgPIL.mode,imgPIL.size)
#Lấy kích thước ảnh từ thư viên ImgPIL
width = Binary.size[0]
height = Binary.size[1]

#Do mỗi ảnh là ma trận 2 chiều nên ta dùng 2 lần vòng lặp for để quét điểm ảnh
#Phương pháp Average
for x in range(width):
    for y in range(height):
        #Lấy giá trị điểm ảnh tại điểm x,y
        R,G,B = imgPIL.getpixel((x,y))
        #Công thức toán học của Phương Pháp Average
        gray = numpy.uint8( ( R + G + B ) / 3 )
        #Tính toán và xử lí giá trị để chuyển sang hình Binary
        if(gray<130):
         Binary.putpixel((x,y),( 0, 0, 0))
        if(gray>130):
         Binary.putpixel((x,y),( 255, 255, 255))

#Chuyển ảnh vừa được xử lí ở thư viện pillow qua thư viện OpenCv
Binary=numpy.array(Binary)
#Hiển thị hình ảnh
cv2.imshow('Hinh goc',img)
cv2.imshow('Binary',Binary)



cv2.waitKey(0)
cv2.destroyAllWindows()
