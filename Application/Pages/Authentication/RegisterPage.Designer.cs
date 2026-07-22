namespace Application.Pages.Authentication
{
    partial class RegisterPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterPage));
            label3 = new Label();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            lastname_txtbox = new TextBox();
            firstname_txtbox = new TextBox();
            pictureBox1 = new PictureBox();
            username_txtbox = new TextBox();
            password_txtbox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Vazirmatn", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(41, 44, 44);
            label3.Location = new Point(192, 576);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(144, 26);
            label3.TabIndex = 5;
            label3.Text = "اکانتی دارید؟ وارد شوید";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(41, 44, 44);
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = Color.White;
            button1.Location = new Point(64, 510);
            button1.Name = "button1";
            button1.Size = new Size(272, 48);
            button1.TabIndex = 4;
            button1.Text = "ثبت نام";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 254);
            label2.Name = "label2";
            label2.Size = new Size(91, 27);
            label2.TabIndex = 8;
            label2.Text = "نام خانوادگی";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(305, 175);
            label1.Name = "label1";
            label1.Size = new Size(31, 27);
            label1.TabIndex = 9;
            label1.Text = "نام";
            // 
            // lastname_txtbox
            // 
            lastname_txtbox.Location = new Point(64, 284);
            lastname_txtbox.Name = "lastname_txtbox";
            lastname_txtbox.Size = new Size(272, 32);
            lastname_txtbox.TabIndex = 1;
            // 
            // firstname_txtbox
            // 
            firstname_txtbox.Location = new Point(64, 205);
            firstname_txtbox.Name = "firstname_txtbox";
            firstname_txtbox.Size = new Size(272, 32);
            firstname_txtbox.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(155, 50);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // username_txtbox
            // 
            username_txtbox.Location = new Point(64, 372);
            username_txtbox.Name = "username_txtbox";
            username_txtbox.Size = new Size(272, 32);
            username_txtbox.TabIndex = 2;
            // 
            // password_txtbox
            // 
            password_txtbox.Location = new Point(64, 455);
            password_txtbox.Name = "password_txtbox";
            password_txtbox.Size = new Size(272, 32);
            password_txtbox.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(263, 339);
            label4.Name = "label4";
            label4.Size = new Size(73, 27);
            label4.TabIndex = 9;
            label4.Text = "نام کاربری";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(275, 425);
            label5.Name = "label5";
            label5.Size = new Size(61, 27);
            label5.TabIndex = 8;
            label5.Text = "رمز عبور";
            // 
            // RegisterPage
            // 
            AutoScaleDimensions = new SizeF(9F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(password_txtbox);
            Controls.Add(username_txtbox);
            Controls.Add(lastname_txtbox);
            Controls.Add(firstname_txtbox);
            Controls.Add(pictureBox1);
            Font = new Font("Vazirmatn", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "RegisterPage";
            Size = new Size(400, 630);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox lastname_txtbox;
        private TextBox firstname_txtbox;
        private PictureBox pictureBox1;
        private TextBox username_txtbox;
        private TextBox password_txtbox;
        private Label label4;
        private Label label5;
    }
}
