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
        int x, y, sX, sY, cX, cY;

        ColorDialog cd = new ColorDialog();
        Color new_color;

       

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

            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;

        }

       

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;
            cX = e.X;
            cY = e.Y;

        }

      

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            sX = x - cX;
            sY = y - cY;

            if (index==3)
            {
                g.DrawEllipse(p, cX, cY, sX, sY);
            }
            if (index==4)
            {
                g.DrawRectangle(p, cX, cY, sX, sY);
            }
            if (index==5)
            {
                g.DrawLine(p,cX,cY,x,y);
            }
         
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pic.Image = bm;
            index = 0;
        }

        private void btn_renk_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            new_color = cd.Color;
            pic_renk.BackColor = cd.Color;
            p.Color = cd.Color;
        }

        private void btn_kalem_Click(object sender, EventArgs e)
        {
            index = 1;
        }

       

        private void btn_silgi_Click(object sender, EventArgs e)
        {
            index = 2;
        }
        
        private void btn_elips_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void btn_kare_Click(object sender, EventArgs e)
        {
            index = 4;
        }
        private void btn_çizgi_Click(object sender, EventArgs e)
        {
            index = 5;
        }
        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (paint)
            {

                if (index == 3)
                {
                    g.DrawEllipse(p, cX, cY, sX, sY);
                }
                if (index == 4)
                {
                    g.DrawRectangle(p, cX, cY, sX, sY);
                }
                if (index == 5)
                {
                    g.DrawLine(p, cX, cY, x, y);
                }
            }
        }
        static Point set_point(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X*pX),(int)(pt.Y*pY));
        }

        private void renk_paleti_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = set_point(renk_paleti, e.Location);
            pic_renk.BackColor = ((Bitmap)renk_paleti.Image).GetPixel(point.X, point.Y);
            new_color = pic_renk.BackColor;
            p.Color = pic_renk.BackColor;
        }

    }
}