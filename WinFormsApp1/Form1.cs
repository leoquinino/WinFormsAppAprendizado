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


            /*  OPERADORES
             == IGUAL
             != DIFERENTE
             && AND
             || OR
             >  MAIOR QUE
             <  MENOR QUE
             <= MENOR IGUAL
             >= MAIOR IGUAL
            */

            /* INCREMENTOS / DECREMENTOS
             ++ --> INCREMENTA +1
             -- --> DECREMENTA -1
            EXEMPLO: 
                MEDIA = += 
                MEDIA = --
            */

            if (media < numericUpDownMediaLimite.Value)
                lbResultado.Text = "Infelizmente REPROVADO ESTUDE MAIS !";
            else if (media >= numericUpDownMediaLimite.Value && media < numericUpDownMedia.Value)            
                lbResultado.Text = "Parabéns APROVADO no Limite !";
            else if (media > numericUpDownMediaLimite.Value && media == numericUpDownMedia.Value)
                lbResultado.Text = "Parabéns APROVADO na Média !";
            else if (media > numericUpDownMedia.Value && media < numericUpDownMediaLouvor.Value)
                lbResultado.Text = "Parabéns APROVADO Acima da Média !";
            else if (media >= numericUpDownMediaLouvor.Value)
                lbResultado.Text = "Parabéns APROVADO Acima da Média e com muito Louvor !";            
        }

        private void btOk_Loop_Click(object sender, EventArgs e)
        {
            lblProcessamento.Visible = false;

            //incrementa 1 em 1 valor++  ou valor+=1
            //incrementa 2 em 2 valor+=2
            //etc...

            //loop for
            for (int valor = 1; valor <= 50; valor+=1)
            {
                ListView.Items.Add(valor.ToString());
            }

            lblProcessamento.Text = "Processamento...";
            lblProcessamento.Visible = true;

            int vezes = 1;

            string txt = "";

            //lopp while
            while (vezes <= ListView.Items.Count)
            {
                txt = "Processamento... " + vezes.ToString();

                lblProcessamento.Text = txt.ToUpper();
                vezes++;
            }
        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {
            comboBoxTipoForEach.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxForEach.Items.Clear();

            //looop foreach com char
            if (comboBoxTipoForEach.SelectedIndex == 0)
            {
                string frase = "Meu Curso de C# Vamos Testar os Recursos";
                foreach (char f in frase)
                {
                    listBoxForEach.Items.Add(f);
                }
            }

            if (comboBoxTipoForEach.SelectedIndex == 1)
            {
                List<string> listaNome = new List<string>()
                {
                    "Leo", "Gau", "Felipe", "Gisele", "Elisa"
                };

                foreach (string lista in listaNome)
                {
                    listBoxForEach.Items.Add (lista);
                }
            }
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
