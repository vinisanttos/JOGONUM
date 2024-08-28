namespace JOGONUM
{
    partial class Form6
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.USÚARIO = new System.Windows.Forms.Label();
            this.senha = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button1.Location = new System.Drawing.Point(125, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::JOGONUM.Properties.Resources.Captura_de_tela_2024_08_21_090714;
            this.panel1.Controls.Add(this.senha);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.usuario);
            this.panel1.Controls.Add(this.USÚARIO);
            this.panel1.Location = new System.Drawing.Point(284, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 176);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(25, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "SENHA";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // usuario
            // 
            this.usuario.AccessibleDescription = "tnsdovini";
            this.usuario.AccessibleName = "tnsdovini";
            this.usuario.Location = new System.Drawing.Point(28, 40);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(100, 20);
            this.usuario.TabIndex = 1;
            this.usuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usuario_KeyPress);
            // 
            // USÚARIO
            // 
            this.USÚARIO.AutoSize = true;
            this.USÚARIO.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.USÚARIO.Location = new System.Drawing.Point(25, 24);
            this.USÚARIO.Name = "USÚARIO";
            this.USÚARIO.Size = new System.Drawing.Size(56, 13);
            this.USÚARIO.TabIndex = 0;
            this.USÚARIO.Text = "USUÁRIO";
            this.USÚARIO.Click += new System.EventHandler(this.label1_Click);
            // 
            // senha
            // 
            this.senha.AccessibleDescription = "tnsdovini";
            this.senha.AccessibleName = "tnsdovini";
            this.senha.Location = new System.Drawing.Point(28, 93);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(100, 20);
            this.senha.TabIndex = 5;
            this.senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.senha_KeyPress);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JOGONUM.Properties.Resources.Captura_de_tela_2024_08_21_0907141;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label USÚARIO;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox senha;
    }
}