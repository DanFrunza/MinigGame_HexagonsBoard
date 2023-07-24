using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect7
{
    internal class Pion
    {
        Image imgP;
        int x, y;
        
        

        public Pion(int x, int y)
        {
            this.x = x;
            this.y = y;
           


            imgP = Properties.Resources.Pion;
        }

        public void deseneaza(Graphics g)
        {
            g.DrawImage(imgP, x, y);
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public bool este_deasupra(int x, int y)
        {
            if (x > this.x + 30 || x < this.x - 30) return false;
            if (y > this.y + 30 || y < this.y - 30) return false;

            return true;
        }

    }
}
