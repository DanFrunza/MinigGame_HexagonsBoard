using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Proiect7
{

    

    internal class TablaHexagon
    {
        int w, h;
        public Graphics g;
        Hex hex = new Hex(0, 0, 0);
        public Board B;
        public List<Hex> BoardJoc;
        public Pion pion;
        public Hex PozStart;
        public int dx, dy;
        public int Score = 0;
        public int dim;
        public int Pasi = 0;
        public bool Final = false;
        public bool Finall = false;
        public bool Finalll = false;
        public bool Finallll = false;
        public int dificultate;
        public int pasi;

        public TablaHexagon(int w, int h, int dim,int dificultate,int Pasi, Graphics g)
        {
            this.pasi = Pasi;
            this.dificultate = dificultate;
            this.g = g;
            Point F = new Point(w / 2, h / 2);
            this.w = w;
            this.h = h;
            this.dim = dim;
            this.B = new Board(dim);
            if(this.dificultate==1)
            {
                this.BoardJoc = B.Board1();
            }

            if (this.dificultate == 2)
            {
                this.BoardJoc = B.Board2();
            }

            if (this.dificultate == 3)
            {
                this.BoardJoc = B.Board3();
            }

            this.PozStart = new Hex(0, -dim, dim);

            Point G = this.PozStart.centru;

            this.pion = new Pion(G.X - 15, G.Y - 15);


        }

        

        public void selecteaza_pion(int x, int y)
        {

            this.dx = this.pion.X - x;
            this.dy = this.pion.Y - y;



            deseneazaBoard1();
        }

        public void muta_piesa(int x, int y)
        {


            this.pion.X = x + dx;
            this.pion.Y = y + dy;
            deseneazaBoard1();

        }


        public void elibereaza_pion(int x, int y)
        {
            Point F = new Point(x, y);
            Hex End;
            End = hex.pixel_to_hex(F);



            if (valideaza_mutare(this.PozStart, End))
            {

                this.Pasi += 1;
                int a = PozStart.Q;
                int b = PozStart.R;
                int c = End.Q;
                int d = End.R;
                
                this.Score += BoardJoc.Find(x => x.Q == c && x.R == d).Score; 
                BoardJoc.Find(x => x.Q == a && x.R == b).Valid = false;

                Hex EEnd;
                aseaza_pion(this.pion, End);
                PozStart = End;

                if (BoardJoc.Find(x => x.Q == End.Q && x.R == End.R).val == -4)
                {
                    BoardJoc.Find(x => x.val == -4).Valid = false;
                    EEnd = new Hex(BoardJoc.Find(x => x.val == -5));
                    aseaza_pion(this.pion, EEnd);
                    PozStart = EEnd;
                }

                if (BoardJoc.Find(x => x.Q == End.Q && x.R == End.R).val == -5)
                {
                    BoardJoc.Find(x => x.val == -5).Valid = false;
                    EEnd = new Hex(BoardJoc.Find(x => x.val == -4));
                    aseaza_pion(this.pion, EEnd);
                    PozStart = EEnd;
                }

                if (BoardJoc.Find(x => x.Q == End.Q && x.R == End.R).finish ==true)
                {
                    this.Final = true;

                }

                int k = 0;
                foreach (Hex ahex in PozStart.All_neighbors())
                {
                    if (BoardJoc.Exists(x => x.Q == ahex.Q && x.R == ahex.R))
                    {
                        if (BoardJoc.Find(x => x.Q == ahex.Q && x.R == ahex.R).Valid == true) k = 1;
                    }
                }

                if (k == 0) this.Finall = true;

                this.pasi -= 1;
                if (this.pasi == 0) this.Finalll = true;

                Hex HH = new Hex(0, this.dim, -this.dim);
                int kk = 0;
                foreach (Hex ahex in HH.All_neighbors())
                {
                    if (BoardJoc.Exists(x => x.Q == ahex.Q && x.R == ahex.R))
                    {
                        if (BoardJoc.Find(x => x.Q == ahex.Q && x.R == ahex.R).Valid == true) kk = 1;
                    }
                }

                if (kk == 0) this.Finallll = true;


            }
            else
            {
                aseaza_pion(this.pion, PozStart);

            }
            


            deseneazaBoard1();
        }

        void aseaza_pion(Pion pion, Hex hex)
        {

            //Point F = hex.centru;
            Point F = hex.centru;

            this.pion.X = hex.centru.X  - 15;
            this.pion.Y = hex.centru.Y - 15;

            

        }


        public void deseneazaBoard1()
        {
            g.Clear(Color.Transparent);
            foreach (Hex aHex in this.BoardJoc)
            {

                
                aHex.deseneazaHexagon(g);

            }

            this.pion.deseneaza(g);

        }

        public bool valideaza_mutare(Hex Start, Hex End)
        {

            //List<Hex> List = new List<Hex>(Start.All_Direction());
            //Hex hex = Start.hex_subtract(Start, End);
            //if (!(List.Exists(x => x.Q == hex.Q && x.R == hex.R && x.S == hex.S))) return false;

            if (Start.Q == End.Q && Start.R == End.R) return false;
            if (!(BoardJoc.Exists(x => x.centru == End.centru)))
            {
                return false;
            }

            if (Start.Q == End.Q && Start.R == End.R) return false;

            double vec = Start.hex_distance(Start, End);
            if (vec > 1) return false;
            int a = End.Q;
            int b = End.R;
            if (this.BoardJoc.Find(x => x.Q == a && x.R == b).Valid==false) return false;


            return true;
        }




    }
}
