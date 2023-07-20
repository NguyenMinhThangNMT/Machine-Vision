using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XLA_Project4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string filehinh = @"D:\Môn Học\Thị Giác Máy\Lena.jpg";
            //Đưa file hình về dạng pixel 
            Bitmap hinhgoc = new Bitmap(filehinh);
            //Hình thị hình trong pictureBox
            picBox1.Image = hinhgoc;
            picBox2.Image = hinhBinary(hinhgoc, 100);
        }
        public Bitmap hinhBinary(Bitmap hinhgoc, byte nguong)
        {
            Bitmap Binary = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            for (int x = 0; x < hinhgoc.Width; x++)
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    //Lấy điểm ảnh
                    Color pixel = hinhgoc.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    // Tính giá trị mức xám cho điểm ảnh tại (x,y)
                    byte nhiphan = (byte)(R * 0.2126 + G * 0.7152 + B * 0.0722);

                    //Phân loại điểm ảnh sang nhị phân dựa vào giá trị ngưỡng
                    if (nhiphan < nguong)
                        nhiphan = 0;
                    else
                        nhiphan = 255;

                    // Gán hình mức xám vừa tính vào hình mức xám
                    Binary.SetPixel(x, y, Color.FromArgb(nhiphan, nhiphan, nhiphan));

                }
            return Binary;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
