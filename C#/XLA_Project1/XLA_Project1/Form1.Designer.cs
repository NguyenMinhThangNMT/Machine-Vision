namespace XLA_Project1
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
            this.picBox_O = new System.Windows.Forms.PictureBox();
            this.picBox_R = new System.Windows.Forms.PictureBox();
            this.picBox_B = new System.Windows.Forms.PictureBox();
            this.picBox_G = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_O)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_G)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_O
            // 
            this.picBox_O.Location = new System.Drawing.Point(49, 35);
            this.picBox_O.Name = "picBox_O";
            this.picBox_O.Size = new System.Drawing.Size(450, 450);
            this.picBox_O.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_O.TabIndex = 0;
            this.picBox_O.TabStop = false;
            // 
            // picBox_R
            // 
            this.picBox_R.Location = new System.Drawing.Point(619, 35);
            this.picBox_R.Name = "picBox_R";
            this.picBox_R.Size = new System.Drawing.Size(450, 450);
            this.picBox_R.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_R.TabIndex = 0;
            this.picBox_R.TabStop = false;
            // 
            // picBox_B
            // 
            this.picBox_B.Location = new System.Drawing.Point(49, 508);
            this.picBox_B.Name = "picBox_B";
            this.picBox_B.Size = new System.Drawing.Size(450, 450);
            this.picBox_B.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_B.TabIndex = 0;
            this.picBox_B.TabStop = false;
            // 
            // picBox_G
            // 
            this.picBox_G.Location = new System.Drawing.Point(619, 508);
            this.picBox_G.Name = "picBox_G";
            this.picBox_G.Size = new System.Drawing.Size(450, 450);
            this.picBox_G.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_G.TabIndex = 0;
            this.picBox_G.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hình gốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(597, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hình kênh đỏ R";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 488);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hình kênh xanh B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(597, 488);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hình kênh xanh lá G";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 1055);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox_G);
            this.Controls.Add(this.picBox_R);
            this.Controls.Add(this.picBox_B);
            this.Controls.Add(this.picBox_O);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_O)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_G)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_O;
        private System.Windows.Forms.PictureBox picBox_R;
        private System.Windows.Forms.PictureBox picBox_B;
        private System.Windows.Forms.PictureBox picBox_G;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

