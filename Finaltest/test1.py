from tkinter import *
from tkinter import messagebox
import cv2
import time
import dlib
import numpy as np
from PIL import Image, ImageTk
import tkinter as tk

from tensorflow import keras
from keras.utils import load_img
from keras.utils.image_utils import img_to_array

mainWindow = Tk()
mainWindow.title("Đồ Án Cuối Kì")
mainWindow.geometry("1000x700")
mainWindow['bg'] = "white" # chỉnh màu cho background
mainWindow.attributes('-topmost',True)

#Load Model
model = keras.models.load_model('data.h5')
# Load face detection model
detector = dlib.get_frontal_face_detector()
# Initialize webcam
cap = cv2.VideoCapture('http://192.168.1.9:4747/video')
# hàm camera


def show_camera(self, window):
        self.window = window
        self.label = tk.Label(window)
        self.label.place(x=0, y=250)
        # Khởi tạo camera
        self.cap = cv2.VideoCapture('http://192.168.1.9:4747/video')
        # Thiết lập kích thước khung hình mong muốn
        self.cap.set(cv2.CAP_PROP_FRAME_WIDTH, 100)
        self.cap.set(cv2.CAP_PROP_FRAME_HEIGHT, 100)
        # Gọi hàm hiển thị camera
        self.show_camera()
        # Đọc khung hình từ camera
        ret, frame = cap.read()
        #anh = cv2.imread('44.jpg')
        #frame = cv2.imread('44.jpg')
        # Kích thước mới (width, height) hoặc tỷ lệ mới
        new_size = (500, 300)  # Kích thước mới
        # Resize ảnh
        #frame = cv2.resize(anh, new_size)

        # Xử lý dữ liệu từ camera
        gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
        faces = detector(gray)
        for face in faces:
            x1, y1, x2, y2 = face.left(), face.top(), face.right(), face.bottom()
            cv2.rectangle(frame, (x1, y1), (x2, y2), (0, 255, 0), 2)
            cropped_img = frame[y1:y2, x1:x2]
            resized_img = cv2.resize(cropped_img, (40, 40))
            arrayImage = np.array(resized_img).reshape(1, 40, 40,3) / 255.0
            #arrayImage = resized_img / 255.0
            pred = np.argmax(model.predict(arrayImage))
            class_name = {0: 'Surprise', 1: 'Sad', 2: 'Neutral', 3: 'Happy', 4: 'Fear', 5: 'Angry', 6: 'Disgust'}
            cv2.putText(frame, class_name[pred], (x1, y1 - 10), cv2.FONT_HERSHEY_SIMPLEX, 0.9, (36, 255, 12), 2)
            print("Predicted: ", class_name[pred])
            person_name = class_name[pred]
            label_name.config(text=person_name)
            label_name1.config(text='Feeling:')
            
        # Chuyển khung hình sang định dạng hình ảnh Tkinter
        image = cv2.cvtColor(frame, cv2.COLOR_BGR2RGB)
        image = Image.fromarray(image)
        image_tk = ImageTk.PhotoImage(image)
        # Cập nhật hình ảnh trên label
        self.label.configure(image=image_tk)
        self.label.image = image_tk
        # Hiển thị khung hình và gọi lại hàm sau 1ms
        self.window.after(10, self.show_camera)



def detect():
    cap = cv2.VideoCapture('http://192.168.1.9:4747/video')
    while cap.isOpened():
        ret, frame = cap.read()
        height, width, channel = frame.shape
        gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
        #faces = face_haar_cascade.detectMultiScale(gray_image)
        faces = detector(gray)
        try: 
            for face in faces:
                x1, y1, x2, y2 = face.left(), face.top(), face.right(), face.bottom()
                cv2.rectangle(frame, (x1, y1), (x2, y2), (0, 255, 0), 2)
                cropped_img = frame[y1:y2, x1:x2]
                resized_img = cv2.resize(cropped_img, (40, 40))
                arrayImage = np.array(resized_img).reshape(1, 40, 40,3) / 255.0
                #arrayImage = resized_img / 255.0
                pred = np.argmax(model.predict(arrayImage))
                class_name = {0: 'Surprise', 1: 'Sad', 2: 'Neutral', 3: 'Happy', 4: 'Fear', 5: 'Angry', 6: 'Disgust'}
                cv2.putText(frame, class_name[pred], (x1, y1 - 10), cv2.FONT_HERSHEY_SIMPLEX, 0.9, (36, 255, 12), 2)
                print("Predicted: ", class_name[pred])
                person_name = class_name[pred]
                label_name.config(text=person_name)
                label_name1.config(text='Feeling:')

        except:
            pass
        frame[0:int(height/20), 0:int(width)] = ret
        cv2.imshow('AI PROJECT - EMOTION DETECTION - TR.KIEN - DETECT', frame)
        if cv2.waitKey(1) & 0xFF == ord('q'):
            break
    cap.release()
    cv2.destroyAllWindows() 





