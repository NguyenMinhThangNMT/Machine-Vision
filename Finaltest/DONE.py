from tkinter import *
from tkinter import messagebox
import cv2
import time
import dlib
import numpy as np
from PIL import Image, ImageTk
import tkinter as tk
from tkinter import filedialog
from tensorflow import keras
from keras.utils import load_img
from keras.utils.image_utils import img_to_array
from tkinter import Tk, Button, Toplevel

import cv2
import tkinter as tk
import numpy as np
from tkinter import *
from PIL import ImageTk, Image

from tensorflow import keras
#from tensorflow.keras.models import model_from_json
#from tensorflow.keras.preprocessing.image import img_to_array
#from tensorflow.keras.preprocessing import image
from tkinter import filedialog

import datetime


mainWindow = Tk()
mainWindow.title("Đồ Án Cuối Kì")
mainWindow.geometry("1000x600")
mainWindow['bg'] = "white" # chỉnh màu cho background
mainWindow.attributes('-topmost',True)



#Load Model 
model = None  # Khai báo biến model là biến toàn cuc


# model sử dụng hiện tại
model = keras.models.load_model('data.h5')

# hàm thay thế model khi có model hiệu suất tốt hơn
def loadmodel():
    global model  # Sử dụng biến model toàn cục
    file_path = filedialog.askopenfilename()
    if file_path:
        model = keras.models.load_model(file_path)



# Load face detection mode để nhận diện khuôn mặt
detector = cv2.CascadeClassifier('haarcascade_frontalface_default.xml')




def EmotionDetect():
    # Tạo một cửa sổ mới
    global a  
    global b
    new_window = Toplevel(login)
    new_window.title("XÁC ĐỊNH CẢM XÚC DỰA TRÊN HÌNH ẢNH")
    new_window.geometry("1000x600")
    mainWindow.withdraw()

    logo = Image.open('logonews.png')
    resized_image = logo.resize((354, 81))
    a = ImageTk.PhotoImage(resized_image)
    image_label = Label(new_window, image=photo)
    image_label.place(x=10,y=10)

    ckm = Image.open('CKM.png')
    resized_image = ckm.resize((100, 100))
    b = ImageTk.PhotoImage(resized_image)
    image_label1 = Label(new_window, image=photo1)
    image_label1.place(x=845,y=10)


    def close_new_window():
        #Đóng cửa sổ mới
        new_window.destroy()
        # Hiển thị lại cửa sổ trước đó
        mainWindow.deiconify()
    # Tạo một nút trong cửa sổ mới để đóng cửa sổ hiện tại
    close_button = Button(new_window, text="Back",height=1,width=12, command=close_new_window)
    close_button.place(x = 40, y = 100)
    B4 = Button(new_window, text="START",height=1 , width=12,command = '')
    B4.place(x = 150,y = 100)
    
    label_name = Label(new_window, text="", font=("Arial", 15, 'bold'),fg="#FBA401")
    label_name.place(x=800, y=150)
    label_name1 = Label(new_window, text="Cảm xúc", font=("Arial", 15, 'bold'),fg="#C51762")
    label_name1.place(x=700, y=150)
    # đọc hình ảnh từ camera
    cap = cv2.VideoCapture(0)

    class CameraApp:        
        def __init__(self, window):
            
            self.window = window
            self.label = tk.Label(window)
            self.label.place(x=5, y=150)
            # Khởi tạo camera
            self.cap = cv2.VideoCapture(0)
            # Thiết lập kích thước khung hình mong muốn
            self.cap.set(cv2.CAP_PROP_FRAME_WIDTH, 300)
            self.cap.set(cv2.CAP_PROP_FRAME_HEIGHT, 300)
            # Gọi hàm hiển thị camera
            self.show_camera()
        def show_camera(self):
            # Đọc khung hình từ camera
            ret, frame = cap.read()    
            # Xử lý dữ liệu từ camera6
            gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
            #faces = detector.detectMultiScale(gray)
            faces = detector.detectMultiScale(gray, scaleFactor=1.1, minNeighbors=9, minSize=(10, 10))

            for (x, y, w, h) in faces:
                cv2.rectangle(frame, (x, y), (x+w, y+h), (0, 255, 0), 2)
                #cropped_img = frame[x:w, y:h]
                cropped_img = frame[y:y + h, x:x + w]
                resized_img = cv2.resize(cropped_img, (40, 40))
                arrayImage = np.array(resized_img).reshape(1, 40,40, 3) / 255.0
                pred = np.argmax(model.predict(arrayImage))
                #class_name = {0: 'Surprise', 1: 'Sad', 2: 'Neutral', 3: 'Happy', 4: 'Fear', 5: 'Angry', 6: 'Disgust'}
                class_name = {0: 'Surprise', 1: 'Sad', 2: 'Neutral', 3: 'Happy', 4: 'Angry', 5: 'Angry', 6: 'Angry'}
                cv2.putText(frame, class_name[pred], (x, y - 10), cv2.FONT_HERSHEY_SIMPLEX, 0.9, (36, 255, 12), 2)
                print("Predicted: ", class_name[pred])
                a =  class_name[pred]           
                label_name.config(text = a)
 
                
            # Chuyển khung hình sang định dạng hình ảnh Tkinter
            image = cv2.cvtColor(frame, cv2.COLOR_BGR2RGB)
            image = Image.fromarray(image)
            image_tk = ImageTk.PhotoImage(image)
            # Cập nhật hình ảnh trên label
            self.label.configure(image=image_tk)
            self.label.image = image_tk
            # Hiển thị khung hình và gọi lại hàm sau 15ms
            self.window.after(15, self.show_camera)

    
    camera = CameraApp(new_window)




