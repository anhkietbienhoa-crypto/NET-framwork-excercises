using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeThi2
{
    public partial class Form1 : Form
    {
        Rectangle rect = new Rectangle(10, 10, 60, 40);
        Color rectColor = Color.Red;

        bool isDragging = false;
        Point offset;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(rectColor))
            {
                e.Graphics.FillRectangle(brush, rect);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (rect.Contains(e.Location))
            {
                isDragging = true;
                offset = new Point(e.X - rect.X, e.Y - rect.Y);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                rect.X = e.X - offset.X;
                rect.Y = e.Y - offset.Y;

                Invalidate();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
                rectColor = Color.Red;
            else if (e.KeyCode == Keys.G)
                rectColor = Color.Green;
            else if (e.KeyCode == Keys.B)
                rectColor = Color.Blue;

            Invalidate();
        }
    }
}
