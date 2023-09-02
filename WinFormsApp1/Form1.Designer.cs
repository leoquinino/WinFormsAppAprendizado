namespace WinFormsApp1
{
    partial class FrmMeuAppTestes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PageBotoes = new System.Windows.Forms.TabPage();
            this.textBox = new System.Windows.Forms.TextBox();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.PageCalcular = new System.Windows.Forms.TabPage();
            this.bt_ok_parcelas = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblParcela2 = new System.Windows.Forms.Label();
            this.lblParcela1 = new System.Windows.Forms.Label();
            this.PageNotasMedia = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownMediaLouvor = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownMediaLimite = new System.Windows.Forms.NumericUpDown();
            this.lbResultado = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownMedia = new System.Windows.Forms.NumericUpDown();
            this.btCalcMedia = new System.Windows.Forms.Button();
            this.textBoxMedia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNota4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNota3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNota2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNota1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageLoops = new System.Windows.Forms.TabPage();
            this.lblProcessamento = new System.Windows.Forms.Label();
            this.btOk_Loop = new System.Windows.Forms.Button();
            this.ListView = new System.Windows.Forms.ListBox();
            this.tabPageForEach = new System.Windows.Forms.TabPage();
            this.lblTipoForEach = new System.Windows.Forms.Label();
            this.comboBoxTipoForEach = new System.Windows.Forms.ComboBox();
            this.btnForEach = new System.Windows.Forms.Button();
            this.listBoxForEach = new System.Windows.Forms.ListBox();
            this.tabPageArray = new System.Windows.Forms.TabPage();
            this.btnArray = new System.Windows.Forms.Button();
            this.listBoxArrays = new System.Windows.Forms.ListBox();
            this.tabPageClassePessoa = new System.Windows.Forms.TabPage();
            this.listBoxPessoas = new System.Windows.Forms.ListBox();
            this.btnProcessaPessoas = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.PageBotoes.SuspendLayout();
            this.PageCalcular.SuspendLayout();
            this.PageNotasMedia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMediaLouvor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMediaLimite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMedia)).BeginInit();
            this.tabPageLoops.SuspendLayout();
            this.tabPageForEach.SuspendLayout();
            this.tabPageArray.SuspendLayout();
            this.tabPageClassePessoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.PageBotoes);
            this.tabControl1.Controls.Add(this.PageCalcular);
            this.tabControl1.Controls.Add(this.PageNotasMedia);
            this.tabControl1.Controls.Add(this.tabPageLoops);
            this.tabControl1.Controls.Add(this.tabPageForEach);
            this.tabControl1.Controls.Add(this.tabPageArray);
            this.tabControl1.Controls.Add(this.tabPageClassePessoa);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(632, 293);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.Enter += new System.EventHandler(this.tabControl1_Enter);
            // 
            // PageBotoes
            // 
            this.PageBotoes.Controls.Add(this.textBox);
            this.PageBotoes.Controls.Add(this.btn_Sair);
            this.PageBotoes.Controls.Add(this.btn_ok);
            this.PageBotoes.Location = new System.Drawing.Point(4, 24);
            this.PageBotoes.Name = "PageBotoes";
            this.PageBotoes.Padding = new System.Windows.Forms.Padding(3);
            this.PageBotoes.Size = new System.Drawing.Size(624, 265);
            this.PageBotoes.TabIndex = 0;
            this.PageBotoes.Text = "Botões";
            this.PageBotoes.UseVisualStyleBackColor = true;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(29, 16);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(166, 23);
            this.textBox.TabIndex = 5;
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(120, 57);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(75, 23);
            this.btn_Sair.TabIndex = 4;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(29, 57);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // PageCalcular
            // 
            this.PageCalcular.Controls.Add(this.bt_ok_parcelas);
            this.PageCalcular.Controls.Add(this.textBox3);
            this.PageCalcular.Controls.Add(this.textBox2);
            this.PageCalcular.Controls.Add(this.textBox1);
            this.PageCalcular.Controls.Add(this.lblResultado);
            this.PageCalcular.Controls.Add(this.lblParcela2);
            this.PageCalcular.Controls.Add(this.lblParcela1);
            this.PageCalcular.Location = new System.Drawing.Point(4, 24);
            this.PageCalcular.Name = "PageCalcular";
            this.PageCalcular.Padding = new System.Windows.Forms.Padding(3);
            this.PageCalcular.Size = new System.Drawing.Size(624, 265);
            this.PageCalcular.TabIndex = 1;
            this.PageCalcular.Text = "Parcelas";
            this.PageCalcular.UseVisualStyleBackColor = true;
            // 
            // bt_ok_parcelas
            // 
            this.bt_ok_parcelas.Location = new System.Drawing.Point(197, 91);
            this.bt_ok_parcelas.Name = "bt_ok_parcelas";
            this.bt_ok_parcelas.Size = new System.Drawing.Size(79, 23);
            this.bt_ok_parcelas.TabIndex = 6;
            this.bt_ok_parcelas.Text = "Ok";
            this.bt_ok_parcelas.UseVisualStyleBackColor = true;
            this.bt_ok_parcelas.Click += new System.EventHandler(this.bt_ok_parcelas_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Window;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(81, 91);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Location = new System.Drawing.Point(81, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(81, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 3;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(21, 99);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(59, 15);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Resultado";
            // 
            // lblParcela2
            // 
            this.lblParcela2.AutoSize = true;
            this.lblParcela2.Location = new System.Drawing.Point(21, 49);
            this.lblParcela2.Name = "lblParcela2";
            this.lblParcela2.Size = new System.Drawing.Size(54, 15);
            this.lblParcela2.TabIndex = 1;
            this.lblParcela2.Text = "Parcela 2";
            // 
            // lblParcela1
            // 
            this.lblParcela1.AutoSize = true;
            this.lblParcela1.Location = new System.Drawing.Point(21, 11);
            this.lblParcela1.Name = "lblParcela1";
            this.lblParcela1.Size = new System.Drawing.Size(54, 15);
            this.lblParcela1.TabIndex = 0;
            this.lblParcela1.Text = "Parcela 1";
            // 
            // PageNotasMedia
            // 
            this.PageNotasMedia.Controls.Add(this.label8);
            this.PageNotasMedia.Controls.Add(this.numericUpDownMediaLouvor);
            this.PageNotasMedia.Controls.Add(this.label7);
            this.PageNotasMedia.Controls.Add(this.numericUpDownMediaLimite);
            this.PageNotasMedia.Controls.Add(this.lbResultado);
            this.PageNotasMedia.Controls.Add(this.label6);
            this.PageNotasMedia.Controls.Add(this.numericUpDownMedia);
            this.PageNotasMedia.Controls.Add(this.btCalcMedia);
            this.PageNotasMedia.Controls.Add(this.textBoxMedia);
            this.PageNotasMedia.Controls.Add(this.label5);
            this.PageNotasMedia.Controls.Add(this.textBoxNota4);
            this.PageNotasMedia.Controls.Add(this.label4);
            this.PageNotasMedia.Controls.Add(this.textBoxNota3);
            this.PageNotasMedia.Controls.Add(this.label3);
            this.PageNotasMedia.Controls.Add(this.textBoxNota2);
            this.PageNotasMedia.Controls.Add(this.label2);
            this.PageNotasMedia.Controls.Add(this.textBoxNota1);
            this.PageNotasMedia.Controls.Add(this.label1);
            this.PageNotasMedia.Location = new System.Drawing.Point(4, 24);
            this.PageNotasMedia.Name = "PageNotasMedia";
            this.PageNotasMedia.Padding = new System.Windows.Forms.Padding(3);
            this.PageNotasMedia.Size = new System.Drawing.Size(624, 265);
            this.PageNotasMedia.TabIndex = 2;
            this.PageNotasMedia.Text = "Médias";
            this.PageNotasMedia.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(321, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 45);
            this.label8.TabIndex = 17;
            this.label8.Text = "Média  para\r\nAprovação \r\ncom Louvor ?\r\n";
            // 
            // numericUpDownMediaLouvor
            // 
            this.numericUpDownMediaLouvor.Location = new System.Drawing.Point(415, 144);
            this.numericUpDownMediaLouvor.Name = "numericUpDownMediaLouvor";
            this.numericUpDownMediaLouvor.Size = new System.Drawing.Size(61, 23);
            this.numericUpDownMediaLouvor.TabIndex = 16;
            this.numericUpDownMediaLouvor.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(321, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 45);
            this.label7.TabIndex = 15;
            this.label7.Text = "Média  para\r\nAprovação  \r\nLimite ?";
            // 
            // numericUpDownMediaLimite
            // 
            this.numericUpDownMediaLimite.Location = new System.Drawing.Point(415, 24);
            this.numericUpDownMediaLimite.Name = "numericUpDownMediaLimite";
            this.numericUpDownMediaLimite.Size = new System.Drawing.Size(61, 23);
            this.numericUpDownMediaLimite.TabIndex = 14;
            this.numericUpDownMediaLimite.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(13, 208);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(59, 15);
            this.lbResultado.TabIndex = 13;
            this.lbResultado.Text = "Resultado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 30);
            this.label6.TabIndex = 12;
            this.label6.Text = "Média  para\r\nAprovação ?";
            // 
            // numericUpDownMedia
            // 
            this.numericUpDownMedia.Location = new System.Drawing.Point(415, 86);
            this.numericUpDownMedia.Name = "numericUpDownMedia";
            this.numericUpDownMedia.Size = new System.Drawing.Size(61, 23);
            this.numericUpDownMedia.TabIndex = 11;
            this.numericUpDownMedia.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // btCalcMedia
            // 
            this.btCalcMedia.Location = new System.Drawing.Point(175, 157);
            this.btCalcMedia.Name = "btCalcMedia";
            this.btCalcMedia.Size = new System.Drawing.Size(75, 23);
            this.btCalcMedia.TabIndex = 10;
            this.btCalcMedia.Text = "Calcular";
            this.btCalcMedia.UseVisualStyleBackColor = true;
            this.btCalcMedia.Click += new System.EventHandler(this.btCalcMedia_Click);
            // 
            // textBoxMedia
            // 
            this.textBoxMedia.Location = new System.Drawing.Point(57, 156);
            this.textBoxMedia.Name = "textBoxMedia";
            this.textBoxMedia.Size = new System.Drawing.Size(100, 23);
            this.textBoxMedia.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Média";
            // 
            // textBoxNota4
            // 
            this.textBoxNota4.Location = new System.Drawing.Point(57, 97);
            this.textBoxNota4.Name = "textBoxNota4";
            this.textBoxNota4.Size = new System.Drawing.Size(100, 23);
            this.textBoxNota4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nota4";
            // 
            // textBoxNota3
            // 
            this.textBoxNota3.Location = new System.Drawing.Point(57, 68);
            this.textBoxNota3.Name = "textBoxNota3";
            this.textBoxNota3.Size = new System.Drawing.Size(100, 23);
            this.textBoxNota3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nota3";
            // 
            // textBoxNota2
            // 
            this.textBoxNota2.Location = new System.Drawing.Point(57, 39);
            this.textBoxNota2.Name = "textBoxNota2";
            this.textBoxNota2.Size = new System.Drawing.Size(100, 23);
            this.textBoxNota2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nota2";
            // 
            // textBoxNota1
            // 
            this.textBoxNota1.Location = new System.Drawing.Point(57, 10);
            this.textBoxNota1.Name = "textBoxNota1";
            this.textBoxNota1.Size = new System.Drawing.Size(100, 23);
            this.textBoxNota1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota1";
            // 
            // tabPageLoops
            // 
            this.tabPageLoops.Controls.Add(this.lblProcessamento);
            this.tabPageLoops.Controls.Add(this.btOk_Loop);
            this.tabPageLoops.Controls.Add(this.ListView);
            this.tabPageLoops.Location = new System.Drawing.Point(4, 24);
            this.tabPageLoops.Name = "tabPageLoops";
            this.tabPageLoops.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLoops.Size = new System.Drawing.Size(624, 265);
            this.tabPageLoops.TabIndex = 3;
            this.tabPageLoops.Text = "Loops";
            this.tabPageLoops.UseVisualStyleBackColor = true;
            // 
            // lblProcessamento
            // 
            this.lblProcessamento.AutoSize = true;
            this.lblProcessamento.Location = new System.Drawing.Point(402, 15);
            this.lblProcessamento.Name = "lblProcessamento";
            this.lblProcessamento.Size = new System.Drawing.Size(100, 15);
            this.lblProcessamento.TabIndex = 2;
            this.lblProcessamento.Text = "Processamento....";
            this.lblProcessamento.Visible = false;
            // 
            // btOk_Loop
            // 
            this.btOk_Loop.Location = new System.Drawing.Point(82, 238);
            this.btOk_Loop.Name = "btOk_Loop";
            this.btOk_Loop.Size = new System.Drawing.Size(82, 24);
            this.btOk_Loop.TabIndex = 1;
            this.btOk_Loop.Text = "Ok";
            this.btOk_Loop.UseVisualStyleBackColor = true;
            this.btOk_Loop.Click += new System.EventHandler(this.btOk_Loop_Click);
            // 
            // ListView
            // 
            this.ListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListView.FormattingEnabled = true;
            this.ListView.ItemHeight = 15;
            this.ListView.Location = new System.Drawing.Point(6, 6);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(242, 227);
            this.ListView.TabIndex = 0;
            // 
            // tabPageForEach
            // 
            this.tabPageForEach.Controls.Add(this.lblTipoForEach);
            this.tabPageForEach.Controls.Add(this.comboBoxTipoForEach);
            this.tabPageForEach.Controls.Add(this.btnForEach);
            this.tabPageForEach.Controls.Add(this.listBoxForEach);
            this.tabPageForEach.Location = new System.Drawing.Point(4, 24);
            this.tabPageForEach.Name = "tabPageForEach";
            this.tabPageForEach.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageForEach.Size = new System.Drawing.Size(624, 265);
            this.tabPageForEach.TabIndex = 4;
            this.tabPageForEach.Text = "ForEach";
            this.tabPageForEach.UseVisualStyleBackColor = true;
            // 
            // lblTipoForEach
            // 
            this.lblTipoForEach.AutoSize = true;
            this.lblTipoForEach.Location = new System.Drawing.Point(279, 15);
            this.lblTipoForEach.Name = "lblTipoForEach";
            this.lblTipoForEach.Size = new System.Drawing.Size(91, 15);
            this.lblTipoForEach.TabIndex = 6;
            this.lblTipoForEach.Text = "Tipo de ForEach";
            // 
            // comboBoxTipoForEach
            // 
            this.comboBoxTipoForEach.DisplayMember = "0";
            this.comboBoxTipoForEach.FormattingEnabled = true;
            this.comboBoxTipoForEach.Items.AddRange(new object[] {
            "Usando CHAR",
            "Usando List<string>"});
            this.comboBoxTipoForEach.Location = new System.Drawing.Point(264, 33);
            this.comboBoxTipoForEach.Name = "comboBoxTipoForEach";
            this.comboBoxTipoForEach.Size = new System.Drawing.Size(166, 23);
            this.comboBoxTipoForEach.TabIndex = 5;
            // 
            // btnForEach
            // 
            this.btnForEach.Location = new System.Drawing.Point(279, 62);
            this.btnForEach.Name = "btnForEach";
            this.btnForEach.Size = new System.Drawing.Size(114, 24);
            this.btnForEach.TabIndex = 4;
            this.btnForEach.Text = "ForEach";
            this.btnForEach.UseVisualStyleBackColor = true;
            this.btnForEach.Click += new System.EventHandler(this.btnForEach_Click);
            // 
            // listBoxForEach
            // 
            this.listBoxForEach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxForEach.FormattingEnabled = true;
            this.listBoxForEach.ItemHeight = 15;
            this.listBoxForEach.Location = new System.Drawing.Point(3, 6);
            this.listBoxForEach.Name = "listBoxForEach";
            this.listBoxForEach.Size = new System.Drawing.Size(242, 257);
            this.listBoxForEach.TabIndex = 1;
            // 
            // tabPageArray
            // 
            this.tabPageArray.Controls.Add(this.btnArray);
            this.tabPageArray.Controls.Add(this.listBoxArrays);
            this.tabPageArray.Location = new System.Drawing.Point(4, 24);
            this.tabPageArray.Name = "tabPageArray";
            this.tabPageArray.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageArray.Size = new System.Drawing.Size(624, 265);
            this.tabPageArray.TabIndex = 5;
            this.tabPageArray.Text = "Arrays";
            this.tabPageArray.UseVisualStyleBackColor = true;
            // 
            // btnArray
            // 
            this.btnArray.Location = new System.Drawing.Point(362, 20);
            this.btnArray.Name = "btnArray";
            this.btnArray.Size = new System.Drawing.Size(111, 27);
            this.btnArray.TabIndex = 3;
            this.btnArray.Text = "Processar Array";
            this.btnArray.UseVisualStyleBackColor = true;
            this.btnArray.Click += new System.EventHandler(this.btnArray_Click);
            // 
            // listBoxArrays
            // 
            this.listBoxArrays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxArrays.FormattingEnabled = true;
            this.listBoxArrays.ItemHeight = 15;
            this.listBoxArrays.Location = new System.Drawing.Point(3, 5);
            this.listBoxArrays.Name = "listBoxArrays";
            this.listBoxArrays.Size = new System.Drawing.Size(242, 257);
            this.listBoxArrays.TabIndex = 2;
            // 
            // tabPageClassePessoa
            // 
            this.tabPageClassePessoa.Controls.Add(this.listBoxPessoas);
            this.tabPageClassePessoa.Controls.Add(this.btnProcessaPessoas);
            this.tabPageClassePessoa.Location = new System.Drawing.Point(4, 24);
            this.tabPageClassePessoa.Name = "tabPageClassePessoa";
            this.tabPageClassePessoa.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClassePessoa.Size = new System.Drawing.Size(624, 265);
            this.tabPageClassePessoa.TabIndex = 6;
            this.tabPageClassePessoa.Text = "Classe Pessoas";
            this.tabPageClassePessoa.UseVisualStyleBackColor = true;
            // 
            // listBoxPessoas
            // 
            this.listBoxPessoas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxPessoas.FormattingEnabled = true;
            this.listBoxPessoas.ItemHeight = 15;
            this.listBoxPessoas.Location = new System.Drawing.Point(6, 35);
            this.listBoxPessoas.Name = "listBoxPessoas";
            this.listBoxPessoas.Size = new System.Drawing.Size(609, 212);
            this.listBoxPessoas.TabIndex = 3;
            // 
            // btnProcessaPessoas
            // 
            this.btnProcessaPessoas.Location = new System.Drawing.Point(6, 6);
            this.btnProcessaPessoas.Name = "btnProcessaPessoas";
            this.btnProcessaPessoas.Size = new System.Drawing.Size(128, 23);
            this.btnProcessaPessoas.TabIndex = 0;
            this.btnProcessaPessoas.Text = "Listar Pessoas";
            this.btnProcessaPessoas.UseVisualStyleBackColor = true;
            this.btnProcessaPessoas.Click += new System.EventHandler(this.btnProcessaPessoas_Click);
            // 
            // FrmMeuAppTestes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 292);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmMeuAppTestes";
            this.Text = "Aplicação Testes - Diversos Testes";
            this.tabControl1.ResumeLayout(false);
            this.PageBotoes.ResumeLayout(false);
            this.PageBotoes.PerformLayout();
            this.PageCalcular.ResumeLayout(false);
            this.PageCalcular.PerformLayout();
            this.PageNotasMedia.ResumeLayout(false);
            this.PageNotasMedia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMediaLouvor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMediaLimite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMedia)).EndInit();
            this.tabPageLoops.ResumeLayout(false);
            this.tabPageLoops.PerformLayout();
            this.tabPageForEach.ResumeLayout(false);
            this.tabPageForEach.PerformLayout();
            this.tabPageArray.ResumeLayout(false);
            this.tabPageClassePessoa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PageBotoes;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.TabPage PageCalcular;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblParcela2;
        private System.Windows.Forms.Label lblParcela1;
        private System.Windows.Forms.Button bt_ok_parcelas;
        private System.Windows.Forms.TabPage PageNotasMedia;
        private System.Windows.Forms.TextBox textBoxNota2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNota1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCalcMedia;
        private System.Windows.Forms.TextBox textBoxMedia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNota4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNota3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownMedia;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownMediaLouvor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownMediaLimite;
        private System.Windows.Forms.TabPage tabPageLoops;
        private System.Windows.Forms.Button btOk_Loop;
        private System.Windows.Forms.ListBox ListView;
        private System.Windows.Forms.Label lblProcessamento;
        private System.Windows.Forms.TabPage tabPageForEach;
        private System.Windows.Forms.ListBox listBoxForEach;
        private System.Windows.Forms.Label lblTipoForEach;
        private System.Windows.Forms.ComboBox comboBoxTipoForEach;
        private System.Windows.Forms.Button btnForEach;
        private System.Windows.Forms.TabPage tabPageArray;
        private System.Windows.Forms.ListBox listBoxArrays;
        private System.Windows.Forms.Button btnArray;
        private System.Windows.Forms.TabPage tabPageClassePessoa;
        private System.Windows.Forms.Button btnProcessaPessoas;
        private System.Windows.Forms.ListBox listBoxPessoas;
    }
}