def Testcamera():
    windowTestcam = Toplevel(login)
    windowTestcam.title("XÁC ĐỊNH CẢM XÚC DỰA TRÊN HÌNH ẢNH")
    windowTestcam.geometry("1000x600")
    windowTestcam.withdraw()

    logo = Image.open('logonews.png')
    resized_image = logo.resize((354, 81))
    a = ImageTk.PhotoImage(resized_image)
    image_label = Label(windowTestcam, image=photo)
    image_label.place(x=10,y=10)

    ckm = Image.open('CKM.png')
    resized_image = ckm.resize((100, 100))
    b = ImageTk.PhotoImage(resized_image)
    image_label1 = Label(windowTestcam, image=photo1)
    image_label1.place(x=845,y=10)
    
    def close_new_window():
        #Đóng cửa sổ mới
        windowTestcam.destroy()
        # Hiển thị lại cửa sổ trước đó
        windowTestcam.deiconify()
    # Tạo một nút trong cửa sổ mới để đóng cửa sổ hiện tại
    close_button = Button(windowTestcam, text="Back",height=1,width=12, command=close_new_window)
    close_button.place(x = 40, y = 100)
    B4 = Button(windowTestcam, text="START",height=1 , width=12,command = '')
    B4.place(x = 150,y = 100)






