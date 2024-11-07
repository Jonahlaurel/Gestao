using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_de_gestao_escolar
{
    public partial class Codicoemail : Form
    {
        public Codicoemail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NOVA_SENHA NOVA_SENHA = new NOVA_SENHA();
            NOVA_SENHA.ShowDialog();
        }
    }
}
