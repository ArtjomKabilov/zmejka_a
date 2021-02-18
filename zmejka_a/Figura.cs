using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zmejka_a
{
    class Figura
    {
        protected List<Point> pList;


        public void Drow()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
