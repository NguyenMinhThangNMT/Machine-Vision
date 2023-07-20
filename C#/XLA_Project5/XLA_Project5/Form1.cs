using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace XLA_Project5
{
    public partial class Form1 : Form
    {
        Bitmap hinhgoc;
        public Form1()
        {
            InitializeComponent();
          
            // tạo biến chứ địa chỉ hình
            string filehinh = @"D:\Môn Học\Thị Giác Máy\lena.jpg";
            // load hình từ biến chứ địa chỉ file hình
            hinhgoc = new Bitmap(filehinh);

            // Hiển thị lên pictureBox
            pictureBox1.Image = hinhgoc;
            Bitmap Hinhmucxam = ChuyenhinhRGBsanghinhxamLuminance(hinhgoc);
            pictureBox2.Image = Hinhmucxam;
            //GỌi hàm biểu đồ histogram 
            double[] histogram = TinhHistogram(Hinhmucxam);
            //Chuyển đổi kiểu dữ liệu 
            PointPairList points = Chuuyendoihistogram(histogram);
            //Vẽ đồ thị biểu diễn cho histogram
            zedG.GraphPane = BieudoHistogram(points);
            zedG.Refresh();

        }
        // Tính hình mức xám theo phương pháp Luminance
        public Bitmap ChuyenhinhRGBsanghinhxamLuminance(Bitmap hinhgoc)
        {
            Bitmap Hinhmucxam = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            for (int x = 0; x < hinhgoc.Width; x++)
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    //Lấy điểm ảnh
                    Color pixel = hinhgoc.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    // Tính giá trị mức xám cho điểm ảnh tại (x,y)

                    byte gray = (byte)(R * 0.2126 + G * 0.7152 + B * 0.0722);

                    // Gán gia tri mức xám vừa tính vào hình mức xám
                    Hinhmucxam.SetPixel(x, y, Color.FromArgb(gray, gray, gray));

                }
            return Hinhmucxam;
        }
        //Tính histogram ảnh xám
        public double [] TinhHistogram (Bitmap Hinhmucxam)
        {
            //Mỗi pixel mức xám có giá trị từ 0 - 255
            double[] histogram = new double[256];
            for (int x = 0; x < Hinhmucxam.Width; x++)
                for (int y = 0; y < Hinhmucxam.Height; y++)
                {

                    Color color = Hinhmucxam.GetPixel(x, y);
                    byte gray = color.R;//Trong hình xám giá trị kênh R cũng giống như kênh G hoặc kênh B
                    //Giá trị gray tính ra cũng là phần tử thứ grang trong mảng Histogram
                    //Ta tăng số đếm của gray lên 1
                    histogram[gray]++;
                }
            return histogram;


        }
        
        PointPairList Chuuyendoihistogram(double[] histogram)
        {
            //Dùng kiểu dữ liệu PointPairList để vẽ biểu đồ
            PointPairList points = new PointPairList();

            for (int i = 0; i < histogram.Length; i++)
            {
                //i tương ứng với trục nằm ngang từ 0 - 255
                //histogram[i] tương ứng với trục dọc,là số pixel có cùng mức xám 
                points.Add(i, histogram[i]);
            }
            return points;
        }
        //Thiết lập biểu đồ trong ZedGraph
        public GraphPane BieudoHistogram (PointPairList histogram)
        {
            //GraphPane là đối tượng biểu đồ trong zedGraph

            GraphPane gp = new GraphPane();
            gp.Title.Text = @"Biểu đồ histogram";//Tên biểu đồ 
            gp.Rect = new Rectangle(0, 0, 700, 500);//Khung chứa biểu đồ 
            //Thiết lập trục ngang
            gp.XAxis.Title.Text = @"Gia tri muc xam cua cac diem anh";
            gp.XAxis.Scale.Min = 0;//nhỏ nhất là 0
            gp.XAxis.Scale.Max = 255;// lớn nhất là 255
            gp.XAxis.Scale.MajorStep = 5;//mỗi bước chính là 5
            gp.XAxis.Scale.MinorStep = 1;//Mỗi bước trong 1 bước chính là 1 
            //Thiết lập trục dọc
            gp.YAxis.Title.Text = @"So diem anh co cung muc xam";
            gp.YAxis.Scale.Min = 0;
            gp.YAxis.Scale.Max = 15000;//Số này phải lớn hơn w x h của ảnh 
            gp.YAxis.Scale.MajorStep = 5;
            gp.YAxis.Scale.MinorStep = 0;

            //Dùng biểu đồ dạng bar để biểu diễn histogram
            gp.AddBar("Histogram",histogram,Color.OrangeRed);
            return gp;

        } 



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void zedG_Load(object sender, EventArgs e)
        {

        }
    }
}
