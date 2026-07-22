namespace Application.Shared
{
    partial class Alert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alert));
            panel1 = new Panel();
            titlelbl = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            messagelbl = new Label();
            descriptionlbl = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(titlelbl);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 30);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // titlelbl
            // 
            titlelbl.AutoSize = true;
            titlelbl.Font = new Font("Vazirmatn", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titlelbl.ForeColor = Color.FromArgb(64, 64, 64);
            titlelbl.Location = new Point(8, 4);
            titlelbl.Name = "titlelbl";
            titlelbl.RightToLeft = RightToLeft.Yes;
            titlelbl.Size = new Size(76, 24);
            titlelbl.TabIndex = 2;
            titlelbl.Text = "عنوان تستی";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(470, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 22);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(345, 52);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 120);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // messagelbl
            // 
            messagelbl.Font = new Font("Vazirmatn", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            messagelbl.Location = new Point(22, 52);
            messagelbl.Name = "messagelbl";
            messagelbl.RightToLeft = RightToLeft.Yes;
            messagelbl.Size = new Size(304, 41);
            messagelbl.TabIndex = 2;
            messagelbl.Text = "این یک پیام ساده است.";
            // 
            // descriptionlbl
            // 
            descriptionlbl.Font = new Font("Vazirmatn", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptionlbl.ForeColor = Color.DimGray;
            descriptionlbl.Location = new Point(22, 99);
            descriptionlbl.Name = "descriptionlbl";
            descriptionlbl.RightToLeft = RightToLeft.Yes;
            descriptionlbl.Size = new Size(304, 92);
            descriptionlbl.TabIndex = 2;
            descriptionlbl.Text = "این نمونه ای از توضیحات لازم برای این قسمت است به نظر شما چه بخش های دیگری میتوند اضافه شود ؟";
            // 
            // Alert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 200);
            Controls.Add(descriptionlbl);
            Controls.Add(messagelbl);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Alert";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alert";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label titlelbl;
        private PictureBox pictureBox2;
        private Label messagelbl;
        private Label descriptionlbl;
    }
}