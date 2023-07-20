using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XLA_Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Khai báo file hình
            string filehinh = @"D:\Môn Học\Thị Giác Máy\Lena.jpg";
            //Đưa file hình về dạng pixel bắt bitmap
            Bitmap hinhgoc = new Bitmap(filehinh);
            //Hình thị hình trong pictureBox
            picBox1.Image = hinhgoc;
            picBox3.Image = Binary (hinhgoc);
          
        }
      

        //Phương pháp Average
        public Bitmap Binary (Bitmap hinhgoc)
        {
         
            Bitmap Binary = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            //Do mỗi ảnh là ma trận 2 chiều nên ta dùng 2 lần vòng lặp for để quét điểm ảnh
            for (int x = 0; x < hinhgoc.Width; x++)
                for (int y = 0; y < hinhgoc.Height; y++)

                {
                    //Lấy giá trị điểm ảnh tại điểm x,y
                    Color pixel = hinhgoc.GetPixel(x, y);
                    //Gán giá trị các kênh R G B
                    Byte R = pixel.R;
                    Byte G = pixel.G;
                    Byte B = pixel.B;
                    Byte A = pixel.A;
                    //Công thức toán học của Phương Pháp Average
                    Byte gray = (byte)((R+G+B) / 3);
                    //Gán giá trị mức xám vừa tính được vào hình
                    Binary.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                    if (gray < 130) {
                        Binary.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    if (gray > 130) {
                        Binary.SetPixel(x, y, Color.FromArgb(255, 255, 255));};
                }
            return Binary;
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
