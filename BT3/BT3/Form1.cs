using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Text = DateTime.Now.ToString("HH:mm:ss");
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        bool up = false;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (up)
            { pictureBox1.Top -= 20; }
            else { pictureBox1.Top += 20; }
            pictureBox1.Left += 50;
            up = !up;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = checkBox1.Checked;
            timer2.Enabled = checkBox1.Checked;
        }
    }
}
