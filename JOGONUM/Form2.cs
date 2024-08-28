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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 tela2 = new Form3();
            this.Visible = false;
            tela2.ShowDialog();
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 tela2 = new Form4();
            this.Visible = false;
            tela2.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 tela2 = new Form5();
            this.Visible = false;
            tela2.ShowDialog();
            this.Visible = true;
        }
    }
}