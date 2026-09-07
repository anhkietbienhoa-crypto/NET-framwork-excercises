namespace _25_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Rectangle rect = new Rectangle(50, 50, 100, 60);
        bool isDragging = false;
        Point offset;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Brush brush = new SolidBrush(Color.Red);
            g.FillRectangle(brush, rect);
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

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (rect.Contains(e.Location))
            {
                isDragging = true;
                offset = new Point(e.X - rect.X, e.Y - rect.Y);
                Cursor = Cursors.Hand;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            Cursor = Cursors.Default;
        }
    }
}
