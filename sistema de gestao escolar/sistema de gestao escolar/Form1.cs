﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Diagnostics;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sistema_de_gestao_escolar
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selecione_usuarios selecione_Usuarios = new selecione_usuarios();
            selecione_Usuarios.Show();
            protected void Page_Load(object sender, EventArgs e)
            {
                if (!Page.IsPostBack)
                {

                    // If querystring value is missing, send the user to ManageUsers.aspx
                    string userName = Request.QueryString["user"];
                    if (string.IsNullOrEmpty(userName))
                        Response.Redirect("ManageUsers.aspx");

                    // Get information about this user
                    MembershipUser usr = Membership.GetUser(userName);
                    if (usr == null)
                        Response.Redirect("ManageUsers.aspx");

                    UserNameLabel.Text = usr.UserName;
                    IsApproved.Checked = usr.IsApproved;
                    if (usr.LastLockoutDate.Year < 2000)

                        LastLockoutDateLabel.Text = string.Empty;
                    else
                        LastLockoutDateLabel.Text = usr.LastLockoutDate.ToShortDateString();

                    UnlockUserButton.Enabled = usr.IsLockedOut;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            novouser novouser = new novouser();
            novouser.ShowDialog();
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            recuperar_senha recuperar_Senha = new recuperar_senha();
            recuperar_Senha.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
