namespace QLSV
{
    partial class Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            StNameTb = new TextBox();
            FeesTb = new TextBox();
            label1 = new Label();
            StGenCb = new ComboBox();
            label4 = new Label();
            DOBPicker = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            ClassCb = new ComboBox();
            SaveBtn = new Button();
            EditBtn = new Button();
            DeleteBtn = new Button();
            BackBtn = new Button();
            StudentsDGV = new PictureBox();
            label7 = new Label();
            AddressTb = new TextBox();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StudentsDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(983, 40);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DodgerBlue;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(947, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(43, 15);
            label2.Name = "label2";
            label2.Size = new Size(89, 22);
            label2.TabIndex = 13;
            label2.Text = "Students";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(21, 63);
            label3.Name = "label3";
            label3.Size = new Size(58, 21);
            label3.TabIndex = 5;
            label3.Text = "Name";
            // 
            // StNameTb
            // 
            StNameTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StNameTb.Location = new Point(21, 87);
            StNameTb.Name = "StNameTb";
            StNameTb.Size = new Size(129, 27);
            StNameTb.TabIndex = 8;
            // 
            // FeesTb
            // 
            FeesTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FeesTb.Location = new Point(619, 87);
            FeesTb.Name = "FeesTb";
            FeesTb.Size = new Size(160, 27);
            FeesTb.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(619, 63);
            label1.Name = "label1";
            label1.Size = new Size(44, 21);
            label1.TabIndex = 9;
            label1.Text = "Fees";
            // 
            // StGenCb
            // 
            StGenCb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StGenCb.FormattingEnabled = true;
            StGenCb.Items.AddRange(new object[] { "Male", "Female" });
            StGenCb.Location = new Point(156, 87);
            StGenCb.Name = "StGenCb";
            StGenCb.Size = new Size(121, 29);
            StGenCb.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(153, 63);
            label4.Name = "label4";
            label4.Size = new Size(70, 21);
            label4.TabIndex = 12;
            label4.Text = "Gender";
            // 
            // DOBPicker
            // 
            DOBPicker.CalendarFont = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DOBPicker.Format = DateTimePickerFormat.Short;
            DOBPicker.Location = new Point(292, 91);
            DOBPicker.Name = "DOBPicker";
            DOBPicker.Size = new Size(168, 23);
            DOBPicker.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(292, 63);
            label5.Name = "label5";
            label5.Size = new Size(103, 21);
            label5.TabIndex = 14;
            label5.Text = "DateOfBirth";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(471, 63);
            label6.Name = "label6";
            label6.Size = new Size(49, 21);
            label6.TabIndex = 16;
            label6.Text = "Class";
            // 
            // ClassCb
            // 
            ClassCb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClassCb.FormattingEnabled = true;
            ClassCb.Items.AddRange(new object[] { "Male", "Female" });
            ClassCb.Location = new Point(471, 87);
            ClassCb.Name = "ClassCb";
            ClassCb.Size = new Size(121, 29);
            ClassCb.TabIndex = 15;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.Yellow;
            SaveBtn.ForeColor = Color.Black;
            SaveBtn.Location = new Point(150, 150);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(144, 35);
            SaveBtn.TabIndex = 17;
            SaveBtn.Text = "Add";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.Yellow;
            EditBtn.ForeColor = Color.Black;
            EditBtn.Location = new Point(309, 150);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(144, 35);
            EditBtn.TabIndex = 18;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Yellow;
            DeleteBtn.ForeColor = Color.Black;
            DeleteBtn.Location = new Point(471, 150);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(144, 35);
            DeleteBtn.TabIndex = 19;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Yellow;
            BackBtn.ForeColor = Color.Black;
            BackBtn.Location = new Point(635, 150);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(144, 35);
            BackBtn.TabIndex = 20;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = false;
            // 
            // StudentsDGV
            // 
            StudentsDGV.Location = new Point(21, 254);
            StudentsDGV.Name = "StudentsDGV";
            StudentsDGV.Size = new Size(941, 352);
            StudentsDGV.SizeMode = PictureBoxSizeMode.Zoom;
            StudentsDGV.TabIndex = 21;
            StudentsDGV.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.MediumBlue;
            label7.Location = new Point(395, 205);
            label7.Name = "label7";
            label7.Size = new Size(155, 30);
            label7.TabIndex = 22;
            label7.Text = "Students List";
            // 
            // AddressTb
            // 
            AddressTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddressTb.Location = new Point(786, 87);
            AddressTb.Multiline = true;
            AddressTb.Name = "AddressTb";
            AddressTb.Size = new Size(176, 57);
            AddressTb.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(786, 59);
            label8.Name = "label8";
            label8.Size = new Size(72, 21);
            label8.TabIndex = 23;
            label8.Text = "Address";
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.White;
            ClientSize = new Size(983, 641);
            Controls.Add(AddressTb);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(StudentsDGV);
            Controls.Add(BackBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(EditBtn);
            Controls.Add(SaveBtn);
            Controls.Add(label6);
            Controls.Add(ClassCb);
            Controls.Add(label5);
            Controls.Add(DOBPicker);
            Controls.Add(label4);
            Controls.Add(StGenCb);
            Controls.Add(FeesTb);
            Controls.Add(label1);
            Controls.Add(StNameTb);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Students";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Students";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)StudentsDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private TextBox StNameTb;
        private TextBox FeesTb;
        private Label label1;
        private ComboBox StGenCb;
        private Label label4;
        private DateTimePicker DOBPicker;
        private Label label5;
        private Label label6;
        private ComboBox ClassCb;
        private Button SaveBtn;
        private Button EditBtn;
        private Button DeleteBtn;
        private Button BackBtn;
        private PictureBox StudentsDGV;
        private Label label7;
        private TextBox AddressTb;
        private Label label8;
    }
}