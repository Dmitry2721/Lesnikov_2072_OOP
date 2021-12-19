using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum Figs
        {
            None,
            circle,
            rect,
            wagon,
            train,
            coal,
            sand
        }
        Figs fig;

        private void Circle_Click(object sender, EventArgs e)
        {
            fig = Figs.circle;
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            fig = Figs.rect;
        }

        private void Wagon_Click(object sender, EventArgs e)
        {
            fig = Figs.wagon;
        }

        private void Coal_Click(object sender, EventArgs e)
        {
            fig = Figs.coal;
        }

        private void Sand_Click(object sender, EventArgs e)
        {
            fig = Figs.sand;
        }

        private void Train_Click(object sender, EventArgs e)
        {
            fig = Figs.train;
        }

        private bool IsInt(string str)
        {
            return Int32.TryParse(str, out int a);
        }
        List<Figure> figures = new List<Figure>();

        private void DrawPanel_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            if (fig == Figs.circle && IsInt(Radius.Text))
            {
                figures.Add(new MyCircle(x, y, Convert.ToInt32(Radius.Text)));
            }
            if (fig == Figs.rect && IsInt(Weight.Text) && IsInt(Height.Text))
            {
                figures.Add(new MyRectangle(x, y, Convert.ToInt32(Weight.Text), Convert.ToInt32(Height.Text)));
            }
            if (fig == Figs.wagon && IsInt(Weight.Text) && IsInt(Height.Text))
            {
                figures.Add(new MyWagon(x, y, Convert.ToInt32(Weight.Text), Convert.ToInt32(Height.Text)));
            }
            if (fig == Figs.coal && IsInt(Weight.Text) && IsInt(Height.Text))
            {
                figures.Add(new MyWagonCoal(x, y, Convert.ToInt32(Weight.Text), Convert.ToInt32(Height.Text)));
            }
            if (fig == Figs.sand && IsInt(Weight.Text) && IsInt(Height.Text))
            {
                figures.Add(new MyWagonSand(x, y, Convert.ToInt32(Weight.Text), Convert.ToInt32(Height.Text)));
            }
            if (fig == Figs.train && IsInt(Weight.Text) && IsInt(Height.Text) && IsInt(Count.Text))
            {
                figures.Add(new MyTrain(x, y, Convert.ToInt32(Weight.Text), Convert.ToInt32(Height.Text), Convert.ToInt32(Count.Text)));
            }
            DrawPanel.Refresh();
        }

        private void DrawPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics instrument = DrawPanel.CreateGraphics();
            foreach (Figure figure in figures)
                figure.draw(instrument);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            figures = new List<Figure>();
            DrawPanel.Refresh();
        }
    }
}
