namespace WindowsFormsApp1
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
            this.OriginBox = new System.Windows.Forms.PictureBox();
            this.Smooth7x7Box = new System.Windows.Forms.PictureBox();
            this.Smooth3x3Box = new System.Windows.Forms.PictureBox();
            this.Smooth5x5Box = new System.Windows.Forms.PictureBox();
            this.Smooth9x9Box = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OriginBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Smooth7x7Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Smooth3x3Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Smooth5x5Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Smooth9x9Box)).BeginInit();
            this.SuspendLayout();
            // 
            // OriginBox
            // 
            this.OriginBox.Location = new System.Drawing.Point(12, 24);
            this.OriginBox.Name = "OriginBox";
            this.OriginBox.Size = new System.Drawing.Size(339, 405);
            this.OriginBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OriginBox.TabIndex = 0;
            this.OriginBox.TabStop = false;
            this.OriginBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Smooth7x7Box
            // 
            this.Smooth7x7Box.Location = new System.Drawing.Point(1220, 24);
            this.Smooth7x7Box.Name = "Smooth7x7Box";
            this.Smooth7x7Box.Size = new System.Drawing.Size(381, 412);
            this.Smooth7x7Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Smooth7x7Box.TabIndex = 0;
            this.Smooth7x7Box.TabStop = false;
            this.Smooth7x7Box.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Smooth3x3Box
            // 
            this.Smooth3x3Box.Location = new System.Drawing.Point(419, 24);
            this.Smooth3x3Box.Name = "Smooth3x3Box";
            this.Smooth3x3Box.Size = new System.Drawing.Size(336, 405);
            this.Smooth3x3Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Smooth3x3Box.TabIndex = 0;
            this.Smooth3x3Box.TabStop = false;
            this.Smooth3x3Box.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Smooth5x5Box
            // 
            this.Smooth5x5Box.Location = new System.Drawing.Point(817, 24);
            this.Smooth5x5Box.Name = "Smooth5x5Box";
            this.Smooth5x5Box.Size = new System.Drawing.Size(342, 412);
            this.Smooth5x5Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Smooth5x5Box.TabIndex = 0;
            this.Smooth5x5Box.TabStop = false;
            this.Smooth5x5Box.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Smooth9x9Box
            // 
            this.Smooth9x9Box.Location = new System.Drawing.Point(397, 525);
            this.Smooth9x9Box.Name = "Smooth9x9Box";
            this.Smooth9x9Box.Size = new System.Drawing.Size(358, 369);
            this.Smooth9x9Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Smooth9x9Box.TabIndex = 0;
            this.Smooth9x9Box.TabStop = false;
            this.Smooth9x9Box.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Image Origin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Smooth 3x3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(814, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Smooth 5x5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1217, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Smooth 7x7";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 505);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Smooth 9x9";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1711, 1055);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Smooth5x5Box);
            this.Controls.Add(this.Smooth3x3Box);
            this.Controls.Add(this.Smooth9x9Box);
            this.Controls.Add(this.Smooth7x7Box);
            this.Controls.Add(this.OriginBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OriginBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Smooth7x7Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Smooth3x3Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Smooth5x5Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Smooth9x9Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox OriginBox;
        private System.Windows.Forms.PictureBox Smooth7x7Box;
        private System.Windows.Forms.PictureBox Smooth3x3Box;
        private System.Windows.Forms.PictureBox Smooth5x5Box;
        private System.Windows.Forms.PictureBox Smooth9x9Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

