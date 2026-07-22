using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Application.Shared
{
    public partial class Alert : Form
    {
        static Alert? alert;
        bool isDragging = false;
        Point dragStartPoint;

        public Alert()
        {
            InitializeComponent();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newLocation = this.Location;
                newLocation.X += e.X - dragStartPoint.X;
                newLocation.Y += e.Y - dragStartPoint.Y;

                this.Location = newLocation;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                dragStartPoint = new Point(e.X, e.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        public static void Show(string title, string message, string description)
        {
            alert = new Alert();
            
            alert.titlelbl.Text = title;
            alert.messagelbl.Text = message;
            alert.descriptionlbl.Text = description;

            alert.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            alert?.Close();
        }
    }
}
