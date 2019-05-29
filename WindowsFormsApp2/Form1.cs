using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MaterialSkin.Controls;
using MaterialSkin;

namespace WindowsFormsApp2
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaterialSkinManager msm = MaterialSkinManager.Instance;
            msm.AddFormToManage(this);
            msm.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox13.Text = "40";
            textBox13.BackColor = Color.PaleVioletRed;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox13.Text = "50";
            textBox13.BackColor = Color.ForestGreen;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox13.Text = "60";
            textBox13.BackColor = Color.CornflowerBlue;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox14.Text = "NP";
            textBox14.BackColor = Color.Aquamarine;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox14.Text = "MDP";
            textBox14.BackColor = Color.MediumSpringGreen;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox14.Text = "GP";
            textBox14.BackColor = Color.SpringGreen;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox14.Text = "NK";
            textBox14.BackColor = Color.DarkTurquoise;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox14.Text = "GK";
            textBox14.BackColor = Color.CadetBlue;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox14.Text = "BP";
            textBox14.BackColor = Color.LightSlateGray;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox14.Text = "NEMP";
            textBox14.BackColor = Color.LightBlue;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox14.Text = "FP";
            textBox14.BackColor = Color.SteelBlue;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox14.Text = "KNK";
            textBox14.BackColor = Color.DodgerBlue;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox14.Text = "KGK";
            textBox14.BackColor = Color.CornflowerBlue;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox14.Text = "NICK";
            textBox14.BackColor = Color.SlateBlue;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox14.Text = "GICK";
            textBox14.BackColor = Color.DarkSeaGreen;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox14.Text = "MHP";
            textBox14.BackColor = Color.GreenYellow;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox14.Text = "PP";
            textBox14.BackColor = Color.LightGreen;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox14.Text = "DRP";
            textBox14.BackColor = Color.PaleGreen;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox14.Text = "GCKK";
            textBox14.BackColor = Color.MediumSeaGreen;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox14.Text = "PTP";
            textBox14.BackColor = Color.MediumAquamarine;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox14.Text = "PK";
            textBox14.BackColor = Color.MediumTurquoise;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
            
        }

        private void button34_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.Focus();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 4;
            textBox11.Text = textBox13.Text + "_" + textBox1.Text + "x" + textBox2.Text + "_" + textBox14.Text;

            




        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 4;
            textBox11.Text = textBox13.Text + "_" + textBox1.Text + "x" + textBox2.Text + "_" + textBox14.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void button22_Click(object sender, EventArgs e)
        {


           



            decimal toplam, sayı1, sayı2, sayı3, sayı4, sayı7, sayı8, toplam1, toplam2;
            sayı1 = Convert.ToDecimal(textBox1.Text);
            sayı2 = Convert.ToDecimal(textBox2.Text);
            

            toplam = (sayı1 * sayı2)/1000000;
            Decimal sayi = toplam;
            sayi = Decimal.Round(sayi, 2);
            textBox12.Text = Convert.ToString(sayi);

            


            int En, Boy, PnD40, PnD50, PnD60, PnI40, PnI50, PnI60, PkD40, PkD50, PkD60, PkI40, PkI50, PkI60, IcKd40, IcKi40, IcKd60, IcKi60, IcKd50, IcKi50;
            String paneltipi, izo;
            
            
            paneltipi = Convert.ToString(textBox14.Text);
            izo = Convert.ToString(textBox13.Text);
            En = Convert.ToInt32(textBox1.Text);
            Boy = Convert.ToInt32(textBox2.Text);

            PnD40 = 85;
            PnD50 = 43;
            PnD60 = 125;
            PnI40 = 20;
            PnI50 = 83;
            PnI60 = 20;
            PkD40 = 107;
            PkD50 = 41;
            PkD60 = 145;
            PkI40 = -17;
            PkI50 = 73;
            PkI60 = -19;
            IcKd40 = -135;
            IcKi40 = -15;
            IcKd50 = -59;
            IcKi50 = -27;
            IcKd60 = -178;
            IcKi60 = -14;

          

            if (paneltipi == "NP" && izo == "40")

            {
               textBox3.Text = Convert.ToString(En + PnD40);
            }


            else if (paneltipi == "MDP" && izo == "40")

            {
                
                textBox3.Text = Convert.ToString(En + PnD40);
            }

            else if (paneltipi == "GP" && izo == "40")

            {
                
                textBox3.Text = Convert.ToString(En + PnD40);
            }

            
            else if (paneltipi == "BP" && izo == "40")

            {
                
                textBox3.Text = Convert.ToString(En + PnD40);
            }

            else if (paneltipi == "NEMP" && izo == "40")

            {
                
                textBox3.Text = Convert.ToString(En + PnD40);
            }

            else if (paneltipi == "FP" && izo == "40")

            {
                
                textBox3.Text = Convert.ToString(En + PnD40);
            }

            else if (paneltipi == "MHP" && izo == "40")

            {
                
                textBox3.Text = Convert.ToString(En + PnD40);
            }

            else if (paneltipi == "PP" && izo == "40")

            {
                
                textBox3.Text = Convert.ToString(En + PnD40);
            }

            else if (paneltipi == "DRP" && izo == "40")

            {
                textBox3.Text = Convert.ToString(En + PnD40);
            }

            else if (paneltipi == "PTP" && izo == "40")

            {
                textBox3.Text = Convert.ToString(En + PnD40);
            }

            

            else if (paneltipi == "NP" && izo == "50")

            {
                textBox3.Text = Convert.ToString(En + PnD50);
            }


            else if (paneltipi == "MDP" && izo == "50")

            {
                textBox3.Text = Convert.ToString(En + PnD50);
            }

            else if (paneltipi == "GP" && izo == "50")

            {
                textBox3.Text = Convert.ToString(En + PnD50);
            }

            else if (paneltipi == "BP" && izo == "50")

            {
                textBox3.Text = Convert.ToString(En + PnD50);
            }

            else if (paneltipi == "NEMP" && izo == "50")

            {
                textBox3.Text = Convert.ToString(En + PnD50);
            }

            else if (paneltipi == "FP" && izo == "50")

            {
                textBox3.Text = Convert.ToString(En + PnD50);
            }

            else if (paneltipi == "MHP" && izo == "50")

            {
                textBox3.Text = Convert.ToString(En + PnD50);
            }

            else if (paneltipi == "PP" && izo == "50")

            {
                textBox3.Text = Convert.ToString(En + PnD50);
            }

            else if (paneltipi == "DRP" && izo == "50")

            {
                textBox3.Text = Convert.ToString(En + PnD50);
            }

            else if (paneltipi == "PTP" && izo == "50")

            {
                textBox3.Text = Convert.ToString(En + PnD50);
            }

            else if (paneltipi == "NP" && izo == "50")

            {
                textBox3.Text = Convert.ToString(En + PnD50);
            }


            else if (paneltipi == "MDP" && izo == "50")

            {
                textBox3.Text = Convert.ToString(En + PnD50);
            }

            else if (paneltipi == "GP" && izo == "50")

            {
                textBox3.Text = Convert.ToString(En + PnD50);
            }

            else if (paneltipi == "BP" && izo == "50")

            {
                textBox3.Text = Convert.ToString(En + PnD50);
            }

            else if (paneltipi == "NEMP" && izo == "50")

            {
                textBox3.Text = Convert.ToString(En + PnD50);
            }

            else if (paneltipi == "FP" && izo == "50")

            {
                textBox3.Text = Convert.ToString(En + PnD50);
            }

            else if (paneltipi == "MHP" && izo == "50")

            {
                textBox3.Text = Convert.ToString(En + PnD50);
            }

            else if (paneltipi == "PP" && izo == "50")

            {
                textBox3.Text = Convert.ToString(En + PnD50);
            }

            else if (paneltipi == "DRP" && izo == "50")

            {
                textBox3.Text = Convert.ToString(En + PnD50);
            }

            else if (paneltipi == "PTP" && izo == "50")

            {
                textBox3.Text = Convert.ToString(En + PnD50);
            }

            else if (paneltipi == "NP" && izo == "60")

            {
                textBox3.Text = Convert.ToString(En + PnD60);
            }


            else if (paneltipi == "MDP" && izo == "60")

            {
                textBox3.Text = Convert.ToString(En + PnD60);
            }

            else if (paneltipi == "GP" && izo == "60")

            {
                textBox3.Text = Convert.ToString(En + PnD60);
            }

            else if (paneltipi == "BP" && izo == "60")

            {
                textBox3.Text = Convert.ToString(En + PnD60);
            }

            else if (paneltipi == "NEMP" && izo == "60")

            {
                textBox3.Text = Convert.ToString(En + PnD60);
            }

            else if (paneltipi == "FP" && izo == "60")

            {
                textBox3.Text = Convert.ToString(En + PnD60);
            }

            else if (paneltipi == "MHP" && izo == "60")

            {
                textBox3.Text = Convert.ToString(En + PnD60);
            }

            else if (paneltipi == "PP" && izo == "60")

            {
                textBox3.Text = Convert.ToString(En + PnD60);
            }

            else if (paneltipi == "DRP" && izo == "60")

            {
                textBox3.Text = Convert.ToString(En + PnD60);
            }

            else if (paneltipi == "NK" && izo == "40")

            {
                textBox3.Text = Convert.ToString(En + PkD40);
            }

            else if (paneltipi == "NK" && izo == "50")

            {
                textBox3.Text = Convert.ToString(En + PkD50);
            }

            else if (paneltipi == "NK" && izo == "60")

            {
                textBox3.Text = Convert.ToString(En + PkD60);
            }

            else if (paneltipi == "GK" && izo == "40")

            {
                textBox3.Text = Convert.ToString(En + PkD40);
            }

            else if (paneltipi == "GK" && izo == "50")

            {
                textBox3.Text = Convert.ToString(En + PkD50);
            }

            else if (paneltipi == "GK" && izo == "60")

            {
                textBox3.Text = Convert.ToString(En + PkD60);
            }

            else if (paneltipi == "KNK" && izo == "40")

            {
                textBox3.Text = Convert.ToString(En + PkD40);
            }

            else if (paneltipi == "KNK" && izo == "50")

            {
                textBox3.Text = Convert.ToString(En + PkD50);
            }

            else if (paneltipi == "KNK" && izo == "60")

            {
                textBox3.Text = Convert.ToString(En + PkD60);
            }

            else if (paneltipi == "KGK" && izo == "40")

            {
                textBox3.Text = Convert.ToString(En + PkD40);
            }

            else if (paneltipi == "KGK" && izo == "50")

            {
                textBox3.Text = Convert.ToString(En + PkD50);
            }

            else if (paneltipi == "KGK" && izo == "60")

            {
                textBox3.Text = Convert.ToString(En + PkD60);
            }

            else if (paneltipi == "NICK" && izo == "40")

            {
                textBox3.Text = Convert.ToString(En + IcKd40);
            }

            else if (paneltipi == "NICK" && izo == "50")

            {
                textBox3.Text = Convert.ToString(En + IcKd50);
            }

            else if (paneltipi == "NICK" && izo == "60")

            {
                textBox3.Text = Convert.ToString(En + IcKd60);
            }

            else if (paneltipi == "GICK" && izo == "40")

            {
                textBox3.Text = Convert.ToString(En + IcKd40);
            }

            else if (paneltipi == "GICK" && izo == "50")

            {
                textBox3.Text = Convert.ToString(En + IcKd50);
            }

            else if (paneltipi == "GICK" && izo == "60")

            {
                textBox3.Text = Convert.ToString(En + IcKd60);
            }

            else if (paneltipi == "GCKK" && izo == "40")

            {
                textBox3.Text = Convert.ToString(En + PkD40);
            }

            else if (paneltipi == "GCKK" && izo == "50")

            {
                textBox3.Text = Convert.ToString(En + PkD50);
            }

            else if (paneltipi == "GCKK" && izo == "60")

            {
                textBox3.Text = Convert.ToString(En + PkD60);
            }

            else if (paneltipi == "PK" && izo == "40")

            {
                textBox3.Text = Convert.ToString(En + PkD40);
            }

            else if (paneltipi == "PK" && izo == "50")

            {
                textBox3.Text = Convert.ToString(En + PkD50);
            }

            else if (paneltipi == "PK" && izo == "60")

            {
                textBox3.Text = Convert.ToString(En + PkD60);
            }

            else

            {
                textBox3.Text = Convert.ToString(En + PnD60);
            }

            if (paneltipi == "NP" && izo == "40")

            {
                textBox4.Text = Convert.ToString(Boy + PnD40);
            }


            else if (paneltipi == "MDP" && izo == "40")

            {
                textBox4.Text = Convert.ToString(Boy + PnD40);
            }

            else if (paneltipi == "GP" && izo == "40")

            {
                textBox4.Text = Convert.ToString(Boy + PnD40);
            }

            else if (paneltipi == "GP" && izo == "40")

            {
                textBox4.Text = Convert.ToString(Boy + PnD40);
            }

            else if (paneltipi == "BP" && izo == "40")

            {
                textBox4.Text = Convert.ToString(Boy + PnD40);
            }

            else if (paneltipi == "NEMP" && izo == "40")

            {
                textBox4.Text = Convert.ToString(Boy + PnD40);
            }

            else if (paneltipi == "FP" && izo == "40")

            {
                textBox4.Text = Convert.ToString(Boy + PnD40);
            }

            else if (paneltipi == "MHP" && izo == "40")

            {
                textBox4.Text = Convert.ToString(Boy + PnD40);
            }

            else if (paneltipi == "PP" && izo == "40")

            {
                textBox4.Text = Convert.ToString(Boy + PnD40);
            }

            else if (paneltipi == "DRP" && izo == "40")

            {
                textBox4.Text = Convert.ToString(Boy + PnD40);
            }

            else if (paneltipi == "PTP" && izo == "40")

            {
                textBox4.Text = Convert.ToString(Boy + PnD40);
            }



            else if (paneltipi == "NP" && izo == "50")

            {
                textBox4.Text = Convert.ToString(Boy + PnD50);
            }


            else if (paneltipi == "MDP" && izo == "50")

            {
                textBox4.Text = Convert.ToString(Boy + PnD50);
            }

            else if (paneltipi == "GP" && izo == "50")

            {
                textBox4.Text = Convert.ToString(Boy + PnD50);
            }

            else if (paneltipi == "BP" && izo == "50")

            {
                textBox4.Text = Convert.ToString(Boy + PnD50);
            }

            else if (paneltipi == "NEMP" && izo == "50")

            {
                textBox4.Text = Convert.ToString(Boy + PnD50);
            }

            else if (paneltipi == "FP" && izo == "50")

            {
                textBox4.Text = Convert.ToString(Boy + PnD50);
            }

            else if (paneltipi == "MHP" && izo == "50")

            {
                textBox4.Text = Convert.ToString(Boy + PnD50);
            }

            else if (paneltipi == "PP" && izo == "50")

            {
                textBox4.Text = Convert.ToString(Boy + PnD50);
            }

            else if (paneltipi == "DRP" && izo == "50")

            {
                textBox4.Text = Convert.ToString(Boy + PnD50);
            }

            else if (paneltipi == "PTP" && izo == "50")

            {
                textBox4.Text = Convert.ToString(Boy + PnD50);
            }

            else if (paneltipi == "NP" && izo == "50")

            {
                textBox4.Text = Convert.ToString(Boy + PnD50);
            }


            else if (paneltipi == "MDP" && izo == "50")

            {
                textBox4.Text = Convert.ToString(Boy + PnD50);
            }

            else if (paneltipi == "GP" && izo == "50")

            {
                textBox4.Text = Convert.ToString(Boy + PnD50);
            }

            else if (paneltipi == "BP" && izo == "50")

            {
                textBox4.Text = Convert.ToString(Boy + PnD50);
            }

            else if (paneltipi == "NEMP" && izo == "50")

            {
                textBox4.Text = Convert.ToString(Boy + PnD50);
            }

            else if (paneltipi == "FP" && izo == "50")

            {
                textBox4.Text = Convert.ToString(Boy + PnD50);
            }

            else if (paneltipi == "MHP" && izo == "50")

            {
                textBox4.Text = Convert.ToString(Boy + PnD50);
            }

            else if (paneltipi == "PP" && izo == "50")

            {
                textBox4.Text = Convert.ToString(Boy + PnD50);
            }

            else if (paneltipi == "DRP" && izo == "50")

            {
                textBox4.Text = Convert.ToString(Boy + PnD50);
            }

            else if (paneltipi == "PTP" && izo == "50")

            {
                textBox4.Text = Convert.ToString(Boy + PnD50);
            }

            else if (paneltipi == "NP" && izo == "60")

            {
                textBox4.Text = Convert.ToString(Boy + PnD60);
            }


            else if (paneltipi == "MDP" && izo == "60")

            {
                textBox4.Text = Convert.ToString(Boy + PnD60);
            }

            else if (paneltipi == "GP" && izo == "60")

            {
                textBox4.Text = Convert.ToString(Boy + PnD60);
            }

            else if (paneltipi == "BP" && izo == "60")

            {
                textBox4.Text = Convert.ToString(Boy + PnD60);
            }

            else if (paneltipi == "NEMP" && izo == "60")

            {
                textBox4.Text = Convert.ToString(Boy + PnD60);
            }

            else if (paneltipi == "FP" && izo == "60")

            {
                textBox4.Text = Convert.ToString(Boy + PnD60);
            }

            else if (paneltipi == "MHP" && izo == "60")

            {
                textBox4.Text = Convert.ToString(Boy + PnD60);
            }

            else if (paneltipi == "PP" && izo == "60")

            {
                textBox4.Text = Convert.ToString(Boy + PnD60);
            }

            else if (paneltipi == "DRP" && izo == "60")

            {
                textBox4.Text = Convert.ToString(Boy + PnD60);
            }

            else if (paneltipi == "NK" && izo == "40")

            {
                textBox4.Text = Convert.ToString(Boy + PkD40);
            }

            else if (paneltipi == "NK" && izo == "50")

            {
                textBox4.Text = Convert.ToString(Boy + PkD50);
            }

            else if (paneltipi == "NK" && izo == "60")

            {
                textBox4.Text = Convert.ToString(Boy + PkD60);
            }

            else if (paneltipi == "GK" && izo == "40")

            {
                textBox4.Text = Convert.ToString(Boy + PkD40);
            }

            else if (paneltipi == "GK" && izo == "50")

            {
                textBox4.Text = Convert.ToString(Boy + PkD50);
            }

            else if (paneltipi == "GK" && izo == "60")

            {
                textBox4.Text = Convert.ToString(Boy + PkD60);
            }

            else if (paneltipi == "KNK" && izo == "40")

            {
                textBox4.Text = Convert.ToString(Boy + PkD40);
            }

            else if (paneltipi == "KNK" && izo == "50")

            {
                textBox4.Text = Convert.ToString(Boy + PkD50);
            }

            else if (paneltipi == "KNK" && izo == "60")

            {
                textBox4.Text = Convert.ToString(Boy + PkD60);
            }

            else if (paneltipi == "KGK" && izo == "40")

            {
                textBox4.Text = Convert.ToString(Boy + PkD40);
            }

            else if (paneltipi == "KGK" && izo == "50")

            {
                textBox4.Text = Convert.ToString(Boy + PkD50);
            }

            else if (paneltipi == "KGK" && izo == "60")

            {
                textBox4.Text = Convert.ToString(Boy + PkD60);
            }

            else if (paneltipi == "NICK" && izo == "40")

            {
                textBox4.Text = Convert.ToString(Boy + IcKd40);
            }

            else if (paneltipi == "NICK" && izo == "50")

            {
                textBox4.Text = Convert.ToString(Boy + IcKd50);
            }

            else if (paneltipi == "NICK" && izo == "60")

            {
                textBox4.Text = Convert.ToString(Boy + IcKd60);
            }

            else if (paneltipi == "GICK" && izo == "40")

            {
                textBox4.Text = Convert.ToString(Boy + IcKd40);
            }

            else if (paneltipi == "GICK" && izo == "50")

            {
                textBox4.Text = Convert.ToString(Boy + IcKd50);
            }

            else if (paneltipi == "GICK" && izo == "60")

            {
                textBox4.Text = Convert.ToString(Boy + IcKd60);
            }

            else if (paneltipi == "GCKK" && izo == "40")

            {
                textBox4.Text = Convert.ToString(Boy + PkD40);
            }

            else if (paneltipi == "GCKK" && izo == "50")

            {
                textBox4.Text = Convert.ToString(Boy + PkD50);
            }

            else if (paneltipi == "GCKK" && izo == "60")

            {
                textBox4.Text = Convert.ToString(Boy + PkD60);
            }

            else if (paneltipi == "PK" && izo == "40")

            {
                textBox4.Text = Convert.ToString(Boy + PkD40);
            }

            else if (paneltipi == "PK" && izo == "50")

            {
                textBox4.Text = Convert.ToString(Boy + PkD50);
            }

            else if (paneltipi == "PK" && izo == "60")

            {
                textBox4.Text = Convert.ToString(Boy + PkD60);
            }

            else

            {
                textBox4.Text = Convert.ToString(Boy + PnD60);
            }

            if (paneltipi == "NP" && izo == "40")

            {
                textBox7.Text = Convert.ToString(En + PnI40);
            }


            else if (paneltipi == "MDP" && izo == "40")

            {

                textBox7.Text = Convert.ToString(En + PnI40);
            }

            else if (paneltipi == "GP" && izo == "40")

            {

                textBox7.Text = Convert.ToString(En + PnI40);
            }


            else if (paneltipi == "BP" && izo == "40")

            {

                textBox7.Text = Convert.ToString(En + PnI40);
            }

            else if (paneltipi == "NEMP" && izo == "40")

            {

                textBox7.Text = Convert.ToString(En + PnI40);
            }

            else if (paneltipi == "FP" && izo == "40")

            {

                textBox7.Text = Convert.ToString(En + PnI40);
            }

            else if (paneltipi == "MHP" && izo == "40")

            {

                textBox7.Text = Convert.ToString(En + PnI40);
            }

            else if (paneltipi == "PP" && izo == "40")

            {

                textBox7.Text = Convert.ToString(En + PnI40);
            }

            else if (paneltipi == "DRP" && izo == "40")

            {
                textBox7.Text = Convert.ToString(En + PnI40);
            }

            else if (paneltipi == "PTP" && izo == "40")

            {
                textBox7.Text = Convert.ToString(En + PnI40);
            }



            else if (paneltipi == "NP" && izo == "50")

            {
                textBox7.Text = Convert.ToString(En + PnI50);
            }


            else if (paneltipi == "MDP" && izo == "50")

            {
                textBox7.Text = Convert.ToString(En + PnI50);
            }

            else if (paneltipi == "GP" && izo == "50")

            {
                textBox7.Text = Convert.ToString(En + PnI50);
            }

            else if (paneltipi == "BP" && izo == "50")

            {
                textBox7.Text = Convert.ToString(En + PnI50);
            }

            else if (paneltipi == "NEMP" && izo == "50")

            {
                textBox7.Text = Convert.ToString(En + PnI50);
            }

            else if (paneltipi == "FP" && izo == "50")

            {
                textBox7.Text = Convert.ToString(En + PnI50);
            }

            else if (paneltipi == "MHP" && izo == "50")

            {
                textBox7.Text = Convert.ToString(En + PnI50);
            }

            else if (paneltipi == "PP" && izo == "50")

            {
                textBox7.Text = Convert.ToString(En + PnI50);
            }

            else if (paneltipi == "DRP" && izo == "50")

            {
                textBox7.Text = Convert.ToString(En + PnI50);
            }

            else if (paneltipi == "PTP" && izo == "50")

            {
                textBox7.Text = Convert.ToString(En + PnI50);
            }

            else if (paneltipi == "NP" && izo == "50")

            {
                textBox7.Text = Convert.ToString(En + PnI50);
            }


            else if (paneltipi == "MDP" && izo == "50")

            {
                textBox7.Text = Convert.ToString(En + PnI50);
            }

            else if (paneltipi == "GP" && izo == "50")

            {
                textBox7.Text = Convert.ToString(En + PnI50);
            }

            else if (paneltipi == "BP" && izo == "50")

            {
                textBox7.Text = Convert.ToString(En + PnI50);
            }

            else if (paneltipi == "NEMP" && izo == "50")

            {
                textBox7.Text = Convert.ToString(En + PnI50);
            }

            else if (paneltipi == "FP" && izo == "50")

            {
                textBox7.Text = Convert.ToString(En + PnI50);
            }

            else if (paneltipi == "MHP" && izo == "50")

            {
                textBox7.Text = Convert.ToString(En + PnI50);
            }

            else if (paneltipi == "PP" && izo == "50")

            {
                textBox7.Text = Convert.ToString(En + PnI50);
            }

            else if (paneltipi == "DRP" && izo == "50")

            {
                textBox7.Text = Convert.ToString(En + PnI50);
            }

            else if (paneltipi == "PTP" && izo == "50")

            {
                textBox7.Text = Convert.ToString(En + PnI50);
            }

            else if (paneltipi == "NP" && izo == "60")

            {
                textBox7.Text = Convert.ToString(En + PnI60);
            }


            else if (paneltipi == "MDP" && izo == "60")

            {
                textBox7.Text = Convert.ToString(En + PnI60);
            }

            else if (paneltipi == "GP" && izo == "60")

            {
                textBox7.Text = Convert.ToString(En + PnI60);
            }

            else if (paneltipi == "BP" && izo == "60")

            {
                textBox7.Text = Convert.ToString(En + PnI60);
            }

            else if (paneltipi == "NEMP" && izo == "60")

            {
                textBox7.Text = Convert.ToString(En + PnI60);
            }

            else if (paneltipi == "FP" && izo == "60")

            {
                textBox7.Text = Convert.ToString(En + PnI60);
            }

            else if (paneltipi == "MHP" && izo == "60")

            {
                textBox7.Text = Convert.ToString(En + PnI60);
            }

            else if (paneltipi == "PP" && izo == "60")

            {
                textBox7.Text = Convert.ToString(En + PnI60);
            }

            else if (paneltipi == "DRP" && izo == "60")

            {
                textBox7.Text = Convert.ToString(En + PnI60);
            }

            else if (paneltipi == "NK" && izo == "40")

            {
                textBox7.Text = Convert.ToString(En + PkI40);
            }

            else if (paneltipi == "NK" && izo == "50")

            {
                textBox7.Text = Convert.ToString(En + PkI50);
            }

            else if (paneltipi == "NK" && izo == "60")

            {
                textBox7.Text = Convert.ToString(En + PkI60);
            }

            else if (paneltipi == "GK" && izo == "40")

            {
                textBox7.Text = Convert.ToString(En + PkI40);
            }

            else if (paneltipi == "GK" && izo == "50")

            {
                textBox7.Text = Convert.ToString(En + PkI50);
            }

            else if (paneltipi == "GK" && izo == "60")

            {
                textBox7.Text = Convert.ToString(En + PkI60);
            }

            else if (paneltipi == "KNK" && izo == "40")

            {
                textBox7.Text = Convert.ToString(En + PkI40);
            }

            else if (paneltipi == "KNK" && izo == "50")

            {
                textBox7.Text = Convert.ToString(En + PkI50);
            }

            else if (paneltipi == "KNK" && izo == "60")

            {
                textBox7.Text = Convert.ToString(En + PkI60);
            }

            else if (paneltipi == "KGK" && izo == "40")

            {
                textBox7.Text = Convert.ToString(En + PkI40);
            }

            else if (paneltipi == "KGK" && izo == "50")

            {
                textBox7.Text = Convert.ToString(En + PkI50);
            }

            else if (paneltipi == "KGK" && izo == "60")

            {
                textBox7.Text = Convert.ToString(En + PkI60);
            }

            else if (paneltipi == "NICK" && izo == "40")

            {
                textBox7.Text = Convert.ToString(En + IcKi40);
            }

            else if (paneltipi == "NICK" && izo == "50")

            {
                textBox7.Text = Convert.ToString(En + IcKi50);
            }

            else if (paneltipi == "NICK" && izo == "60")

            {
                textBox7.Text = Convert.ToString(En + IcKi60);
            }

            else if (paneltipi == "GICK" && izo == "40")

            {
                textBox7.Text = Convert.ToString(En + IcKi40);
            }

            else if (paneltipi == "GICK" && izo == "50")

            {
                textBox7.Text = Convert.ToString(En + IcKi50);
            }

            else if (paneltipi == "GICK" && izo == "60")

            {
                textBox7.Text = Convert.ToString(En + IcKi60);
            }

            else if (paneltipi == "GCKK" && izo == "40")

            {
                textBox7.Text = Convert.ToString(En + PkI40);
            }

            else if (paneltipi == "GCKK" && izo == "50")

            {
                textBox7.Text = Convert.ToString(En + PkI50);
            }

            else if (paneltipi == "GCKK" && izo == "60")

            {
                textBox7.Text = Convert.ToString(En + PkI60);
            }

            else if (paneltipi == "PK" && izo == "40")

            {
                textBox7.Text = Convert.ToString(En + PkI40);
            }

            else if (paneltipi == "PK" && izo == "50")

            {
                textBox7.Text = Convert.ToString(En + PkI50);
            }

            else if (paneltipi == "PK" && izo == "60")

            {
                textBox7.Text = Convert.ToString(En + PkI60);
            }

            else

            {
                textBox7.Text = Convert.ToString(En + PnI60);
            }

            if (paneltipi == "NP" && izo == "40")

            {
                textBox8.Text = Convert.ToString(Boy + PnI40);
            }


            else if (paneltipi == "MDP" && izo == "40")

            {
                textBox8.Text = Convert.ToString(Boy + PnI40);
            }

            else if (paneltipi == "GP" && izo == "40")

            {
                textBox8.Text = Convert.ToString(Boy + PnI40);
            }

            else if (paneltipi == "GP" && izo == "40")

            {
                textBox8.Text = Convert.ToString(Boy + PnI40);
            }

            else if (paneltipi == "BP" && izo == "40")

            {
                textBox8.Text = Convert.ToString(Boy + PnI40);
            }

            else if (paneltipi == "NEMP" && izo == "40")

            {
                textBox8.Text = Convert.ToString(Boy + PnI40);
            }

            else if (paneltipi == "FP" && izo == "40")

            {
                textBox8.Text = Convert.ToString(Boy + PnI40);
            }

            else if (paneltipi == "MHP" && izo == "40")

            {
                textBox8.Text = Convert.ToString(Boy + PnI40);
            }

            else if (paneltipi == "PP" && izo == "40")

            {
                textBox8.Text = Convert.ToString(Boy + PnI40);
            }

            else if (paneltipi == "DRP" && izo == "40")

            {
                textBox8.Text = Convert.ToString(Boy + PnI40);
            }

            else if (paneltipi == "PTP" && izo == "40")

            {
                textBox8.Text = Convert.ToString(Boy + PnI40);
            }



            else if (paneltipi == "NP" && izo == "50")

            {
                textBox8.Text = Convert.ToString(Boy + PnI50);
            }


            else if (paneltipi == "MDP" && izo == "50")

            {
                textBox8.Text = Convert.ToString(Boy + PnI50);
            }

            else if (paneltipi == "GP" && izo == "50")

            {
                textBox8.Text = Convert.ToString(Boy + PnI50);
            }

            else if (paneltipi == "BP" && izo == "50")

            {
                textBox8.Text = Convert.ToString(Boy + PnI50);
            }

            else if (paneltipi == "NEMP" && izo == "50")

            {
                textBox8.Text = Convert.ToString(Boy + PnI50);
            }

            else if (paneltipi == "FP" && izo == "50")

            {
                textBox8.Text = Convert.ToString(Boy + PnI50);
            }

            else if (paneltipi == "MHP" && izo == "50")

            {
                textBox8.Text = Convert.ToString(Boy + PnI50);
            }

            else if (paneltipi == "PP" && izo == "50")

            {
                textBox8.Text = Convert.ToString(Boy + PnI50);
            }

            else if (paneltipi == "DRP" && izo == "50")

            {
                textBox8.Text = Convert.ToString(Boy + PnI50);
            }

            else if (paneltipi == "PTP" && izo == "50")

            {
                textBox8.Text = Convert.ToString(Boy + PnI50);
            }

            else if (paneltipi == "NP" && izo == "50")

            {
                textBox8.Text = Convert.ToString(Boy + PnI50);
            }


            else if (paneltipi == "MDP" && izo == "50")

            {
                textBox8.Text = Convert.ToString(Boy + PnI50);
            }

            else if (paneltipi == "GP" && izo == "50")

            {
                textBox8.Text = Convert.ToString(Boy + PnI50);
            }

            else if (paneltipi == "BP" && izo == "50")

            {
                textBox8.Text = Convert.ToString(Boy + PnI50);
            }

            else if (paneltipi == "NEMP" && izo == "50")

            {
                textBox8.Text = Convert.ToString(Boy + PnI50);
            }

            else if (paneltipi == "FP" && izo == "50")

            {
                textBox8.Text = Convert.ToString(Boy + PnI50);
            }

            else if (paneltipi == "MHP" && izo == "50")

            {
                textBox8.Text = Convert.ToString(Boy + PnI50);
            }

            else if (paneltipi == "PP" && izo == "50")

            {
                textBox8.Text = Convert.ToString(Boy + PnI50);
            }

            else if (paneltipi == "DRP" && izo == "50")

            {
                textBox8.Text = Convert.ToString(Boy + PnI50);
            }

            else if (paneltipi == "PTP" && izo == "50")

            {
                textBox8.Text = Convert.ToString(Boy + PnI50);
            }

            else if (paneltipi == "NP" && izo == "60")

            {
                textBox8.Text = Convert.ToString(Boy + PnI60);
            }


            else if (paneltipi == "MDP" && izo == "60")

            {
                textBox8.Text = Convert.ToString(Boy + PnI60);
            }

            else if (paneltipi == "GP" && izo == "60")

            {
                textBox8.Text = Convert.ToString(Boy + PnI60);
            }

            else if (paneltipi == "BP" && izo == "60")

            {
                textBox8.Text = Convert.ToString(Boy + PnI60);
            }

            else if (paneltipi == "NEMP" && izo == "60")

            {
                textBox8.Text = Convert.ToString(Boy + PnI60);
            }

            else if (paneltipi == "FP" && izo == "60")

            {
                textBox8.Text = Convert.ToString(Boy + PnI60);
            }

            else if (paneltipi == "MHP" && izo == "60")

            {
                textBox8.Text = Convert.ToString(Boy + PnI60);
            }

            else if (paneltipi == "PP" && izo == "60")

            {
                textBox8.Text = Convert.ToString(Boy + PnI60);
            }

            else if (paneltipi == "DRP" && izo == "60")

            {
                textBox8.Text = Convert.ToString(Boy + PnI60);
            }

            else if (paneltipi == "NK" && izo == "40")

            {
                textBox8.Text = Convert.ToString(Boy + PkI40);
            }

            else if (paneltipi == "NK" && izo == "50")

            {
                textBox8.Text = Convert.ToString(Boy + PkI50);
            }

            else if (paneltipi == "NK" && izo == "60")

            {
                textBox8.Text = Convert.ToString(Boy + PkI60);
            }

            else if (paneltipi == "GK" && izo == "40")

            {
                textBox8.Text = Convert.ToString(Boy + PkI40);
            }

            else if (paneltipi == "GK" && izo == "50")

            {
                textBox8.Text = Convert.ToString(Boy + PkI50);
            }

            else if (paneltipi == "GK" && izo == "60")

            {
                textBox8.Text = Convert.ToString(Boy + PkI60);
            }

            else if (paneltipi == "KNK" && izo == "40")

            {
                textBox8.Text = Convert.ToString(Boy + PkI40);
            }

            else if (paneltipi == "KNK" && izo == "50")

            {
                textBox8.Text = Convert.ToString(Boy + PkI50);
            }

            else if (paneltipi == "KNK" && izo == "60")

            {
                textBox8.Text = Convert.ToString(Boy + PkI60);
            }

            else if (paneltipi == "KGK" && izo == "40")

            {
                textBox8.Text = Convert.ToString(Boy + PkI40);
            }

            else if (paneltipi == "KGK" && izo == "50")

            {
                textBox8.Text = Convert.ToString(Boy + PkI50);
            }

            else if (paneltipi == "KGK" && izo == "60")

            {
                textBox8.Text = Convert.ToString(Boy + PkI60);
            }

            else if (paneltipi == "NICK" && izo == "40")

            {
                textBox8.Text = Convert.ToString(Boy + IcKi40);
            }

            else if (paneltipi == "NICK" && izo == "50")

            {
                textBox8.Text = Convert.ToString(Boy + IcKi50);
            }

            else if (paneltipi == "NICK" && izo == "60")

            {
                textBox8.Text = Convert.ToString(Boy + IcKi60);
            }

            else if (paneltipi == "GICK" && izo == "40")

            {
                textBox8.Text = Convert.ToString(Boy + IcKi40);
            }

            else if (paneltipi == "GICK" && izo == "50")

            {
                textBox8.Text = Convert.ToString(Boy + IcKi50);
            }

            else if (paneltipi == "GICK" && izo == "60")

            {
                textBox8.Text = Convert.ToString(Boy + IcKi60);
            }

            else if (paneltipi == "GCKK" && izo == "40")

            {
                textBox8.Text = Convert.ToString(Boy + PkI40);
            }

            else if (paneltipi == "GCKK" && izo == "50")

            {
                textBox8.Text = Convert.ToString(Boy + PkI50);
            }

            else if (paneltipi == "GCKK" && izo == "60")

            {
                textBox8.Text = Convert.ToString(Boy + PkI60);
            }

            else if (paneltipi == "PK" && izo == "40")

            {
                textBox8.Text = Convert.ToString(Boy + PkI40);
            }

            else if (paneltipi == "PK" && izo == "50")

            {
                textBox8.Text = Convert.ToString(Boy + PkI50);
            }

            else if (paneltipi == "PK" && izo == "60")

            {
                textBox8.Text = Convert.ToString(Boy + PkI60);
            }

            else

            {
                textBox8.Text = Convert.ToString(Boy + PnI60);
            }

            textBox5.Text = textBox13.Text + "_D_" + textBox3.Text + "x" + textBox4.Text + "_" + textBox14.Text;
            textBox10.Text = textBox13.Text + "_I_" + textBox7.Text + "x" + textBox8.Text + "_" + textBox14.Text;

            sayı3 = Convert.ToDecimal(textBox3.Text);
            sayı4 = Convert.ToDecimal(textBox4.Text);
            sayı7 = Convert.ToDecimal(textBox7.Text);
            sayı8 = Convert.ToDecimal(textBox8.Text);


            toplam1 = ((sayı3 * sayı4) / 1000000)*8;
            Decimal sayi1 = toplam1;
            sayi1 = Decimal.Round(sayi1, 2);
            textBox6.Text = Convert.ToString(sayi1);

            toplam2 = ((sayı7 * sayı8) / 1000000)*8;
            Decimal sayi2 = toplam2;
            sayi2 = Decimal.Round(sayi2, 2);
            textBox9.Text = Convert.ToString(sayi2);



            {
                string[] files = Directory.GetFiles(@"Z:\Hendek\Uretim(Production)\Uretim\Common_Folders\7.Punch_Arsiv\PANELLER\", textBox5.Text + ".nc", SearchOption.AllDirectories);

                if (files.Length == 0)
                {
                    textBox15.Text = "Yok";
                }
                else
                {
                    textBox15.Text = "Var";
                    var dosyalar = new DirectoryInfo(@"Z:\Hendek\Uretim(Production)\Uretim\Common_Folders\7.Punch_Arsiv\PANELLER\").GetFiles(textBox5.Text + ".nc", SearchOption.AllDirectories);

                }

            }

            {
                string[] files = Directory.GetFiles(@"Z:\Hendek\Uretim(Production)\Uretim\Common_Folders\7.Punch_Arsiv\PANELLER\", textBox10.Text + ".nc", SearchOption.AllDirectories);

                if (files.Length == 0)
                {
                    textBox16.Text = "Yok";
                }
                else
                {
                    textBox16.Text = "Var";
                    var dosyalar = new DirectoryInfo(@"Z:\Hendek\Uretim(Production)\Uretim\Common_Folders\7.Punch_Arsiv\PANELLER\").GetFiles(textBox10.Text + ".nc", SearchOption.AllDirectories);

                }

            }



        }

private void ss(object sender, MouseEventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox12.Clear();

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            textBox11.Text = textBox13.Text + "_" + textBox1.Text + "x" + textBox2.Text + "_" + textBox14.Text;
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            textBox11.Text = textBox13.Text + "_" + textBox1.Text + "x" + textBox2.Text + "_" + textBox14.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }
    }
}