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


        }

        private void feld1_Load(object sender, EventArgs e)
        {

        }
    }
}
