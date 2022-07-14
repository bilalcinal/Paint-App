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
            try
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Bir Hata meydana geldi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                paint.IsPaint = true;
                paint.PointY = e.Location;
                paint.CoordinateX = e.X;
                paint.CoordinateY = e.Y;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata meydana geldi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            try
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata meydana geldi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            try
            {
                this.Width = 900;
                this.Height = 700;
                paint.Bitmap = new Bitmap(pic.Width, pic.Height);
                paint.Graphics = Graphics.FromImage(paint.Bitmap);
                paint.Graphics.Clear(Color.White);
                pic.Image = paint.Bitmap;
                paint.Index = 0;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata meydana geldi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_renk_Click(object sender, EventArgs e)
        {
            try
            {
                paint.ColorDialog.ShowDialog();
                paint.Color = paint.ColorDialog.Color;
                pic_renk.BackColor = paint.ColorDialog.Color;
                paint.Pen.Color = paint.ColorDialog.Color;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata meydana geldi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_kalem_Click(object sender, EventArgs e)
        {
            try
            {
                paint.Index = 1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata meydana geldi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void btn_silgi_Click(object sender, EventArgs e)
        {
            try
            {
                paint.Index = 2;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata meydana geldi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_elips_Click(object sender, EventArgs e)
        {
            try
            {
                paint.Index = 3;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata meydana geldi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_kare_Click(object sender, EventArgs e)
        {
            try
            {
                paint.Index = 4;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata meydana geldi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void btn_çizgi_Click(object sender, EventArgs e)
        {
            try
            {
                paint.Index = 5;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata meydana geldi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_yükle_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    var bitmap = new Bitmap(openFileDialog1.FileName);
                    paint.Graphics = Graphics.FromImage(bitmap);
                    pic.Image = bitmap;
                    paint.Bitmap = bitmap;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Yüklerken bir Hata meydana geldi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap bmp = new Bitmap(pic.ClientSize.Width, pic.ClientSize.Width);
                pic.DrawToBitmap(bmp, pic.ClientRectangle);
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Bitmap Image (.bmp)|.bmp|Gif Image (.gif)|.gif|JPEG Image (.jpeg)|.jpeg|Png Image (.png)|.png|Tiff Image (.tiff)|.tiff|Wmf Image (.wmf)|.wmf";
                if (sf.ShowDialog() != DialogResult.Cancel)
                {
                    var path = sf.FileName;
                    bmp.Save(path, ImageFormat.Bmp);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Kayýt edilirken bir Hata meydana geldi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata meydana geldi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        static Point set_point(PictureBox pb, Point pt)
        {
            try
            {
                float pX = 1f * pb.Image.Width / pb.Width;
                float pY = 1f * pb.Image.Height / pb.Height;
                return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata meydana geldi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new Point(0,0);
            }

        }



        public void Doldur(Bitmap bm, int x, int y, Color new_rnk)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata meydana geldi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }
        private void validate(Bitmap bm, Stack<Point> sp, int x, int y, Color old_color, Color new_color)
        {
            try
            {
                Color cx = bm.GetPixel(x, y);
                if (cx == old_color)
                {
                    sp.Push(new Point(x, y));
                    bm.SetPixel(x, y, new_color);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata meydana geldi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (paint.Index == 6)
                {
                    Point point = set_point(pic, e.Location);
                    Doldur(paint.Bitmap, point.X, point.Y, paint.Color);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata meydana geldi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void btn_doldur_Click(object sender, EventArgs e)
        {
            try
            {
                paint.Index = 6;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata meydana geldi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }




    }
}