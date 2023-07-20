namespace XLA_Project7
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
            this.picI = new System.Windows.Forms.PictureBox();
            this.picHSI = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHSI)).BeginInit();
            this.SuspendLayout();
            // 
            // picO
            // 
            this.picO.Location = new System.Drawing.Point(24, 27);
            this.picO.Name = "picO";
            this.picO.Size = new System.Drawing.Size(255, 255);
            this.picO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picO.TabIndex = 0;
            this.picO.TabStop = false;
            // 
            // picH
            // 
            this.picH.Location = new System.Drawing.Point(24, 332);
            this.picH.Name = "picH";
            this.picH.Size = new System.Drawing.Size(255, 255);
            this.picH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picH.TabIndex = 0;
            this.picH.TabStop = false;
            // 
            // picS
            // 
            this.picS.Location = new System.Drawing.Point(322, 332);
            this.picS.Name = "picS";
            this.picS.Size = new System.Drawing.Size(255, 255);
            this.picS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picS.TabIndex = 0;
            this.picS.TabStop = false;
            // 
            // picI
            // 
            this.picI.Location = new System.Drawing.Point(627, 332);
            this.picI.Name = "picI";
            this.picI.Size = new System.Drawing.Size(255, 255);
            this.picI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picI.TabIndex = 0;
            this.picI.TabStop = false;
            // 
            // picHSI
            // 
            this.picHSI.Location = new System.Drawing.Point(928, 332);
            this.picHSI.Name = "picHSI";
            this.picHSI.Size = new System.Drawing.Size(255, 255);
            this.picHSI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHSI.TabIndex = 0;
            this.picHSI.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hình Gốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hình Hue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hình Saturation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(624, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hình Intensity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(925, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Hình HSI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 746);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picHSI);
            this.Controls.Add(this.picI);
            this.Controls.Add(this.picS);
            this.Controls.Add(this.picH);
            this.Controls.Add(this.picO);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHSI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picO;
        private System.Windows.Forms.PictureBox picH;
        private System.Windows.Forms.PictureBox picS;
        private System.Windows.Forms.PictureBox picI;
        private System.Windows.Forms.PictureBox picHSI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

