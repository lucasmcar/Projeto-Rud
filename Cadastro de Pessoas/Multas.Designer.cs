namespace Cadastro_de_Pessoas
{
    partial class Multas
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
            this.txCCnh = new System.Windows.Forms.TextBox();
            this.btCCnh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtMulta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtMulta)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cadastro_de_Pessoas.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(194, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 78);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consulta CNH:";
            // 
            // txCCnh
            // 
            this.txCCnh.Location = new System.Drawing.Point(105, 157);
            this.txCCnh.Name = "txCCnh";
            this.txCCnh.Size = new System.Drawing.Size(171, 20);
            this.txCCnh.TabIndex = 2;
            // 
            // btCCnh
            // 
            this.btCCnh.Location = new System.Drawing.Point(302, 155);
            this.btCCnh.Name = "btCCnh";
            this.btCCnh.Size = new System.Drawing.Size(75, 23);
            this.btCCnh.TabIndex = 3;
            this.btCCnh.Text = "Consultar";
            this.btCCnh.UseVisualStyleBackColor = true;
            this.btCCnh.Click += new System.EventHandler(this.btCCnh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Consulta de Multas ";
            // 
            // dtMulta
            // 
            this.dtMulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMulta.Location = new System.Drawing.Point(15, 251);
            this.dtMulta.Name = "dtMulta";
            this.dtMulta.Size = new System.Drawing.Size(591, 187);
            this.dtMulta.TabIndex = 5;
            // 
            // Multas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtMulta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCCnh);
            this.Controls.Add(this.txCCnh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Multas";
            this.Text = "Multas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtMulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txCCnh;
        private System.Windows.Forms.Button btCCnh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtMulta;
    }
}