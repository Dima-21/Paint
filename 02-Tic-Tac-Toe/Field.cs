using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Tic_Tac_Toe
{
    class Field
    {
        public Line Line1 { get; set; }
        public Line Line2 { get; set; }
        public Line Line3 { get; set; }
        public Line Line4 { get; set; }

        public Field()
        {
            Line1 = new Line { Point1 = new Point(80, 20), Point2 = new Point(80, 120) };
            Line2 = new Line { Point1 = new Point(130, 20), Point2 = new Point(130, 120) };
            Line3 = new Line { Point1 = new Point(40, 50), Point2 = new Point(170, 50) };
            Line4 = new Line { Point1 = new Point(40, 90), Point2 = new Point(170, 90) };
        }
    }
}

