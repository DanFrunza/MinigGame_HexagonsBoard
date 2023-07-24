using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect7
{
    internal class HexFractal
    {
        float q, r, s;
        public int size = 30;
        int w = 1000;
        int h = 640;


        public HexFractal pixel_to_hex(Point point)
        {



            float q = (float)(2 * (this.h / 2 - point.Y) / 3) / this.size;
            float r = (float)(((Math.Sqrt(3) * (this.w / 2-point.X)) / 3 - (this.h/2 - point.Y) / 3) / this.size);
            float s = -q - r;
            return new HexFractal(q, r, s);

        }

        public HexFractal(float q, float r, float s)
        {
            this.q = q;
            this.r = r;
            this.s = s;
        }

        public HexFractal(float q, float r)
        {
            this.q = q;
            this.r = r;
            this.s = -q - r;
        }

        public HexFractal(HexFractal hex)
        {
            this.q = hex.Q;
            this.r = hex.R;
            this.s = hex.S;
        }


        public float Q
        {
            get { return q; }
            set { q = value; }
        }

        public float S
        {
            get { return s; }
            set { s = value; }
        }

        public float R
        {
            get { return r; }
            set { r = value; }
        }

    }
}
