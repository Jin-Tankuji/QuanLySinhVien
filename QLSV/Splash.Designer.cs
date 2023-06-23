namespace QLSV
{
    partial class Splash
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            progressBar1 = new ProgressBar();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(128, 41);
            label1.Name = "label1";
            label1.Size = new Size(287, 25);
            label1.TabIndex = 0;
            label1.Text = "MycodeSpace High School";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(208, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(22, 238);
            label2.Name = "label2";
            label2.Size = new Size(160, 23);
            label2.TabIndex = 3;
            label2.Text = "Loading Module";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 273);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(527, 23);
            progressBar1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(188, 238);
            label3.Name = "label3";
            label3.Size = new Size(26, 24);
            label3.TabIndex = 5;
            label3.Text = "%";
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(551, 308);
            Controls.Add(label3);
            Controls.Add(progressBar1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private ProgressBar progressBar1;
        private Label label3;
    }
}