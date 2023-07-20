using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap Hinhgoc = new Bitmap(@"D:\Môn Học\Thị Giác Máy\Lena.jpg");
            OriginBox.Image = Hinhgoc;
           
            List<Bitmap> Smooth = ChuyendoiSmooth(Hinhgoc);
            Smooth3x3Box.Image = Smooth[0];
            Smooth5x5Box.Image = Smooth[1];
            Smooth7x7Box.Image = Smooth[2];
            Smooth9x9Box.Image = Smooth[3];


        }

        public List<Bitmap> ChuyendoiSmooth(Bitmap Hinhgoc)
        {
            List<Bitmap> Smooth = new List<Bitmap>();
            
            Bitmap Smooth3x3 = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);
            Bitmap Smooth5x5 = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);
            Bitmap Smooth7x7 = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);
            Bitmap Smooth9x9 = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);

            for (int x=1;x<Hinhgoc.Width-1;x++)//Trong mặt nạ 3x3 thì bỏ qua đường viền có kích thước là 1 pixel
                for (int y = 1; y < Hinhgoc.Height - 1; y++)
                {
                    int Rs = 0, Gs = 0, Bs = 0;//Khai báo giá trị ba Kênh màu làm mượt

                    for (int i = x - 1; i <= x + 1; i++)//3x3 thì lấy các pixel lân cận như đường viền 1 pixel
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            Color color = Hinhgoc.GetPixel(i, j);
                            byte R = color.R;
                            byte G = color.G;
                            byte B = color.B;

                            //Tổng có giá trị pixel của từng kênh R-G-B
                            Rs += R;
                            Gs += G;
                            Bs += B;
                        }
                    //Chia giá trị tổng của từng kênh cho 9
                    Rs = (int)(Rs / 9);
                    Gs = (int)(Gs / 9);
                    Bs = (int)(Bs / 9);

                    Smooth3x3.SetPixel(x, y, Color.FromArgb(Rs, Gs, Bs));
                }
            for (int x = 2; x < Hinhgoc.Width - 2; x++)//Trong mặt nạ 5x5 thì bỏ qua đường viền có kích thước là 2 pixel
                for (int y = 2; y < Hinhgoc.Height - 2; y++)
                {
                    int Rs = 0, Gs = 0, Bs = 0;//Khai báo giá trị ba Kênh màu làm mượt

                    for (int i = x - 2; i <= x + 2; i++)//5x5 thì lấy các pixel lân cận như đường viền 2 pixel
                        for (int j = y - 2; j <= y + 2; j++)
                        {
                            Color color = Hinhgoc.GetPixel(i, j);
                            byte R = color.R;
                            byte G = color.G;
                            byte B = color.B;
                            //Tổng có giá trị pixel của từng kênh R-G-B
                            Rs += R;
                            Gs += G;
                            Bs += B;
                        }
                    //Chia giá trị tổng của từng kênh cho 25
                    Rs = (int)(Rs / 25);
                    Gs = (int)(Gs / 25);
                    Bs = (int)(Bs / 25);

                    Smooth5x5.SetPixel(x, y, Color.FromArgb(Rs, Gs, Bs));
                }
            for (int x = 3; x < Hinhgoc.Width - 3; x++)//Trong mặt nạ 7x7 thì bỏ qua đường viền có kích thước là 3 pixel
                for (int y = 3; y < Hinhgoc.Height - 3; y++)
                {
                    int Rs = 0, Gs = 0, Bs = 0;

                    for (int i = x - 3; i <= x + 3; i++) //7x7 thì lấy các pixel lân cận như đường viền 3 pixel
                        for (int j = y - 3; j <= y + 3; j++)
                        {
                            Color color = Hinhgoc.GetPixel(i, j);
                            byte R = color.R;
                            byte G = color.G;
                            byte B = color.B;
                            //Tổng có giá trị pixel của từng kênh R-G-B
                            Rs += R;
                            Gs += G;
                            Bs += B;
                        }
                    //Chia giá trị tổng của từng kênh cho 49
                    Rs = (int)(Rs / 49);
                    Gs = (int)(Gs / 49);
                    Bs = (int)(Bs / 49);

                    Smooth7x7.SetPixel(x, y, Color.FromArgb(Rs, Gs, Bs));
                }
            for (int x = 4; x < Hinhgoc.Width - 4; x++)//Trong mặt nạ 9x9 thì bỏ qua đường viền có kích thước là 4 pixel
                for (int y = 4; y < Hinhgoc.Height - 4; y++)
                {
                    int Rs = 0, Gs = 0, Bs = 0;

                    for (int i = x - 4; i <= x + 4; i++)//9x9 thì lấy các pixel lân cận như đường viền 4 pixel
                        for (int j = y - 4; j <= y + 4; j++)
                        {
                            Color color = Hinhgoc.GetPixel(i, j);
                            byte R = color.R;
                            byte G = color.G;
                            byte B = color.B;
                            //Tổng có giá trị pixel của từng kênh R-G-B
                            Rs += R;
                            Gs += G;
                            Bs += B;
                        }
                    //Chia giá trị tổng của từng kênh cho 81
                    Rs = (int)(Rs / 81);
                    Gs = (int)(Gs / 81);
                    Bs = (int)(Bs / 81);

                    Smooth9x9.SetPixel(x, y, Color.FromArgb(Rs, Gs, Bs));
                }
            Smooth.Add(Smooth3x3);
            Smooth.Add(Smooth5x5);
            Smooth.Add(Smooth7x7);
            Smooth.Add(Smooth9x9);
            return Smooth;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
