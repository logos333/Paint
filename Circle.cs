using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _1.draw
{
    class Circle : Rect
    {
        public Circle(Pen pen, Point first, Point second) : base(pen, first, second)
        {

        }

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(pen, rectangle);
        }
    }
}
