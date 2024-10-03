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
            COMPRAAPROVADA tela1 = new COMPRAAPROVADA();
            this.Visible = false;
            tela1.ShowDialog();
            this.Visible = true;
        }
    }
}
