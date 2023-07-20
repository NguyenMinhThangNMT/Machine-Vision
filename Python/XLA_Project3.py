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
hinhxam = Image.new(imgPIL.mode,imgPIL.size)
#Lấy kích thước ảnh từ thư viên ImgPIL
width = hinhxam.size[0]
height = hinhxam.size[1]

#Do mỗi ảnh là ma trận 2 chiều nên ta dùng 2 lần vòng lặp for để quét điểm ảnh
#Phương pháp Average
for x in range(width):
    for y in range(height):
        #Lấy giá trị điểm ảnh tại điểm x,y
        R,G,B = imgPIL.getpixel((x,y))
        #Công thức toán học của Phương Pháp Average
        gray = numpy.uint8( ( R + G + B ) / 3 )
        #Gán giá trị mức xám vừa tính được vào hinhxam
        hinhxam.putpixel((x,y),(gray,gray,gray))
#Chuyển ảnh vừa được xử lí ở thư viện pillow qua thư viện OpenCv
Average=numpy.array(hinhxam)

#Phương pháp Lightness
for x in range(width):
    for y in range(height):
        #Lấy giá trị điểm ảnh tại điểm x,y
        R,G,B = imgPIL.getpixel((x,y))
        #Công thức toán học của Phương Pháp Lightnesss
        Min=min(R,G,B)
        Max=max(R,G,B)
        gray = numpy.uint8( ( Min + Max  ) / 2 )
        #Gán giá trị mức xám vừa tính được vào hinhxam
        hinhxam.putpixel((x,y),(gray,gray,gray))
#Chuyển ảnh vừa được xử lí ở thư viện pillow qua thư viện OpenCv
MinMax=numpy.array(hinhxam)

#Phương Pháp Luminace
for x in range(width):
    for y in range(height):
        #Lấy giá trị điểm ảnh tại điểm x,y
        R,G,B = imgPIL.getpixel((x,y))
        #Công thức toán học của Phương Pháp Luminace
        gray = numpy.uint8(0.2126*R + 0.7152*G + 0.0722*B )
        #Gán giá trị mức xám vừa tính được vào hinhxa 
        hinhxam.putpixel((x,y),(gray,gray,gray))
#Chuyển ảnh vừa được xử lí ở thư viện pillow qua thư viện OpenCv
Luminace=numpy.array(hinhxam)

#Hiển thị hình ảnh
cv2.imshow('Hinh goc',img)
cv2.imshow('Average',Average)
cv2.imshow('Lightness',MinMax)
cv2.imshow('Luminace',Luminace)

cv2.waitKey(0)
cv2.destroyAllWindows()
