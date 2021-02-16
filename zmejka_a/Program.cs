using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zmejka_a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            HorizontalLine Upline = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine Downline = new HorizontalLine(0, 78, 24, '+');
            VerticalLine Leftline = new VerticalLine(0, 24, 0, '+');
            VerticalLine Rightline = new VerticalLine(0, 24, 78, '+');
            Upline.Drow();
            Downline.Drow();
            Leftline.Drow();
            Rightline.Drow();


            Point p1 = new Point(1,3,'*');
            snake snake = new snake(p1, 4, Direction.RIGHT);
        }
    }
}
