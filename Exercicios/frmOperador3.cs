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
    public partial class frmOperador3 : Form
    {
        public frmOperador3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtSalario.Text.Trim() == string.Empty || txtPorcentagem.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher todos os campos");
            }
            else
            {
                decimal salario, aumento, resultado, resultadoSalario;
                string classificacao = "";

                try 
                {
                    salario = Convert.ToDecimal(txtSalario.Text);
                    aumento = Convert.ToDecimal(txtPorcentagem.Text);
                    resultado = (salario * aumento) / 100;
                    resultadoSalario = salario + resultado;

                    if(resultado >= 0 && resultado <= 100)
                    {
                        classificacao = "Aumento nível 1";
                    }
                    else if(resultado >= 101 && resultado <= 200)
                    {
                        classificacao = "Aumento nível 2";
                    }
                    else if(resultado >= 201 && resultado <= 300)
                    {
                        classificacao = "Aumento nível 3";
                    }
                    else if(resultado >= 301 && resultado <= 400)
                    {
                        classificacao = "Aumento nível 4";
                    }
                    else if(resultado >= 400)
                    {
                        classificacao = "Aumento nível 5";
                    }

                        txtResultado.Text = Convert.ToString(resultadoSalario);
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
