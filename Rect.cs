using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _1.draw
{
    class Rect : Shape
    {
        protected int Width { get; set; }
        protected int Height { get; set; }

        protected Rectangle rectangle;
        public Rect(Pen pen, Point first, Point second) : base(pen, first, second)
        {
            if (SecondPoint.X > FirstPoint.X && SecondPoint.Y > FirstPoint.Y)                   //4 quarter
                rectangle = new Rectangle(FirstPoint.X, FirstPoint.Y, SecondPoint.X - FirstPoint.X, SecondPoint.Y - FirstPoint.Y);
            else if (SecondPoint.X < FirstPoint.X && SecondPoint.Y > FirstPoint.Y)              //3 quarter
                rectangle = new Rectangle(SecondPoint.X, FirstPoint.Y, FirstPoint.X - SecondPoint.X, SecondPoint.Y - FirstPoint.Y);
            else if (SecondPoint.X > FirstPoint.X && SecondPoint.Y < FirstPoint.Y)              //2 quarter
                rectangle = new Rectangle(FirstPoint.X, SecondPoint.Y, SecondPoint.X - FirstPoint.X, FirstPoint.Y - SecondPoint.Y);
            else                                                                                //1 quarter
                rectangle = new Rectangle(SecondPoint.X, SecondPoint.Y, FirstPoint.X - SecondPoint.X, FirstPoint.Y - SecondPoint.Y);
        }

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(pen, rectangle);
        }
    }
}
