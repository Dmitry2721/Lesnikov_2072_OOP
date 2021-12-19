using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
namespace Paint
{
    class MyTrain: Figure
    {
        static Random rnd;
        List<MyWagon> list;
        public int Count
        {
            get
            {
                return list.Count;
            }
        }
        int gap;
        public MyTrain(int x, int y, int width, int height, int count) : base(x, y)
        {

            gap = width / 10;
            rnd = new Random();
            list = new List<MyWagon>();
            int t = rnd.Next(3);
            if (t == 0)
                for (int i = 0; i < count; i++)
                {
                    list.Add(new MyWagon(x + (width + gap) * i, y, width, height));
                }
            if (t == 1)
                for (int i = 0; i < count; i++)
                {
                    list.Add(new MyWagonCoal(x + (width + gap) * i, y, width, height));
                }
            if (t == 2)
                for (int i = 0; i < count; i++)
                {
                    list.Add(new MyWagonSand(x + (width + gap) * i, y, width, height));
                }
        }
        public override void draw(Graphics instrument)
        {
            foreach (MyWagon i in list)
                i.draw(instrument);
        }
    }
}
