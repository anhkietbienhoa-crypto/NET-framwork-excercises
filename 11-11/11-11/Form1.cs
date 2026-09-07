using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace _11_11
{
    public partial class mainForm : Form
    {
      
        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            string text = "Xin chào";
            using (Font font = new Font("Times New Roman", 30, FontStyle.Italic))
            using (Brush brush = Brushes.DarkBlue)
            {
                SizeF sz = g.MeasureString(text, font);
                float x = (this.ClientSize.Width - sz.Width) / 2f;
                float y = (this.ClientSize.Height - sz.Height) / 2f;
                g.DrawString(text, font, brush, x, y);
            }
                  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
