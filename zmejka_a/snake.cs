using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zmejka_a
{
    class snake:Figura
    {
        public snake(Point tail, int leight, Direction direction)
        {
            for (int i = 0; i < leight; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
               //pList.Add( p );
                
            }
        }
    }
}
