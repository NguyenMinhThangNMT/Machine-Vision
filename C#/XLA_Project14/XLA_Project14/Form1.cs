using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XLA_Project14
{
   
    public partial class Form1 : Form
    {
        Bitmap hinhgoc = new Bitmap(@"D:\Môn Học\Thị Giác Máy\Lena.jpg");
        public Form1()
        {
            InitializeComponent();
            picO.Image = hinhgoc;
        }

        //Tạo hàm hình xám
        public Bitmap hinhxam(Bitmap hinhgoc)
        {
            //Tạo hình mới có kích thước bằng hình gốc
            Bitmap Hinhmucxam = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            //Dùng vòng lập for để quét các điểm ảnh
            for (int x = 0; x < hinhgoc.Width; x++)
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    //Lấy điểm ảnh
                    Color pixel = hinhgoc.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    // Tính giá trị mức xám cho điểm ảnh tại (x,y)
                    byte gray = (byte)(R * 0.2126 + G * 0.7152 + B * 0.0722);

                    //Phân loại điểm ảnh sang nhị phân dựa vào giá trị ngưỡng


                    // Gán hình mức xám vừa tính vào hình mức xám
                    Hinhmucxam.SetPixel(x, y, Color.FromArgb(gray, gray, gray));

                }
            return Hinhmucxam;
        }

        //Tạo hàm nhận diện biên Sobel
        public Bitmap NhanDangDuongBienAnhXamSobel(Bitmap Hinhmucxam,int nguong)
        {
            //Ma trận SobelX
            int[,] Sx =
            {
                {-1,-2,-1},
                {0, 0 , 0 },
                {1 , 2 ,1 }
            };
            //Ma trận SobelY
            int[,] Sy =
            {
                {-1,0,1 },
                {-2,0,2 },
                {-1,0,1 }
            };
            //Tạo ra hình mới với kích thước như  hình mục xám
            Bitmap AnhDuongBien = new Bitmap(Hinhmucxam.Width, Hinhmucxam.Height);
            //Dùng vòng lập for để quét các điểm ảnh 
            for (int x = 1; x <Hinhmucxam.Width - 1; x++)
                for (int y = 1; y < Hinhmucxam.Height - 1; y++)
                {
                    //Khai báo biến gx gy
                    int gx = 0, gy = 0;
                    //Dùng vòng lập for để quét điểm ảnh có kích thước là 3x3pixel
                    for (int i = - 1; i <= 1; i++)
                    {
                        for (int j = - 1; j <= 1; j++)
                        {
                            //Lấy giá trị điểm ảnh 
                            Color color = Hinhmucxam.GetPixel(x+i,y+j);
                            int Gr = color.R;
                            //Nhân tích chập với ma trân sobel 
                            gx += Gr *Sx[i + 1, j + 1];
                            gy += Gr *Sy[i + 1, j + 1];
                        }

                    }
                    //Tính M
                    int M = Math.Abs(gx) + Math.Abs(gy);
                    if (M < nguong)
                        AnhDuongBien.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    else
                        AnhDuongBien.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                }
            return AnhDuongBien;
        } 
            private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nguong = Convert.ToInt16(textBox1.Text);
            Bitmap hinhmucxam = hinhxam(hinhgoc);
            Bitmap hinhduongbien = NhanDangDuongBienAnhXamSobel(hinhmucxam, nguong);
            picS.Image = hinhduongbien;
        }

       

        

        private void lblnguong_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
