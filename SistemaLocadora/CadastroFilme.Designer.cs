namespace SistemaLocadora
{
    partial class CadastroFilme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroFilme));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCarregarFoto = new System.Windows.Forms.Button();
            this.btnLimparImagen = new System.Windows.Forms.Button();
            this.txtCodFilme = new System.Windows.Forms.TextBox();
            this.txtNomeFilme = new System.Windows.Forms.TextBox();
            this.txtClassificacao = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSinop = new System.Windows.Forms.Button();
            this.btnLimparSinop = new System.Windows.Forms.Button();
            this.btnExcluirFilme = new System.Windows.Forms.Button();
            this.btnLimparFilme = new System.Windows.Forms.Button();
            this.btnCadastraFilme = new System.Windows.Forms.Button();
            this.btnCarregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(534, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 285);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCarregarFoto
            // 
            this.btnCarregarFoto.FlatAppearance.BorderSize = 0;
            this.btnCarregarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregarFoto.Image = ((System.Drawing.Image)(resources.GetObject("btnCarregarFoto.Image")));
            this.btnCarregarFoto.Location = new System.Drawing.Point(598, 332);
            this.btnCarregarFoto.Name = "btnCarregarFoto";
            this.btnCarregarFoto.Size = new System.Drawing.Size(49, 42);
            this.btnCarregarFoto.TabIndex = 1;
            this.btnCarregarFoto.UseVisualStyleBackColor = true;
            this.btnCarregarFoto.Click += new System.EventHandler(this.btnCarregarFoto_Click);
            // 
            // btnLimparImagen
            // 
            this.btnLimparImagen.FlatAppearance.BorderSize = 0;
            this.btnLimparImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparImagen.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparImagen.Image")));
            this.btnLimparImagen.Location = new System.Drawing.Point(674, 332);
            this.btnLimparImagen.Name = "btnLimparImagen";
            this.btnLimparImagen.Size = new System.Drawing.Size(50, 42);
            this.btnLimparImagen.TabIndex = 2;
            this.btnLimparImagen.UseVisualStyleBackColor = true;
            // 
            // txtCodFilme
            // 
            this.txtCodFilme.Location = new System.Drawing.Point(42, 44);
            this.txtCodFilme.Name = "txtCodFilme";
            this.txtCodFilme.Size = new System.Drawing.Size(78, 20);
            this.txtCodFilme.TabIndex = 3;
            // 
            // txtNomeFilme
            // 
            this.txtNomeFilme.Location = new System.Drawing.Point(129, 44);
            this.txtNomeFilme.Name = "txtNomeFilme";
            this.txtNomeFilme.Size = new System.Drawing.Size(337, 20);
            this.txtNomeFilme.TabIndex = 4;
            // 
            // txtClassificacao
            // 
            this.txtClassificacao.Location = new System.Drawing.Point(148, 83);
            this.txtClassificacao.Name = "txtClassificacao";
            this.txtClassificacao.Size = new System.Drawing.Size(188, 20);
            this.txtClassificacao.TabIndex = 6;
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(342, 83);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(124, 20);
            this.txtQtd.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Codigo Filme:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nome Filme:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Genero:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Qtd:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Classificação:";
            // 
            // cboGenero
            // 
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Items.AddRange(new object[] {
            "1-Ação. ",
            "2-Comédia.",
            "3-Drama",
            "4-Romance ",
            "5-Documentário",
            "6-Suspense",
            "7-Terror",
            "8-Ficção científica"});
            this.cboGenero.Location = new System.Drawing.Point(42, 82);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(100, 21);
            this.cboGenero.TabIndex = 22;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(42, 139);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(475, 174);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Sinopse:";
            // 
            // btnSinop
            // 
            this.btnSinop.FlatAppearance.BorderSize = 0;
            this.btnSinop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinop.Image = ((System.Drawing.Image)(resources.GetObject("btnSinop.Image")));
            this.btnSinop.Location = new System.Drawing.Point(443, 113);
            this.btnSinop.Name = "btnSinop";
            this.btnSinop.Size = new System.Drawing.Size(34, 23);
            this.btnSinop.TabIndex = 25;
            this.btnSinop.UseVisualStyleBackColor = true;
            // 
            // btnLimparSinop
            // 
            this.btnLimparSinop.FlatAppearance.BorderSize = 0;
            this.btnLimparSinop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparSinop.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparSinop.Image")));
            this.btnLimparSinop.Location = new System.Drawing.Point(483, 113);
            this.btnLimparSinop.Name = "btnLimparSinop";
            this.btnLimparSinop.Size = new System.Drawing.Size(34, 23);
            this.btnLimparSinop.TabIndex = 26;
            this.btnLimparSinop.UseVisualStyleBackColor = true;
            // 
            // btnExcluirFilme
            // 
            this.btnExcluirFilme.BackColor = System.Drawing.Color.Red;
            this.btnExcluirFilme.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirFilme.Location = new System.Drawing.Point(290, 328);
            this.btnExcluirFilme.Name = "btnExcluirFilme";
            this.btnExcluirFilme.Size = new System.Drawing.Size(119, 47);
            this.btnExcluirFilme.TabIndex = 29;
            this.btnExcluirFilme.Text = "Excluir";
            this.btnExcluirFilme.UseVisualStyleBackColor = false;
            // 
            // btnLimparFilme
            // 
            this.btnLimparFilme.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimparFilme.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparFilme.Location = new System.Drawing.Point(165, 328);
            this.btnLimparFilme.Name = "btnLimparFilme";
            this.btnLimparFilme.Size = new System.Drawing.Size(119, 47);
            this.btnLimparFilme.TabIndex = 28;
            this.btnLimparFilme.Text = "Limpar";
            this.btnLimparFilme.UseVisualStyleBackColor = false;
            this.btnLimparFilme.Click += new System.EventHandler(this.btnLimparFilme_Click);
            // 
            // btnCadastraFilme
            // 
            this.btnCadastraFilme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCadastraFilme.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastraFilme.Location = new System.Drawing.Point(40, 328);
            this.btnCadastraFilme.Name = "btnCadastraFilme";
            this.btnCadastraFilme.Size = new System.Drawing.Size(119, 47);
            this.btnCadastraFilme.TabIndex = 27;
            this.btnCadastraFilme.Text = "Cadastra";
            this.btnCadastraFilme.UseVisualStyleBackColor = false;
            this.btnCadastraFilme.Click += new System.EventHandler(this.btnCadastraFilme_Click);
            // 
            // btnCarregar
            // 
            this.btnCarregar.BackColor = System.Drawing.Color.Chartreuse;
            this.btnCarregar.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregar.Location = new System.Drawing.Point(415, 327);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(119, 47);
            this.btnCarregar.TabIndex = 30;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = false;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // CadastroFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.btnExcluirFilme);
            this.Controls.Add(this.btnLimparFilme);
            this.Controls.Add(this.btnCadastraFilme);
            this.Controls.Add(this.btnLimparSinop);
            this.Controls.Add(this.btnSinop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.cboGenero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.txtClassificacao);
            this.Controls.Add(this.txtNomeFilme);
            this.Controls.Add(this.txtCodFilme);
            this.Controls.Add(this.btnLimparImagen);
            this.Controls.Add(this.btnCarregarFoto);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CadastroFilme";
            this.Text = "CadastroFilme";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCarregarFoto;
        private System.Windows.Forms.Button btnLimparImagen;
        private System.Windows.Forms.TextBox txtCodFilme;
        private System.Windows.Forms.TextBox txtNomeFilme;
        private System.Windows.Forms.TextBox txtClassificacao;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSinop;
        private System.Windows.Forms.Button btnLimparSinop;
        private System.Windows.Forms.Button btnExcluirFilme;
        private System.Windows.Forms.Button btnLimparFilme;
        private System.Windows.Forms.Button btnCadastraFilme;
        private System.Windows.Forms.Button btnCarregar;
    }
}