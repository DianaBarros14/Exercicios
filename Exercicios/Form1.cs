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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (txtProduto.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher campo NOME DO PRODUTO");

                txtProduto.Focus();
                txtProduto.Clear();

            }
            else if (!
                decimal.TryParse(txtCompra.Text.Trim(), System.Globalization.NumberStyles.Any, new System.Globalization.CultureInfo("pt-BR"), out
             _))
            {
                MessageBox.Show("Preencher o campo VALOR DA COMPRA, apenas números");

                txtCompra.Focus();
                txtCompra.Clear();
            }
            else if (!
                decimal.TryParse(txtVenda.Text.Trim(), System.Globalization.NumberStyles.Any, new System.Globalization.CultureInfo("pt-BR"), out
                _))
            {
                MessageBox.Show("Preencher o campo VALOR DA VENDA, apenas números");

                txtVenda.Focus();
                txtVenda.Clear();

            }
            else if (txtDescricao.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher o campo DESCRIÇÃO");

                txtDescricao.Focus();
                txtDescricao.Clear();
            }
            else
            {
                string produto, compra, venda, descricao, valor;

                produto = txtProduto.Text;
                compra = txtCompra.Text;
                venda = txtVenda.Text;
                descricao = txtDescricao.Text;
                MessageBox.Show("Nome Produto: " + produto + "\nValor de compra: " + compra + "\nValor de venda: " + venda + "\nDescrição: " + descricao);
            }
        }
    }
}
