import cv2 #Xu li anh
from PIL import Image #Thu vien xu li anh ho tro nhieu loai anh
import numpy as np
import math

def NhanDangDuongBien(anhxam, nguong):
    #Tao tam anh moi 
    AnhDaNhanDangDuongBien = Image.new(anhxam.mode, anhxam.size)

    #Lay kich thuoc anh goc
    width = anhxam.size[0]
    height = anhxam.size[1]
    #Ma tran Sobel
    Sober_X = np.array([[-1, -2, -1], [ 0, 0, 0 ],[ 1, 2, 1 ]])
    Sober_Y = np.array([[-1, 0, 1 ], [ -2, 0, 2 ],[ -1, 0, 1 ]])
    
    #Quet diem anh
    for x in range(1, width - 1):
        for y in range(1, height - 1):

            gxx=0
            gyy=0
            for i in range(x-1,x+2):
                for j in range(y-1,y+2):
                    #Lay gia tri cac diem anh tai vi tri (x,y)
                    r,g,b = imgPIL.getpixel((i,j))
                    #Tinh gia tri muc xam phuong phap luminance
                    gray = np.uint8(0.2126*r + 0.7152*g + 0.0722*b) 

                    #Tinh gxx gyy
                    gxx += gray * Sober_X[i-x+1,j-y+1]
                    gyy += gray * Sober_Y[i-x+1,j-y+1]

                    #Tinh M
                    M_xy = math.fabs(gxx) + math.fabs(gyy)

                    #So sanh voi gia tri nguong
                    if (M_xy <= nguong):
                        AnhDaNhanDangDuongBien.putpixel((x, y), (0, 0, 0))
                    else:
                        AnhDaNhanDangDuongBien.putpixel((x, y), (255, 255, 255))
    AnhDaNhanDangDuongBien_CV = np.array(AnhDaNhanDangDuongBien)
    return AnhDaNhanDangDuongBien_CV

def NhapThongSo():
    
    ThongSo = int(input("Nhập ngưỡng:")) #ngưỡng
    return ThongSo
    
ThongSo = NhapThongSo()

#Tao duong dans
filehinh = r'lena_color.jpg'
#Đọc ảnh màu dùng thư viện OpenCV
img = cv2.imread(filehinh, cv2.IMREAD_COLOR)
#Đọc ảnh màu dùng thư viện PIL
imgPIL = Image.open(filehinh)

img_NhanDangDuongBien = NhanDangDuongBien(imgPIL,ThongSo)
cv2.imshow('Anh nhan dang duong bien', img_NhanDangDuongBien)
cv2.imshow('Original Image', img)

#Bam phim bat ki de dong cua so
cv2.waitKey(0)

#Giai phong bo nho
cv2.destroyAllWindows()