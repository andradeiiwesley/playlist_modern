using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace WF_ModernUI
{
    public partial class FormMenu : Form
    {
      

        private Form frmAtivo;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]

        public static extern bool ReleaseCapture();


        public FormMenu()
        {
            InitializeComponent();
            CarregarDados();
            
        }


        private void CarregarDados()
        {
            try
            {
                DataTable table = new DataTable();

              //table.Columns.Add("Id", typeof(int));
                table.Columns.Add("Cantor", typeof(string));
                table.Columns.Add("Música", typeof(string));

                string[] linhas = File.ReadAllLines(UsuarioLogado.GetCaminhoServicosUsuario());

                foreach (var linha in linhas)
                {
                    string Cantor = Util.Descriptografar(linha.Split(';')[0], UsuarioLogado.Instance().Senha);
                    string Musica = Util.Descriptografar(linha.Split(';')[1], UsuarioLogado.Instance().Senha);
                    table.Rows.Add(Cantor, Musica);

                }

                dataGridView1.DataSource = table;
            }
            catch (Exception)
            {

                //throw;
            }
        }

       

        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            panelConteudo.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();


        }

        private void ActiveFormClose()
        {
            if (frmAtivo != null)

                frmAtivo.Close();
        }

        private void ActiveButton(Button frmAtivo)
        {
            foreach (Control ctrl in panelConteudo.Controls)
            {
               

               
            }
        }

        private void btnContas_Click(object sender, EventArgs e)
        {
            ActiveButton(btnContas);
            FormShow(new FormYesso());

        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
     

        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = true;
        }

        private void panelCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);

            }

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ActiveButton(btnClientes);
            FormShow(new FormwSounds());  
        }


        private void btnVendas_Click(object sender, EventArgs e)
        {
            ActiveButton(btnVendas);
            FormShow(new FormTeezer());
        }


        private void btnCompras_Click(object sender, EventArgs e)
        {
            ActiveButton(btnCompras);
            FormShow(new FormNimoMusic());

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActiveButton(btnHome);
            CarregarDados();
            ActiveFormClose();

        }

        private void panelConteudo_Paint(object sender, PaintEventArgs e)
        {

        }

      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtProcurar_TextChanged(object sender, EventArgs e)
        {
            

            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Cantor LIKE '%{0}%' OR Música LIKE '%{0}%'", txtProcurar.Text);

            if (string.IsNullOrWhiteSpace(txtProcurar.Text))
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = null;
            }

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_Name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_State.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            */
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
       {
           var ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
           //Cantor = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
           //Musica = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
       }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //dataGridView1.Rows[e.RowIndex].Cells["excluir"].ToolTipText = "Clique aqui para excluir.";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //File.ReadAllLines(UsuarioLogado.GetCaminhoServicosUsuario());

             int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);

            if (File.Exists(UsuarioLogado.GetCaminhoServicosUsuario()))
                File.Delete(UsuarioLogado.GetCaminhoServicosUsuario());


            for (int i = 0; (i < dataGridView1.Rows.Count -1); i++)
            {
                var item = dataGridView1.Rows[i];

                var CantorCrip = Util.Criptografar(item.Cells[0].Value, UsuarioLogado.Instance().Senha);
                var MusicaCrip = Util.Criptografar(item.Cells[1].Value, UsuarioLogado.Instance().Senha);

                File.AppendAllText(UsuarioLogado.GetCaminhoServicosUsuario(),
                (CantorCrip + ";" + MusicaCrip) + Environment.NewLine);

            }

        }

       
    }
}

