using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XLA_Project10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap Hinhgoc = new Bitmap(@"D:\Môn Học\Thị Giác Máy\Lena.jpg");
            pic0.Image = Hinhgoc;
            //Khai bao hien thi hinh CMYK
            List<Bitmap> YCbCr = ChuyendoiRGBsangYCbCr(Hinhgoc);
            picY.Image = YCbCr[0];
            picCb.Image = YCbCr[1];
            picCr.Image = YCbCr[2];
            picYCbCr.Image = YCbCr[3];





        }
        public List<Bitmap> ChuyendoiRGBsangYCbCr(Bitmap Hinhgoc)
        {
            List<Bitmap> YCbCr = new List<Bitmap>();
            //Tao ra 4 hinh voi kich thuoc bang hinh goc
            Bitmap KY = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);
            Bitmap KCb = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);
            Bitmap KCr = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);
            Bitmap KYCbCrimg = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);

            for (int x = 0; x < Hinhgoc.Width; x++)
                for (int y = 0; y < Hinhgoc.Width; y++)
                {
                    Color pixel = Hinhgoc.GetPixel(x, y);
                    double R = pixel.R;
                    double G = pixel.G;
                    double B = pixel.B;

                    //Cong thuc cac kenh
                    byte Y = (byte)(16 + (65.738 * R) / 256 + (129.057 * G) / 256 + (25.064 * B) / 256);
                    byte Cb = (byte)(128 - (37.945 * R) / 256 - (74.494 * G) / 256 + (112.439 * B) / 256);
                    byte Cr = (byte)(128 + (112.439 * R) / 256 - (94.154 * G) / 256 - (18.285 * B) / 256);



                    KY.SetPixel(x, y, Color.FromArgb((byte)Y, (byte)Y, (byte)Y));
                    KCb.SetPixel(x, y, Color.FromArgb((byte)Cb, (byte)Cb, (byte)Cb));
                    KCr.SetPixel(x, y, Color.FromArgb((byte)Cr, (byte)Cr, (byte)Cr));
                    KYCbCrimg.SetPixel(x, y, Color.FromArgb((byte)Y, (byte)Cb, (byte)Cr));






                }
            YCbCr.Add(KY);
            YCbCr.Add(KCb);
            YCbCr.Add(KCr);
            YCbCr.Add(KYCbCrimg);
            return YCbCr;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
