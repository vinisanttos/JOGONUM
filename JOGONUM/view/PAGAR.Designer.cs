namespace JOGONUM.view
{
    partial class PAGAR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGerarQrCode = new System.Windows.Forms.Button();
            this.QrCodeBox = new System.Windows.Forms.PictureBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.btnGerarQrCode1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QrCodeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGerarQrCode
            // 
            this.btnGerarQrCode.Location = new System.Drawing.Point(193, 254);
            this.btnGerarQrCode.Name = "btnGerarQrCode";
            this.btnGerarQrCode.Size = new System.Drawing.Size(75, 23);
            this.btnGerarQrCode.TabIndex = 0;
            this.btnGerarQrCode.Text = "PAGAR";
            this.btnGerarQrCode.UseVisualStyleBackColor = true;
            this.btnGerarQrCode.Click += new System.EventHandler(this.btnGerarQrCode_Click);
            // 
            // QrCodeBox
            // 
            this.QrCodeBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.QrCodeBox.Location = new System.Drawing.Point(338, 190);
            this.QrCodeBox.Name = "QrCodeBox";
            this.QrCodeBox.Size = new System.Drawing.Size(137, 140);
            this.QrCodeBox.TabIndex = 1;
            this.QrCodeBox.TabStop = false;
            this.QrCodeBox.Click += new System.EventHandler(this.QrCodeBox_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(193, 228);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(62, 20);
            this.txtValor.TabIndex = 2;
            this.txtValor.Text = "R$347.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "TN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(532, 228);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(60, 20);
            this.txtValor1.TabIndex = 4;
            this.txtValor1.Text = "R$377.00";
            // 
            // btnGerarQrCode1
            // 
            this.btnGerarQrCode1.Location = new System.Drawing.Point(532, 270);
            this.btnGerarQrCode1.Name = "btnGerarQrCode1";
            this.btnGerarQrCode1.Size = new System.Drawing.Size(75, 23);
            this.btnGerarQrCode1.TabIndex = 5;
            this.btnGerarQrCode1.Text = "PAGAR";
            this.btnGerarQrCode1.UseVisualStyleBackColor = true;
            this.btnGerarQrCode1.Click += new System.EventHandler(this.btnGerarQrCode1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(536, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "MIZUNO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "FINALIZAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PAGAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JOGONUM.Properties.Resources.Inserir_um_título10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGerarQrCode1);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.QrCodeBox);
            this.Controls.Add(this.btnGerarQrCode);
            this.DoubleBuffered = true;
            this.Name = "PAGAR";
            this.Text = "PAGAR";
            ((System.ComponentModel.ISupportInitialize)(this.QrCodeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerarQrCode;
        private System.Windows.Forms.PictureBox QrCodeBox;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.Button btnGerarQrCode1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}