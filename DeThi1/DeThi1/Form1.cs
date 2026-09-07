using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace DeThi1
{
    public partial class Form1 : Form
    {
        List<string> validCodes = new List<string>();
        public Form1()
        {
            InitializeComponent();
            KhoiTaoMaHopLe();
        }

        void KhoiTaoMaHopLe()
        {
            validCodes.Add("1523");
            validCodes.Add("1627");

            for (int i = 3106; i <= 3120; i++)
                validCodes.Add(i.ToString());
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string code = textBox1.Text;
            string time = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            if (validCodes.Contains(code))
            {
                listBox1.Items.Insert(0, $"{time} Access granted");
            }
            else
            {
                listBox1.Items.Insert(0, $"{time} Access denied");
            }

            textBox1.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            textBox1.Text += btn.Text;
        }
    }
}
