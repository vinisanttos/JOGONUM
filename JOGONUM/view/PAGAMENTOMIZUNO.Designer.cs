namespace JOGONUM.view
{
    partial class PAGAMENTOMIZUNO
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
            this.MODELOMIZ = new System.Windows.Forms.ComboBox();
            this.TAMANHOMIZ = new System.Windows.Forms.ComboBox();
            this.LOCALMIZ = new System.Windows.Forms.TextBox();
            this.PREÇOMIZ = new System.Windows.Forms.TextBox();
            this.FINALIZARMIZ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MODELOMIZ
            // 
            this.MODELOMIZ.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MODELOMIZ.FormattingEnabled = true;
            this.MODELOMIZ.Items.AddRange(new object[] {
            "MIZUNO LS \"AREIA\".",
            "MIZUNO 7 \"BRANCO\".",
            "MIZUNO 8 \"PRETO\"."});
            this.MODELOMIZ.Location = new System.Drawing.Point(203, 165);
            this.MODELOMIZ.Name = "MODELOMIZ";
            this.MODELOMIZ.Size = new System.Drawing.Size(121, 23);
            this.MODELOMIZ.TabIndex = 0;
            this.MODELOMIZ.Text = "MODELO";
            this.MODELOMIZ.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // TAMANHOMIZ
            // 
            this.TAMANHOMIZ.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TAMANHOMIZ.FormattingEnabled = true;
            this.TAMANHOMIZ.Items.AddRange(new object[] {
            "P",
            "M",
            "G",
            "GG",
            "XGG"});
            this.TAMANHOMIZ.Location = new System.Drawing.Point(203, 236);
            this.TAMANHOMIZ.Name = "TAMANHOMIZ";
            this.TAMANHOMIZ.Size = new System.Drawing.Size(121, 23);
            this.TAMANHOMIZ.TabIndex = 1;
            this.TAMANHOMIZ.Text = "TAMANHO";
            // 
            // LOCALMIZ
            // 
            this.LOCALMIZ.Enabled = false;
            this.LOCALMIZ.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOCALMIZ.Location = new System.Drawing.Point(402, 166);
            this.LOCALMIZ.Name = "LOCALMIZ";
            this.LOCALMIZ.ReadOnly = true;
            this.LOCALMIZ.Size = new System.Drawing.Size(106, 22);
            this.LOCALMIZ.TabIndex = 2;
            this.LOCALMIZ.Text = "Campos do Jordão";
            this.LOCALMIZ.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PREÇOMIZ
            // 
            this.PREÇOMIZ.Enabled = false;
            this.PREÇOMIZ.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PREÇOMIZ.Location = new System.Drawing.Point(402, 237);
            this.PREÇOMIZ.Name = "PREÇOMIZ";
            this.PREÇOMIZ.ReadOnly = true;
            this.PREÇOMIZ.Size = new System.Drawing.Size(106, 22);
            this.PREÇOMIZ.TabIndex = 3;
            this.PREÇOMIZ.TabStop = false;
            this.PREÇOMIZ.Text = "R$377.00";
            this.PREÇOMIZ.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // FINALIZARMIZ
            // 
            this.FINALIZARMIZ.Location = new System.Drawing.Point(522, 322);
            this.FINALIZARMIZ.Name = "FINALIZARMIZ";
            this.FINALIZARMIZ.Size = new System.Drawing.Size(75, 23);
            this.FINALIZARMIZ.TabIndex = 4;
            this.FINALIZARMIZ.Text = "FINALIZAR";
            this.FINALIZARMIZ.UseVisualStyleBackColor = true;
            this.FINALIZARMIZ.Click += new System.EventHandler(this.FINALIZARMIZ_Click);
            // 
            // PAGAMENTOMIZUNO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JOGONUM.Properties.Resources.Design_sem_nome__1_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FINALIZARMIZ);
            this.Controls.Add(this.PREÇOMIZ);
            this.Controls.Add(this.LOCALMIZ);
            this.Controls.Add(this.TAMANHOMIZ);
            this.Controls.Add(this.MODELOMIZ);
            this.DoubleBuffered = true;
            this.Name = "PAGAMENTOMIZUNO";
            this.Text = "PAGAMENTOMIZUNO";
            this.Load += new System.EventHandler(this.PAGAMENTOMIZUNO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MODELOMIZ;
        private System.Windows.Forms.ComboBox TAMANHOMIZ;
        private System.Windows.Forms.TextBox LOCALMIZ;
        private System.Windows.Forms.TextBox PREÇOMIZ;
        private System.Windows.Forms.Button FINALIZARMIZ;
    }
}