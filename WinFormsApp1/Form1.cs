using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmMeuAppTestes : Form
    {
        //modificadores
        string MeuNome = "LeoQ";
        int valor1;
        int valor2;
        int res;

        decimal nota1, nota2, nota3, nota4, media;

        private void btCalcMedia_Click(object sender, EventArgs e)
        {
            nota1 = decimal.Parse(textBoxNota1.Text);
            nota2 = decimal.Parse(textBoxNota2.Text);
            nota3 = decimal.Parse(textBoxNota3.Text);
            nota4 = decimal.Parse(textBoxNota4.Text);
            media = (nota1 + nota2 + nota3 + nota4) / 4;
            textBoxMedia.Text = Convert.ToString(media);

            if (media >= numericUpDownMedia.Value)            
                lbResultado.Text = "Parabéns Aprovado !";
            else
                lbResultado.Text = "Infelizmente Reprovado !";
        }

        public FrmMeuAppTestes()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            textBox.Text = MeuNome;
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_ok_parcelas_Click(object sender, EventArgs e)
        {
            valor1 = int.Parse(textBox1.Text);
            valor2 = int.Parse(textBox2.Text);
            res = valor1 + valor2;
            textBox3.Text = Convert.ToString(res);
        }
    }
}
