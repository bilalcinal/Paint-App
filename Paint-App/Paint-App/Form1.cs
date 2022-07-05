namespace Paint_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Width = 900;
            this.Height = 700;
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;
            
        }
        
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p =new Pen(Color.Black,1);
        Pen erase = new Pen(Color.White, 40);
        int index;

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index==1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;
                }
            }

            pic.Refresh();

        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

        }

        private void btn_kalem_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void btn_silgi_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

        }

        
    }
}