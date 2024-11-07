using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace sistema_de_gestao_escolar
{
    public partial class recuperar_senha : Form
    {
        public recuperar_senha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Codicoemail codicoemail = new Codicoemail();
            codicoemail.ShowDialog();
        }
    }
}
