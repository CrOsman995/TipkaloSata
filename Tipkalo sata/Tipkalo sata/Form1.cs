using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tipkalo_sata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int pocetnoStanje = 0;
            tbSati.Text = pocetnoStanje.ToString();
            tbMinute.Text = pocetnoStanje.ToString();
            tbSekunde.Text = pocetnoStanje.ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int a = 1;
            Load(a);

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int a = 2;
            Load(a);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int a = 3;
            Load(a);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            int a = 4;
            Load(a);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            int a = 5;
            Load(a);
        }

        public new void Load(int red)
        {
            if (cbStart.Checked == true)
            {
                rbSati.Select();
                switch (red)
                {
                    case 1:
                        rbSati.Select();
                        break;
                    case 2:
                        rbMinute.Select();
                        break;
                    case 3:
                        rbSekunde.Select();
                        break;
                    case 4:
                        Inkrement();
                        break;
                    case 5:
                        Dekrement();
                        break;                    
                }
            }
            else MessageBox.Show("Niste unijeli tipku za pokretanje.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        
        void Inkrement()
        {
            int pom = 0;
            if (rbSati.Checked == true)
            {
                pom = Int32.Parse(tbSati.Text);
                pom++;
                tbSati.Text = pom.ToString();
                provjera();
            }
            else if (rbMinute.Checked == true)
            {
                pom = Int32.Parse(tbMinute.Text);
                pom++;
                tbMinute.Text = pom.ToString();
                provjera();
            }
            else
            {
                pom = Int32.Parse(tbSekunde.Text);
                pom++;               
                tbSekunde.Text = pom.ToString();
                provjera();
            }
        }
        void Dekrement()
        {
            int pom = 0;
            if (rbSati.Checked == true)
            {
                pom = Int32.Parse(tbSati.Text);
                pom--;
                tbSati.Text = pom.ToString();
                provjera();
            }
            else if (rbMinute.Checked == true)
            {
                pom = Int32.Parse(tbMinute.Text);
                pom--;
                tbMinute.Text = pom.ToString();
                provjera();
            }
            else
            {
                pom = Int32.Parse(tbMinute.Text);
                pom--;
                tbSekunde.Text = pom.ToString();
                provjera();
            }
        }
        private void provjera()
        {
            if(Int32.Parse(tbSati.Text)>=23)
            {
                
                tbSati.Text = "0";
            }
            if (Int32.Parse(tbSati.Text) < 0)
            {
                tbSati.Text = "0";
            }
            if (Int32.Parse(tbMinute.Text) >= 60)
            {

                tbMinute.Text = "0";
            }
            if (Int32.Parse(tbMinute.Text) < 0)
            {
                tbMinute.Text = "0";
            }
            if (Int32.Parse(tbSekunde.Text) >= 60)
            {

                tbSekunde.Text = "0";
            }
            if (Int32.Parse(tbSekunde.Text) < 0)
            {
                tbSekunde.Text = "0";
            }

        }

       
    }
}

