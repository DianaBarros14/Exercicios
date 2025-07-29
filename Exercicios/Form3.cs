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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text.Trim() == string.Empty)
            {
                txtNumero1.Focus();
                txtNumero1.Clear();
            }
            else if (txtNumero2.Text.Trim() == string.Empty)
            {
                txtNumero2.Focus();
                txtNumero2.Clear();
            }
            else if (txtNumero3.Text.Trim() == string.Empty)
            {
                txtNumero3.Focus();
                txtNumero3.Clear();
            }
            else
            {
                double numero1, numero2, numero3, resultado;

                try
                {
                    numero1 = Convert.ToDouble(txtNumero1.Text);
                    numero2 = Convert.ToDouble(txtNumero2.Text);
                    numero3 = Convert.ToDouble(txtNumero3.Text);
                    resultado = numero1 + numero2 + numero3;

                    txtResultado.Text = (resultado / 3).ToString("F2");
                }
                catch
                {
                    MessageBox.Show("Preencher os campos vazios");
                }
            }
        }
    }
}
