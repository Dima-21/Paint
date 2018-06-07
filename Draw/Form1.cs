using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        MyLine Line;
        List<MyLine> Lines = new List<MyLine>();
        public Form1()
        {
            InitializeComponent();
        }
        private void RandomLine()
        {
            switch (rand.Next(0, 4))
            {
                case 0:
                    Line.p1 = new Point(0, rand.Next(0, this.ClientSize.Height));
                    break;
                case 1:
                    Line.p1 = new Point(rand.Next(0, this.ClientSize.Width), rand.Next(0, 0));
                    break;
                case 2:
                    Line.p1 = new Point(rand.Next(0, this.ClientSize.Width), this.ClientSize.Height);
                    break;
                case 3:
                    Line.p1 = new Point(this.ClientSize.Width, rand.Next(0, this.ClientSize.Height));
                    break;
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Black, Line.p1, Line.p2);
            foreach (var item in Lines)
            {
                e.Graphics.DrawLine(Pens.Black, item.p1, item.p2);
            }
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                Line.p2 = e.Location;
                RandomLine();
                Lines.Add(Line);
            }
            Invalidate();
        }
    }
}
