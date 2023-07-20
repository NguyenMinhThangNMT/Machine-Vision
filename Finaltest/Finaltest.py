# from tkinter import *
# from tkinter import messagebox
# import cv2
# import time
# import dlib
# import numpy as np
# from PIL import Image, ImageTk

# from tensorflow import keras
# from keras.utils import load_img
# from keras.utils.image_utils import img_to_array



# tkWindow = Tk()  
# tkWindow.geometry('800x600')  
# tkWindow.title('Đồ án cuối kì')
# #Load Model
# model = keras.models.load_model('data.h5')
# # Load face detection model
# detector = dlib.get_frontal_face_detector()

# # Initialize webcam
# cap = cv2.VideoCapture(0)

# def showMsg():  
#    while True:
#     # Read frame from webcam
#     ret, frame = cap.read()

#     # Convert frame to grayscale
#     gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)

#     # Detect faces in the frame
#     faces = detector(gray)

#     # Draw a rectangle around each face
#     for face in faces:
#         x1, y1, x2, y2 = face.left(), face.top(), face.right(), face.bottom()
#         cv2.rectangle(frame, (x1, y1), (x2, y2), (0, 255, 0), 2)
#     for face in faces:
#         # Tìm tọa độ của khuôn mặt
#         x1, y1, x2, y2 = face.left(), face.top(), face.right(), face.bottom()

#         # Cắt ảnh
#         cropped_img = frame[y1:y2, x1:x2]

#         # Resize ảnh
#         resized_img = cv2.resize(cropped_img, (40, 40))

#         # Chuyển ảnh sang ma trận numpy và chuẩn hóa
#         arrayImage = np.array(resized_img).reshape(1, 40, 40, 3) / 255.0

#         # Sử dụng ma trận ảnh cắt được để dự đoán lớp sử dụng model
#         pred = np.argmax(model.predict(arrayImage))
#         class_name = {0: 'Suprise', 1: 'sad', 2: 'Neutral', 3: 'Happy', 4: 'Fear', 5: 'Angry', 6: 'Disgust'}
#         cv2.putText(frame, class_name[pred], (x1, y1 - 10), cv2.FONT_HERSHEY_SIMPLEX, 0.9, (36, 255, 12), 2)
#         print("Predicted: ", class_name[pred])

#     # Display the frame
#     cv2.imshow('frame', frame)

#     # Exit if the user presses 'q'
#     if cv2.waitKey(1) & 0xFF == ord('esc'):
#         break

# button = Button(tkWindow,
# 	text = 'Start',height=2,width=18,bd=9,command = showMsg)  
# button.pack()  
# button.place(x=300, y=510)

# # Tạo một Label
# label1 = Label(tkWindow, text='Project cuối kì môn học: Trí Tuệ Nhân Tạo',font=("Aria", 16, 'bold'), fg="#000080")
# label1.pack()
# label1.place(x=200,y=100)

# label2 = Label(tkWindow, text='Nhận diện cảm xúc con người',font=("Aria", 16, 'bold'), fg="#000080")
# label2.pack()
# label2.place(x=250,y=140)


# label4 = Label(tkWindow, text='Khoa Cơ Khí Chế Tạo Máy',font=("Aria", 11, 'bold'), fg="#000080")
# label4.pack()
# label4.place(x=500,y=20)

# label5 = Label(tkWindow, text='Bộ Môn Cơ Điện Tử',font=("Aria", 11, 'bold'), fg="#000080")
# label5.pack()
# label5.place(x=500,y=40)

# label6 = Label(tkWindow, text='GVHD: PGSTS.Nguyễn Trường Thịnh',font=("Aria", 11, 'bold'), fg="#000080")
# label6.pack()
# label6.place(x=50,y=200)

# label7 = Label(tkWindow, text='SVTH: Nguyễn Minh Thắng   MSSV:20146533',font=("Aria", 11, 'bold'), fg="#000080")
# label7.pack()
# label7.place(x=50,y=220)

# # Đọc hình ảnh và resize
# image = Image.open('logonews.png')
# resized_image = image.resize((354, 81))
# # Tạo một đối tượng PhotoImage từ hình ảnh đã resize
# photo = ImageTk.PhotoImage(resized_image)
# # Tạo một Label mới để chứa hình ảnh
# image_label = Label(tkWindow, image=photo)
# image_label.pack()
# image_label.place(x=10,y=10)

# # Đọc hình ảnh và resize
# image1 = Image.open('CKM.png')
# resized_image = image1.resize((100, 100))
# # Tạo một đối tượng PhotoImage từ hình ảnh đã resize
# photo1 = ImageTk.PhotoImage(resized_image)
# # Tạo một Label mới để chứa hình ảnh
# image_label1 = Label(tkWindow, image=photo1)
# image_label1.pack()
# image_label1.place(x=700,y=10)
  

# # Đọc hình ảnh và resize
# image2 = Image.open('Bia.webp')
# resized_image2 = image2.resize((300, 300))
# # Tạo một đối tượng PhotoImage từ hình ảnh đã resize
# photo2 = ImageTk.PhotoImage(resized_image2)
# # Tạo một Label mới để chứa hình ảnh
# image_label2 = Label(tkWindow, image=photo2)
# image_label2.pack()
# image_label2.place(x=400,y=200)
  
