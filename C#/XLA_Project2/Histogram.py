import cv2
from PIL import Image
import numpy
import matplotlib.pyplot as plt

#tạo một hàm chứ ảnh nhị phân mới từ ảnh xám bằng thư viện PIL
def Luminace(imgPIL):
 #Tạo ra một hình Binary mới với mode và size giống như ảnh ở thư viện Pillow
 average = Image.new(imgPIL.mode,imgPIL.size)
#Lấy kích thước ảnh từ thư viên ImgPIL
 width = average.size[0]
 height = average.size[1]

#Do mỗi ảnh là ma trận 2 chiều nên ta dùng 2 lần vòng lặp for để quét điểm ảnh
#phương pháp Luminace
 for x in range(width):
    for y in range(height):
        R,G,B = imgPIL.getpixel((x,y))

        gray = numpy.uint8(0.2126*R + 0.7152*G + 0.0722*B )

        average.putpixel((x,y),(gray,gray,gray))
 return average


#Tạo ra hàm tính toán history ảnh xám
def TinhHistogram(HinhXamPIL):
    #Mỗi pixel mức xám có giá trị từ 0 - 255
    his=numpy.zeros(256)
    #Lấy kích thước ảnh từ thư viên ImgPIL
    w = HinhXamPIL.size[0]
    h = HinhXamPIL.size[1]

    #Giá trị gray tính ra cũng là phần tử thứ gray trong mảng Histogram
    #Ta tăng số đếm của gray lên 1

    for x in range(w):
       for y in range(h):
         #lấy giá trị xám tại điểm x,y
         gR,gG,gB=HinhXamPIL.getpixel((x,y))
       #Giá trị gray tính ra cũng là phần tử thứ gray trong mảng Histogram
       #Ta tăng số đếm của gray lên 1
         his[gR] +=1

    return his
#Vẽ bản đồ histogram
def VebieudoHistogram(his):
   w=5
   h=4
   plt.figure('Bieu do Histogram',figsize=(((w,h))),dpi=100)
   trucX=numpy.zeros(256)
   trucX=numpy.linspace(0,256,256)
   plt.plot(trucX,his,color='orange')
   plt.title('Bieu do Histogram')
   plt.xlabel('Gia tri muc xam')
   plt.ylabel('So diem anh co cung gia tri muc xam')
   plt.show()

#CHƯƠNG TRÌNH CHÍNH
#khai báo file hình
filehinh = r'Lena.jpg' 
#Đọc ảnh màu bằng thư viện PILLOW để tính toán và xử lí ảnh
imgPIL = Image.open(filehinh)
#Chuyển sang ảnh mức xám
HinhXamPIL = Luminace (imgPIL)
#Tính histogram
his=TinhHistogram(HinhXamPIL)
#chuyển ảnh sang thư viện opencv để hiển thị ảnh
HinhXamCV=numpy.array(HinhXamPIL)
cv2.imshow('Anh muc xam', HinhXamCV )
#hiển thị đồ thị
VebieudoHistogram(his)
cv2.waitKey(0)
cv2.destroyAllWindows()



          
         
