namespace JOGONUM.view
{
    partial class PAGAMENTOTN
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
            this.PREÇOTN = new System.Windows.Forms.TextBox();
            this.LOCALTN = new System.Windows.Forms.TextBox();
            this.TAMANHOTN = new System.Windows.Forms.ComboBox();
            this.MODELOTN = new System.Windows.Forms.ComboBox();
            this.FINALIZARTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PREÇOTN
            // 
            this.PREÇOTN.Enabled = false;
            this.PREÇOTN.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PREÇOTN.Location = new System.Drawing.Point(406, 250);
            this.PREÇOTN.Name = "PREÇOTN";
            this.PREÇOTN.ReadOnly = true;
            this.PREÇOTN.Size = new System.Drawing.Size(106, 22);
            this.PREÇOTN.TabIndex = 7;
            this.PREÇOTN.TabStop = false;
            this.PREÇOTN.Text = "R$347.00";
            // 
            // LOCALTN
            // 
            this.LOCALTN.Enabled = false;
            this.LOCALTN.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOCALTN.Location = new System.Drawing.Point(406, 179);
            this.LOCALTN.Name = "LOCALTN";
            this.LOCALTN.ReadOnly = true;
            this.LOCALTN.Size = new System.Drawing.Size(106, 22);
            this.LOCALTN.TabIndex = 6;
            this.LOCALTN.Text = "Campos do Jordão";
            this.LOCALTN.TextChanged += new System.EventHandler(this.LOCALTN_TextChanged);
            // 
            // TAMANHOTN
            // 
            this.TAMANHOTN.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TAMANHOTN.FormattingEnabled = true;
            this.TAMANHOTN.Items.AddRange(new object[] {
            "P",
            "M",
            "G",
            "GG",
            "XGG"});
            this.TAMANHOTN.Location = new System.Drawing.Point(207, 249);
            this.TAMANHOTN.Name = "TAMANHOTN";
            this.TAMANHOTN.Size = new System.Drawing.Size(121, 23);
            this.TAMANHOTN.TabIndex = 5;
            this.TAMANHOTN.Text = "TAMANHO";
            // 
            // MODELOTN
            // 
            this.MODELOTN.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MODELOTN.FormattingEnabled = true;
            this.MODELOTN.Items.AddRange(new object[] {
            "TN 1 \"VOLTAGE PURPLE\"",
            "TN 1 \"BLACK METALIC\"",
            "TN 1 \"DUSK\""});
            this.MODELOTN.Location = new System.Drawing.Point(207, 178);
            this.MODELOTN.Name = "MODELOTN";
            this.MODELOTN.Size = new System.Drawing.Size(121, 23);
            this.MODELOTN.TabIndex = 4;
            this.MODELOTN.Text = "MODELO";
            // 
            // FINALIZARTN
            // 
            this.FINALIZARTN.Location = new System.Drawing.Point(562, 350);
            this.FINALIZARTN.Name = "FINALIZARTN";
            this.FINALIZARTN.Size = new System.Drawing.Size(89, 23);
            this.FINALIZARTN.TabIndex = 8;
            this.FINALIZARTN.Text = "PROSSEGUIR";
            this.FINALIZARTN.UseVisualStyleBackColor = true;
            this.FINALIZARTN.Click += new System.EventHandler(this.FINALIZARMIZ_Click);
            // 
            // PAGAMENTOTN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JOGONUM.Properties.Resources.Inserir_um_título__3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FINALIZARTN);
            this.Controls.Add(this.PREÇOTN);
            this.Controls.Add(this.LOCALTN);
            this.Controls.Add(this.TAMANHOTN);
            this.Controls.Add(this.MODELOTN);
            this.DoubleBuffered = true;
            this.Name = "PAGAMENTOTN";
            this.Text = "PAGAMENTOTN";
            this.Load += new System.EventHandler(this.PAGAMENTOTN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PREÇOTN;
        private System.Windows.Forms.TextBox LOCALTN;
        private System.Windows.Forms.ComboBox TAMANHOTN;
        private System.Windows.Forms.ComboBox MODELOTN;
        private System.Windows.Forms.Button FINALIZARTN;
    }
}