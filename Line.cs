using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _1.draw
{
    class Line : Shape
    {
        public Line(Pen pen, Point first, Point second) : base(pen, first, second)
        {
            
        }
        public override void Draw(Graphics g)
        {
            g.DrawLine(pen, FirstPoint, SecondPoint);
        }
    }
}
