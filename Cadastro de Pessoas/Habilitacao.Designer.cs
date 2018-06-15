namespace Cadastro_de_Pessoas
{
    partial class Habilitacao
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txCsRud = new System.Windows.Forms.TextBox();
            this.btCsRud = new System.Windows.Forms.Button();
            this.gpPHab = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txRenach = new System.Windows.Forms.TextBox();
            this.btRenach = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ckA = new System.Windows.Forms.CheckBox();
            this.ckB = new System.Windows.Forms.CheckBox();
            this.ckC = new System.Windows.Forms.CheckBox();
            this.ckD = new System.Windows.Forms.CheckBox();
            this.ckE = new System.Windows.Forms.CheckBox();
            this.dtValidade = new System.Windows.Forms.DateTimePicker();
            this.dtFhab = new System.Windows.Forms.DateTimePicker();
            this.txRegistro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtEmissaoCnh = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpPHab.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cadastro_de_Pessoas.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(189, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 73);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "CNH - Carteira Nacional de Habilitação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Passe o RUD no leitor: ";
            // 
            // txCsRud
            // 
            this.txCsRud.Location = new System.Drawing.Point(136, 140);
            this.txCsRud.Name = "txCsRud";
            this.txCsRud.Size = new System.Drawing.Size(208, 20);
            this.txCsRud.TabIndex = 3;
            // 
            // btCsRud
            // 
            this.btCsRud.Location = new System.Drawing.Point(363, 137);
            this.btCsRud.Name = "btCsRud";
            this.btCsRud.Size = new System.Drawing.Size(124, 23);
            this.btCsRud.TabIndex = 4;
            this.btCsRud.Text = "Consultar Rud";
            this.btCsRud.UseVisualStyleBackColor = true;
            // 
            // gpPHab
            // 
            this.gpPHab.Controls.Add(this.button2);
            this.gpPHab.Controls.Add(this.button1);
            this.gpPHab.Controls.Add(this.dtEmissaoCnh);
            this.gpPHab.Controls.Add(this.label8);
            this.gpPHab.Controls.Add(this.txRegistro);
            this.gpPHab.Controls.Add(this.dtFhab);
            this.gpPHab.Controls.Add(this.dtValidade);
            this.gpPHab.Controls.Add(this.ckE);
            this.gpPHab.Controls.Add(this.ckD);
            this.gpPHab.Controls.Add(this.ckC);
            this.gpPHab.Controls.Add(this.ckB);
            this.gpPHab.Controls.Add(this.ckA);
            this.gpPHab.Controls.Add(this.label7);
            this.gpPHab.Controls.Add(this.label6);
            this.gpPHab.Controls.Add(this.label5);
            this.gpPHab.Controls.Add(this.label4);
            this.gpPHab.Controls.Add(this.btRenach);
            this.gpPHab.Controls.Add(this.txRenach);
            this.gpPHab.Controls.Add(this.label3);
            this.gpPHab.Location = new System.Drawing.Point(20, 180);
            this.gpPHab.Name = "gpPHab";
            this.gpPHab.Size = new System.Drawing.Size(600, 258);
            this.gpPHab.TabIndex = 5;
            this.gpPHab.TabStop = false;
            this.gpPHab.Text = "Habilitação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Renach: ";
            // 
            // txRenach
            // 
            this.txRenach.Location = new System.Drawing.Point(63, 25);
            this.txRenach.Name = "txRenach";
            this.txRenach.Size = new System.Drawing.Size(160, 20);
            this.txRenach.TabIndex = 1;
            // 
            // btRenach
            // 
            this.btRenach.Location = new System.Drawing.Point(249, 22);
            this.btRenach.Name = "btRenach";
            this.btRenach.Size = new System.Drawing.Size(105, 23);
            this.btRenach.TabIndex = 2;
            this.btRenach.Text = "Gerar Renach";
            this.btRenach.UseVisualStyleBackColor = true;
            this.btRenach.Click += new System.EventHandler(this.btRenach_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nº do Registro: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Categoria: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Validade: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Primeira Habilitação:";
            // 
            // ckA
            // 
            this.ckA.AutoSize = true;
            this.ckA.Location = new System.Drawing.Point(79, 97);
            this.ckA.Name = "ckA";
            this.ckA.Size = new System.Drawing.Size(33, 17);
            this.ckA.TabIndex = 7;
            this.ckA.Text = "A";
            this.ckA.UseVisualStyleBackColor = true;
            // 
            // ckB
            // 
            this.ckB.AutoSize = true;
            this.ckB.Location = new System.Drawing.Point(127, 97);
            this.ckB.Name = "ckB";
            this.ckB.Size = new System.Drawing.Size(33, 17);
            this.ckB.TabIndex = 8;
            this.ckB.Text = "B";
            this.ckB.UseVisualStyleBackColor = true;
            // 
            // ckC
            // 
            this.ckC.AutoSize = true;
            this.ckC.Location = new System.Drawing.Point(179, 97);
            this.ckC.Name = "ckC";
            this.ckC.Size = new System.Drawing.Size(33, 17);
            this.ckC.TabIndex = 9;
            this.ckC.Text = "C";
            this.ckC.UseVisualStyleBackColor = true;
            // 
            // ckD
            // 
            this.ckD.AutoSize = true;
            this.ckD.Location = new System.Drawing.Point(227, 97);
            this.ckD.Name = "ckD";
            this.ckD.Size = new System.Drawing.Size(34, 17);
            this.ckD.TabIndex = 10;
            this.ckD.Text = "D";
            this.ckD.UseVisualStyleBackColor = true;
            // 
            // ckE
            // 
            this.ckE.AutoSize = true;
            this.ckE.Location = new System.Drawing.Point(283, 97);
            this.ckE.Name = "ckE";
            this.ckE.Size = new System.Drawing.Size(33, 17);
            this.ckE.TabIndex = 11;
            this.ckE.Text = "E";
            this.ckE.UseVisualStyleBackColor = true;
            // 
            // dtValidade
            // 
            this.dtValidade.CustomFormat = "yyyy/MM/dd";
            this.dtValidade.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtValidade.Location = new System.Drawing.Point(79, 130);
            this.dtValidade.Name = "dtValidade";
            this.dtValidade.Size = new System.Drawing.Size(113, 20);
            this.dtValidade.TabIndex = 12;
            // 
            // dtFhab
            // 
            this.dtFhab.CustomFormat = "yyyy/MM/dd";
            this.dtFhab.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFhab.Location = new System.Drawing.Point(330, 131);
            this.dtFhab.Name = "dtFhab";
            this.dtFhab.Size = new System.Drawing.Size(121, 20);
            this.dtFhab.TabIndex = 13;
            // 
            // txRegistro
            // 
            this.txRegistro.Location = new System.Drawing.Point(92, 61);
            this.txRegistro.Name = "txRegistro";
            this.txRegistro.Size = new System.Drawing.Size(224, 20);
            this.txRegistro.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Data de Emissão:";
            // 
            // dtEmissaoCnh
            // 
            this.dtEmissaoCnh.CustomFormat = "yyyy/MM/dd";
            this.dtEmissaoCnh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEmissaoCnh.Location = new System.Drawing.Point(102, 166);
            this.dtEmissaoCnh.Name = "dtEmissaoCnh";
            this.dtEmissaoCnh.Size = new System.Drawing.Size(110, 20);
            this.dtEmissaoCnh.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(330, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Habilitacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 450);
            this.Controls.Add(this.gpPHab);
            this.Controls.Add(this.btCsRud);
            this.Controls.Add(this.txCsRud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Habilitacao";
            this.Text = "Habilitacao";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpPHab.ResumeLayout(false);
            this.gpPHab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txCsRud;
        private System.Windows.Forms.Button btCsRud;
        private System.Windows.Forms.GroupBox gpPHab;
        private System.Windows.Forms.Button btRenach;
        private System.Windows.Forms.TextBox txRenach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtEmissaoCnh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txRegistro;
        private System.Windows.Forms.DateTimePicker dtFhab;
        private System.Windows.Forms.DateTimePicker dtValidade;
        private System.Windows.Forms.CheckBox ckE;
        private System.Windows.Forms.CheckBox ckD;
        private System.Windows.Forms.CheckBox ckC;
        private System.Windows.Forms.CheckBox ckB;
        private System.Windows.Forms.CheckBox ckA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}