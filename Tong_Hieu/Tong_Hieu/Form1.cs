using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tong_Hieu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban muon thoat?", "Confirm Box", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                Close();
            else if (result == DialogResult.No)
                MessageBox.Show("Vay hay tiep tuc su dung");
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong;
            tong = int.Parse(txtA.Text) + int.Parse(txtB.Text);
            lblKetQua.Text = txtA.Text + " + " + txtB.Text+ " = " + tong + "";
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            int hieu;
            hieu = int.Parse(txtA.Text) - int.Parse(txtB.Text);
            lblKetQua.Text = txtA.Text + " - " + txtB.Text + " = " + hieu + "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Ban co chac?", 
                "Confirm", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                lblKetQua.Text = "";
                txtB.Text = "";
                txtA.Text = "";
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Tọa độ tâm và kích thước ngôi sao
            int centerX = 200;
            int centerY = 200;
            int outerRadius = 100;  // bán kính ngoài
            int innerRadius = 40;   // bán kính trong

            // Tạo mảng chứa 10 điểm (5 ngoài + 5 trong)
            PointF[] points = new PointF[10];
            double angle = -Math.PI / 2; // bắt đầu từ đỉnh trên

            for (int i = 0; i < 10; i++)
            {
                double r = (i % 2 == 0) ? outerRadius : innerRadius;
                points[i] = new PointF(
                    (float)(centerX + r * Math.Cos(angle)),
                    (float)(centerY + r * Math.Sin(angle))
                );
                angle += Math.PI / 5; // mỗi bước 36°
            }

            // Vẽ ngôi sao
            Pen pen = new Pen(Color.Red, 2);
            Brush brush = new SolidBrush(Color.Gold);

            g.FillPolygon(brush, points);   // tô màu
            g.DrawPolygon(pen, points);     // viền ngoài

            pen.Dispose();
            brush.Dispose();
        }
    }
}
