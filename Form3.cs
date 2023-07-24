using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Proiect7
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Dim3.Checked = true;
            this.DifEasy.Checked = true;
            this.Pasi40.Checked = true;
            this.NumeJucator.Text = "NoName";
            this.timp.Text = "300";


        }

        private void button1_Click(object sender, EventArgs e)
        {



            File.Delete("C:\\Users\\Dan\\source\\repos\\Proiect7\\Proiect7\\Setari.txt");

            using (StreamWriter sw = new StreamWriter("C:\\Users\\Dan\\source\\repos\\Proiect7\\Proiect7\\Setari.txt"))
            {



                if (this.Dim3.Checked == true)
                {
                    String s = (3).ToString();

                    sw.WriteLine(s);
                }


                if (this.Dim4.Checked == true)
                {
                    String s = (4).ToString();

                    sw.WriteLine(s);
                }


                if (this.Dim5.Checked == true)
                {
                    String s = (5).ToString();

                    sw.WriteLine(s);
                }

                if (this.DifEasy.Checked == true)
                {

                    String s = (1).ToString();

                    sw.WriteLine(s);

                }

                if (this.DifMedium.Checked == true)
                {

                    String s = (2).ToString();

                    sw.WriteLine(s);

                }

                if (this.DifHard.Checked == true)
                {

                    String s = (3).ToString();

                    sw.WriteLine(s);

                }


                if (this.Pasi20.Checked == true)
                {

                    String s = (20).ToString();

                    sw.WriteLine(s);

                }

                if (this.Pasi30.Checked == true)
                {

                    String s = (30).ToString();

                    sw.WriteLine(s);

                }

                if (this.Pasi40.Checked == true)
                {

                    String s = (40).ToString();

                    sw.WriteLine(s);

                }

                String nume = this.NumeJucator.Text;
                sw.WriteLine(nume);
                String Timp = this.timp.Text;
                sw.WriteLine(Timp);


            }






            this.Close();
        }





        private void Dim5_Click(object sender, EventArgs e)
        {
            if (this.Dim5.Checked == true)
            {
                this.Dim3.Checked = false;
                this.Dim4.Checked = false;
            }
        }

        private void Dim4_Click(object sender, EventArgs e)
        {
            if (this.Dim4.Checked == true)
            {
                this.Dim3.Checked = false;
                this.Dim5.Checked = false;
            }
        }

        private void Dim3_Click(object sender, EventArgs e)
        {

            if (this.Dim3.Checked == true)
            {
                this.Dim4.Checked = false;
                this.Dim5.Checked = false;
            }
        }

        private void DifEasy_Click(object sender, EventArgs e)
        {
            if (this.DifEasy.Checked == true)
            {
                this.DifMedium.Checked = false;
                this.DifHard.Checked = false;
            }
        }

        private void DifMedium_Click(object sender, EventArgs e)
        {
            if (this.DifMedium.Checked == true)
            {
                this.DifEasy.Checked = false;
                this.DifHard.Checked = false;
            }
        }

        private void DifHard_Click(object sender, EventArgs e)
        {
            if (this.DifHard.Checked == true)
            {
                this.DifEasy.Checked = false;
                this.DifMedium.Checked = false;
            }
        }

        private void Pasi40_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Pasi40.Checked == true)
            {
                this.Pasi30.Checked = false;
                this.Pasi20.Checked = false;
            }
        }

        private void Pasi30_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Pasi30.Checked == true)
            {
                this.Pasi40.Checked = false;
                this.Pasi20.Checked = false;
            }

        }

        private void Pasi20_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Pasi20.Checked == true)
            {
                this.Pasi30.Checked = false;
                this.Pasi40.Checked = false;
            }
        }

        
    }
}
