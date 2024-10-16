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
    public partial class TIPOSDETENIS : Form
    {
        public TIPOSDETENIS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TN tela2 = new TN();
            this.Visible = false;
            tela2.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           MIZUNO MIZUNO = new MIZUNO();
           this.Visible = false;
           MIZUNO.ShowDialog();
           this.Visible = true;
        }
    }
}
