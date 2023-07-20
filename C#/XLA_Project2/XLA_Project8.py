import cv2
from PIL import Image
import numpy
import math

#khai báo file hình
filehinh = r'Lena.jpg'
#Đọc ảnh màu bằng thư viên OpenCv
img = cv2.imread(filehinh,cv2.IMREAD_COLOR)
#Đọc ảnh màu bằng thư viện PILLOW để tính toán và xử lí ảnh
imgPIL = Image.open(filehinh)
#Tạo một ảnh có cùng kích thước và mode với Ảnh của thư viện Pillow
Hue = Image.new(imgPIL.mode,imgPIL.size)
Saturation = Image.new(imgPIL.mode,imgPIL.size)
Value = Image.new(imgPIL.mode,imgPIL.size)
HSV = Image.new(imgPIL.mode,imgPIL.size)

#Lấy kích thước ảnh từ thư viên ImgPIL
width = imgPIL.size[0]
height = imgPIL.size[1]

#Do mỗi ảnh là ma trận 2 chiều nên ta dùng 2 lần vòng lặp for để quét điểm ảnh
for x in range(width):
    for y in range(height):
        #Lấy giá trị điểm ảnh tại điểm x,y
        R,G,B = imgPIL.getpixel((x,y))
        
          
        #Cong thuc Hue
        t1 = ((R - G) + (R - B)) / 2
        t2 = math.sqrt((R-G)*(R-G)+(R-B)*(G-B))
        theta = math.acos(t1/t2)
        
        H=0

        if B<=G:
            H=theta
        else:
            H=2*math.pi-theta
        H=numpy.uint8(H*180/math.pi)
       

        #Cong thuc kenh Saturation
        S = 1 - 3 *min(R,G,B) / (R + G + B)
        S=numpy.uint8(S*255)
        #Cong thuc kenh Value
        V = numpy.uint8(max(R , G ,B))


        Hue.putpixel((x,y),(H,H,H))
        Saturation.putpixel((x,y),(S,S,S))
        Value.putpixel((x,y),(V,V,V))
        HSV.putpixel((x,y),(V,S,H))

Hue=numpy.array(Hue)
Saturation=numpy.array(Saturation)
Value=numpy.array(Value)
HSV=numpy.array(HSV)


#Hiển thị hình ảnh
cv2.imshow('Hinh goc',img)
cv2.imshow('AnhHue',Hue)
cv2.imshow('AnhSaturation',Saturation)
cv2.imshow('AnhValue',Value)
cv2.imshow('AnhHSV',HSV)

cv2.waitKey(0)
cv2.destroyAllWindows()