# tkWindow.mainloop()




from tkinter import *
from tkinter import messagebox
import cv2
import time
import dlib
import numpy as np
from PIL import Image, ImageTk

from tensorflow import keras
from keras.utils import load_img
from keras.utils.image_utils import img_to_array



tkWindow = Tk()  
tkWindow.geometry('800x600')  
tkWindow.title('Đồ án cuối kì')
#Load Model
model = keras.models.load_model('data.h5')
# Load face detection model
detector = dlib.get_frontal_face_detector()

# Initialize webcam
cap = cv2.VideoCapture(0)

def showMsg():
   # Đóng window hiện tại
    tkWindow.destroy()
    
    while True:
        # Read frame from webcam
        ret, frame = cap.read()

        # Convert frame to grayscale
        gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)

        # Detect faces in the frame
        faces = detector(gray)

        # Draw a rectangle around each face
        for face in faces:
            x1, y1, x2, y2 = face.left(), face.top(), face.right(), face.bottom()
            cv2.rectangle(frame, (x1, y1), (x2, y2), (0, 255, 0), 2)
        for face in faces:
            # Tìm tọa độ của khuôn mặt
            x1, y1, x2, y2 = face.left(), face.top(), face.right(), face.bottom()

            # Cắt ảnh
            cropped_img = frame[y1:y2, x1:x2]

            # Resize ảnh
            resized_img = cv2.resize(cropped_img, (40, 40))

            # Chuyển ảnh sang ma trận numpy và chuẩn hóa
            arrayImage = np.array(resized_img).reshape(1, 40, 40, 3) / 255.0

            # Sử dụng ma trận ảnh cắt được để dự đoán lớp sử dụng model
            pred = np.argmax(model.predict(arrayImage))
            class_name = {0: 'Suprise', 1: 'sad', 2: 'Neutral', 3: 'Happy', 4: 'Fear', 5: 'Angry', 6: 'Disgust'}
            cv2.putText(frame, class_name[pred], (x1, y1 - 10), cv2.FONT_HERSHEY_SIMPLEX, 0.9, (36, 255, 12), 2)
            print("Predicted: ", class_name[pred])

        # Display the frame
        cv2.imshow('frame', frame)

        # Exit if the user presses 'q'
        if cv2.waitKey(1) & 0xFF == ord('a'):
            break
            # Hiển thị window mới
    
button = Button(tkWindow,
	text = 'Start',height=2,width=18,bd=9,command = showMsg)  
button.pack()  
button.place(x=300, y=510)

# Tạo một Label
label1 = Label(tkWindow, text='Project cuối kì môn học: Trí Tuệ Nhân Tạo',font=("Aria", 16, 'bold'), fg="#000080")
label1.pack()
label1.place(x=200,y=100)

label2 = Label(tkWindow, text='Nhận diện cảm xúc con người',font=("Aria", 16, 'bold'), fg="#000080")
label2.pack()
label2.place(x=250,y=140)


label4 = Label(tkWindow, text='Khoa Cơ Khí Chế Tạo Máy',font=("Aria", 11, 'bold'), fg="#000080")
label4.pack()
label4.place(x=500,y=20)

label5 = Label(tkWindow, text='Bộ Môn Cơ Điện Tử',font=("Aria", 11, 'bold'), fg="#000080")
label5.pack()
label5.place(x=500,y=40)

label6 = Label(tkWindow, text='GVHD: PGSTS.Nguyễn Trường Thịnh',font=("Aria", 11, 'bold'), fg="#000080")
label6.pack()
label6.place(x=50,y=200)

label7 = Label(tkWindow, text='SVTH: Nguyễn Minh Thắng   MSSV:20146533',font=("Aria", 11, 'bold'), fg="#000080")
label7.pack()
label7.place(x=50,y=220)

# Đọc hình ảnh và resize
image = Image.open('logonews.png')
resized_image = image.resize((354, 81))
# Tạo một đối tượng PhotoImage từ hình ảnh đã resize
photo = ImageTk.PhotoImage(resized_image)
# Tạo một Label mới để chứa hình ảnh
image_label = Label(tkWindow, image=photo)
image_label.pack()
image_label.place(x=10,y=10)

# Đọc hình ảnh và resize
image1 = Image.open('CKM.png')
resized_image = image1.resize((100, 100))
# Tạo một đối tượng PhotoImage từ hình ảnh đã resize
photo1 = ImageTk.PhotoImage(resized_image)
# Tạo một Label mới để chứa hình ảnh
image_label1 = Label(tkWindow, image=photo1)
image_label1.pack()
image_label1.place(x=700,y=10)
  

# Đọc hình ảnh và resize
image2 = Image.open('Bia.webp')
resized_image2 = image2.resize((300, 300))
# Tạo một đối tượng PhotoImage từ hình ảnh đã resize
photo2 = ImageTk.PhotoImage(resized_image2)
# Tạo một Label mới để chứa hình ảnh
image_label2 = Label(tkWindow, image=photo2)
image_label2.pack()
image_label2.place(x=400,y=200)
  
tkWindow.mainloop()