using Application.Pages.Authentication;
using Application.Services;
using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;

namespace Application
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            NavigationService.Panel = panel1;
            NavigationService.MainForm = this;

            NavigationService.Navigate(page: new LoginPage());
        }
    }
}
