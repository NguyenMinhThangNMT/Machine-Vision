using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.Structure;


namespace XLA_Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
            //Tạo đường dẫn đến nơi lưu ảnh
             string filehinh= @"D:\Môn Học\Thị Giác Máy\Lena.jpg";
            //Tạp biến bitmap
            Bitmap hinhgoc= new Bitmap(filehinh);
            //Hiển thị hình trong PicBox
            picBox_O.Image  = hinhgoc;
            //Khai báo Hình R G B
            Bitmap red = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap green = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap blue = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            //Mỗi hình là 2 ma trân nên ta dùng vòng lặp for 2 lần để đọc điểm ảnh 
            for (int x = 0; x < hinhgoc.Width; x++)
                for (int y = 0; y< hinhgoc.Height;y++)
            {
                    Color pixel = hinhgoc.GetPixel(x, y);

                    Byte R = pixel.R;
                    Byte G = pixel.G;
                    Byte B = pixel.B;
                    Byte A = pixel.A;

                    red.SetPixel(x, y, Color.FromArgb(A, R, 0, 0));
                    green.SetPixel(x, y, Color.FromArgb(A, 0, G, 0));
                    blue.SetPixel(x, y, Color.FromArgb(A, 0, 0, B));

                 

                }
            picBox_R.Image = red;
            picBox_G.Image = green;
            picBox_B.Image = blue;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void imageBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
