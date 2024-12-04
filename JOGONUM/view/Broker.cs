using JOGONUM.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace JOGONUM.view
{
    public partial class Broker : Form
    {

        public Broker()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string modelo = cmbModelo.Text;
            string preco = txbPreco.Text;
            string usuario = txbusu.Text;

            // Verifica se o item já está na lista
            foreach (ListViewItem item in lvtProdutos.Items)
            {
                if (item.Text == modelo)
                {
                    item.SubItems[1].Text = preco; // Atualiza o preço
                    return;
                }
            }
        
    }

        private void btn_broker_Click(object sender, EventArgs e)
        {
            PAGAR tela1 = new PAGAR();
            this.Visible = false;
            tela1.ShowDialog();
            this.Visible = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Atualiza o campo de preço com base no modelo selecionado
            if (cmbModelo.SelectedItem.ToString() == "TN")
            {
                txbPreco.Text = "347,00";
            }
            else if (cmbModelo.SelectedItem.ToString() == "Mizuno")
            {
                txbPreco.Text = "377,00";
            }
            lvtProdutos.Columns.Add("Usuario");
            lvtProdutos.Columns.Add("Modelo");
            lvtProdutos.Columns.Add("Preço");
            lvtProdutos.View = View.Details;
        }
        private void Broker_Load(object sender, EventArgs e)
        {
            // Adiciona os modelos ao ComboBox
            cmbModelo.Items.Add("TN");
            cmbModelo.Items.Add("Mizuno");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string modelo = cmbModelo.Text;
            string preco = txbPreco.Text;
            string usuario = txbusu.Text;

            var novoItem = new ListViewItem(usuario);  // Adiciona o usuário como o primeiro item
            novoItem.SubItems.Add(modelo);            // Adiciona o modelo
            novoItem.SubItems.Add(preco);             // Adiciona o preço
            lvtProdutos.Items.Add(novoItem);          // Adiciona o item ao ListView

            // Limpa os campos após adicionar
            txbusu.Clear();
            txbPreco.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.MessageBox.Show("Salvo com Sucesso!");
        }
    }
}

