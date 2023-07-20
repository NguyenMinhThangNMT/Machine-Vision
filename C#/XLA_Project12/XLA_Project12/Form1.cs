using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XLA_Project12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap Hinhgoc = new Bitmap(@"D:\Môn Học\Thị Giác Máy\Lena.jpg");
            OriginBox.Image = Hinhgoc;

            Bitmap sharp = ImageSharp(Hinhgoc);
            SolutionBox.Image = sharp;
        }

        public Bitmap ImageSharp (Bitmap Hinhgoc)
        {
            int[,] matrix = { { 0, -1, 0 }, { -1, 4, -1 }, { 0, -1, 0 } };
            Bitmap Sharp = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);

            for (int x = 1; x < Hinhgoc.Width-1; x++)
                for (int y = 1; y < Hinhgoc.Width-1; y++)
                {

                    int Rs = 0, Gs = 0, Bs = 0;
                    int SharpR = 0, SharpG = 0, SharpB = 0;

                    for (int i = x - 1;i<=x+1 ; i++)
                        for (int j =y- 1; j <=y +1; j++)
                        {
                            Color color = Hinhgoc.GetPixel(i, j);
                            int R = color.R;
                            int G = color.G;
                            int B = color.B;

                            Rs += R * matrix[i - x + 1, j - y + 1];
                            Gs += G * matrix[i - x + 1, j - y + 1];
                            Bs += B * matrix[i - x + 1, j - y + 1];

                        }
                    Color color1 = Hinhgoc.GetPixel(x, y);
                    int R1 = color1.R;
                    int G1 = color1.G;
                    int B1 = color1.B;

                    SharpR = R1 + Rs;
                    SharpG = G1 + Gs;
                    SharpB = B1 + Bs;

                    if (SharpR < 0)
                        SharpR = 0;
                    else if (SharpR > 255)
                        SharpR = 255;

                    if (SharpG < 0)
                        SharpG = 0;
                    else if (SharpG > 255)
                        SharpG = 255;

                    if (SharpB < 0)
                        SharpB = 0;
                    else if (SharpB > 255)
                        SharpB = 255;
                    Sharp.SetPixel(x, y, Color.FromArgb(SharpR, SharpG, SharpB));
                }
            return Sharp;
        }

        private void OriginBox_Click(object sender, EventArgs e)
        {

        }
    }
}
