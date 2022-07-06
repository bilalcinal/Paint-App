using System.Drawing.Imaging;

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

        private void btn_yükle_Click(object sender, EventArgs e)
        {
            var bitmap = new Bitmap(@"C:\Users\hbila\OneDrive\Masaüstü\txt.bmp");
            g = Graphics.FromImage(bitmap);
            pic.Image = bitmap;


        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            string fileName = @"C:\Users\hbila\OneDrive\Masaüstü\txt.bmp";
            Bitmap bmp = new Bitmap(pic.ClientSize.Width, pic.ClientSize.Width);
            pic.DrawToBitmap(bmp, pic.ClientRectangle);
            bmp.Save(fileName, ImageFormat.Bmp);
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

       

        public void Doldur(Bitmap bm , int x, int y, Color new_rnk)
        {
            Color old_color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, new_rnk);
            if (old_color == new_rnk) return;

            while(pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X>0 && pt.Y>0 && pt.X<bm.Width-1 && pt.Y<bm.Height-1)
                {
                    validate(bm, pixel, pt.X - 1, pt.Y, old_color, new_rnk);
                    validate(bm, pixel, pt.X , pt.Y - 1, old_color, new_rnk);
                    validate(bm, pixel, pt.X + 1, pt.Y, old_color, new_rnk);
                    validate(bm, pixel, pt.X , pt.Y + 1, old_color, new_rnk);
                }
            }
        }
        private void validate(Bitmap bm,Stack<Point>sp,int x,int y,Color old_color,Color new_color)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx==old_color)
            {
                sp.Push(new Point(x,y));
                bm.SetPixel(x, y, new_color);

            }
        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            if (index==6)
            {
                Point point = set_point(pic, e.Location);
                Doldur(bm, point.X, point.Y, new_color);

            }
        }
        private void btn_doldur_Click(object sender, EventArgs e)
        {
            index = 6;
        }

       


    }
}