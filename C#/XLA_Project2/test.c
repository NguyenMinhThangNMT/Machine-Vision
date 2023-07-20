using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Serial_CM
{
    public partial class Form1 : Form
    {
        string send_data;
        string receive_data;
        string led;
        string total;

        //Bai Modbus
        int state = 0;

        byte[] data_resq = new byte[8];
        byte[] data_rp   = new byte[100];


        string frame;
        string Address;
        string Function;
        string Start_Ad;
        string Quanti;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Lấy đầu vào các cổng com
            string[] ports = SerialPort.GetPortNames();
            CBxCOMPORT.Items.AddRange(ports);
        }

        private void BT_OPEN_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = CBxCOMPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(CBxBAUDRATE.Text);
                serialPort1.DataBits = Convert.ToInt32(CBxDATABITS.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), CBxSTOPBITS.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), CBxPARITYBITS.Text);
                serialPort1.Encoding = System.Text.Encoding.GetEncoding(28591);
                BT_SEND.Enabled = true;

                serialPort1.Open();
                progressBar1.Value = 100;
            }

            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BT_CLOSE_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
                BT_SEND.Enabled = false;
            }
        }

        private void BT_SEND_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                send_data = Send_Data.Text;
                serialPort1.Write(send_data);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            receive_data = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));

        }

        private void ShowData(object sender, EventArgs e)
        {
            Encoding cp1252 = Encoding.GetEncoding(1252);
            data_rp = cp1252.GetBytes(receive_data);
            foreach (byte b in data_rp)
            {
                string hex = b.ToString("X2");
                hex = hex.ToUpper();
                Data2_Box.Text += hex;
                Data2_Box.Text += " ";
            }
        }

        private void clear_data_Click(object sender, EventArgs e)
        {
            if (Data_Box.Text != "")
            {
                Data_Box.Text = "";
            }

            if (Data2_Box.Text != "")
            {
                Data2_Box.Text = "";
            }
        }

        private void On_1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                led += "1";
            }
        }

        private void Off_1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                led += "0";
            }
        }

        private void On_2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                led += "1";
            }
        }

        private void Off_2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                led += "0";
            }
        }

        private void On_3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                led += "1";
            }
        }

        private void Off_3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                led += "0";
            }
        }

        private void On_4_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                led += "1";
            }
        }

        private void Off_4_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                led += "0";
            }
        }

        private void On_5_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                led += "1";
            }
        }

        private void Off_5_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                led += "0";
            }
        }

        private void On_6_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                led += "1";
            }
        }

        private void Off_6_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                led += "0";
            }
        }

        private void On_7_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                led += "1";
            }
        }

        private void Off_7_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                led += "0";
            }
        }

        private void On_8_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                led += "1";
            }
        }

        private void Off_8_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                led += "0";
            }
        }

        private void Data_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                total = "~" + led + "LF"+"CR";
                serialPort1.Write(total);
                led = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            state = 1;
            if (state == 1)
                {
                frame = "";
                Data_Box.Text = "";
                Data2_Box.Text = "";

                frame = Box_Request.Text;
                frame = frame.Replace(" ", "");

                Address  = frame.Substring(0, 2);
                Function = frame.Substring(2, 2);

                Start_Ad = frame.Substring(4, 2);
                Quanti = frame.Substring(6, 2);

                //Chuyen sang int Address
                int Address_Int = int.Parse(Address);

                byte[] Address_B = new byte[4];

                Address_B[0] = (byte)(Address_Int >> 24);
                Address_B[1] = (byte)(Address_Int >> 16);
                Address_B[2] = (byte)(Address_Int >> 8);
                Address_B[3] = (byte)Address_Int;

                serialPort1.Write(new byte[] { Address_B[3] }, 0, 1);
                data_resq[0] = Address_B[3];

                //Chuyen sang int Function
                int Function_Int = int.Parse(Function);

                byte[] Function_B = new byte[4];

                Function_B[0] = (byte)(Function_Int >> 24);
                Function_B[1] = (byte)(Function_Int >> 16);
                Function_B[2] = (byte)(Function_Int >> 8);
                Function_B[3] = (byte)Function_Int;

                serialPort1.Write(new byte[] { Function_B[3] }, 0, 1);
                data_resq[1] = Function_B[3];

                //Start Address
                ushort Start_B = Convert.ToUInt16(Start_Ad);

                data_resq[2] = (byte)(Start_B >> 8);
                serialPort1.Write(new byte[] { data_resq[2] }, 0, 1);

                data_resq[3] = (byte)(Start_B);
                serialPort1.Write(new byte[] { data_resq[3] }, 0, 1);

                //Quanlity
                ushort Quanlity_B = Convert.ToUInt16(Quanti);

                data_resq[4] = (byte)(Quanlity_B >> 8);
                serialPort1.Write(new byte[] { data_resq[4] }, 0, 1);

                data_resq[5] = (byte)(Quanlity_B);
                serialPort1.Write(new byte[] { data_resq[5] }, 0, 1);

                //Calculate CRC
                byte[] checkSum = CRC16(data_resq);
                data_resq[6] = checkSum[0];
                data_resq[7] = checkSum[1];
                serialPort1.Write(new byte[] { data_resq[6], data_resq[7] }, 0, 2);

                Data_Box.Text += "Resquest Line: ";
                foreach(var item in data_resq)
                {
                    string hex = item.ToString("x2");
                    hex = hex.ToUpper();
                    Data_Box.Text += hex;
                    Data_Box.Text += " ";
                }
                Data2_Box.Text += "Respond Line: ";

            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            state = 0;
        }

        private static byte[] CRC16(byte[] data)
        {
            byte[] checkSum = new byte[2];
            ushort reg_crc = 0XFFFF;

            for (int i = 0;i<data.Length-2;i++)
            {
                reg_crc ^= data[i];
                for (int j = 0; j < 8; j++)
                {
                    if ((reg_crc & 0x01) == 1)
                    {
                        reg_crc = (ushort)((reg_crc >> 1) ^ 0xA001);
                    }
                    else
                    {
                        reg_crc = (ushort)(reg_crc >> 1);
                    }
                }
            }

            checkSum[1] = (byte)((reg_crc >> 8) & 0xFF);
            checkSum[0] = (byte)(reg_crc & 0xFF);
            return checkSum;
        }


    }
}
