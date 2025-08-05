using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios
{
    public partial class frmOperador6 : Form
    {
        public frmOperador6()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if(txtVelocidade.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher o campo vazio");
                txtVelocidade.Focus();
                txtVelocidade.Clear();
            }
            else
            {
                double velocidadePermitida, velocidadeDigitada, tolerancia;
                string classificacao = "";

                try
                {
                    velocidadeDigitada = Convert.ToDouble(txtVelocidade.Text);
                    velocidadePermitida = 50;
                    tolerancia = velocidadePermitida * 0.02;


                    if(velocidadeDigitada <= 50 + tolerancia)
                    {
                        classificacao = "Sem multa";
                    }
                    else if(velocidadeDigitada >= 51 && velocidadeDigitada <= 60)
                    {
                        classificacao = "Multa 3 pontos";
                    }
                    else if(velocidadeDigitada >= 61 && velocidadeDigitada <= 70)
                    {
                        classificacao = "Multa 5 pontos";
                    }
                    else if(velocidadeDigitada >= 71 && velocidadeDigitada <= 80)
                    {
                        classificacao = "Multa 10 pontos";
                    }
                    else if(velocidadeDigitada >= 81 && velocidadeDigitada <= 90)
                    {
                        classificacao = "Multa 15 pontos";
                    }
                    else if(velocidadeDigitada >= 91 && velocidadeDigitada <= 100)
                    {
                        classificacao = "Multa 18 pontos";
                    }
                    else if(velocidadeDigitada >= 100)
                    {
                        classificacao = "Multa 20 pontos e suspensão da carteira";
                    }

                    
                    lblClassificacao.Text = classificacao;
 
                }
                catch
                {
                    MessageBox.Show("Preencher o campo corretamente");
                }
            }
        }
    }
}
