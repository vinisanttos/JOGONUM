using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOGONUM.view
{
    public partial class PAGAMENTOMIZUNO : Form
    {
        public PAGAMENTOMIZUNO()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }

        private void PAGAMENTOMIZUNO_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FINALIZARMIZ_Click(object sender, EventArgs e)
        {
            COMPRAAPROVADA tela5 = new COMPRAAPROVADA();
            this.Visible = false;
            tela5.ShowDialog();
            this.Visible = true;
        }
    }
}
