using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (txtRsocial.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher o campo RAZÃO SOCIAL");
                txtRsocial.Focus();
                txtRsocial.Clear();
            }
            else if (txtNfantasia.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher o campo NOME FANTASIA");
                txtNfantasia.Focus();
                txtNfantasia.Clear();
            }
            else if (!mtbCnpj.MaskFull)
            {
                MessageBox.Show("Preencher o campo CNPJ");
                mtbCnpj.Focus();
                mtbCnpj.Clear();
            }
            else if (!mtbTel.MaskFull)
            {
                MessageBox.Show("Preencher o campo TELEFONE");
                mtbTel.Focus();
                mtbTel.Clear();
            }
            else if (txtObs.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Prenecher o campo OBSERVAÇÃO");
                txtObs.Focus();
                txtObs.Clear();
            }
            else
            {
                string rSocial, nFantasia, cnpj, tel, obs;
                rSocial = txtRsocial.Text;
                nFantasia = txtNfantasia.Text;
                cnpj = mtbCnpj.Text;
                tel = mtbTel.Text;
                obs = txtObs.Text;

                MessageBox.Show("Razão social: " + rSocial + "\nNome fantasia: " + nFantasia + "\nCnpj: " + cnpj + "\nTelefone: " + tel + "\nObservação: " + obs);

            }

        }
    }
}
       

