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
                class_name = {0: 'Surprise', 1: 'Sad', 2: 'Neutral', 3: 'Happy', 4: 'Fear', 5: 'Angry', 6: 'Disgust'}
                cv2.putText(frame, class_name[pred], (x, y - 10), cv2.FONT_HERSHEY_SIMPLEX, 0.9, (36, 255, 12), 2)
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
            self.window.after(15, self.show_camera)



    B1 = Button(login,text="EMOTION RECOGNITION",height=2,width=20,command=lambda:show_frame(frame1) )
    B1.place(x =0,y=200)
