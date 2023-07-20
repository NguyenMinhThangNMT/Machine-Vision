using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XLA_Project15
{   
    public partial class Form1 : Form
    {
        Bitmap hinhgoc = new Bitmap(@"D:\Môn Học\Thị Giác Máy\Lena.jpg");
        public Form1()
        { 
            {
                InitializeComponent();
                picO.Image = hinhgoc;
            }
        }
        //Tạo ra hàm nhận diện đường biên
        public Bitmap NhanDangDuongBienAnhRGBSobel(Bitmap hinhgoc, int nguong)
        {
            //Ma trận sobel X
            int[,] SobelX =
            {
                {-1,-2,-1},
                {0, 0 , 0 },
                {1 , 2 ,1 }
            };
            //Ma trận SobelY
            int[,] SobelY =
            {
                {-1,0,1 },
                {-2,0,2 },
                {-1,0,1 }
            };
            Bitmap AnhDuongBien = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            for (int x = 1; x < hinhgoc.Width - 1; x++)
                for (int y = 1; y < hinhgoc.Height - 1; y++)
                {
                    //Khai báo các giá trị
                    int gxR = 0, gxG = 0, gxB = 0;
                    int gyR = 0, gyG = 0, gyB = 0;
                    int gxx = 0, gyy = 0, gxy = 0;
                    double theta = 0;
                    //Dùng vòng lập for để quét điểm anh
                    for (int i =x-1; i <=x+ 1; i++)
                    {
                        for (int j =y-1; j <= y+1; j++)
                        {
                            //Lấy giá trị màu
                            Color color = hinhgoc.GetPixel(i, j);
                            int R = color.R;
                            int G = color.G;
                            int B = color.B;
                            //Nhân tích chập với ma trận Sobel
                            gxR += R * SobelX[i-x + 1, j- y + 1];
                            gyR += R * SobelY[i - x + 1, j - y + 1];

                            gxG += G * SobelX[i - x + 1, j - y + 1];
                            gyG += G * SobelY[i - x + 1, j - y + 1];

                            gxB += B * SobelX[i - x + 1, j - y + 1];
                            gyB += B * SobelY[i - x + 1, j - y + 1];
                            //Tính gxx gyy gxy
                            gxx = (Math.Abs(gxR) * Math.Abs(gxR)) + (Math.Abs(gxG) * Math.Abs(gxG)) + (Math.Abs(gxB) * Math.Abs(gxB));
                            gyy = (Math.Abs(gyR) * Math.Abs(gyR)) + (Math.Abs(gyG) * Math.Abs(gyG)) + (Math.Abs(gyB) * Math.Abs(gyB));
                            gxy = gxR * gyR + gxG * gyG + gxB * gyB;
                            //Tính theta
                            theta =0.5* Math.Atan2((2 * gxy), (gxx - gyy)) ;
                            //Tính F0
                            double F0 = Math.Sqrt(0.5*(gxx + gxy + (gxx - gyy) * Math.Cos(2 * theta) + 2 * gxy * Math.Sin(2 * theta)) );
                            if (F0 <=nguong)
                                AnhDuongBien.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                            else
                                AnhDuongBien.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                        }

                    }
                   
                    
                }
            return AnhDuongBien;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nguong = Convert.ToInt16(textBox1.Text);
            Bitmap hinhduongbien = NhanDangDuongBienAnhRGBSobel(hinhgoc, nguong);
            picS.Image = hinhduongbien;
        }
    }
}
