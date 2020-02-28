using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioUdemy
{
    public partial class Form1 : Form
    {
        Exercicio01 ex = new Exercicio01();
        public Form1()
        {
            InitializeComponent();

           
        }

        public void Limpar()
        {
            txtCD01.Clear();
            txtCD02.Clear();
            txtQtd01.Clear();
            txtQtd02.Clear();
            txtValor01.Clear();
            txtValor02.Clear();
        }

    


        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        
        private void btnExecutar_Click(object sender, EventArgs e)
        {
          

            ex.cod01 = txtCD01.Text;
            ex.cod02 = txtCD02.Text;
            ex.quant01 = txtQtd01.Text;
            ex.quant02 = txtQtd02.Text;
            ex.valor01 = txtValor01.Text;
            ex.valor02 = txtValor02.Text;


            if (float.Parse(ex.quant01) != 0) 
            {
                ex.Executar();
            }
            if (float.Parse(ex.quant02) != 0) 
            {
                ex.Executar();
            }
            ex.Executar();
            lblResul.Text = Convert.ToString("O Resultrado final: "+(ex.resultadofinal));
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
