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
    public partial class PAGAMENTOTN : Form
    {
        public PAGAMENTOTN()
        {
            InitializeComponent();
        }

        private void FINALIZARMIZ_Click(object sender, EventArgs e)
        {
            Broker tela1 = new Broker();
            this.Visible = false;
            tela1.ShowDialog();
            this.Visible = true;
        }

        private void PAGAMENTOTN_Load(object sender, EventArgs e)
        {

        }

        private void LOCALTN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
