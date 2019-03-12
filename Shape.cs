using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _1.draw
{
    enum Shapes
    {
        Line = 1,
        Rect,
        Circle
    }
    abstract class Shape
    {
        public Point FirstPoint { get; set; }
        public Point SecondPoint { get; set; }
        public Pen pen { get; set; }

        public Shape(Pen pen, Point first, Point second)
        {
            this.pen = pen;
            this.FirstPoint = first;
            this.SecondPoint = second;
        }

        public abstract void Draw(Graphics g);
    }
}
