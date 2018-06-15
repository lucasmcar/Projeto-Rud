using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cadastro_de_Pessoas
{
    public partial class Multas : Form
    {
        public Multas()
        {
            InitializeComponent();
        }

        private void btCCnh_Click(object sender, EventArgs e)
        {
            mostraResultados();
        }

        

        private void mostraResultados()
        {
            try
            {

                MySqlConnection con;
                MySqlDataAdapter adapt;
                DataSet ds;

                ds = new DataSet();
                con = new MySqlConnection("server=localhost; database=db_rud_rs; uid=root; Pwd=; SslMode=none; ");
                con.Open();

                //cria um adapter utilizando a instrução SQL para aceder à tabela
                adapt = new MySqlDataAdapter(
                    "SELECT " +
                        "cnh, descricao, multa_data, pontos_cnh " +
                   "FROM " +
                        "tb_multas as m " +
                   "INNER JOIN " +
                        "tb_cnh as cnh" +
                   "ON" +
                        "m.id_multas = cnh.id_cnh" +
                   "WHERE " +
                        "(cnh = '" + txCCnh.Text + "')", con);

                //preenche o dataset através do adapter
                adapt.Fill(ds, "tabela_dados");

                //atribui o resultado à propriedade DataSource da dataGridView
                dtMulta.DataSource = ds;
                dtMulta.DataMember = "tabela_dados";

                if(dtMulta.RowCount == 0)
                {
                    MessageBox.Show("Não foram encontradas multas");
                }
                else
                {
                    MessageBox.Show("Foram encontradas " + dtMulta.RowCount + "multas(s)!");
                }
            } catch(MySqlException ex)
            {
                MessageBox.Show("Não conseguimos visualizar seus dados! " + ex);
            }
        }
    }
}
