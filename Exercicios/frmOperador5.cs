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
    public partial class frmOperador5 : Form
    {
        public frmOperador5()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(txtMesAnterior.Text.Trim() == string.Empty || txtMesAtual.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher todos os campos vazios");
            }
            else
            {
                double anterior, atual, resultadoAnterior, resultadoAtual, aumentoAnterior, aumentoAtual, aumentos;
                string classificacao = "";

                try
                {
                    anterior = Convert.ToDouble(txtMesAnterior.Text);
                    atual = Convert.ToDouble(txtMesAtual.Text);
                    resultadoAnterior = anterior * 1.15;
                    resultadoAtual = atual * 1.18;
                    aumentoAnterior = resultadoAnterior - anterior;
                    aumentoAtual = resultadoAtual - atual;
                    aumentos = aumentoAnterior + aumentoAtual;

                    lblAumentoAnterior.Text = Convert.ToString(aumentoAnterior);
                    lblAumentoAtual.Text = Convert.ToString(aumentoAtual);
                    
                    if(aumentos >= 0 && aumentos <= 100)
                    {
                        classificacao = "Aumento RUIM";
                    }
                    else if(aumentos >= 101 && aumentos <= 200)
                    {
                        classificacao = "Aumento RAZOÁVEL";
                    }
                    else if(aumentos >= 201 && aumentos <= 300)
                    {
                        classificacao = "Aumento BOM";
                    }
                    else if(aumentos >= 301 && aumentos <= 400)
                    {
                        classificacao = "Aumento ÓTIMO";
                    }
                    else if(aumentos >= 401)
                    {
                        classificacao = "Aumento EXCELENTE";
                    }

                    lblClassificacao.Text = classificacao;

                }
                catch
                {
                    MessageBox.Show("Preencher todos os campos corretamente");
                }
            }
        }
    }
}
