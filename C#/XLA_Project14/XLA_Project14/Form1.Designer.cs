namespace XLA_Project14
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picS)).BeginInit();
            this.SuspendLayout();
            // 
            // picO
            // 
            this.picO.Location = new System.Drawing.Point(47, 67);
            this.picO.Name = "picO";
            this.picO.Size = new System.Drawing.Size(350, 350);
            this.picO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picO.TabIndex = 0;
            this.picO.TabStop = false;
            // 
            // picS
            // 
            this.picS.Location = new System.Drawing.Point(463, 67);
            this.picS.Name = "picS";
            this.picS.Size = new System.Drawing.Size(350, 350);
            this.picS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picS.TabIndex = 0;
            this.picS.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(924, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 95);
            this.button1.TabIndex = 2;
            this.button1.Text = "Nhận Diện Biên";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(924, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 22);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 747);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picS);
            this.Controls.Add(this.picO);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picO;
        private System.Windows.Forms.PictureBox picS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

