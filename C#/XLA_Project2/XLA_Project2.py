import cv2
import numpy

#Đọc ảnh màu bằng thư viên OpenCv
img=cv2.imread('Lena.jpg',cv2.IMREAD_COLOR)
#Khai báo kích thước ảnh
height = len(img[0])
width = len(img[1])

#khai báo biến để chứa 3 kênh R-G-B
red =numpy.zeros((width,height,3),numpy.uint8)
green =numpy.zeros((width,height,3),numpy.uint8)
blue =numpy.zeros((width,height,3),numpy.uint8)
#Set zero cho tất cả các điểm ảnh của 3 kênh
red[:] = [0,0,0]
green[:] = [0,0,0]
blue[:] = [0,0,0]

#Do mỗi ảnh là ma trận 2 chiều nên ta dùng 2 lần vòng lặp for để quét điểm ảnh
for x in range(width):
    for y in range(height):
        #Lấy điểm ảnh tại vị trí x,y
        R = img [x,y,2]
        G = img [x,y,1]
        B = img [x,y,0]

        #Thiết lập màu cho kênh
        red[x,y,2]=R
        green[x,y,1]=G
        blue[x,y,0]=B

    


#Hiển thị các hình ảnh
cv2.imshow('Hinh goc',img)
cv2.imshow('Hinh red',red)
cv2.imshow('Hinh green',green)
cv2.imshow('Hinh blue',blue)

cv2.waitKey(0)
cv2.destroyAllWindows()
