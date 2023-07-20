import cv2 #Xu li anh
from PIL import Image #Thu vien xu li anh ho tro nhieu loai anh
import numpy as np
import math

def NhanDangDuongBien(anhRGB, nguong):
    #Tao tam anh moi
    AnhDaNhanDangDuongBien = Image.new(anhRGB.mode, anhRGB.size)

    #Lay kich thuoc anh goc
    width = anhRGB.size[0]
    height = anhRGB.size[1]

    Sober_X = np.array([[-1, -2, -1], [ 0, 0, 0 ],[ 1, 2, 1 ]])
    Sober_Y = np.array([[-1, 0, 1 ], [ -2, 0, 2 ],[ -1, 0, 1 ]])
    
    #Quet diem anh
    for x in range(1, width - 1):
        for y in range(1, height - 1):

            gxR=0
            gyR=0
            gxG=0
            gyG=0
            gxB=0
            gyB=0

            for i in range(x-1,x+2):
                for j in range(y-1,y+2):
                    #Lay gia tri cac diem anh tai vi tri (x,y)
                    r,g,b = imgPIL.getpixel((i,j))
                     
                    #Tinh gradient
                    gxR += r * Sober_X[i-x+1,j-y+1]
                    gyR += r * Sober_Y[i-x+1,j-y+1]

                    gxG += g * Sober_X[i-x+1,j-y+1]
                    gyG += g * Sober_Y[i-x+1,j-y+1]

                    gxB += b * Sober_X[i-x+1,j-y+1]
                    gyB += b * Sober_Y[i-x+1,j-y+1]

                    #Tinh gxx, gxy, gyy
                    Gxx = np.abs(gxR*gxR) + np.abs(gxG*gxG) + np.abs(gxB*gxB)
                    Gyy = np.abs(gyR*gyR) + np.abs(gyG*gyG) + np.abs(gyB*gyB)
                    Gxy = gxR*gyR + gxG*gyG + gxB*gyB
                    #Tinh goc theta
                    theta_xy = 0.5*np.arctan2((2 * Gxy), (Gxx - Gyy)) 

                    #Tinh F0
                    F0 = np.sqrt(0.5*(Gxx + Gxy + (Gxx - Gyy)*np.cos(2*theta_xy) + 2*Gxy*np.sin(2*theta_xy)))

                    if (F0 <= nguong):
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
