
namespace Paint_App
{
    public class Paint
    {
        public Paint()
        {
            Pen = new Pen(Color.Black, 1);
            Eraser = new Pen(Color.White, 40);
            ColorDialog = new ColorDialog();
        }
        public Bitmap Bitmap { get; set; }
        public Graphics Graphics { get; set; }
        public bool IsPaint { get; set; }
        public Point PointX { get; set; }
        public Point PointY { get; set; }
        public Pen Pen { get; set; }
        public Pen Eraser { get; set; }
        public int Index { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int StartX { get; set; }
        public int StartY { get; set; }
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }
        public ColorDialog ColorDialog { get; set; }
        public Color Color { get; set; }
    }
}
