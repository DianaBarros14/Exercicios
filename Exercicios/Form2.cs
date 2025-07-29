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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtGanhosJan.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher o campo vazio");
                txtGanhosJan.Focus();
                txtGanhosJan.Clear();
            }
            else if (txtGanhosFev.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher o campo vazio");
                txtGanhosFev.Focus();
                txtGanhosFev.Clear();
            }
            else if (txtGanhosMar.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher o campo vazio");
                txtGanhosMar.Focus();
                txtGanhosMar.Clear();
            }
            else if (txtGanhosAbr.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher o campo vazio");
                txtGanhosAbr.Focus();
                txtGanhosAbr.Clear();
            }
            else if (txtGanhosMai.Text.Trim() == string.Empty)
            {
                MessageBox.Show("preencher o campo vazio");
                txtGanhosMai.Focus();
                txtGanhosMai.Clear();
            }
            else if (txtGanhosJun.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher o campo vazio");
                txtGanhosJun.Focus();
                txtGanhosJun.Clear();
            }
            else if (txtGanhosJul.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher o campo vazio");
                txtGanhosJul.Focus();
                txtGanhosJul.Clear();
            }
            else if (txtGanhosAgo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher o campo vazio");
                txtGanhosAgo.Focus();
                txtGanhosAgo.Clear();
            }
            else if (txtGanhosSet.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher o campo vazio");
                txtGanhosSet.Focus();
                txtGanhosSet.Clear();
            }
            else if (txtGanhosOut.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher o campo vazio");
                txtGanhosOut.Focus();
                txtGanhosOut.Clear();
            }
            else if (txtGanhosNov.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher o campo vazio");
                txtGanhosNov.Focus();
                txtGanhosNov.Clear();
            }
            else if (txtGanhosDez.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher o campo vazio");
                txtGanhosDez.Focus();
                txtGanhosDez.Clear();
            }
            else if (txtGastosJan.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher o campo vazio");
                txtGastosJan.Focus();
                txtGastosJan.Clear();
            }
            else if (txtGastosFev.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher o campo vazio");
                txtGastosFev.Focus();
                txtGastosFev.Clear();
            }
            else if (txtGastosMar.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher o campo vazio");
                txtGastosMar.Focus();
                txtGastosMar.Clear();
            }
            else if (txtGastosAbr.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher o campo vazio");
                txtGastosAbr.Focus();
                txtGastosAbr.Clear();
            }
            else if (txtGastosMai.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher o campo vazio");
                txtGastosMai.Focus();
                txtGastosMai.Clear();
            }
            else if (txtGastosJun.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher o campo vazio");
                txtGastosJun.Focus();
                txtGastosJun.Clear();
            }
            else if (txtGastosJul.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher o campo vazio");
                txtGastosJul.Focus();
                txtGastosJul.Clear();
            }
            else if (txtGastosAgo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher o campo vazio");
                txtGastosAgo.Focus();
                txtGastosAgo.Clear();
            }
            else if (txtGastosSet.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher o campo vazio");
                txtGastosSet.Focus();
                txtGastosSet.Clear();
            }
            else if (txtGastosOut.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher o campo vazio");
                txtGastosOut.Focus();
                txtGastosOut.Clear();
            }
            else if (txtGastosNov.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher o campo vazio");
                txtGastosNov.Focus();
                txtGastosNov.Clear();
            }
            else if (txtGastosDez.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher o campo vazio");
                txtGastosDez.Focus();
                txtGastosDez.Clear();
            }
            else
            {
                double ganhosJan, ganhosFev, ganhosMar, ganhosAbr, ganhosMai, ganhosJun, ganhosJul, ganhosAgo, ganhosSet, ganhosOut,
                    ganhosNov, ganhosDez, gastosJan, gastosFev, gastosMar, gastosAbr, gastosMai, gastosJun, gastosJul, gastosAgo,
                    gastosSet, gastosOut, gastosNov, gastosDez, ganhosAno, gastosAno;
                try
                {
                    ganhosJan = Convert.ToDouble(txtGanhosJan.Text);
                    ganhosFev = Convert.ToDouble(txtGanhosFev.Text);
                    ganhosMar = Convert.ToDouble(txtGanhosMar.Text);
                    ganhosAbr = Convert.ToDouble(txtGanhosAbr.Text);
                    ganhosMai = Convert.ToDouble(txtGanhosMai.Text);
                    ganhosJun = Convert.ToDouble(txtGanhosJun.Text);
                    ganhosJul = Convert.ToDouble(txtGanhosJun.Text);
                    ganhosAgo = Convert.ToDouble(txtGanhosAgo.Text);
                    ganhosSet = Convert.ToDouble(txtGanhosSet.Text);
                    ganhosOut = Convert.ToDouble(txtGanhosOut.Text);
                    ganhosNov = Convert.ToDouble(txtGanhosNov.Text);
                    ganhosDez = Convert.ToDouble(txtGanhosDez.Text);
                    gastosJan = Convert.ToDouble(txtGastosJan.Text);
                    gastosFev = Convert.ToDouble(txtGastosFev.Text);
                    gastosMar = Convert.ToDouble(txtGastosMar.Text);
                    gastosAbr = Convert.ToDouble(txtGastosAgo.Text);
                    gastosMai = Convert.ToDouble(txtGastosMai.Text);
                    gastosJun = Convert.ToDouble(txtGastosJun.Text);
                    gastosJul = Convert.ToDouble(txtGastosJul.Text);
                    gastosAgo = Convert.ToDouble(txtGastosAgo.Text);
                    gastosSet = Convert.ToDouble(txtGastosSet.Text);
                    gastosOut = Convert.ToDouble(txtGastosOut.Text);
                    gastosNov = Convert.ToDouble(txtGastosNov.Text);
                    gastosDez = Convert.ToDouble(txtGastosDez.Text);
                    ganhosAno = ganhosJan + ganhosFev + ganhosMar + ganhosAbr + ganhosMai + ganhosJun +
                        ganhosJul + ganhosAgo + ganhosSet + ganhosOut + ganhosNov + ganhosDez;
                    gastosAno = gastosJan + gastosFev + gastosMar + gastosAbr + ganhosMai + gastosJun +
                        gastosJul + gastosAgo + gastosSet + gastosOut + gastosNov + gastosDez;


                    txtlucroJan.Text = (ganhosJan - gastosJan).ToString("F2");
                    txtlucroFev.Text = (ganhosFev - gastosFev).ToString("F2");
                    txtlucroMar.Text = (ganhosMar - gastosMar).ToString("F2");
                    txtlucroAbr.Text = (ganhosAbr - gastosAbr).ToString("F2");
                    txtlucroMai.Text = (ganhosMai - gastosMai).ToString("F2");
                    txtlucroJun.Text = (ganhosJun - gastosJun).ToString("F2");
                    txtlucroJul.Text = (ganhosJun - gastosJul).ToString("F2");
                    txtlucroAgo.Text = (ganhosAgo - gastosAgo).ToString("F2");
                    txtlucroSet.Text = (ganhosSet - gastosSet).ToString("F2");
                    txtlucroOut.Text = (ganhosOut - gastosOut).ToString("F2");
                    txtlucroNov.Text = (ganhosNov - gastosNov).ToString("F2");
                    txtlucroDez.Text = (ganhosDez - gastosDez).ToString("F2");
                    txtganhosAno.Text = (ganhosAno).ToString("F2");
                    txtgastosAno.Text = (gastosAno).ToString("F2");
                    txtlucrosAno.Text = (ganhosAno - gastosAno).ToString("F2");

                }
                catch
                {
                    MessageBox.Show("Preencher todos campos");
                }
            }
        }
    }
}


                 
                
            

            
        
    
    