def Record():
    cap = cv2.VideoCapture(0)

    current_time = datetime.datetime.now().strftime("%Y.%m.%d-%H.%H")
    video_filename = f"videorec_{current_time}.mp4"
    fourcc = cv2.VideoWriter_fourcc(*'XVID')
    op = cv2.VideoWriter(video_filename, fourcc, 9.0, (640, 480))
    while cap.isOpened():
        res, frame = cap.read()
        height, width, channel = frame.shape
        gray_image = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
        faces = detector.detectMultiScale(gray_image)
        try: 
            for (x, y, w, h) in faces:
                cv2.rectangle(frame, (x, y), (x+w, y+h), (0, 255, 0), 2)
                #cropped_img = frame[x:w, y:h]
                cropped_img = frame[y:y + h, x:x + w]
                resized_img = cv2.resize(cropped_img, (40, 40))
                arrayImage = np.array(resized_img).reshape(1, 40,40, 3) / 255.0
                pred = np.argmax(model.predict(arrayImage))
                #class_name = {0: 'Surprise', 1: 'Sad', 2: 'Neutral', 3: 'Happy', 4: 'Fear', 5: 'Angry', 6: 'Disgust'}
                class_name = {0: 'Surprise', 1: 'Sad', 2: 'Neutral', 3: 'Happy', 4: 'Angry', 5: 'Angry', 6: 'Angry'}
                cv2.putText(frame, class_name[pred], (x, y - 10), cv2.FONT_HERSHEY_SIMPLEX, 0.9, (36, 255, 12), 2)
        except:
            pass
        frame[0:int(height/20), 0:int(width)] = res
        op.write(frame)
        cv2.imshow('Record Video Emotion Detect', frame)
        if cv2.waitKey(1) & 0xFF == ord('e'):
            break
    op.release()
    cap.release()
    cv2.destroyAllWindows() 












def File():
    # Tạo một cửa sổ mới
    global a, b
    
    new_window = Toplevel(login)
    new_window.title("XÁC ĐỊNH CẢM XÚC DỰA TRÊN HÌNH ẢNH")
    new_window.geometry("1000x700")
    mainWindow.withdraw()

    logo = Image.open('logonews.png')
    resized_image = logo.resize((354, 81))
    a = ImageTk.PhotoImage(resized_image)
    image_label = Label(new_window, image=photo)
    image_label.place(x=10,y=10)

    ckm = Image.open('CKM.png')
    resized_image = ckm.resize((100, 100))
    b = ImageTk.PhotoImage(resized_image)
    image_label1 = Label(new_window, image=photo1)
    image_label1.place(x=845,y=10)


    def close_new_window():
        #Đóng cửa sổ mới
        new_window.destroy()
        # Hiển thị lại cửa sổ trước đó
        mainWindow.deiconify()
    # Tạo một nút trong cửa sổ mới để đóng cửa sổ hiện tại
    close_button = Button(new_window, text="Back",height=1,width=12, command=close_new_window)
    close_button.place(x = 40, y = 100)

    def UploadAction(event=None):
        filename = filedialog.askopenfilename()
        print('Selected:', filename)
        cap = cv2.VideoCapture(filename)
        while cap.isOpened():
            ret, frame = cap.read()
            frame = cv2.resize(frame,(600,700))
            #height, width, channel = frame.shape
            gray_image = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
            #faces = detector.detectMultiScale(gray_image)
            faces = detector.detectMultiScale(gray_image, scaleFactor=1.1, minNeighbors=5, minSize=(30, 30))
            for (x, y, w, h) in faces:
                cv2.rectangle(frame, (x, y), (x+w, y+h), (0, 255, 0), 2)
                #cropped_img = frame[y:h, x:w]
                cropped_img = frame[y:y + h, x:x + w]               
                resized_img = cv2.resize(cropped_img, (40, 40))
                arrayImage = np.array(resized_img).reshape(1, 40,40, 3) / 255.0
                pred = np.argmax(model.predict(arrayImage))
                class_name = {0: 'Surprise', 1: 'Sad', 2: 'Neutral', 3: 'Happy', 4: 'Fear', 5: 'Angry', 6: 'Disgust'}        
                cv2.putText(frame, class_name[pred], (x, y - 10), cv2.FONT_HERSHEY_SIMPLEX, 0.9, (36, 255, 12), 2)
            #frame[0:int(height/1000), 0:int(width)] = res
            #cv2.imshow('DETECT', frame)

            
            image_rgb = cv2.cvtColor(frame, cv2.COLOR_BGR2RGB)
            # Chuyển đổi hình ảnh thành đối tượng ImageTk
            image_pil = Image.fromarray(image_rgb)
            image_tk = ImageTk.PhotoImage(image_pil)
            # Tạo một Label để hiển thị hình ảnh
            label = Label(new_window, image= image_tk)
            label.place(x = 20 , y = 100)
            if cv2.waitKey(1) & 0xFF == ord('q'):
                break
        cap.release()
        cv2.destroyAllWindows() 
    Chonfile = Button(new_window, text="file",height=1,width=12, command=UploadAction)
    Chonfile.place(x = 150 , y =100 )










