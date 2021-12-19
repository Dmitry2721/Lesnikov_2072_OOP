using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
namespace Paint
{
    class MyWagon: MyRectangle
    {
        public int width;
        public int height;
        MyCircle koleso1;
        MyCircle koleso2;
        public MyWagon(int x, int y, int width, int height) : base(x, y - 2 * height / 10, width, 3 * height / 5)
        {
            this.width = width;
            this.height = height;

            koleso1 = new MyCircle(x - width / 4, y + height / 3, height / 6);
            koleso2 = new MyCircle(x + width / 4, y + height / 3, height / 6);
        }
        public override void draw(Graphics instrument)
        {
            base.draw(instrument);
            koleso1.draw(instrument);
            koleso2.draw(instrument);
        }
        
    }
}
