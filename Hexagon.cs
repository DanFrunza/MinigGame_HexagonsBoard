using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect7
{
    internal class Hex
    {
        private int q, r, s;
        public int size = 30;
        int w = 1000;
        int h = 640;
        public Point centru;
        private bool valid=true;
        public bool start=false;
        public bool finish=false;
        public int val =-1;
        Image imgP;
        public int Score = 0;
        public int Obiect; 
        //1=obstacol, 2=score5, 3=score10, 4=score15, 5=score=-10, 6=score-15, 7=inchis, 8=deshis 


        public Hex(int q, int r, int s)
        {

            this.q = q;
            this.r = r;
            this.s = s;
            this.centru.X = (int)(this.w / 2 + this.size * ((float)(Math.Sqrt(3) * this.R + Math.Sqrt(3) / 2 * this.Q)));
            this.centru.Y = (int)(this.h / 2 + ((3 * this.size) / 2) * this.Q);

        }

        public Hex(int q, int r)
        {
            this.q = q;
            this.r = r;
            this.s = -q - r;
            this.centru.X = (int)(this.w / 2 + this.size * ((float)(Math.Sqrt(3) * this.R + Math.Sqrt(3) / 2 * this.Q)));
            this.centru.Y = (int)(this.h / 2 + ((3 * this.size) / 2) * this.Q);
        }

        public Hex(Hex hex)
        {
            this.q = hex.Q;
            this.r = hex.R;
            this.s = hex.S;
            this.centru.X = (int)(this.w / 2 + this.size * ((float)(Math.Sqrt(3) * this.R + Math.Sqrt(3) / 2 * this.Q)));
            this.centru.Y = (int)(this.h / 2 + ((3 * this.size) / 2) * this.Q);
        }

        public bool Valid
        {
            get { return valid; }
            set { valid = value; }
        }

        public int Q
        {
            get { return q; }
            set { q = value; }
        }

        public int S
        {
            get { return s; }
            set { s = value; }
        }

        public int R
        {
            get { return r; }
            set { r = value; }
        }

        public Point hex_to_pixel()
        {
            Point F = new Point();
            F.X = (int)(this.w / 2 + this.size * ((float)(Math.Sqrt(3) * this.R + Math.Sqrt(3) / 2 * this.Q)));
            F.Y = (int)(this.h / 2 + ((3 * this.size) / 2) * this.Q);

            return F;

        }


        public Hex pixel_to_hex(Point point)
        {

            HexFractal A = new HexFractal(0, 0, 0);
            HexFractal frac = A.pixel_to_hex(point);

            double q = Math.Round(frac.Q);
            double r = Math.Round(frac.R);
            double s = Math.Round(frac.S);

            double q_diff = Math.Abs(q - frac.Q);
            double r_diff = Math.Abs(r - frac.R);
            double s_diff = Math.Abs(s - frac.S);

            if (q_diff > r_diff && q_diff > s_diff)
            {
                q = -r - s;
            }
            else if (r_diff > s_diff)
            {
                r = -q - s;
            }
            else
            {
                s = -q - r;
            }

            return new Hex(-(int)q, -(int)r, -(int)s);


        }

        public Point Varf(int i)
        {
            
            double angle_deg = 60 * i - 30;
            double angle_rad = Math.PI / 180 * angle_deg;
            return new Point((int)(this.centru.X + this.size * Math.Cos(angle_rad)), (int)(this.centru.Y + this.size * Math.Sin(angle_rad)));

        }


        public Point[] Varfuri()
        {
            Point point0 = this.Varf(0);
            Point point1 = this.Varf(1);
            Point point2 = this.Varf(2);
            Point point3 = this.Varf(3);
            Point point4 = this.Varf(4);
            Point point5 = this.Varf(5);
            Point[] Varfuri = { point0, point1, point2, point3, point4, point5 };

            return Varfuri;
        }

        public Hex hex_add(Hex hex, Hex vec)
        {
            return new Hex(hex.Q + vec.Q, hex.R + vec.R, hex.S + vec.S);
        }

        public Hex hex_neighbor(Hex hex, Hex direction)
        {
            return hex_add(hex, direction);
        }

        public List<Hex> All_neighbors()
        {
            List<Hex> List = new List<Hex> { };

            Hex Directia0 = new Hex(+1, 0, -1);
            Hex Directia1 = new Hex(+1, -1, 0);
            Hex Directia2 = new Hex(0, -1, +1);
            Hex Directia3 = new Hex(-1, 0, +1);
            Hex Directia4 = new Hex(-1, +1, 0);
            Hex Directia5 = new Hex(0, +1, -1);


            Hex list0 = hex_neighbor(this, Directia0);
            Hex list1 = hex_neighbor(this, Directia1);
            Hex list2 = hex_neighbor(this, Directia2);
            Hex list3 = hex_neighbor(this, Directia3);
            Hex list4 = hex_neighbor(this, Directia4);
            Hex list5 = hex_neighbor(this, Directia5);
            List.Add(list0);
            List.Add(list1);
            List.Add(list2);
            List.Add(list3);
            List.Add(list4);
            List.Add(list5);

            return List;
        }

        public List<Hex> All_Direction()
        {
            List<Hex> List = new List<Hex> { };

            Hex Directia0 = new Hex(+1, 0, -1);
            Hex Directia1 = new Hex(+1, -1, 0);
            Hex Directia2 = new Hex(0, -1, +1);
            Hex Directia3 = new Hex(-1, 0, +1);
            Hex Directia4 = new Hex(-1, +1, 0);
            Hex Directia5 = new Hex(0, +1, -1);

            List.Add(Directia0);
            List.Add(Directia1);
            List.Add(Directia2);
            List.Add(Directia3);
            List.Add(Directia4);
            List.Add(Directia5);

            return List;
        }

        public Hex hex_subtract(Hex a, Hex b)
        {
            return new Hex(a.Q - b.Q, a.R - b.R, a.S - b.S);
        }

        public double hex_distance(Hex a, Hex b)
        {
            Hex vec = hex_subtract(a, b);
            return (Math.Abs(vec.Q) + Math.Abs(vec.R) + Math.Abs(vec.S)) / 2;
        }

        public void deseneazaHexagon(Graphics g)
        {

            


            if (this.Obiect ==1) this.valid = false;

            Pen blackPen = new Pen(Color.Black, 3);
            Point[] Varfuri = this.Varfuri();

            Brush brushh = new SolidBrush(Color.YellowGreen);
            g.FillPolygon(brushh, Varfuri);


            if (this.valid == false)
            {
                Brush brush = new SolidBrush(Color.DarkSlateGray);
                g.FillPolygon(brush, Varfuri);

            }

            if (this.Obiect==1)
            {
                this.imgP = Properties.Resources.Obstacol;
                g.DrawImage(imgP, this.centru.X - 20, this.centru.Y - 20);

            }

            if(this.Obiect==2)
            {
                this.imgP = Properties.Resources.Score5;
                g.DrawImage(imgP, this.centru.X - 20, this.centru.Y - 20);
            }
            if (this.Obiect==3)
            {
                this.imgP = Properties.Resources.Score10;
                g.DrawImage(imgP, this.centru.X - 20, this.centru.Y - 20);
            }

            if (this.Obiect==4)
            {
                this.imgP = Properties.Resources.Score15;
                g.DrawImage(imgP, this.centru.X - 20, this.centru.Y - 20);
            }

            if (this.Obiect==5)
            {
                this.imgP = Properties.Resources.Score_10;
                g.DrawImage(imgP, this.centru.X - 20, this.centru.Y - 20);
            }

            if (this.Obiect==6)
            {
                this.imgP = Properties.Resources.Score_15;
                g.DrawImage(imgP, this.centru.X - 20, this.centru.Y - 20);
            }

            if (this.Obiect==7)
            {
                this.imgP = Properties.Resources.Cufar_inchis;
                g.DrawImage(imgP, this.centru.X - 20, this.centru.Y - 20);
            }

            if (this.Obiect==8)
            {
                this.imgP = Properties.Resources.Cufar_deschis;
                g.DrawImage(imgP, this.centru.X - 20, this.centru.Y - 20);
            }

            if(this.val==-4 || this.val==-5)
            {
                this.imgP = Properties.Resources.Portal;
                g.DrawImage(imgP, this.centru.X - 20, this.centru.Y - 20);

            }

            if (this.start == true)
            {
                this.imgP = Properties.Resources.StartHexagon;
                g.DrawImage(imgP, this.centru.X - 20, this.centru.Y - 20);
            }
            
            if(this.finish==true)
            {
                this.imgP = Properties.Resources.Finish;
                g.DrawImage(imgP, this.centru.X - 20, this.centru.Y - 20);
            }
            

            g.DrawPolygon(blackPen, Varfuri);
            


            

        }


    }
}
