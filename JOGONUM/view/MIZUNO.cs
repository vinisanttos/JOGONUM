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
    public partial class MIZUNO : Form
    {
        public MIZUNO()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PAGAMENTOMIZUNO pagamentomizuno = new PAGAMENTOMIZUNO();
            this.Visible = false;
            pagamentomizuno.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PAGAMENTOMIZUNO pagamentomizuno = new PAGAMENTOMIZUNO();
            this.Visible = false;
            pagamentomizuno.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PAGAMENTOMIZUNO pagamentomizuno = new PAGAMENTOMIZUNO();
            this.Visible = false;
            pagamentomizuno.ShowDialog();
            this.Visible = true;
        }
    }
}
