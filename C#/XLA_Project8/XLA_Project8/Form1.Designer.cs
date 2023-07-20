namespace XLA_Project8
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
            this.picH = new System.Windows.Forms.PictureBox();
            this.picS = new System.Windows.Forms.PictureBox();
            this.picV = new System.Windows.Forms.PictureBox();
            this.picHSV = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHSV)).BeginInit();
            this.SuspendLayout();
            // 
            // picO
            // 
            this.picO.Location = new System.Drawing.Point(24, 23);
            this.picO.Name = "picO";
            this.picO.Size = new System.Drawing.Size(255, 255);
            this.picO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picO.TabIndex = 0;
            this.picO.TabStop = false;
            // 
            // picH
            // 
            this.picH.Location = new System.Drawing.Point(24, 324);
            this.picH.Name = "picH";
            this.picH.Size = new System.Drawing.Size(255, 255);
            this.picH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picH.TabIndex = 0;
            this.picH.TabStop = false;
            // 
            // picS
            // 
            this.picS.Location = new System.Drawing.Point(326, 324);
            this.picS.Name = "picS";
            this.picS.Size = new System.Drawing.Size(255, 255);
            this.picS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picS.TabIndex = 0;
            this.picS.TabStop = false;
            // 
            // picV
            // 
            this.picV.Location = new System.Drawing.Point(635, 324);
            this.picV.Name = "picV";
            this.picV.Size = new System.Drawing.Size(255, 255);
            this.picV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picV.TabIndex = 0;
            this.picV.TabStop = false;
            // 
            // picHSV
            // 
            this.picHSV.Location = new System.Drawing.Point(949, 324);
            this.picHSV.Name = "picHSV";
            this.picHSV.Size = new System.Drawing.Size(255, 255);
            this.picHSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHSV.TabIndex = 0;
            this.picHSV.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hinh Goc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hinh Hue";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hinh Saturation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(632, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hinh Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(946, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "HinhHSV";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 771);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picHSV);
            this.Controls.Add(this.picV);
            this.Controls.Add(this.picS);
            this.Controls.Add(this.picH);
            this.Controls.Add(this.picO);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picO;
        private System.Windows.Forms.PictureBox picH;
        private System.Windows.Forms.PictureBox picS;
        private System.Windows.Forms.PictureBox picV;
        private System.Windows.Forms.PictureBox picHSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

