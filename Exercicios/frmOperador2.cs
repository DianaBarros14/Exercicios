using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios
{
    public partial class frmOperador2 : Form
    {
        public frmOperador2()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if(txtNumero1.Text.Trim() == string.Empty || txtNumero2.Text.Trim() == string.Empty 
                || txtNumero3.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher todos os campos corretamente");
            }
            else
            {
                double numero1, numero2, numero3, resultado;

                try
                {
                    numero1 = Convert.ToDouble(txtNumero1.Text);
                    numero2 = Convert.ToDouble(txtNumero2.Text);
                    numero3 = Convert.ToDouble(txtNumero3.Text);
                    resultado = numero2 / 2;

                    lblResultado.Text = Convert.ToString(resultado);

                    if(resultado >= numero1 && resultado <= numero3)
                    {
                        MessageBox.Show("O numero " + resultado + " está entre o número INICIAL ( " + numero1 + " ) e FINAL ( " + numero3 + " )");
                    }
                    else
                    {
                        MessageBox.Show("O numero " + resultado + " NÃO está entre o número INICIAL ( " + numero1 + " ) e FINAL ( " + numero3 + " )");
                    }
                }
                catch
                {
                    MessageBox.Show("Digitar os campos corretamente");
                }
            }
        }
    }
}
