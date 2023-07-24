using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect7
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (!File.Exists("C:\\Users\\Dan\\source\\repos\\Proiect7\\Proiect7\\Clasament.txt"))
            {

                using (StreamWriter sw = File.CreateText("C:\\Users\\Dan\\source\\repos\\Proiect7\\Proiect7\\Clasament.txt"))
                {
                }
            }
            var first10Lines = File.ReadLines("C:\\Users\\Dan\\source\\repos\\Proiect7\\Proiect7\\Clasament.txt").Take(10).ToList();
            using (StreamWriter sw = new StreamWriter("C:\\Users\\Dan\\source\\repos\\Proiect7\\Proiect7\\Clasamentt.txt"))
            {

                foreach (String s in first10Lines)
                {
                    sw.WriteLine(s);
                }

            }

            string t = File.ReadAllText("C:\\Users\\Dan\\source\\repos\\Proiect7\\Proiect7\\Clasamentt.txt");
            this.Clasamentt.Text = t;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.Delete("C:\\Users\\Dan\\source\\repos\\Proiect7\\Proiect7\\Clasament.txt");
            if (!File.Exists("C:\\Users\\Dan\\source\\repos\\Proiect7\\Proiect7\\Clasament.txt"))
            {

                using (StreamWriter sw = File.CreateText("C:\\Users\\Dan\\source\\repos\\Proiect7\\Proiect7\\Clasament.txt"))
                {
                }
            }

            var first10Lines = File.ReadLines("C:\\Users\\Dan\\source\\repos\\Proiect7\\Proiect7\\Clasament.txt").Take(10).ToList();
            using (StreamWriter sw = new StreamWriter("C:\\Users\\Dan\\source\\repos\\Proiect7\\Proiect7\\Clasamentt.txt"))
            {

                foreach (String s in first10Lines)
                {
                    sw.WriteLine(s);
                }

            }

            string t = File.ReadAllText("C:\\Users\\Dan\\source\\repos\\Proiect7\\Proiect7\\Clasamentt.txt");
            this.Clasamentt.Text = t;

        }
    }
}
