using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XLA_Project13
{
    public partial class Form1 : Form
    {
        Bitmap hinhgoc = new Bitmap(@"D:\Môn Học\Thị Giác Máy\Lena.jpg");
        public Form1()
        {
            InitializeComponent();
            
            picO.Image = hinhgoc;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Chuyển đổi text thành giá trị số nguyên
            int x1 = Convert.ToInt16(TextX1.Text);
            int x2 = Convert.ToInt16(textX2.Text);
            int y1 = Convert.ToInt16(textY1.Text);
            int y2 = Convert.ToInt16(textY2.Text);
            int nguong = Convert.ToInt16(textNguong.Text);
            //Khai báo các biến với kiểu dữ liệu là double
            double aRtb = 0, aGtb = 0, aBtb = 0;
            //Dùng vòng lập for quét các điểm ảnh trong vùng nhập giá trị
            for (int x = x1;x <= x2;x++)
                for(int y = y1; y <= y2; y++)
                {
                    Color pixel = hinhgoc.GetPixel(x, y);
                    aRtb += pixel.R;
                    aGtb += pixel.G;
                    aBtb += pixel.B;

                }
            //Lấy giá trị vừa tính ở trên chia cho kích thước vùng chứa
            double size = Math.Abs(x2 - x1) * Math.Abs(y2 - y1);
            aRtb /= size;
            aGtb /= size;
            aBtb /= size;

            Bitmap SegImg = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            for (int x=0;x<hinhgoc.Width;x++)
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    Color pixel2 = hinhgoc.GetPixel(x, y);
                    double zR = pixel2.R;
                    double zG = pixel2.G;
                    double zB = pixel2.B;
                    //Dùng công thức trong giáo trình 
                    double D = Math.Sqrt(Math.Pow(zR - aRtb, 2) + Math.Pow(zG - aGtb, 2) + Math.Pow(zB - aBtb, 2));

                    if ((int)D <= nguong)
                        SegImg.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    else
                        SegImg.SetPixel(x, y, Color.FromArgb((int)zR, (int)zG, (int)zB));

                }
            picS.Image = SegImg;

        }
    }
}
