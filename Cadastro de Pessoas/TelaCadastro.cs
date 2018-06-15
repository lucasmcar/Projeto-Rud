using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Cadastro_de_Pessoas
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
            

        }

        private void TelaCadastro_Load(object sender, EventArgs e)
        {
            dtNascimento.Value = DateTime.Now;
            dtExpedicao.Value = DateTime.Now;
            TmNasc.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((txUid.Text == "") || (txUid.Text.Length <= 7))
            {
                MessageBox.Show("Acesso negado ou verifique se possui 8 ou mais digitos");
            }
            else
            {
                MySqlConnection conn = new MySqlConnection("server=localhost; database=db_rud_rs; uid=root; Pwd=; SslMode=none; ");
                try
                {
                    
                    
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO tb_uid (uid) VALUES (SHA1('" + txUid.Text + "'))", conn);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("UID gravada com sucesso!");

                    conn.Close();
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show("UID Não gravada!");
                }
                txUid.ReadOnly = true;
                btLib.Enabled = false;
                gbDados.Enabled = true;

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            //Verifica Campos vazios
            if (
                (txNome.Text == "") || (txMae.Text == "") ||
                (txPai.Text == "") || (txRg.Text == "") ||
                (txSenha.Text == "") ||(rdM.Checked = false) || (rdF.Checked = false)
              )
            {
                MessageBox.Show("Campos devem ser todos preenchidos!");
            }
            else if (
                (txMae.Text.Length <= 2) || (txPai.Text.Length <= 2) ||
                (txNome.Text.Length <=2) || (txSobrenome.Text.Length <= 2)
                
                )
            {
                MessageBox.Show("Campos devem possuir mais de 2");
            }
            else if ((txSenha.Text.Length <= 8))
            {
                MessageBox.Show("Senha deve possuir mais de 8 digitos");
            }

           
             
                MySqlConnection con;
                /**/
            try
            {

                con = new MySqlConnection("server=localhost; database=db_rud_rs; uid=root; Pwd=; SslMode=none; ");
                con.Open();


                if (rdM.Checked)
                {
                    MySqlCommand cmd1 = new MySqlCommand("" +
                        "INSERT INTO tb_identidade " +
                        "(nome, sobrenome, expedicao, nascimento, hora, n_mae, n_pai, sexo, est_civil, id_uid)" +
                        "VALUES('"
                           + this.txNome.Text + "','"
                           + this.txSobrenome.Text + "', '"
                           + this.dtExpedicao.Value.Date.ToString("yyyy-MM-dd") + "', '"
                           + this.dtNascimento.Value.Date.ToString("yyyy-MM-dd") + "', '"
                           + this.TmNasc.Text + "','"
                           + this.txMae.Text + "','"
                           + this.txPai.Text + "','"
                           + this.rdM.Text + "','"
                           + this.cbCivil.Text + "',LAST_INSERT_ID())", con);

                    cmd1.ExecuteNonQuery();
                }
                else
                {
                    MySqlCommand cmd1 = new MySqlCommand("" +
                        "INSERT INTO tb_identidade " +
                        "(nome, sobrenome, expedicao, nascimento, hora, n_mae, n_pai, sexo, est_civil, id_uid)" +
                        "VALUES('"
                           + this.txNome.Text + "','"
                           + this.txSobrenome.Text + "' , '"
                           + this.dtExpedicao.Value.Date.ToString("yyyy-MM-dd") + "', '"
                           + this.dtNascimento.Value.Date.ToString("yyyy-MM-dd") + "', '"
                           + this.TmNasc.Text + "', '"
                           + this.txMae.Text + "',' "
                           + this.txPai.Text + "','"
                           + this.rdF.Text + "','"
                           + cbCivil.Text + "',LAST_INSERT_ID())", con);

                    cmd1.ExecuteNonQuery();
                }

               

                    MessageBox.Show("Dados gravados com sucesso!");

                con.Close();

                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Dados não inseridos " + ex.ToString());
                 
            }
        }

        private void btRud_Click(object sender, EventArgs e)
        {
            Random rd = new Random();

            int rud = rd.Next(0, 1000000000);

            txRud.Text = "RS" + rud.ToString();

            btRud.Enabled = false;

            if (txRud.Text.Length >= 8)
            {

                txSenha.Enabled = true;
                btGRud.Enabled = true;
            }

            
           
            
        }

        private void btGRud_Click(object sender, EventArgs e)
        {

            String senha = txSenha.Text;
            HashAlgorithm.Create(senha);

            MySqlConnection conex;  
            try
            {

                conex = new MySqlConnection("server=localhost; database=db_rud_rs; uid=root; Pwd=; SslMode=none; ");

                conex.Open();

                MySqlCommand cmd3 = new MySqlCommand("INSERT INTO tb_rud (rud, senha,  id_uid) VALUES ('" + txRud.Text + "', SHA1('" + txSenha.Text + "'), LAST_INSERT_ID())", conex);

                cmd3.ExecuteNonQuery();
                conex.Close();

                MessageBox.Show("RUD gravado com sucesso!");

                btGRud.Enabled = false;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("RUD não inserido" + ex);
            }

           
        }

        private void tsPrimeira_Click(object sender, EventArgs e)
        {
            Habilitacao hab = new Habilitacao();
            hab.Show();
            this.Hide();
        }

        private void tsMultas_Click(object sender, EventArgs e)
        {
            Multas multa = new Multas();
            multa.Show();
            this.Hide();
        }

       

        private void btConecta_Click(object sender, EventArgs e)
        {
            try
            {
                spArduino.Open();
                String ent = spArduino.ReadLine();
                spArduino.Close();
                txUid.Text = ent;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
