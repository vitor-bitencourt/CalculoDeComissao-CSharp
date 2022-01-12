using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comissão
{
    public partial class Form1 : Form
    {
        double val, val2, val3, cms, cms2, cms3, qtt;
        string nome, nome1, nome2;

        private void button3_Click_2(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
      
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_cms.Clear();
            txt_cms2.Clear();
            txt_cms3.Clear();
           
            txt_nome.Clear();
            txt_nome1.Clear();
            txt_nome2.Clear();
            txt_nome3.Clear();
            txt_nome4.Clear();
            txt_nome5.Clear();
           
            txt_val.Clear();
            txt_val2.Clear();
            txt_val3.Clear();
           
            txt_valven2.Clear();
            txt_valven3.Clear();
            txt_valven4.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            val = double.Parse(txt_val.Text);
            val2 = double.Parse(txt_val2.Text);
            val3 = double.Parse(txt_val3.Text);
            nome = txt_nome.Text;
            nome1 = txt_nome1.Text;
            nome2 = txt_nome2.Text;

            //Cálculo do funcionário 1
            if (val > 50000 && val2 > 50000 && val3 > 50000)
            {
                cms = (12 * val) / 100;
                cms2 = (12 * val2) / 100;
                cms3 = (12 * val3) / 100;
                qtt++;
            }
            else if (val >= 30000 & val<= 50000 && val2 >= 30000 & val2 <=50000 && val3 >= 30000 & val3 <= 50000)
            {
                cms = (9.5 * val) / 100;
                cms2 = (9.5 * val2) / 100;
                cms3 = (9.5 * val3) / 100;
                qtt++;
            }
            else
            {
                cms = (7 * val)/100;
                cms2 = (7 * val2) / 100;
                cms3 = (7 * val3) / 100;
                qtt++;
            }

            //Mostra os nomes
            txt_nome3.Text = Convert.ToString(nome);
            txt_nome4.Text = Convert.ToString(nome1);
            txt_nome5.Text = Convert.ToString(nome2);
            //Mostra o valor da venda
            txt_valven2.Text = Convert.ToString(val.ToString("C"));
            txt_valven3.Text = Convert.ToString(val2.ToString("C"));
            txt_valven4.Text = Convert.ToString(val3.ToString("C"));
            //Mostra o valor da comissão
            txt_cms.Text = Convert.ToString(cms.ToString("C"));
            txt_cms2.Text = Convert.ToString(cms2.ToString("C"));
            txt_cms3.Text = Convert.ToString(cms3.ToString("C"));
            //Mostra a quantidade de vendas da empresa         
            txt_vendas.Text = Convert.ToString(qtt);
            txt_vendas1.Text = Convert.ToString(qtt);
            txt_vendas2.Text = Convert.ToString(qtt);
        }


            
          
        }
   }

