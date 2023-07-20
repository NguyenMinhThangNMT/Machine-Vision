﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XLA_Project8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap Hinhgoc = new Bitmap(@"D:\Môn Học\Thị Giác Máy\Lena.gif");
            picO.Image = Hinhgoc;
            //Khai bao hien thi hinh CMYK
            List<Bitmap> HSI = ChuyendoiRGBsangHSI(Hinhgoc);
            picH.Image = HSI[0];
            picS.Image = HSI[1];
            picV.Image = HSI[2];
            picHSV.Image = HSI[3];





        }
        public List<Bitmap> ChuyendoiRGBsangHSI(Bitmap Hinhgoc)
        {
            List<Bitmap> HSI = new List<Bitmap>();
            //Tao ra 4 hinh voi kich thuoc bang hinh goc
            Bitmap Hue = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);
            Bitmap Saturation = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);
            Bitmap Intensity = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);
            Bitmap HSIimg = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);

            for (int x = 0; x < Hinhgoc.Width; x++)
                for (int y = 0; y < Hinhgoc.Width; y++)
                {
                    Color pixel = Hinhgoc.GetPixel(x, y);
                    double R = pixel.R;
                    double G = pixel.G;
                    double B = pixel.B;

                    //cong thuc Hue
                    double t1 = ((R - G) + (R + B)) / 2;
                    double t2 = (R - G) * (R - G) + Math.Sqrt((R - B) * (G - B));
                    double theta = Math.Acos(t1 / t2);
                    //cong thuc kenh Hue 
                    double H = 0;
                    if (B <= G)
                        H = theta;
                    else
                        H = 2 * Math.PI - theta;
                    H = H * 180 / Math.PI;
                    //Cong thuc kenh Saturation
                    double S = 1 - 3 * Math.Min(R, Math.Min(G, B)) / (R + G + B);
                    //Cong thuc Value
                    double V = Math.Max(R,Math.Min(G,B));

                    //Gan Gia tri cac kenh
                    Hue.SetPixel(x, y, Color.FromArgb((byte)H, (byte)H, (byte)H));
                    Saturation.SetPixel(x, y, Color.FromArgb((byte)(S * 255), (byte)(S * 255), (byte)(S * 255)));
                    Intensity.SetPixel(x, y, Color.FromArgb((byte)V, (byte)V, (byte)V));
                    HSIimg.SetPixel(x, y, Color.FromArgb((byte)H, (byte)(S*255), (byte)V));





                }
            HSI.Add(Hue);
            HSI.Add(Saturation);
            HSI.Add(Intensity);
            HSI.Add(HSIimg);

            return HSI;

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
