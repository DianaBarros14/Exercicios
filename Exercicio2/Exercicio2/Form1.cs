using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (txtJogador1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher o campo JOGADOR 1");

                txtJogador1.Focus();
                txtJogador1.Clear();

            }
            else if (txtJogador2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher o campo JOGADOR 2");

                txtJogador2.Focus();
                txtJogador2.Clear();

            }
            else if (txtJogador3.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher o campo JOGADOR 3");

                txtJogador3.Focus();
                txtJogador3.Clear();

            }
            else if (txtTecnico.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher o campo TECNICO");

                txtTecnico.Focus();
                txtTecnico.Clear();

            }
            else if (txtCapitao.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher o campo CAPITÃO");

                txtCapitao.Focus();
                txtCapitao.Clear();

            }
            else
            {
                string jogador1, jogador2, jogador3, tecnico, capitao;

                jogador1 = txtJogador1.Text;
                jogador2 = txtJogador2.Text;
                jogador3 = txtJogador3.Text;
                tecnico = txtTecnico.Text;
                capitao = txtCapitao.Text;

                MessageBox.Show("Nome do jogador 1: " + jogador1 + "\nNome do jogador 2: " + jogador2 + "\nNome do jogador 3: " + jogador3 + "\nNome do técnico: " + tecnico + "\nNome do capitão: " + capitao);
            }
        }
    }
}
