using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CadastroPessoal.Shared
{
    public static class DesignTemplate
    {
        public static Color primaryColor = Color.FromArgb(196,191,191);
        public static Color secondaryColor = Color.FromArgb(204, 144, 144);
        public static Color spotlightColor = Color.FromArgb(255, 253, 59);
        public static Color unfocusedtColor = Color.FromArgb(178,178,114);


        public static void onButtonSaveMouseEnter(object sender, EventArgs e)
        {
            Control element = (Control) sender;
            element.BackColor = Color.Green;
        }

        public static void onButtonMouseLeave(object sender, EventArgs e)
        {
            Control element = (Control)sender;
            element.BackColor = Color.Transparent;
        }

        public static void onButtonWarningMouseEnter(object sender, EventArgs e)
        {
            Control element = (Control)sender;
            element.BackColor = Color.Black;
        }

        public static void onToolStripMouseEnter(object sender, EventArgs e)
        {
            ToolStripItem element = (ToolStripItem)sender;
            element.BackColor = spotlightColor;
            element.ForeColor = unfocusedtColor;
        }

        public static void onToolStripMouseLeave(object sender, EventArgs e)
        {
            ToolStripItem element = (ToolStripItem)sender;
            element.BackColor = Color.Transparent;
            element.ForeColor = Color.White;
        }
    }
}
