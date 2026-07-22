using Application.Services;
using Application.Services.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Application.Pages.Dashboard
{
    public partial class DashboardPage : UserControl
    {
        public DashboardPage()
        {
            InitializeComponent();
            Form? MainForm = NavigationService.MainForm;

            MainForm?.ClientSize = new Size(this.Size.Width, this.Size.Height);
        }

        private void DashboardPage_Load(object sender, EventArgs e)
        {
            var user = CurrentUserStorage.User;

            label1.Text = $"سلام {user?.FirstName} {user?.LastName}";
        }
    }
}
