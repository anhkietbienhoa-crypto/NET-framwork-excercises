using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_11
{
    public partial class Form1 : Form
    {
        int soBanh = 1;
        int r;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Pen pen = new Pen(Color.Blue, 2);
            g.DrawEllipse(pen, 50, 150, 100, 100);

            Random rnd = new Random();
            for(int i = 0; i < soBanh; i++)
            {
                int x = rnd.Next(r, ClientSize.Width -r + 1);
                int y = rnd.Next(r, ClientSize.Height -r + 1);
                g.FillEllipse(Brushes.Blue, x - r, y - r, 2 * r, 2 * r);
            }
            cx = rnd.Next(r, ClientSize.Width - r + 1);
            cy = rnd.Next(r, ClientSize.Height - r + 1);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            soBanh++;
            if (soBanh > 15)
            {
                timer1.Enabled = false;
                MessageBox.Show()
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            r = ClientSize.Height / 16;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
