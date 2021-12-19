using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Paint
{
    class MyRectangle: Figure
    {
        int width, height;

        public MyRectangle(int x, int y, int width, int height) : base(x, y)
        {

            this.width = width;
            this.height = height;

        }

        public override void draw(Graphics instrument)
        {
            instrument.DrawRectangle(new Pen(Color.Black), x - width / 2, y - height / 2, width, height);

        }
        
    }
}
