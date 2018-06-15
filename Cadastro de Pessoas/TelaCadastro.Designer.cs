namespace Cadastro_de_Pessoas
{
    partial class TelaCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label12;
            this.label1 = new System.Windows.Forms.Label();
            this.txUid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.txSenha = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btGRud = new System.Windows.Forms.Button();
            this.btRud = new System.Windows.Forms.Button();
            this.txRud = new System.Windows.Forms.TextBox();
            this.lae = new System.Windows.Forms.Label();
            this.rdF = new System.Windows.Forms.RadioButton();
            this.rdM = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.cbCivil = new System.Windows.Forms.ComboBox();
            this.txRg = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dtExpedicao = new System.Windows.Forms.DateTimePicker();
            this.txPai = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txMae = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TmNasc = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txSobrenome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btLib = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pessoalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cPFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cNHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPrimeira = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMultas = new System.Windows.Forms.ToolStripMenuItem();
            this.cNHToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tituloDeEleitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antecedentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.spArduino = new System.IO.Ports.SerialPort(this.components);
            this.btConecta = new System.Windows.Forms.Button();
            label12 = new System.Windows.Forms.Label();
            this.gbDados.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Arial", 8.25F);
            label12.Location = new System.Drawing.Point(239, 214);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(35, 14);
            label12.TabIndex = 20;
            label12.Text = "Sexo:";
            label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Documento";
            // 
            // txUid
            // 
            this.txUid.Location = new System.Drawing.Point(145, 213);
            this.txUid.Name = "txUid";
            this.txUid.ReadOnly = true;
            this.txUid.Size = new System.Drawing.Size(159, 20);
            this.txUid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Passe o cartão no leitor: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // gbDados
            // 
            this.gbDados.Controls.Add(this.txSenha);
            this.gbDados.Controls.Add(this.label13);
            this.gbDados.Controls.Add(this.btGRud);
            this.gbDados.Controls.Add(this.btRud);
            this.gbDados.Controls.Add(this.txRud);
            this.gbDados.Controls.Add(this.lae);
            this.gbDados.Controls.Add(this.rdF);
            this.gbDados.Controls.Add(this.rdM);
            this.gbDados.Controls.Add(label12);
            this.gbDados.Controls.Add(this.label11);
            this.gbDados.Controls.Add(this.cbCivil);
            this.gbDados.Controls.Add(this.txRg);
            this.gbDados.Controls.Add(this.label10);
            this.gbDados.Controls.Add(this.btClear);
            this.gbDados.Controls.Add(this.btSalvar);
            this.gbDados.Controls.Add(this.label9);
            this.gbDados.Controls.Add(this.dtExpedicao);
            this.gbDados.Controls.Add(this.txPai);
            this.gbDados.Controls.Add(this.label8);
            this.gbDados.Controls.Add(this.txMae);
            this.gbDados.Controls.Add(this.label7);
            this.gbDados.Controls.Add(this.TmNasc);
            this.gbDados.Controls.Add(this.label6);
            this.gbDados.Controls.Add(this.dtNascimento);
            this.gbDados.Controls.Add(this.label5);
            this.gbDados.Controls.Add(this.txSobrenome);
            this.gbDados.Controls.Add(this.label4);
            this.gbDados.Controls.Add(this.txNome);
            this.gbDados.Controls.Add(this.label3);
            this.gbDados.Enabled = false;
            this.gbDados.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDados.Location = new System.Drawing.Point(20, 252);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(586, 356);
            this.gbDados.TabIndex = 4;
            this.gbDados.TabStop = false;
            this.gbDados.Text = "Dados pessoais";
            // 
            // txSenha
            // 
            this.txSenha.Enabled = false;
            this.txSenha.Location = new System.Drawing.Point(84, 277);
            this.txSenha.Name = "txSenha";
            this.txSenha.Size = new System.Drawing.Size(141, 20);
            this.txSenha.TabIndex = 28;
            this.txSenha.UseSystemPasswordChar = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label13.Location = new System.Drawing.Point(6, 280);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 14);
            this.label13.TabIndex = 27;
            this.label13.Text = "Senha: ";
            // 
            // btGRud
            // 
            this.btGRud.Enabled = false;
            this.btGRud.Location = new System.Drawing.Point(242, 277);
            this.btGRud.Name = "btGRud";
            this.btGRud.Size = new System.Drawing.Size(75, 20);
            this.btGRud.TabIndex = 26;
            this.btGRud.Text = "Gravar Rud";
            this.btGRud.UseVisualStyleBackColor = true;
            this.btGRud.Click += new System.EventHandler(this.btGRud_Click);
            // 
            // btRud
            // 
            this.btRud.Location = new System.Drawing.Point(242, 245);
            this.btRud.Name = "btRud";
            this.btRud.Size = new System.Drawing.Size(75, 23);
            this.btRud.TabIndex = 25;
            this.btRud.Text = "Gerar RUD";
            this.btRud.UseVisualStyleBackColor = true;
            this.btRud.Click += new System.EventHandler(this.btRud_Click);
            // 
            // txRud
            // 
            this.txRud.Location = new System.Drawing.Point(84, 248);
            this.txRud.MaxLength = 13;
            this.txRud.Name = "txRud";
            this.txRud.ReadOnly = true;
            this.txRud.Size = new System.Drawing.Size(141, 20);
            this.txRud.TabIndex = 24;
            // 
            // lae
            // 
            this.lae.AutoSize = true;
            this.lae.Font = new System.Drawing.Font("Arial", 8.25F);
            this.lae.Location = new System.Drawing.Point(6, 254);
            this.lae.Name = "lae";
            this.lae.Size = new System.Drawing.Size(62, 14);
            this.lae.TabIndex = 23;
            this.lae.Text = "Nº do Rud: ";
            // 
            // rdF
            // 
            this.rdF.AutoSize = true;
            this.rdF.Font = new System.Drawing.Font("Arial", 8.25F);
            this.rdF.Location = new System.Drawing.Point(385, 210);
            this.rdF.Name = "rdF";
            this.rdF.Size = new System.Drawing.Size(67, 18);
            this.rdF.TabIndex = 22;
            this.rdF.TabStop = true;
            this.rdF.Text = "Feminino";
            this.rdF.UseVisualStyleBackColor = true;
            // 
            // rdM
            // 
            this.rdM.AutoSize = true;
            this.rdM.Font = new System.Drawing.Font("Arial", 8.25F);
            this.rdM.Location = new System.Drawing.Point(280, 210);
            this.rdM.Name = "rdM";
            this.rdM.Size = new System.Drawing.Size(73, 18);
            this.rdM.TabIndex = 21;
            this.rdM.TabStop = true;
            this.rdM.Text = "Masculino";
            this.rdM.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label11.Location = new System.Drawing.Point(6, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 14);
            this.label11.TabIndex = 19;
            this.label11.Text = "Estado Civil: ";
            // 
            // cbCivil
            // 
            this.cbCivil.FormattingEnabled = true;
            this.cbCivil.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Casado(a)",
            "Divorciado(a)",
            "Viúvo(a)"});
            this.cbCivil.Location = new System.Drawing.Point(84, 206);
            this.cbCivil.Name = "cbCivil";
            this.cbCivil.Size = new System.Drawing.Size(121, 22);
            this.cbCivil.TabIndex = 18;
            // 
            // txRg
            // 
            this.txRg.Location = new System.Drawing.Point(269, 164);
            this.txRg.Name = "txRg";
            this.txRg.Size = new System.Drawing.Size(189, 20);
            this.txRg.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label10.Location = new System.Drawing.Point(235, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 14);
            this.label10.TabIndex = 16;
            this.label10.Text = "RG: ";
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(499, 313);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 15;
            this.btClear.Text = "Limpar campos";
            this.btClear.UseVisualStyleBackColor = true;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(400, 313);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 14;
            this.btSalvar.Text = "Gravar Dados";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label9.Location = new System.Drawing.Point(6, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 14);
            this.label9.TabIndex = 13;
            this.label9.Text = "Data de Expedição: ";
            // 
            // dtExpedicao
            // 
            this.dtExpedicao.CustomFormat = "dd/MM/yyyy";
            this.dtExpedicao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtExpedicao.Location = new System.Drawing.Point(115, 164);
            this.dtExpedicao.Name = "dtExpedicao";
            this.dtExpedicao.Size = new System.Drawing.Size(107, 20);
            this.dtExpedicao.TabIndex = 12;
            // 
            // txPai
            // 
            this.txPai.Location = new System.Drawing.Point(101, 130);
            this.txPai.Name = "txPai";
            this.txPai.Size = new System.Drawing.Size(410, 20);
            this.txPai.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label8.Location = new System.Drawing.Point(8, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 14);
            this.label8.TabIndex = 10;
            this.label8.Text = "Nome do Pai:";
            // 
            // txMae
            // 
            this.txMae.Location = new System.Drawing.Point(101, 100);
            this.txMae.Name = "txMae";
            this.txMae.Size = new System.Drawing.Size(410, 20);
            this.txMae.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label7.Location = new System.Drawing.Point(8, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 14);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nome da Mãe: ";
            // 
            // TmNasc
            // 
            this.TmNasc.CustomFormat = "hh:mm";
            this.TmNasc.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TmNasc.Location = new System.Drawing.Point(426, 64);
            this.TmNasc.Name = "TmNasc";
            this.TmNasc.Size = new System.Drawing.Size(148, 20);
            this.TmNasc.TabIndex = 7;
            this.TmNasc.Value = new System.DateTime(2018, 6, 10, 16, 53, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(382, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "Hora: ";
            // 
            // dtNascimento
            // 
            this.dtNascimento.CustomFormat = "dd/MM/yyyy";
            this.dtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNascimento.Location = new System.Drawing.Point(123, 64);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(239, 20);
            this.dtNascimento.TabIndex = 5;
            this.dtNascimento.Value = new System.DateTime(2018, 6, 10, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label5.Location = new System.Drawing.Point(8, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data de Nascimento: ";
            // 
            // txSobrenome
            // 
            this.txSobrenome.Location = new System.Drawing.Point(329, 30);
            this.txSobrenome.Name = "txSobrenome";
            this.txSobrenome.Size = new System.Drawing.Size(245, 20);
            this.txSobrenome.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(256, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sobrenome: ";
            // 
            // txNome
            // 
            this.txNome.Location = new System.Drawing.Point(52, 26);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(173, 20);
            this.txNome.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label3.Location = new System.Drawing.Point(8, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome:";
            // 
            // btLib
            // 
            this.btLib.Location = new System.Drawing.Point(331, 213);
            this.btLib.Name = "btLib";
            this.btLib.Size = new System.Drawing.Size(100, 23);
            this.btLib.TabIndex = 5;
            this.btLib.Text = "Gravar Dados";
            this.btLib.UseVisualStyleBackColor = true;
            this.btLib.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoalToolStripMenuItem,
            this.cNHToolStripMenuItem,
            this.tituloDeEleitorToolStripMenuItem,
            this.antecedentesToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pessoalToolStripMenuItem
            // 
            this.pessoalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cPFToolStripMenuItem});
            this.pessoalToolStripMenuItem.Name = "pessoalToolStripMenuItem";
            this.pessoalToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.pessoalToolStripMenuItem.Text = "Pessoal";
            // 
            // cPFToolStripMenuItem
            // 
            this.cPFToolStripMenuItem.Name = "cPFToolStripMenuItem";
            this.cPFToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.cPFToolStripMenuItem.Text = "CPF";
            // 
            // cNHToolStripMenuItem
            // 
            this.cNHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPrimeira,
            this.tsMultas,
            this.cNHToolStripMenuItem1});
            this.cNHToolStripMenuItem.Name = "cNHToolStripMenuItem";
            this.cNHToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.cNHToolStripMenuItem.Text = "CNH";
            // 
            // tsPrimeira
            // 
            this.tsPrimeira.Name = "tsPrimeira";
            this.tsPrimeira.Size = new System.Drawing.Size(134, 22);
            this.tsPrimeira.Text = "Habilitação";
            this.tsPrimeira.Click += new System.EventHandler(this.tsPrimeira_Click);
            // 
            // tsMultas
            // 
            this.tsMultas.Name = "tsMultas";
            this.tsMultas.Size = new System.Drawing.Size(134, 22);
            this.tsMultas.Text = "Multas";
            this.tsMultas.Click += new System.EventHandler(this.tsMultas_Click);
            // 
            // cNHToolStripMenuItem1
            // 
            this.cNHToolStripMenuItem1.Name = "cNHToolStripMenuItem1";
            this.cNHToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.cNHToolStripMenuItem1.Text = "CNH";
            // 
            // tituloDeEleitorToolStripMenuItem
            // 
            this.tituloDeEleitorToolStripMenuItem.Name = "tituloDeEleitorToolStripMenuItem";
            this.tituloDeEleitorToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.tituloDeEleitorToolStripMenuItem.Text = "Titulo de Eleitor";
            // 
            // antecedentesToolStripMenuItem
            // 
            this.antecedentesToolStripMenuItem.Name = "antecedentesToolStripMenuItem";
            this.antecedentesToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.antecedentesToolStripMenuItem.Text = "Antecedentes";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cadastro_de_Pessoas.Properties.Resources.governo_brasao;
            this.pictureBox1.Location = new System.Drawing.Point(222, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 99);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // spArduino
            // 
            this.spArduino.PortName = "COM4";
            // 
            // btConecta
            // 
            this.btConecta.Location = new System.Drawing.Point(446, 213);
            this.btConecta.Name = "btConecta";
            this.btConecta.Size = new System.Drawing.Size(75, 23);
            this.btConecta.TabIndex = 7;
            this.btConecta.Text = "Conectar";
            this.btConecta.UseVisualStyleBackColor = true;
            this.btConecta.Click += new System.EventHandler(this.btConecta_Click);
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 620);
            this.Controls.Add(this.btConecta);
            this.Controls.Add(this.btLib);
            this.Controls.Add(this.gbDados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txUid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaCadastro";
            this.Text = "Tela de Cadastro";
            this.Load += new System.EventHandler(this.TelaCadastro_Load);
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txUid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.DateTimePicker TmNasc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtNascimento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txSobrenome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txPai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txMae;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btLib;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtExpedicao;
        private System.Windows.Forms.RadioButton rdF;
        private System.Windows.Forms.RadioButton rdM;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbCivil;
        private System.Windows.Forms.TextBox txRg;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pessoalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cPFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cNHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsPrimeira;
        private System.Windows.Forms.ToolStripMenuItem tsMultas;
        private System.Windows.Forms.ToolStripMenuItem cNHToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tituloDeEleitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem antecedentesToolStripMenuItem;
        private System.Windows.Forms.TextBox txRud;
        private System.Windows.Forms.Label lae;
        private System.Windows.Forms.Button btRud;
        private System.Windows.Forms.Button btGRud;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.IO.Ports.SerialPort spArduino;
        private System.Windows.Forms.Button btConecta;
        private System.Windows.Forms.TextBox txSenha;
        private System.Windows.Forms.Label label13;
    }
}