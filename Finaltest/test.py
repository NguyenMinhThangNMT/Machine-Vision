# import cv2
# import tkinter as tk
# from PIL import Image, ImageTk



# class CameraApp:
#     def __init__(self, window):
#         self.window = window
#         self.label = tk.Label(window)
#         self.label.pack()

#         # Khởi tạo camera
#         self.cap = cv2.VideoCapture(0)

#         # Thiết lập kích thước khung hình mong muốn
#         self.cap.set(cv2.CAP_PROP_FRAME_WIDTH, 320)
#         self.cap.set(cv2.CAP_PROP_FRAME_HEIGHT, 240)

#         # Gọi hàm hiển thị camera
#         self.show_camera()

#     def show_camera(self):
#         # Đọc khung hình từ camera
#         ret, frame = self.cap.read()

#         # Chuyển khung hình sang định dạng hình ảnh Tkinter
#         image = cv2.cvtColor(frame, cv2.COLOR_BGR2RGB)
#         image = Image.fromarray(image)
#         image_tk = ImageTk.PhotoImage(image)

#         # Cập nhật hình ảnh trên label
#         self.label.configure(image=image_tk)
#         self.label.image = image_tk

#         # Lặp lại quá trình sau 1ms
#         self.window.after(1, self.show_camera)

# # Khởi tạo cửa sổ Tkinter
# window = tk.Tk()

# # Khởi tạo ứng dụng CameraApp
# app = CameraApp(window)

# # Chạy chương trình
# window.mainloop()


import cv2
import tkinter as tk
from PIL import Image, ImageTk

class CameraApp:
    def __init__(self, window):
        self.window = window
        self.label = tk.Label(window)
        self.label.place(x=0,y=0)

        # Khởi tạo camera
        self.cap = cv2.VideoCapture(0)

        # Thiết lập kích thước khung hình mong muốn
        self.cap.set(cv2.CAP_PROP_FRAME_WIDTH, 300)
        self.cap.set(cv2.CAP_PROP_FRAME_HEIGHT, 300)

        # Gọi hàm hiển thị camera
        self.show_camera()

    def show_camera(self):
        # Đọc khung hình từ camera
        ret, frame = self.cap.read()

        # Chuyển khung hình sang định dạng hình ảnh Tkinter
        image = cv2.cvtColor(frame, cv2.COLOR_BGR2RGB)
        image = Image.fromarray(image)
        image_tk = ImageTk.PhotoImage(image)

        # Cập nhật hình ảnh trên label
        self.label.configure(image=image_tk)
        self.label.image = image_tk

        # Lặp lại quá trình sau 1ms
        self.window.after(1, self.show_camera)


# Khởi tạo cửa sổ Tkinter
mainWindow = tk.Tk()

# Thiết lập kích thước của cửa sổ chính
mainWindow .geometry("800x600")
mainWindow.title('Đồ án cuối kì')
mainWindow['bg'] = "white"   # chỉnh màu cho background 
mainWindow.attributes('-topmost',True)
# Tạo một cửa sổ con mới
sub_window = tk.Toplevel(mainWindow )
sub_window.geometry("800x600")

# Khởi tạo ứng dụng CameraApp với cửa sổ con
app = CameraApp(sub_window)

# Chạy chương trình
mainWindow .mainloop()

