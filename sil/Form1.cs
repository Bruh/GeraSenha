using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Queue minhaFila = new Queue();

        public int A = 0;

        public void gerarSenha()
        {
            A++;
            minhaFila.Enqueue(A);
            label1.Text = "CC" + A;
        }

        public void chamar()
        {

            label2.Text = "CC" + minhaFila.Dequeue();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gerarSenha();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chamar();
        }

       
    }
}
