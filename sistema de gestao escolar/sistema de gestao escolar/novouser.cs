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
    public partial class novouser : Form
    {
        public novouser()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection("@provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\\\Users\\\\JONAS\\\\Documents\
            { 
                con.Open();
                MessageBox.Show("Ok");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
