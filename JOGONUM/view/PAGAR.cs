using QRCoder;
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
    public partial class PAGAR : Form
    {
        public PAGAR()
        {
            InitializeComponent();
        }

        private void btnGerarQrCode_Click(object sender, EventArgs e)
        {
            string chavePix = ""; // Substitua pela chave Pix válida
            string valor = txtValor.Text; // Pegando valor do TextBox (txtValor)

            // Gerar o Payload Pix diretamente no evento (sem descrição)
            string payloadPix = "00020126580014BR.GOV.BCB.PIX0136{chavePix}5204000053039865802BR5913";

            
            // Gerar o QR Code
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(payloadPix, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            QrCodeBox.Image = qrCode.GetGraphic(3);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void QrCodeBox_Click(object sender, EventArgs e)
        {

        }

        private void btnGerarQrCode1_Click(object sender, EventArgs e)
        {
            string pix = ""; // Substitua pela chave Pix válida
            string valor = txtValor1.Text; // Pegando valor do TextBox (txtValor)

            // Gerar o Payload Pix diretamente no evento (sem descrição)
            string payloadPix = "00020126580014BR.GOV.BCB.PIX0136{pix}5204000053039865802BR5913";


            // Gerar o QR Code
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(payloadPix, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            QrCodeBox.Image = qrCode.GetGraphic(3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            COMPRAAPROVADA tela5 = new COMPRAAPROVADA();
            this.Visible = false;
            tela5.ShowDialog();
            this.Visible = true;
        }
    }
}