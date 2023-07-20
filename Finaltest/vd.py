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

mainWindow = Tk()
mainWindow.title("Đồ Án Cuối Kì")
mainWindow.geometry("1000x600")
mainWindow['bg'] = "white" # chỉnh màu cho background
mainWindow.attributes('-topmost',True)

#Load Model 
model = keras.models.load_model('data.h5')
# Load face detection model
detector = dlib.get_frontal_face_detector()
#detector = cv2.CascadeClassifier('haarcascade_frontalface_default.xml')
# đọc hình ảnh từ camera
cap = cv2.VideoCapture('http://192.168.1.4:4747/video')
# tạo một lớp thuộc đối tự xử lí nhận dạng cảm xúc
class CameraApp:
    def __init__(self, window):
        self.window = window
        self.label = tk.Label(window)
        self.label.place(x=5, y=150)
        # Khởi tạo camera
        self.cap = cv2.VideoCapture('http://192.168.1.4:4747/video')
        # Thiết lập kích thước khung hình mong muốn
        self.cap.set(cv2.CAP_PROP_FRAME_WIDTH, 300)
        self.cap.set(cv2.CAP_PROP_FRAME_HEIGHT, 300)
        # Gọi hàm hiển thị camera
        self.show_camera()
    def show_camera(self):
        # Đọc khung hình từ camera
        ret, frame = cap.read()    
        # Xử lý dữ liệu từ camera
        gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
        #faces = detector.detectMultiScale(gray)
        faces = detector(gray)
        for face in faces:
            x1, y1, x2, y2 = face.left(), face.top(), face.right(), face.bottom()
            cv2.rectangle(frame, (x1, y1), (x2, y2), (0, 255, 0), 2)
            cropped_img = frame[y1:y2, x1:x2]
            resized_img = cv2.resize(cropped_img, (40, 40))
            arrayImage = np.array(resized_img).reshape(1, 40,40, 3) / 255.0
            pred = np.argmax(model.predict(arrayImage))
            class_name = {0: 'Surprise', 1: 'Sad', 2: 'Neutral', 3: 'Happy', 4: 'Fear', 5: 'Angry', 6: 'Disgust'}
            cv2.putText(frame, class_name[pred], (x1, y1 - 10), cv2.FONT_HERSHEY_SIMPLEX, 0.9, (36, 255, 12), 2)
            print("Predicted: ", class_name[pred])
            a =  class_name[pred]           
            label_name.config(text = a)
            #label_name1.config(text='Feeling:')
            
        # Chuyển khung hình sang định dạng hình ảnh Tkinter
        image = cv2.cvtColor(frame, cv2.COLOR_BGR2RGB)
        image = Image.fromarray(image)
        image_tk = ImageTk.PhotoImage(image)
        # Cập nhật hình ảnh trên label
        self.label.configure(image=image_tk)
        self.label.image = image_tk
        # Hiển thị khung hình và gọi lại hàm sau 1ms
        self.window.after(10, self.show_camera)






def create_new_window():
    # Tạo một cửa sổ mới
    global a, b
    frame1.after_cancel(show_frame)
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
    close_button.place(x = 40, y = 70)

    def UploadAction(event=None):
        filename = filedialog.askopenfilename()
        print('Selected:', filename)
        cap = cv2.VideoCapture(filename)
        while cap.isOpened():
            ret, frame = cap.read()
            frame = cv2.resize(frame,(500,500))
            #height, width, channel = frame.shape
            gray_image = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
            #faces = detector.detectMultiScale(gray_image)
            faces = detector(gray_image)
            for face in faces:    
                    x1, y1, x2, y2 = face.left(), face.top(), face.right(), face.bottom()
                    cv2.rectangle(frame, (x1, y1), (x2, y2), (0, 255, 0), 2)
                    cropped_img = frame[y1:y2, x1:x2]
                    resized_img = cv2.resize(cropped_img, (40, 40))
                    arrayImage = np.array(resized_img).reshape(1, 40,40, 3) / 255.0                
                    pred = np.argmax(model.predict(arrayImage))
                    class_name = {0: 'Surprise', 1: 'Sad', 2: 'Neutral', 3: 'Happy', 4: 'Fear', 5: 'Angry', 6: 'Disgust'}        
                    cv2.putText(frame, class_name[pred], (x1, y1 - 10), cv2.FONT_HERSHEY_SIMPLEX, 0.9, (36, 255, 12), 2)
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
    Chonfile.place(x = 150 , y =70 )




















# hàm này để thể hiện frame muốn xem và ẩn frame trước đó đi
def show_frame(frame):
    frame.tkraise() 
def stop_frame(frame):
    frame.destroy()
    
# Tạo ra 2 frame khác nhau chạy song song
login = tk.Frame(mainWindow)
frame1 = tk.Frame(mainWindow)
login.grid(row=0,column=0,sticky='nsew')
frame1.grid(row=0,column=0,sticky='nsew')

# Thiết kế giao diện người dunfg
logo = Image.open('logonews.png')
resized_image = logo.resize((354, 81))
photo = ImageTk.PhotoImage(resized_image)
image_label = Label(login, image=photo)
image_label.place(x=10,y=10)
image_label_0 = Label(frame1, image=photo)
image_label_0.place(x=10,y=10)

ckm = Image.open('CKM.png')
resized_image = ckm.resize((100, 100))
photo1 = ImageTk.PhotoImage(resized_image)
image_label1 = Label(login, image=photo1)
image_label1.place(x=845,y=10)
image_label1_1 = Label(frame1, image=photo1)
image_label1_1.place(x=845,y=10)



mainWindow.rowconfigure(0,weight=1)
mainWindow.columnconfigure(0,weight=1)


# Thiết lập các nút nhấn tùy chọn
B1 = Button(login,text="Start",height=2,width=20,command=lambda:show_frame(frame1))
B1.place(x =0,y=300)
B2 = Button(login,text="Test Camera",height=2,width=20,command= '')
B2.place(x =0,y=400)
B3 = Button(login,text="Photo",height=2,width=20,command= create_new_window)
B3.place(x =0,y=500)



# lập trình các đối tượng giao diện người dùng
label1 = Label(login, text='MÔN HỌC: THỊ GIÁC MÁY',font=("Aria", 16, 'bold'), fg="#000080")
label1.place(x= 380, y= 100)
label2 = Label(login, text='NHẬN DIỆN CẢM XÚC PHỤC VỤ TRONG LĨNH VỰC DỊCH VỤ',font=("Aria", 16, 'bold'), fg="#000080")
label2.place(x= 200, y= 150)

show_frame(login)

# lập trình các đối tượng frame1 


label_name = Label(frame1, text="", font=("Arial", 15, 'bold'),fg="#FBA401")
label_name.place(x=800, y=150)
label_name1 = Label(frame1, text="Cảm xúc", font=("Arial", 15, 'bold'),fg="#C51762")
label_name1.place(x=700, y=150)
camera = CameraApp(frame1)
#_____________________**End Frame1**_____________________
Button(frame1,text="Back",bg='white',fg='black',height=1,width=12,command= lambda:show_frame(login),font=('Arial',11,'bold')).place(x=800, y = 500 )



mainWindow.mainloop()