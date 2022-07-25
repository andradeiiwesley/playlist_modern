using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_ModernUI
{
    public partial class FormNimoMusic : Form
    {
        public FormNimoMusic()
        {
            InitializeComponent();
        }

        private void linkLabelSalvar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ValidarNovaMusica())
            {
                if (MessageBox.Show("Deseja salvar?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (SalvarNovaMusica())
                        MessageBox.Show("Música salva com sucesso na playlist!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparMusica();
                }
                else
                {
                    MessageBox.Show("Operação cancelada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
           
        }

        private bool ValidarNovaMusica()
        {
            bool formValido;

            if (txtCantor.Text == "")
            {
                MessageBox.Show("Por favor, informe um cantor válido.");
                txtCantor.Focus();
                formValido = false;
            }
            else if (txtMusica.Text == "")
            {
                MessageBox.Show("Por favor, informe uma música válida.");
                txtMusica.Focus();
                formValido = false;
            }
            else
            {
                formValido = true;
            }

            return formValido;
        }

        private void LimparMusica()
        {
            txtCantor.Clear();
            txtMusica.Clear();
        }

        private bool SalvarNovaMusica()
        {
            try
            {
                //var ServicoUsuario = Util.criptografarteste(, UsuarioLogado.Instance().Senha);





                var CantorCrip = Util.Criptografar(txtCantor.Text, UsuarioLogado.Instance().Senha);
                var MusicaCrip = Util.Criptografar(txtMusica.Text, UsuarioLogado.Instance().Senha);

                File.AppendAllText(UsuarioLogado.GetCaminhoServicosUsuario(),
                (CantorCrip + ";" + MusicaCrip) + Environment.NewLine);

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar salvar: " + ex.Message, "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

        }
    }
}
