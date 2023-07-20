using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XLA_Porject6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Khai bao va hien thi hinh goc
            Bitmap Hinhgoc = new Bitmap(@"D:\Môn Học\Thị Giác Máy\Lena.jpg");
            picO.Image = Hinhgoc;
            //Khai bao hien thi hinh CMYK
            List<Bitmap> CMYK = ChuyendoiRGBsangCMYK(Hinhgoc);
            picCyan.Image = CMYK[0];
            picMagenta.Image = CMYK[1];
            picYellow.Image = CMYK[2];
            picBlack.Image = CMYK[3];





        }
        public List<Bitmap> ChuyendoiRGBsangCMYK(Bitmap Hinhgoc)
        {
            List<Bitmap> CMYK = new List<Bitmap>();
            //Tao ra 4 hinh voi kich thuoc bang hinh goc
            Bitmap Cyan = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);
            Bitmap Magenta = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);
            Bitmap Yellow = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);
            Bitmap Black = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);

            for (int x = 0; x < Hinhgoc.Width; x++)
                for (int y = 0; y < Hinhgoc.Width; y++)
                {
                    Color pixel = Hinhgoc.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;
                    //Set Gia tri cac Kenh 
                    Cyan.SetPixel(x, y, Color.FromArgb(0, G, B));
                    Magenta.SetPixel(x, y, Color.FromArgb(R, 0, B));
                    Yellow.SetPixel(x, y, Color.FromArgb(R, G, 0));

                    byte K = Math.Min(R, Math.Min(G, B));
                    Black.SetPixel(x, y, Color.FromArgb(K, K, K));


                }
            CMYK.Add(Cyan);
            CMYK.Add(Magenta);
            CMYK.Add(Yellow);
            CMYK.Add(Black);
            return CMYK;

        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
