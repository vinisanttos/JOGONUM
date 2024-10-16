using JOGONUM.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOGONUM
{
    public partial class TELADELOGIN : Form
    {


        public TELADELOGIN()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void enter_Click(object sender, EventArgs e)
        {
            string usuario = txbusuario.Text;
            string senha = txbsenha.Text;

            //cria objeto do tipo da entidade manipulada.
            Usuario usu = new Usuario(usuario, senha);

            //cria objeto para interaçao com o banco de dados.
            UsuarioDAO usuarioDAO = new UsuarioDAO();

            //chama o insert
            usuarioDAO.Insert(usu);

            
            
            string tnsdovini = txbusuario.Text;
            string tnsdovini1 = txbsenha.Text;

            if (tnsdovini == tnsdovini && tnsdovini1 == tnsdovini1)
            {
                TIPOSDETENIS TIPODETENIS = new TIPOSDETENIS();
                this.Visible = false;
                TIPODETENIS.ShowDialog();
                this.Visible = true;
            }
            else
            {
                MessageBox.Show("Usuario ou Senha esta incorreto.");
            }
        }

        private void usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txbsenha.Focus();
        }

        private void senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                enter.Focus();
        }

        private void txbsenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}