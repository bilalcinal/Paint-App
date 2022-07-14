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
            paint.Bitmap = new Bitmap(pic.Width, pic.Height);
            paint.Graphics = Graphics.FromImage(paint.Bitmap);
            paint.Graphics.Clear(Color.White);
            pic.Image = paint.Bitmap;

        }


        Paint paint = new Paint();

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint.IsPaint)
            {
                if (paint.Index == 1)
                {
                    paint.PointX = e.Location;
                    paint.Graphics.DrawLine(paint.Pen, paint.PointX, paint.PointY);
                    paint.PointY = paint.PointX;
                }
                if (paint.Index == 2)
                {
                    paint.PointX = e.Location;
                    paint.Graphics.DrawLine(paint.Eraser, paint.PointX, paint.PointY);
                    paint.PointY = paint.PointX;
                }
            }

            pic.Refresh();

            paint.X = e.X;
            paint.Y = e.Y;
            paint.StartX = e.X - paint.CoordinateX;
            paint.StartY = e.Y - paint.CoordinateY;

        }



        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint.IsPaint = true;
            paint.PointY = e.Location;
            paint.CoordinateX = e.X;
            paint.CoordinateY = e.Y;

        }



        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint.IsPaint = false;
            paint.StartX = paint.X - paint.CoordinateX;
            paint.StartY = paint.Y - paint.CoordinateY;

            if (paint.Index == 3)
            {
                paint.Graphics.DrawEllipse(paint.Pen, paint.CoordinateX, paint.CoordinateY, paint.StartX, paint.StartY);
            }
            if (paint.Index == 4)
            {
                paint.Graphics.DrawRectangle(paint.Pen, paint.CoordinateX, paint.CoordinateY, paint.StartX, paint.StartY);
            }
            if (paint.Index == 5)
            {
                paint.Graphics.DrawLine(paint.Pen, paint.CoordinateX, paint.CoordinateY, paint.X, paint.Y);
            }

        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            this.Width = 900;
            this.Height = 700;
            paint.Bitmap = new Bitmap(pic.Width, pic.Height);
            paint.Graphics = Graphics.FromImage(paint.Bitmap);
            paint.Graphics.Clear(Color.White);
            pic.Image = paint.Bitmap;
            paint.Index = 0;
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
            paint.Index = 1;
        }



        private void btn_silgi_Click(object sender, EventArgs e)
        {
            paint.Index = 2;
        }

        private void btn_elips_Click(object sender, EventArgs e)
        {
            paint.Index = 3;
        }

        private void btn_kare_Click(object sender, EventArgs e)
        {
            paint.Index = 4;
        }



        private void btn_çizgi_Click(object sender, EventArgs e)
        {
            paint.Index = 5;
        }

        private void btn_yükle_Click(object sender, EventArgs e)
        {

           
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var bitmap = new Bitmap(openFileDialog1.FileName);
                    g = Graphics.FromImage(bitmap);
                    pic.Image = bitmap;

                }
                catch
                {
                    MessageBox.Show("ERROR! Please check passphrase and do not attempt to edit cipher text");
                }
            }


        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
           
            Bitmap bmp = new Bitmap(pic.ClientSize.Width, pic.ClientSize.Width);
            pic.DrawToBitmap(bmp, pic.ClientRectangle);
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Bitmap Image (.bmp)|.bmp|Gif Image (.gif)|.gif|JPEG Image (.jpeg)|.jpeg|Png Image (.png)|.png|Tiff Image (.tiff)|.tiff|Wmf Image (.wmf)|.wmf";
            sf.ShowDialog();
            var path = sf.FileName;
            bmp.Save(path, ImageFormat.Bmp);
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (paint.IsPaint)
            {

                if (paint.Index == 3)
                {
                    g.DrawEllipse(paint.Pen, paint.CoordinateX, paint.CoordinateY, paint.StartX, paint.StartY);
                }
                if (paint.Index == 4)
                {
                    g.DrawRectangle(paint.Pen, paint.CoordinateX, paint.CoordinateY, paint.StartX, paint.StartY);
                }
                if (paint.Index == 5)
                {
                    g.DrawLine(paint.Pen, paint.CoordinateX, paint.CoordinateY, paint.X, paint.Y);
                }
            }
        }


        static Point set_point(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }



        public void Doldur(Bitmap bm, int x, int y, Color new_rnk)
        {
            Color old_color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, new_rnk);
            if (old_color == new_rnk) return;

            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    validate(bm, pixel, pt.X - 1, pt.Y, old_color, new_rnk);
                    validate(bm, pixel, pt.X, pt.Y - 1, old_color, new_rnk);
                    validate(bm, pixel, pt.X + 1, pt.Y, old_color, new_rnk);
                    validate(bm, pixel, pt.X, pt.Y + 1, old_color, new_rnk);
                }
            }
        }
        private void validate(Bitmap bm, Stack<Point> sp, int x, int y, Color old_color, Color new_color)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == old_color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, new_color);

            }
        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            if (paint.Index == 6)
            {
                Point point = set_point(pic, e.Location);
                Doldur(paint.Bitmap, point.X, point.Y, new_color);

            }
        }
        private void btn_doldur_Click(object sender, EventArgs e)
        {
            paint.Index = 6;
        }




    }
}