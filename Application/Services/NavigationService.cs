using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    internal class NavigationService
    {
        public static Form? MainForm { get; set; }
        public static Panel? Panel { get; set; }

        public static void Navigate(UserControl page)
        {
            if (Panel == null) return;

            Panel.Controls.Clear();

            page.Dock = DockStyle.Fill;

            Panel.Controls.Add(page);
        }
    }
}
