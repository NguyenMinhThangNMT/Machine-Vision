using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XLA_Project9
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap Hinhgoc = new Bitmap(@"D:\Môn Học\Thị Giác Máy\Lena.jpg");
            picO.Image = Hinhgoc;
            //Khai bao hien thi hinh CMYK
            List<Bitmap> XYZ = ChuyendoiRGBsangXYZ(Hinhgoc);
            picX.Image = XYZ[0];
            picY.Image = XYZ[1];
            picZ.Image = XYZ[2];
            picXYZ.Image = XYZ[3];





        }
        public List<Bitmap> ChuyendoiRGBsangXYZ(Bitmap Hinhgoc)
        {
            List<Bitmap> XYZ = new List<Bitmap>();
            //Tao ra 4 hinh voi kich thuoc bang hinh goc
            Bitmap KX = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);
            Bitmap KY = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);
            Bitmap KZ = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);
            Bitmap KXYZimg = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);

            for (int x = 0; x < Hinhgoc.Width; x++)
                for (int y = 0; y < Hinhgoc.Width; y++)
                {
                    Color pixel = Hinhgoc.GetPixel(x, y);
                    double R = pixel.R;
                    double G = pixel.G;
                    double B = pixel.B;

                    //Cong thuc cac kenh
                    byte X = (byte)(0.4124564 * R + 0.3575761 * G + 0.1804375 * B);
                    byte Y = (byte)(0.2126729 * R + 0.7151522 * G + 0.0721750 * B);
                    byte Z = (byte)(0.0193339 * R + 0.1191920 * G + 0.9503041 * B);


                    KX.SetPixel(x, y, Color.FromArgb((byte)X, (byte)X, (byte)X));
                    KY.SetPixel(x, y, Color.FromArgb((byte)Y, (byte)Y, (byte)Y));
                    KZ.SetPixel(x, y, Color.FromArgb((byte)Z, (byte)Z, (byte)Z));
                    KXYZimg.SetPixel(x, y, Color.FromArgb((byte)X, (byte)Y, (byte)Z));






                }
            XYZ.Add(KX);
            XYZ.Add(KY);
            XYZ.Add(KZ);
            XYZ.Add(KXYZimg);
            return XYZ;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
