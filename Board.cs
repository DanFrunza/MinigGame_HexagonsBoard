using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Proiect7
{
    internal class Board 
    {
        int w = 1000;
        int h = 640;
        int dim;
        

        public Board(int dim)
        {
            this.dim = dim;
        }
        public List<Hex> Board1()
        {
            
            List<Hex> Board1 = new List<Hex> { };
            for (int i = -dim; i <= dim; i++)
            {
                for (int j = Math.Max(-dim, -i - dim); j <= Math.Min(dim, -i + dim); j++)
                {
                    Random rnd = new Random();
                    int num = rnd.Next(0,100);
                    int k = -i - j;
                    Hex H = new Hex(i, j, k);
                    H.val = num;
                    if (i == 0 && j == -dim && k == dim)
                    {
                        H.start = true;
                        H.val = -2;
                    }

                    if (i == 0 && j ==dim && k == -dim)
                    {
                        H.finish = true;
                        H.val = -2;
                    }

                    if (H.val >= 0 && H.val <= 30)
                    {

                        H.Obiect = 1;
                    }

                    if (H.val>=31 && H.val<=40)
                    {
                        H.Score = 5;
                        H.Obiect = 2;
                    }

                    if (H.val >= 41 && H.val <= 50)
                    {
                        H.Score = 10;
                        H.Obiect = 3;
                    }

                    if (H.val >= 51 && H.val <= 60)
                    {
                        H.Score = 15;
                        H.Obiect = 4;
                    }

                    if (H.val >= 61 && H.val <= 70)
                    {
                        H.Score =-10;
                        H.Obiect = 5;
                    }

                    if (H.val >= 71 && H.val <= 80)
                    {
                        H.Score = -15;
                        H.Obiect = 6;
                    }

                    if (H.val >= 81 && H.val <= 90)
                    {
                        Random rndd = new Random();
                        int numm = rndd.Next(-100, 100);
                        H.Score = numm;
                        H.Obiect = 7;

                    }

                    if (H.val >= 91 && H.val <= 100)
                    {
                        Random rndd = new Random();
                        int numm = rndd.Next(0, 100);
                        H.Score = numm;
                        H.Obiect = 8;
                    }


                    Board1.Add(H);
                }


            }
            Random rndc = new Random();
            int num1 = rndc.Next(-dim, dim);
            int num2 = rndc.Next(-dim, dim);
            int num3 = rndc.Next(-dim, dim);
            int num4 = rndc.Next(-dim, dim);
            int k1 = -num1 - num2;
            int k2 = -num3 - num4;
            if (Math.Abs(k1) <= dim && Math.Abs(k2) <= dim)
            {
                Board1.Find(x => x.Q == num1 && x.R == num2).val = -4;
                Board1.Find(x => x.Q == num1 && x.R == num2).Score = 0;
                Board1.Find(x => x.Q == num1 && x.R == num2).Obiect = 0;
                Board1.Find(x => x.Q == num3 && x.R == num4).val = -5;
                Board1.Find(x => x.Q == num3 && x.R == num4).Score = 0;
                Board1.Find(x => x.Q == num3 && x.R == num4).Obiect = 0;

            }
            return Board1;
        }


        public List<Hex> Board2()
        {

            List<Hex> Board2 = new List<Hex> { };
            for (int i = -dim; i <= dim; i++)
            {
                for (int j = Math.Max(-dim, -i - dim); j <= Math.Min(dim, -i + dim); j++)
                {
                    Random rnd = new Random();
                    int num = rnd.Next(0, 100);
                    int k = -i - j;
                    Hex H = new Hex(i, j, k);
                    H.val = num;
                    if (i == 0 && j == -dim && k == dim)
                    {
                        H.start = true;
                        H.val = -2;
                    }

                    if (i == 0 && j == dim && k == -dim)
                    {
                        H.finish = true;
                        H.val = -2;
                    }

                    if (H.val >= 0 && H.val <= 30)
                    {
                        
                        H.Obiect = 1;
                    }

                    if (H.val >= 31 && H.val <= 39)
                    {
                        H.Score = 5;
                        H.Obiect = 2;
                    }

                    if (H.val >= 40 && H.val <= 48)
                    {
                        H.Score = 10;
                        H.Obiect = 3;
                    }

                    if (H.val >= 49 && H.val <= 57)
                    {
                        H.Score = 15;
                        H.Obiect = 4;
                    }

                    if (H.val >= 58 && H.val <= 70)
                    {
                        H.Score = -10;
                        H.Obiect = 5;
                    }

                    if (H.val >= 71 && H.val <= 84)
                    {
                        H.Score = -15;
                        H.Obiect = 6;
                    }

                    if (H.val >= 85 && H.val <= 92)
                    {
                        Random rndd = new Random();
                        int numm = rndd.Next(-100, 100);
                        H.Score = numm;
                        H.Obiect = 7;
                    }

                    if (H.val >= 93 && H.val <= 100)
                    {
                        Random rndd = new Random();
                        int numm = rndd.Next(0, 100);
                        H.Score = numm;
                        H.Obiect = 8;
                    }


                    Board2.Add(H);
                }


            }
            Random rndc = new Random();
            int num1 = rndc.Next(-dim, dim);
            int num2 = rndc.Next(-dim, dim);
            int num3 = rndc.Next(-dim, dim);
            int num4 = rndc.Next(-dim, dim);
            int k1 = -num1 - num2;
            int k2 = -num3 - num4;
            if (Math.Abs(k1) <= dim && Math.Abs(k2) <= dim)
            {
                Board2.Find(x => x.Q == num1 && x.R == num2).val = -4;
                Board2.Find(x => x.Q == num1 && x.R == num2).Score = 0;
                Board2.Find(x => x.Q == num1 && x.R == num2).Obiect = 0;
                Board2.Find(x => x.Q == num3 && x.R == num4).val = -5;
                Board2.Find(x => x.Q == num3 && x.R == num4).Score = 0;
                Board2.Find(x => x.Q == num3 && x.R == num4).Obiect = 0;

            }
            return Board2;
        }



        public List<Hex> Board3()
        {

            List<Hex> Board3 = new List<Hex> { };
            for (int i = -dim; i <= dim; i++)
            {
                for (int j = Math.Max(-dim, -i - dim); j <= Math.Min(dim, -i + dim); j++)
                {
                    Random rnd = new Random();
                    int num = rnd.Next(0, 100);
                    int k = -i - j;
                    Hex H = new Hex(i, j, k);
                    H.val = num;
                    if (i == 0 && j == -dim && k == dim)
                    {
                        H.start = true;
                        H.val = -2;
                    }

                    if (i == 0 && j == dim && k == -dim)
                    {
                        H.finish = true;
                        H.val = -2;
                    }

                    if (H.val >= 0 && H.val <= 30)
                    {

                        H.Obiect = 1;
                    }

                    if (H.val >= 31 && H.val <= 36)
                    {
                        H.Score = 5;
                        H.Obiect = 2;
                    }

                    if (H.val >= 37 && H.val <= 42)
                    {
                        H.Score = 10;
                        H.Obiect = 3;
                    }

                    if (H.val >= 43 && H.val <= 48)
                    {
                        H.Score = 15;
                        H.Obiect = 4;
                    }

                    if (H.val >= 49 && H.val <= 70)
                    {
                        H.Score = -10;
                        H.Obiect = 5;
                    }

                    if (H.val >= 71 && H.val <= 90)
                    {
                        H.Score = -15;
                        H.Obiect = 6;
                    }

                    if (H.val >= 91 && H.val <= 95)
                    {
                        Random rndd = new Random();
                        int numm = rndd.Next(-100, 100);
                        H.Score = numm;
                        H.Obiect = 7;
                    }

                    if (H.val >= 96 && H.val <= 100)
                    {
                        Random rndd = new Random();
                        int numm = rndd.Next(0, 100);
                        H.Score = numm;
                        H.Obiect = 8;
                    }


                    Board3.Add(H);
                }


            }
            Random rndc = new Random();
            int num1 = rndc.Next(-dim, dim);
            int num2 = rndc.Next(-dim, dim);
            int num3 = rndc.Next(-dim, dim);
            int num4 = rndc.Next(-dim, dim);
            int k1 = -num1 - num2;
            int k2 = -num3 - num4;
            if (Math.Abs(k1) <= dim && Math.Abs(k2) <= dim)
            {
                Board3.Find(x => x.Q == num1 && x.R == num2).val = -4;
                Board3.Find(x => x.Q == num1 && x.R == num2).Score = 0;
                Board3.Find(x => x.Q == num1 && x.R == num2).Obiect = 0;
                Board3.Find(x => x.Q == num3 && x.R == num4).val = -5;
                Board3.Find(x => x.Q == num3 && x.R == num4).Score = 0;
                Board3.Find(x => x.Q == num3 && x.R == num4).Obiect = 0;

            }
            return Board3;
        }



    }
}