# Chương trình con ===========================
def show_frame(frame):
    frame.tkraise() 
def stop_frame(frame):
    frame.destroy()
# End chương trình con ========================
login = tk.Frame(mainWindow)
frame1 = tk.Frame(mainWindow)

login.grid(row=0,column=0,sticky='nsew')
frame1.grid(row=0,column=0,sticky='nsew')

#_____________________**Login**_____________________
logo = Image.open('logonews.png')
resized_image = logo.resize((354, 81))
photo = ImageTk.PhotoImage(resized_image)
'''
image_label = Label(login, image=photo)
image_label.place(x=10,y=10)
image_label_0 = Label(frame1, image=photo)
image_label_0.place(x=10,y=10)
'''

ckm = Image.open('CKM.png')
resized_image = ckm.resize((100, 100))
photo1 = ImageTk.PhotoImage(resized_image)
image_label1 = Label(login, image=photo1)
image_label1.place(x=845,y=10)
#image_label1_1 = Label(frame1, image=photo1)
#image_label1_1.place(x=845,y=10)

#bia= Image.open('Bia.webp')
#resized_image2 = bia.resize((350, 350))
#photo2 = ImageTk.PhotoImage(resized_image2)
#image_label2 = Label(login, image=photo2)
#image_label2.place(x=450,y=200)

mainWindow.rowconfigure(0,weight=1)
mainWindow.columnconfigure(0,weight=1)

Button(login,text="Kích hoạt",height=1,width=12,bd=9,command=lambda:show_frame(frame1),bg="green",font=('Arial',11,'bold')).place(x=150, y = 380 )




#_____________________**Frame1**_____________________

label_name = Label(frame1, text="sang", font=("Arial", 12, 'bold'),fg="#FBA401")
label_name.place(x=350, y=225)
label_name1 = Label(frame1, text="", font=("Arial", 12, 'bold'),fg="#C51762")
label_name1.place(x=250, y=225)
#camera_app = CameraApp(frame1)

#Button import file and recog
but1=Button(login,padx=5,pady=5,width=30,bg='white',fg='black',relief=GROOVE,text='Import File & Recognition',command='',font=('helvetica 15 bold'))
but1.place(relx=0.5,rely=0.44, anchor= CENTER)
#UploadAction
#Button Test camera
but2=Button(login,padx=5,pady=5,width=30,bg='white',fg='black',relief=GROOVE,command='',text='Test Camera',font=('helvetica 15 bold'))
but2.place(relx=0.5,rely=0.56, anchor= CENTER)
#cam
#Button only detect
but3=Button(login,padx=5,pady=5,width=30,bg='white',fg='black',command= detect ,text='Open Camera & Recognition',font=('helvetica 15 bold'))
but3.place(relx=0.5,rely=0.68, anchor= CENTER)
#detect
#Button detect & record
but4=Button(login,padx=5,pady=5,width=30,bg='white',fg='black',relief=GROOVE,command = lambda:show_frame(frame1),text='Recognition & Record',font=('helvetica 15 bold'))
but4.place(relx=0.5,rely=0.8, anchor= CENTER)
#detectRec
#Button exit
but5=Button(login,padx=5,pady=5,width=30,bg='white',fg='red',relief=GROOVE,text='EXIT',command='',font=('helvetica 15 bold'))
but5.place(relx=0.5,rely=0.92, anchor= CENTER)
#exitt
#_____________________**End Frame1**_____________________
Button(frame1,text="Kết thúc",height=1,width=12,bd=9,command=lambda:stop_frame(mainWindow),bg="red",font=('Arial',11,'bold')).place(x=800, y = 500 )




show_frame(login)
mainWindow.mainloop()