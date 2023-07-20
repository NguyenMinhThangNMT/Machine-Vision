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
Intensity = Image.new(imgPIL.mode,imgPIL.size)
HSI = Image.new(imgPIL.mode,imgPIL.size)

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
       

        #Cong thuc Saturation
        S = 1 - 3 *min(R,G,B) / (R + G + B)
        S=numpy.uint8(S*255)
        #Cong thuc Intensity
        I = numpy.uint8((R + G + B) / 3)

        #Gan gia tri
        Hue.putpixel((x,y),(H,H,H))
        Saturation.putpixel((x,y),(S,S,S))
        Intensity.putpixel((x,y),(I,I,I))
        HSI.putpixel((x,y),(I,S,H))
#Chuyen anh tu PIL sang OpenCV
Hue=numpy.array(Hue)
Saturation=numpy.array(Saturation)
Intensity=numpy.array(Intensity)
HSI=numpy.array(HSI)


#Hiển thị hình ảnh
cv2.imshow('Hinh goc',img)
cv2.imshow('AnhHue',Hue)
cv2.imshow('AnhSaturation',Saturation)
cv2.imshow('AnhIntensity',Intensity)
cv2.imshow('AnhHSI',HSI)

cv2.waitKey(0)
cv2.destroyAllWindows()