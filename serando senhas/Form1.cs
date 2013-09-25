using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace serando_senhas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            Queue fila = new Queue();
            Queue fila2 = new Queue();

            public int C = 0;
            public int CP = 0;

            public void gerarSenhaCC()
            {
                C++;
                fila.Enqueue(C);
                label4.Text = "CC" + C;
            }

            public void gerarSenhaCP()
            {
                CP++;
                fila2.Enqueue(CP);
                label4.Text = "CP" + CP;
            }    

           
            public void chamar()
            {
                try
                {
                    //label2.Text = "CC" + fila.Dequeue();
                    if (fila2.Count == 0)
                    {
                        label2.Text = "CC" + fila.Dequeue();
                        
                    }
                    else if ((fila2.Count + 4) > (fila.Count))
                    {
                        label2.Text = "CP" + fila2.Dequeue();
                       
                    }
                    else
                    {
                        label2.Text = "CC" + fila.Dequeue();
                        
                    }

                    

                }
                catch (Exception)
                {

                    MessageBox.Show("Sem clientes para ser atendidos.", "Atenção!!!" , MessageBoxButtons.OK ,MessageBoxIcon.Exclamation);            
                }

            }
       
        private void btchamar_Click(object sender, EventArgs e)
        {
            chamar();
        }

        private void btcliente_Click_1(object sender, EventArgs e)
        {
            gerarSenhaCC();
        }

        private void btprefe_Click_1(object sender, EventArgs e)
        {
            gerarSenhaCP();
        }

         
    }
}
