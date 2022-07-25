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

namespace WF_ModernUI
{
    public partial class FormCadastro : Form
    {
        //string arquivoTxt = @"C:\out\DataTable";

        public FormCadastro()
        {
            InitializeComponent();
            
        }

        

        private void FormCadastro_Load(object sender, EventArgs e)
        {

        }


        private bool SalvarNovoCadastro()
        {
            try
            {
                


                var UserCriptografado = Util.CriptografarSemSenha(txtUser.Text);
                var SenhaCriptografado = Util.CriptografarSemSenha(txtSenha.Text);

               File.AppendAllText(Util.CaminhoTxtUsuarios,
               (UserCriptografado + ";" + SenhaCriptografado) + Environment.NewLine);

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar salvar: " + ex.Message, "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

        }
       

        private void LimparCadastro()
        {
            txtUser.Clear();
            txtSenha.Clear();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ValidarCadastro())
            {
                if (MessageBox.Show("Deseja salvar os dados?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (SalvarNovoCadastro())
                        MessageBox.Show("Cadastro salvo com sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCadastro();
                }
                else
                {
                    MessageBox.Show("Operação cancelada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }
       



        private bool ValidarCadastro()
        {
            bool formValido;

            if (txtUser.Text == "")
            {
                MessageBox.Show("Por favor, informe um username válido.");
                txtUser.Focus();
                formValido = false;
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Por favor, informe uma senha válida.");
                txtSenha.Focus();
                formValido = false;
            }
            else
            {
                formValido = true;

            }

            return formValido;
        }




        private void txtUser_Leave(object sender, EventArgs e)
        {
        }


        private void FormCadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja salvar os dados?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                SalvarNovoCadastro();
        }




    }
}

