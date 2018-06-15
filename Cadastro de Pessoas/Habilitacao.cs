using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_Pessoas
{
    public partial class Habilitacao : Form
    {
        public Habilitacao()
        {
            InitializeComponent();
        }

        private void btRenach_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int ren = r.Next(0,1000000000);

            txRenach.Text = "RS" + ren.ToString();
        }
    }
}
