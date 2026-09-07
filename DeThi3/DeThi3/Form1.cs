using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeThi3
{
    public partial class Form1 : Form
    {
        Thread t1, t2;
        bool isRunning = false;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isRunning) return;

            isRunning = true;

            t1 = new Thread(RunLeft);
            t2 = new Thread(RunRight);

            t1.Start();
            t2.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isRunning = false;

            int value = int.Parse(lblLeft.Text + lblRight.Text);

            if (value > 50)
                MessageBox.Show("Pass", "Result", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show("Failed", "Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        void RunLeft()
        {
            while (isRunning)
            {
                int n = rand.Next(1, 10);

                Invoke(new Action( () => { lblLeft.Text = n.ToString();  }));

                Thread.Sleep(100);
            }
        }


        void RunRight()
        {
            while (isRunning)
            {
                int n = rand.Next(0, 10);

                Invoke(new Action( () => { lblRight.Text = n.ToString();  }));
                
                Thread.Sleep(100);
            }
        }
        
    }
}
