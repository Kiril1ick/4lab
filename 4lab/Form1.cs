using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace _4lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                raschet();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void raschet()
        {
            Random rnd1 = new Random();
            Random rnd2 = new Random(rnd1.Next());
            Random rnd3 = new Random(rnd2.Next());
            Random rnd4 = new Random(rnd3.Next());
            Random rnd5 = new Random(rnd4.Next());
            Random rnd6 = new Random(rnd5.Next());
            Random rnd7 = new Random(rnd6.Next());
            Random rnd8 = new Random(rnd7.Next());
            Random rnd9 = new Random(rnd8.Next());
            Random rnd10 = new Random(rnd9.Next());
            Random rnd11= new Random(rnd10.Next());
            Random rnd12 = new Random(rnd11.Next());
            Random rnd13 = new Random(rnd12.Next());
            Random rnd14 = new Random(rnd13.Next());
            Random rnd15 = new Random(rnd14.Next());
            Random rnd16 = new Random(rnd15.Next());
            int ispit = int.Parse(textBox17.Text);
            double ver1 = double.Parse(textBox1.Text);
            double ver2 = double.Parse(textBox2.Text);
            double ver3 = double.Parse(textBox3.Text);
            double ver4 = double.Parse(textBox4.Text);
            double ver5 = double.Parse(textBox5.Text);
            double ver6 = double.Parse(textBox6.Text);
            double ver7 = double.Parse(textBox7.Text);
            double ver8 = double.Parse(textBox8.Text);
            double ver9 = double.Parse(textBox9.Text);
            double ver10 = double.Parse(textBox10.Text);
            double ver11 = double.Parse(textBox11.Text);
            double ver12 = double.Parse(textBox12.Text);
            double ver13 = double.Parse(textBox13.Text);
            double ver14 = double.Parse(textBox14.Text);
            double ver15 = double.Parse(textBox15.Text);
            double ver16 = double.Parse(textBox16.Text);

            double verA = 1 - (1-ver1*ver2)*(1-ver3*ver4);
            double verB = (1-(1-ver5)*(1-ver6*ver7))*ver12;
            double verC = 1 - (1 - ver8) * (1 - ver9) * (1 - ver10 * ver11);
            double verD = 1-(1-verA)*(1-verB)*(1-verC);
            double verE = 1 - (1 - ver13) * (1 - ver14 * (1 - (1 - ver15) * (1 - ver16)));
            double verO = verD * verE;

            label4.Text = verO.ToString();

            double counter = 0;
            for (int i = 0;i<ispit;i++)
            {
                bool block1 = rnd1.NextDouble() <= ver1;
                bool block2 = rnd2.NextDouble() <= ver2;
                bool block3 = rnd3.NextDouble() <= ver3;
                bool block4 = rnd4.NextDouble() <= ver4;
                bool block5 = rnd5.NextDouble() <= ver5;
                bool block6 = rnd6.NextDouble() <= ver6;
                bool block7 = rnd7.NextDouble() <= ver7;
                bool block8 = rnd8.NextDouble() <= ver8;
                bool block9 = rnd9.NextDouble() <= ver9;
                bool block10 = rnd10.NextDouble() <= ver10;
                bool block11 = rnd11.NextDouble() <= ver11;
                bool block12 = rnd12.NextDouble() <= ver12;
                bool block13 = rnd13.NextDouble() <= ver13;
                bool block14 = rnd14.NextDouble() <= ver14;
                bool block15 = rnd15.NextDouble() <= ver15;
                bool block16 = rnd16.NextDouble() <= ver16;

                bool schemA = (block1 && block2) || (block3 && block4);
                bool schemB = (block5 || (block6 && block7)) && block12;
                bool schemC = block8 || block9 || (block10 && block11);
                bool schemD = schemA || schemB || schemC;
                bool schemE = block13 || (block14 && (block15 || block16));
                if (schemE && schemD) counter++;
            }

            label5.Text = (counter/ispit).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
