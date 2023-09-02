using Classes;
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
        #region Teste Declando variaveris 
        //modificadores
        string MeuNome = "LeoQ";
        int valor1;
        int valor2;
        int res;

        decimal nota1, nota2, nota3, nota4, media;

        #endregion Teste Declando variaveris

        public FrmMeuAppTestes()
        {
            InitializeComponent();
        }  
        
        #region Teste Calculando Médias
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
        #endregion Teste Calculando Médias

        #region Teste Loops
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
        #endregion Teste Loops      

        #region Teste ForEach
        private void tabControl1_Enter(object sender, EventArgs e)
        {
            comboBoxTipoForEach.SelectedIndex = 0;
        }
        private void btnForEach_Click(object sender, EventArgs e)
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
                    listBoxForEach.Items.Add(lista);
                }
            }
        }
        #endregion Teste ForEach

        #region Teste Evento de Botões
        private void btn_ok_Click(object sender, EventArgs e)
        {
            textBox.Text = MeuNome;
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion Teste Evento de Botões

        #region Teste Ssomando Parcelas
        private void bt_ok_parcelas_Click(object sender, EventArgs e)
        {
            valor1 = int.Parse(textBox1.Text);
            valor2 = int.Parse(textBox2.Text);
            res = valor1 + valor2;
            textBox3.Text = Convert.ToString(res);
        }
        #endregion Teste Ssomando Parcelas

        #region Teste Array
        private void btnArray_Click(object sender, EventArgs e)
        {
            listBoxArrays.Items.Clear();

            // 0 a 6 (array sempre inicia em 0)
            int[] valores = new int[]
            {
                10,20,30,40,50,60,70
            };

            listBoxArrays.Items.Add("Arrays usando foreach");
            foreach (int valor in valores)
                listBoxArrays.Items.Add(valor);


            listBoxArrays.Items.Add("Arrays usando for");
            for (int indice = 0; indice < valores.Length; indice++)
                listBoxArrays.Items.Add(valores[indice]);         

        }
        #endregion Teste Array


        #region Classe Pessoas
        private void btnProcessaPessoas_Click(object sender, EventArgs e)
        {
            listBoxPessoas.Items.Clear();

            List<Pessoas> vPes = new List<Pessoas>();

            vPes.Add(new Pessoas { id = 1, nome = "João", cidade = "Petrópolis", dataNascimento = DateTime.Parse("15/02/1972") });
            vPes.Add(new Pessoas { id = 2, nome = "José", cidade = "Salvador", dataNascimento = DateTime.Parse("10/12/1988") });                    
            
            for (int valor = 0; valor <= vPes.Count-1; valor += 1)
                    listBoxPessoas.Items.Add("Código :"  + vPes[valor].id.ToString() + ", " + 
                                     "Nome :"    + vPes[valor].nome + ", " +
                                     "Cidade :"  + vPes[valor].cidade + ", " + 
                                     "Dt.Nasc :" + vPes[valor].dataNascimento.ToString("dd/MM/yyyy") + ", " +
                                     "Idade : "  + vPes[valor].idade.ToString());
        }
        #endregion Classe Pessoas

    }
}