def exitt():
   exit()

# hàm này để thể hiện frame muốn xem và ẩn frame trước đó đi
def show_frame(frame):
    frame.tkraise()
def stop_frame(frame):
    frame.destroy()
    
# Tạo ra 2 frame khác nhau chạy song song
login = tk.Frame(mainWindow)
#frame1 = tk.Frame(mainWindow)
login.grid(row=0,column=0,sticky='nsew')


# Thiết kế giao diện người dunfg
logo = Image.open('logonews.png')
resized_image = logo.resize((354, 81))
photo = ImageTk.PhotoImage(resized_image)
image_label = Label(login, image=photo)
image_label.place(x=10,y=10)


ckm = Image.open('CKM.png')
resized_image = ckm.resize((100, 100))
photo1 = ImageTk.PhotoImage(resized_image)
image_label1 = Label(login, image=photo1)
image_label1.place(x=840,y=10)


ckm = Image.open('Thay.jpg')
resized_image = ckm.resize((180,200))
photo3 = ImageTk.PhotoImage(resized_image)
image_label1 = Label(login, image=photo3)

image_label1.place(x=800,y=200)

label3 = Label(login, text='GVHD: TS.NGUYỄN VĂN THÁI',font=("Aria", 10 , 'bold'), fg="#000080")
label3.place(x= 790, y= 430)
#label4 = Label(login, text='MÔN HỌC: THỊ GIÁC MÁY',font=("Aria", 16, 'bold'), fg="#000080")
#label4.place(x= 800, y= 100)


mainWindow.rowconfigure(0,weight=1)
mainWindow.columnconfigure(0,weight=1)

#lambda:show_frame(frame1)
# Thiết lập các nút nhấn tùy chọn
B1 = Button(login,text="EMOTION RECOGNITION",height=2,width=20,command= EmotionDetect)
B1.place(x =400,y=200)
B5 = Button(login,text="RECORD",height=2,width=20,command= Record)
B5.place(x =400,y=250)
B2 = Button(login,text="Test Camera",height=2,width=20,command= '')
B2.place(x =400,y=300)
B3 = Button(login,text="PHOTO",height=2,width=20,command= File)
B3.place(x =400,y=350)
B4 = Button(login,text="EXIT",height=2,width=20,command= exitt)
B4.place(x =400,y=400)
B5 = Button(login,text="LOAD MODEL",height=2,width=20,command= loadmodel )
B5.place(x =400,y=450)


# lập trình các đối tượng giao diện người dùng
label1 = Label(login, text='MÔN HỌC: THỊ GIÁC MÁY',font=("Aria", 16, 'bold'), fg="#000080")
label1.place(x= 380, y= 100)
label2 = Label(login, text='NHẬN DIỆN CẢM XÚC PHỤC VỤ TRONG LĨNH VỰC DỊCH VỤ',font=("Aria", 16, 'bold'), fg="#000080")
label2.place(x= 200, y= 150)


label1 = Label(login, text='SVTH:',font=("Aria", 13, 'bold'), fg="#000080")
label1.place(x= 20, y= 200)
label2 = Label(login, text='NGUYỄN MINH THẮNG           20146533',font=("Aria", 13, 'bold'), fg="#000080")
label2.place(x= 20, y= 250)
label1 = Label(login, text='NGÔ NHỰT SANG                  20146524',font=("Aria", 13, 'bold'), fg="#000080")
label1.place(x= 20, y= 300)
label2 = Label(login, text='ĐINH TRẦN NGỌC THẠCH     20146512',font=("Aria", 13, 'bold'), fg="#000080")
label2.place(x= 20, y= 350)

show_frame(login)


#_____________________**End Frame1**_____________________




mainWindow.mainloop()