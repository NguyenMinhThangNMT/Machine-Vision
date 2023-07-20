namespace XLA_Project13
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picO = new System.Windows.Forms.PictureBox();
            this.picS = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TextX1 = new System.Windows.Forms.TextBox();
            this.textY1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textY2 = new System.Windows.Forms.TextBox();
            this.textX2 = new System.Windows.Forms.TextBox();
            this.textNguong = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picS)).BeginInit();
            this.SuspendLayout();
            // 
            // picO
            // 
            this.picO.Location = new System.Drawing.Point(70, 77);
            this.picO.Name = "picO";
            this.picO.Size = new System.Drawing.Size(350, 350);
            this.picO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picO.TabIndex = 0;
            this.picO.TabStop = false;
            // 
            // picS
            // 
            this.picS.Location = new System.Drawing.Point(499, 77);
            this.picS.Name = "picS";
            this.picS.Size = new System.Drawing.Size(350, 350);
            this.picS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picS.TabIndex = 0;
            this.picS.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Image Origin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Image Segmentation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1175, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngưỡng";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1153, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Chọn vùng vecto";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(996, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "X1";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(996, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Y1";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1252, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "X2";
            this.label7.Click += new System.EventHandler(this.label3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1252, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Y2";
            this.label8.Click += new System.EventHandler(this.label3_Click);
            // 
            // TextX1
            // 
            this.TextX1.Location = new System.Drawing.Point(1037, 224);
            this.TextX1.Name = "TextX1";
            this.TextX1.Size = new System.Drawing.Size(161, 22);
            this.TextX1.TabIndex = 2;
            // 
            // textY1
            // 
            this.textY1.Location = new System.Drawing.Point(1037, 287);
            this.textY1.Name = "textY1";
            this.textY1.Size = new System.Drawing.Size(161, 22);
            this.textY1.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1283, 287);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1283, 224);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 2;
            // 
            // textY2
            // 
            this.textY2.Location = new System.Drawing.Point(1283, 287);
            this.textY2.Name = "textY2";
            this.textY2.Size = new System.Drawing.Size(141, 22);
            this.textY2.TabIndex = 2;
            // 
            // textX2
            // 
            this.textX2.Location = new System.Drawing.Point(1283, 224);
            this.textX2.Name = "textX2";
            this.textX2.Size = new System.Drawing.Size(141, 22);
            this.textX2.TabIndex = 2;
            // 
            // textNguong
            // 
            this.textNguong.Location = new System.Drawing.Point(1145, 119);
            this.textNguong.Name = "textNguong";
            this.textNguong.Size = new System.Drawing.Size(141, 22);
            this.textNguong.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1145, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 63);
            this.button1.TabIndex = 3;
            this.button1.Text = "Phân đoạn ảnh Segmentation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1586, 695);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textNguong);
            this.Controls.Add(this.textX2);
            this.Controls.Add(this.textY2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textY1);
            this.Controls.Add(this.TextX1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picS);
            this.Controls.Add(this.picO);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picO;
        private System.Windows.Forms.PictureBox picS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextX1;
        private System.Windows.Forms.TextBox textY1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textY2;
        private System.Windows.Forms.TextBox textX2;
        private System.Windows.Forms.TextBox textNguong;
        private System.Windows.Forms.Button button1;
    }
}

