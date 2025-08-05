using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Exercicios
{
    public partial class frmOperador4 : Form
    {
        public frmOperador4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtAltura.Text.Trim() == string.Empty || txtPeso.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher os campos vazio");
            }
            else
            {
                double peso, altura, imc;
                string classificacao = "";
                string imagemPath = "";


                try
                {
                    peso = Convert.ToDouble(txtPeso.Text);
                    altura = Convert.ToDouble(txtAltura.Text);
                    imc = peso / (altura * altura);

                    if (imc >= 0 && imc <= 20)
                    {
                        classificacao = "Magro";
                        imagemPath = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Imagens", "magro.png");
                    }
                    else if (imc >= 21 && imc <= 25)
                    {
                        classificacao = "Peso ideal";
                        imagemPath = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Imagens", "peso_ideal.png");
                    }
                    else if (imc >= 26 && imc <= 30)
                    {
                        classificacao = "Obeso";
                        imagemPath = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Imagens", "obeso.png");
                    }
                    else
                    {
                        classificacao = "Muito obeso";
                        imagemPath = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Imagens", "muito_obeso.png");
                    }

                    lblImc.Text = imc.ToString("F2");
                    lblClassificacao.Text = classificacao;

                    if (System.IO.File.Exists(imagemPath))
                    {
                        picIMC.Image = System.Drawing.Image.FromFile(imagemPath);
                        picIMC.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        MessageBox.Show("Imagem não encontrada:\n" + imagemPath);
                        picIMC.Image = null;
                    }

                }

                catch
                {
                    MessageBox.Show("Preencher todos os campos corretamente");
                }
            }

        }

    }
}

