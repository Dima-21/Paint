using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        Point Mouse_Point;
        bool isMouseDown;
        Field field = new Field();
        List<Point> points = new List<Point>();
        public Form1()
        {
            InitializeComponent();
            isMouseDown = false;
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Black, field.Line1.Point1, field.Line1.Point2);
            e.Graphics.DrawLine(Pens.Black, field.Line2.Point1, field.Line2.Point2);
            e.Graphics.DrawLine(Pens.Black, field.Line3.Point1, field.Line3.Point2);
            e.Graphics.DrawLine(Pens.Black, field.Line4.Point1, field.Line4.Point2);
            foreach (var item in points)
            {
                e.Graphics.DrawEllipse(new Pen(Color.Red, 5), item.X, item.Y, 0.5f, 0.5f);
            }
        }



        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Invalidate();
                points.Add(e.Location);
            }
        }

        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
     
        }
    }
}
