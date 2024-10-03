using JOGONUM.view;
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
    public partial class TN : Form
    {
        public TN()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TIPOSDETENIS tela4 = new TIPOSDETENIS();
            this.Visible = false;
            tela4.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PAGAMENTOTN pagamentotn = new PAGAMENTOTN();
            this.Visible = false;
            pagamentotn.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PAGAMENTOTN pagamentotn = new PAGAMENTOTN();
            this.Visible = false;
            pagamentotn.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PAGAMENTOTN pagamentotn = new PAGAMENTOTN();
            this.Visible = false;
            pagamentotn.ShowDialog();
            this.Visible = true;
        }
    }
}