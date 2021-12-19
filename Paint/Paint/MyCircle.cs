using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Paint
{
    class MyCircle : Figure
    {
        public int rad;

        public MyCircle(int x, int y, int rad) : base(x, y)
        {

            this.rad = rad;

        }
        public override void draw(Graphics instrument)
        {
            instrument.DrawEllipse(new Pen(Color.Black), x - rad, y - rad, rad * 2, rad * 2);
        }
        
    
    }
}
