using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Cadastro_de_Pessoas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btAcess_Click(object sender, EventArgs e)
        {
            if((txAdmin.Text == "") || (txAdmin.Text.Length < 8))
            {
                MessageBox.Show("O campo precisa ser preenchido corretamente");
            }
            else if(txAdmin.Text == "@Admin18")
            {
                this.Hide();
                MessageBox.Show("Acesso Liberado");
                TelaCadastro cad = new TelaCadastro();
                cad.Show();
               
            }
        }

        public void carregar()
        {
            try
            {
                String c = String.Format("SELECT * FROM tb_uid");
            }
            catch
            {

            }
        }
    }
}
