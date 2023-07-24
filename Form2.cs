using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proiect7
{
    public partial class Form2 : Form
    {
        Image img;
        Graphics g;
        TablaHexagon joc;
        bool apasat = false;
        int dim;
        TimeSpan ts1, ts2;
        DateTime ts3;
        int counter;
        int min;
        int dificultate;
        int pasi;
        bool Faratimp = false;



        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string DimensiuneS = File.ReadLines("C:\\Users\\Dan\\source\\repos\\Proiect7\\Proiect7\\Setari.txt").Skip(0).Take(1).First();
            string DificultateS = File.ReadLines("C:\\Users\\Dan\\source\\repos\\Proiect7\\Proiect7\\Setari.txt").Skip(1).Take(1).First();
            string PasiS = File.ReadLines("C:\\Users\\Dan\\source\\repos\\Proiect7\\Proiect7\\Setari.txt").Skip(2).Take(1).First();
            string NumeS = File.ReadLines("C:\\Users\\Dan\\source\\repos\\Proiect7\\Proiect7\\Setari.txt").Skip(3).Take(1).First();
            String TimpS = File.ReadLines("C:\\Users\\Dan\\source\\repos\\Proiect7\\Proiect7\\Setari.txt").Skip(4).Take(1).First();
            dim = int.Parse(DimensiuneS) - 1;
            dificultate = int.Parse(DificultateS);
            pasi = int.Parse(PasiS);
            img = new Bitmap(p.Width, p.Height);
            g = Graphics.FromImage(img);
            joc = new TablaHexagon(p.Width, p.Height, dim, dificultate, pasi, g);
            Score.Text = joc.Score.ToString();



            ts3 = DateTime.Now;
            min = int.Parse(TimpS);
            ts2 = TimeSpan.FromSeconds(min);
            this.timer1.Start();
            this.timer2.Start();
            this.Nume.Text = NumeS;



        }

        private void p_Paint(object sender, PaintEventArgs e)
        {
            joc.deseneazaBoard1();
            e.Graphics.DrawImage(img, 0, 0);


            Score.Text = joc.Score.ToString();

            Pasi.Text = joc.Pasi.ToString();
            int a;
            if (joc.Pasi != 0)
            {
                a = (int)(joc.Score / joc.Pasi);
            }
            else
            {
                a = (int)(joc.Score / 1);
            }

            Score_final.Text = a.ToString();

            PasiRamasi.Text = joc.pasi.ToString();





        }

        private void p_MouseDown(object sender, MouseEventArgs e)
        {
            if (joc.pion.este_deasupra(e.X, e.Y))
            {
                apasat = true;
                joc.selecteaza_pion(e.X, e.Y);
            }



        }

        private void p_MouseMove(object sender, MouseEventArgs e)
        {
            if (apasat)
            {
                joc.muta_piesa(e.X, e.Y);
                p.Refresh();
            }



        }

        private void p_MouseUp(object sender, MouseEventArgs e)
        {
            if (apasat == true)
            {

                joc.elibereaza_pion(e.X, e.Y);
                p.Refresh();

                apasat = false;


            }

            if (joc.Final == true)
            {
                String a = this.Score_final.Text;
                String b = this.Score.Text;
                String c = this.Pasi.Text;


                if (joc.Score >= 0)
                {
                    MessageBox.Show("Ai ajuns la final. Statisticile tale sunt || Score : " + b + " || Pasi: " + c + " || Score final: " + a + " || Felicitari!");

                    if (!File.Exists("C:\\Users\\Dan\\source\\repos\\Proiect7\\Proiect7\\Clasament.txt"))
                    {

                        using (StreamWriter sw = File.CreateText("C:\\Users\\Dan\\source\\repos\\Proiect7\\Proiect7\\Clasament.txt"))
                        {
                        }
                    }
                    using (StreamWriter sw = File.AppendText("C:\\Users\\Dan\\source\\repos\\Proiect7\\Proiect7\\Clasament.txt"))
                    {
                        if (a.Length == 1) a = "0" + a;
                        String n = this.Nume.Text;
                        String T = this.cronometru2.Text;
                        TimeSpan ts = TimeSpan.FromSeconds(min);
                        String s_minnn = Convert.ToString(ts.Minutes);
                        String s_seccc = Convert.ToString(ts.Seconds);
                        String s_suttt = Convert.ToString(ts.Milliseconds);
                        if (s_minnn.Length == 1) s_minnn = "0" + s_minnn;
                        if (s_seccc.Length == 1) s_seccc = "0" + s_seccc;
                        if (s_suttt.Length == 1) s_suttt = "0" + s_suttt;
                        String TI = s_minnn + ":" + s_seccc + ":" + s_suttt;
                        String PasiMM = this.Pasi.Text;
                        String PasiM = File.ReadLines("C:\\Users\\Dan\\source\\repos\\Proiect7\\Proiect7\\Setari.txt").Skip(2).Take(1).First(); ;
                        String DificultateM = File.ReadLines("C:\\Users\\Dan\\source\\repos\\Proiect7\\Proiect7\\Setari.txt").Skip(1).Take(1).First();
                        String DimensiuneSS = File.ReadLines("C:\\Users\\Dan\\source\\repos\\Proiect7\\Proiect7\\Setari.txt").Skip(0).Take(1).First();

                        String s = a + " || " + n + " || Dificultate: " + DificultateM + " || Pasi facuti: " + PasiMM + " din " + PasiM + " || Timp ramas: " + T + " din " + TI + " || Dimensiune harta: " + DimensiuneSS;
                        sw.WriteLine(s);

                    }

                    string inFile = @"C:\\Users\\Dan\\source\\repos\\Proiect7\\Proiect7\\Clasament.txt";
                    string outFile = @"C:\\Users\\Dan\\source\\repos\\Proiect7\\Proiect7\\Clasament.txt";
                    var contents = File.ReadAllLines(inFile);

                    IComparer myComparer = new myReverserClass();
                    Array.Sort(contents, myComparer);
                    File.WriteAllLines(outFile, contents);




                }
                else
                {
                    MessageBox.Show("Ai ajuns la final dar ai un scor negativ. Ai pierdut.");
                }
                this.Close();
            }

            if (joc.Finall == true && joc.Final == false)
            {
                String a = this.Score_final.Text;
                MessageBox.Show("Nu mai ai unde sa muti. Ai pierdut.");
                this.Close();
            }

            if (joc.Finalll == true && joc.Final == false)
            {
                String a = this.Score_final.Text;
                MessageBox.Show("Ai epuizat numarul de pasi. Ai pierdut.");
                this.Close();

            }

            if (joc.Finallll == true && joc.Final == false)
            {
                MessageBox.Show("Nu mai exista un drum spre final. Ai pierdut.");
                this.Close();

            }




        }




        private void timer1_Tick(object sender, EventArgs e)
        {

            ts1 = DateTime.Now - ts3;


            String s_min = Convert.ToString(ts1.Minutes);
            String s_sec = Convert.ToString(ts1.Seconds);
            String s_sut = Convert.ToString(ts1.Milliseconds);

            if (s_min.Length == 1) s_min = "0" + s_min;
            if (s_sec.Length == 1) s_sec = "0" + s_sec;
            if (s_sut.Length == 1) s_sut = "0" + s_sut;
            s_sut = s_sut.Substring(0, 2);

            cronometru1.Text = s_min + ":" + s_sec + ":" + s_sut;

            if (joc.Final == true)
            {
                timer1.Stop();
            }

            if (joc.Finall == true)
            {
                timer1.Stop();
            }

            if (joc.Finalll == true)
            {
                timer1.Stop();
            }

            if (this.Faratimp == true)
            {
                timer1.Stop();
            }

            if (joc.Finallll == true)
            {
                timer1.Stop();
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            ts2 = TimeSpan.FromSeconds(min) - (DateTime.Now - ts3);


            String s_min = Convert.ToString(ts2.Minutes);
            String s_sec = Convert.ToString(ts2.Seconds);
            String s_sut = Convert.ToString(ts2.Milliseconds);

            if (s_min.Length == 1) s_min = "0" + s_min;
            if (s_sec.Length == 1) s_sec = "0" + s_sec;
            if (s_sut.Length == 1) s_sut = "0" + s_sut;
            s_sut = s_sut.Substring(0, 2);

            cronometru2.Text = s_min + ":" + s_sec + ":" + s_sut;
            if (joc.Final == true)
            {
                timer2.Stop();
            }

            if (joc.Finall == true)
            {
                timer2.Stop();
            }

            if (joc.Finalll == true)
            {
                timer2.Stop();
            }

            if (joc.Finallll == true)
            {
                timer2.Stop();
            }



            if (ts2.Milliseconds <= TimeSpan.Zero.Milliseconds + 15 && ts2.Seconds == TimeSpan.Zero.Seconds && ts2.Minutes == TimeSpan.Zero.Minutes)
            {
                this.Faratimp = true;
                timer2.Stop();
                MessageBox.Show("Ai ramas fara timp. Ai pierdut.");
                this.Close();
            }




        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                img.Save(sfd.FileName, format);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (pd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                print.Print();
            }
        }

        private void print_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(img, 0, 0);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            Form4 f4 = new Form4();
            f4.ShowDialog();
            f4 = null;

        }
    }
}
