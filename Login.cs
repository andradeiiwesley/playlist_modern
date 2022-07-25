using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace WF_ModernUI
{
    public partial class FormLogin : Form
    {


        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabelAlterar_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(Util.CaminhoTxtUsuarios))
            {
                var texto = File.ReadAllText(Util.CaminhoTxtUsuarios);

                foreach (var line in texto.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
                {
                    string username = Util.DescriptografarSemSenha(line.Split(';')[0]);
                    string senha = Util.DescriptografarSemSenha(line.Split(';')[1]);

                    if (txtUsername.Text == username && txtSenha.Text == senha)
                    {
                        UsuarioLogado.Init(username, senha);

                        UsuarioLogado.GetCaminhoServicosUsuario();

                        MessageBox.Show("Seja bem vindo!");
                        FormMenu principal = new FormMenu();
                        principal.Show();
                        this.Hide();
                    }
                   
                }
            }
          
        }
       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCadastro fc = new FormCadastro();
            fc.Show();

        }
    }
}









