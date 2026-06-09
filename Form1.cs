namespace TicTacHoe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen stiffy = new Pen(Color.Magenta, 4);
            stiffy.Width = 10;
            int w = this.ClientSize.Width;
            int h = this.ClientSize.Height;

            int x1; int y1;
            int x2; int y2;

            g.DrawLine(stiffy, x1 = 0, y1 = 200, x2 = 650, y2 = 200);
            g.DrawLine(stiffy, x1 = 0, y1 = 400, x2 = 650, y2 = 400);
            g.DrawLine(stiffy, x1 = 220, y1 = 000, x2 = 220, y2 = 600);
            g.DrawLine(stiffy, x1 = 42 y1 = 000, x2 = 425, y2 = 600);


        }
    }
}
