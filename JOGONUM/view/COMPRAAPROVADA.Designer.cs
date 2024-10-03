namespace JOGONUM.view
{
    partial class COMPRAAPROVADA
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
            this.COMPRAAPROVADAMIZ = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // COMPRAAPROVADAMIZ
            // 
            this.COMPRAAPROVADAMIZ.Location = new System.Drawing.Point(254, 258);
            this.COMPRAAPROVADAMIZ.Name = "COMPRAAPROVADAMIZ";
            this.COMPRAAPROVADAMIZ.Size = new System.Drawing.Size(273, 23);
            this.COMPRAAPROVADAMIZ.TabIndex = 0;
            this.COMPRAAPROVADAMIZ.Text = "SUA COMPRA FOI FEITA COM SUCESSO!";
            this.COMPRAAPROVADAMIZ.UseVisualStyleBackColor = true;
            this.COMPRAAPROVADAMIZ.Click += new System.EventHandler(this.COMPRAAPROVADAMIZ_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "CANCELAR COMPRA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // COMPRAAPROVADA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JOGONUM.Properties.Resources.Inserir_um_título__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.COMPRAAPROVADAMIZ);
            this.DoubleBuffered = true;
            this.Name = "COMPRAAPROVADA";
            this.Text = "COMPRAAPROVADA";
            this.Load += new System.EventHandler(this.COMPRAAPROVADA_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button COMPRAAPROVADAMIZ;
        private System.Windows.Forms.Button button1;
    }
}