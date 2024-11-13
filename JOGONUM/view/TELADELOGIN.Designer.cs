namespace JOGONUM
{
    partial class TELADELOGIN
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.enter = new System.Windows.Forms.Button();
            this.txbsenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbusuario = new System.Windows.Forms.TextBox();
            this.USÚARIO = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btncriar = new System.Windows.Forms.Button();
            this.txtsenha1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusuario1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::JOGONUM.Properties.Resources.Captura_de_tela_2024_08_21_090714;
            this.panel1.Controls.Add(this.enter);
            this.panel1.Controls.Add(this.txbsenha);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbusuario);
            this.panel1.Controls.Add(this.USÚARIO);
            this.panel1.Location = new System.Drawing.Point(502, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 176);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(122, 150);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(75, 23);
            this.enter.TabIndex = 6;
            this.enter.Text = "ENTER";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // txbsenha
            // 
            this.txbsenha.AccessibleDescription = "tnsdovini";
            this.txbsenha.AccessibleName = "tnsdovini";
            this.txbsenha.Location = new System.Drawing.Point(28, 93);
            this.txbsenha.Name = "txbsenha";
            this.txbsenha.PasswordChar = '*';
            this.txbsenha.Size = new System.Drawing.Size(100, 20);
            this.txbsenha.TabIndex = 5;
            this.txbsenha.TextChanged += new System.EventHandler(this.txbsenha_TextChanged);
            this.txbsenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.senha_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "SENHA";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txbusuario
            // 
            this.txbusuario.AccessibleDescription = "tnsdovini";
            this.txbusuario.AccessibleName = "tnsdovini";
            this.txbusuario.Location = new System.Drawing.Point(28, 40);
            this.txbusuario.Name = "txbusuario";
            this.txbusuario.Size = new System.Drawing.Size(100, 20);
            this.txbusuario.TabIndex = 1;
            this.txbusuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.txbusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usuario_KeyPress);
            // 
            // USÚARIO
            // 
            this.USÚARIO.AutoSize = true;
            this.USÚARIO.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.USÚARIO.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USÚARIO.Location = new System.Drawing.Point(25, 24);
            this.USÚARIO.Name = "USÚARIO";
            this.USÚARIO.Size = new System.Drawing.Size(61, 16);
            this.USÚARIO.TabIndex = 0;
            this.USÚARIO.Text = "USUÁRIO";
            this.USÚARIO.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::JOGONUM.Properties.Resources.Captura_de_tela_2024_08_21_090714;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btncriar);
            this.panel2.Controls.Add(this.txtsenha1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtusuario1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(163, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 194);
            this.panel2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "CRIAR CONTA";
            // 
            // btncriar
            // 
            this.btncriar.Location = new System.Drawing.Point(48, 151);
            this.btncriar.Name = "btncriar";
            this.btncriar.Size = new System.Drawing.Size(75, 23);
            this.btncriar.TabIndex = 6;
            this.btncriar.Text = "CRIAR";
            this.btncriar.UseVisualStyleBackColor = true;
            this.btncriar.Click += new System.EventHandler(this.btncriar_Click);
            // 
            // txtsenha1
            // 
            this.txtsenha1.AccessibleDescription = "tnsdovini";
            this.txtsenha1.AccessibleName = "tnsdovini";
            this.txtsenha1.Location = new System.Drawing.Point(40, 111);
            this.txtsenha1.Name = "txtsenha1";
            this.txtsenha1.PasswordChar = '*';
            this.txtsenha1.Size = new System.Drawing.Size(100, 20);
            this.txtsenha1.TabIndex = 5;
            this.txtsenha1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "SENHA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtusuario1
            // 
            this.txtusuario1.AccessibleDescription = "tnsdovini";
            this.txtusuario1.AccessibleName = "tnsdovini";
            this.txtusuario1.Location = new System.Drawing.Point(40, 61);
            this.txtusuario1.Name = "txtusuario1";
            this.txtusuario1.Size = new System.Drawing.Size(100, 20);
            this.txtusuario1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "USUÁRIO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TELADELOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JOGONUM.Properties.Resources.Captura_de_tela_2024_08_21_0907141;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "TELADELOGIN";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label USÚARIO;
        private System.Windows.Forms.TextBox txbusuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbsenha;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btncriar;
        private System.Windows.Forms.TextBox txtsenha1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtusuario1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}