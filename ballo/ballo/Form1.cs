using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ballo
{
    public partial class Form1 : Form
    {
        bool goingDown = true;
        public Form1()
        {
            InitializeComponent();
            Moving();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void Moving()
        {
            int speed = 7;           
            int topLimit = 20;      
            int bottomLimit = 300;  

            while (true)  // loop vô hạn
            {
                if (goingDown)
                {
                    pictureBox1.Top += speed;
                    if (pictureBox1.Top >= bottomLimit)
                        goingDown = false;
                }
                else
                {
                    pictureBox1.Top -= speed;
                    if (pictureBox1.Top <= topLimit)
                        goingDown = true;
                }

                await Task.Delay(20);
            }
        }

        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

    }
}
