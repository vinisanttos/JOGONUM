﻿using System;
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
    public partial class COMPRAAPROVADA : Form
    {
        public COMPRAAPROVADA()
        {
            InitializeComponent();
        }

        private void COMPRAAPROVADAMIZ_Click(object sender, EventArgs e)
        {
            INICIO inicio = new INICIO();
            this.Visible = false;
            inicio.ShowDialog();
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            INICIO inicio = new INICIO();
            this.Visible = false;
            inicio.ShowDialog();
            this.Visible = true;
        }

        private void COMPRAAPROVADA_Load(object sender, EventArgs e)
        {

        }
    }
}
