namespace Cadastro_de_Pessoas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txAdmin = new System.Windows.Forms.TextBox();
            this.btAcess = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txAdmin
            // 
            this.txAdmin.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txAdmin.Location = new System.Drawing.Point(105, 171);
            this.txAdmin.Name = "txAdmin";
            this.txAdmin.Size = new System.Drawing.Size(402, 32);
            this.txAdmin.TabIndex = 1;
            this.txAdmin.UseSystemPasswordChar = true;
            // 
            // btAcess
            // 
            this.btAcess.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAcess.Location = new System.Drawing.Point(183, 226);
            this.btAcess.Name = "btAcess";
            this.btAcess.Size = new System.Drawing.Size(214, 48);
            this.btAcess.TabIndex = 2;
            this.btAcess.Text = "Acessar";
            this.btAcess.UseVisualStyleBackColor = true;
            this.btAcess.Click += new System.EventHandler(this.btAcess_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Acesso Restrito";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cadastro_de_Pessoas.Properties.Resources.governo_brasao;
            this.pictureBox1.Location = new System.Drawing.Point(194, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 95);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 304);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAcess);
            this.Controls.Add(this.txAdmin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Acesso Restrito";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txAdmin;
        private System.Windows.Forms.Button btAcess;
        private System.Windows.Forms.Label label1;
    }
}

