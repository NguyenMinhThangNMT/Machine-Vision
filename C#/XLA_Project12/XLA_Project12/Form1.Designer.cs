namespace XLA_Project12
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
            this.label1 = new System.Windows.Forms.Label();
            this.SolutionBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OriginBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SolutionBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OriginBox
            // 
            this.OriginBox.Location = new System.Drawing.Point(52, 54);
            this.OriginBox.Name = "OriginBox";
            this.OriginBox.Size = new System.Drawing.Size(512, 512);
            this.OriginBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OriginBox.TabIndex = 0;
            this.OriginBox.TabStop = false;
            this.OriginBox.Click += new System.EventHandler(this.OriginBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "OriginBox";
            // 
            // SolutionBox
            // 
            this.SolutionBox.Location = new System.Drawing.Point(651, 54);
            this.SolutionBox.Name = "SolutionBox";
            this.SolutionBox.Size = new System.Drawing.Size(512, 512);
            this.SolutionBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SolutionBox.TabIndex = 0;
            this.SolutionBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(648, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "High SolutionBox";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 877);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SolutionBox);
            this.Controls.Add(this.OriginBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.OriginBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SolutionBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox OriginBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox SolutionBox;
        private System.Windows.Forms.Label label2;
    }
}

