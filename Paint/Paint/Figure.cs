using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Paint
{
    abstract class Figure
    {
        public int x;
        public int y;


        public Figure(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public virtual void draw(Graphics instrument)
        {
        }
        
        
    }
}
