namespace SistemaLocadora
{
    partial class CatalogoFilmes
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
            this.txtCodFilme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgCatalogoFilme = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeCatalogo = new System.Windows.Forms.TextBox();
            this.btnBuscaFilme = new System.Windows.Forms.Button();
            this.btnLimparTudo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.imgFilme = new System.Windows.Forms.PictureBox();
            this.labNomeFilme = new System.Windows.Forms.Label();
            this.labId = new System.Windows.Forms.Label();
            this.labQtd = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labGenero = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCatalogoFilme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFilme)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodFilme
            // 
            this.txtCodFilme.Location = new System.Drawing.Point(45, 40);
            this.txtCodFilme.Name = "txtCodFilme";
            this.txtCodFilme.Size = new System.Drawing.Size(100, 20);
            this.txtCodFilme.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo Filme:";
            // 
            // dtgCatalogoFilme
            // 
            this.dtgCatalogoFilme.AllowUserToAddRows = false;
            this.dtgCatalogoFilme.AllowUserToDeleteRows = false;
            this.dtgCatalogoFilme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCatalogoFilme.Location = new System.Drawing.Point(45, 66);
            this.dtgCatalogoFilme.Name = "dtgCatalogoFilme";
            this.dtgCatalogoFilme.Size = new System.Drawing.Size(411, 326);
            this.dtgCatalogoFilme.TabIndex = 2;
            this.dtgCatalogoFilme.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCatalogoFilme_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome Filme:";
            // 
            // txtNomeCatalogo
            // 
            this.txtNomeCatalogo.Location = new System.Drawing.Point(180, 40);
            this.txtNomeCatalogo.Name = "txtNomeCatalogo";
            this.txtNomeCatalogo.Size = new System.Drawing.Size(162, 20);
            this.txtNomeCatalogo.TabIndex = 4;
            // 
            // btnBuscaFilme
            // 
            this.btnBuscaFilme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBuscaFilme.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaFilme.Location = new System.Drawing.Point(45, 398);
            this.btnBuscaFilme.Name = "btnBuscaFilme";
            this.btnBuscaFilme.Size = new System.Drawing.Size(119, 47);
            this.btnBuscaFilme.TabIndex = 28;
            this.btnBuscaFilme.Text = "Buscar";
            this.btnBuscaFilme.UseVisualStyleBackColor = false;
            this.btnBuscaFilme.Click += new System.EventHandler(this.btnBuscaFilme_Click);
            // 
            // btnLimparTudo
            // 
            this.btnLimparTudo.BackColor = System.Drawing.Color.Red;
            this.btnLimparTudo.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparTudo.Location = new System.Drawing.Point(223, 398);
            this.btnLimparTudo.Name = "btnLimparTudo";
            this.btnLimparTudo.Size = new System.Drawing.Size(119, 47);
            this.btnLimparTudo.TabIndex = 29;
            this.btnLimparTudo.Text = "Limpar";
            this.btnLimparTudo.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Codigo Filme:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Nome Filme:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(658, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Qtd:";
            // 
            // imgFilme
            // 
            this.imgFilme.Location = new System.Drawing.Point(588, 170);
            this.imgFilme.Name = "imgFilme";
            this.imgFilme.Size = new System.Drawing.Size(218, 263);
            this.imgFilme.TabIndex = 36;
            this.imgFilme.TabStop = false;
            // 
            // labNomeFilme
            // 
            this.labNomeFilme.AutoSize = true;
            this.labNomeFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNomeFilme.Location = new System.Drawing.Point(473, 71);
            this.labNomeFilme.Name = "labNomeFilme";
            this.labNomeFilme.Size = new System.Drawing.Size(0, 25);
            this.labNomeFilme.TabIndex = 37;
            // 
            // labId
            // 
            this.labId.AutoSize = true;
            this.labId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labId.Location = new System.Drawing.Point(473, 24);
            this.labId.Name = "labId";
            this.labId.Size = new System.Drawing.Size(0, 25);
            this.labId.TabIndex = 38;
            // 
            // labQtd
            // 
            this.labQtd.AutoSize = true;
            this.labQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labQtd.Location = new System.Drawing.Point(685, 130);
            this.labQtd.Name = "labQtd";
            this.labQtd.Size = new System.Drawing.Size(0, 25);
            this.labQtd.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(495, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Genero:";
            // 
            // labGenero
            // 
            this.labGenero.AutoSize = true;
            this.labGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGenero.Location = new System.Drawing.Point(475, 130);
            this.labGenero.Name = "labGenero";
            this.labGenero.Size = new System.Drawing.Size(0, 25);
            this.labGenero.TabIndex = 41;
            // 
            // CatalogoFilmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 467);
            this.Controls.Add(this.labGenero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labQtd);
            this.Controls.Add(this.labId);
            this.Controls.Add(this.labNomeFilme);
            this.Controls.Add(this.imgFilme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLimparTudo);
            this.Controls.Add(this.btnBuscaFilme);
            this.Controls.Add(this.txtNomeCatalogo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgCatalogoFilme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodFilme);
            this.Name = "CatalogoFilmes";
            this.Text = "CatalogoFilmes";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCatalogoFilme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFilme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodFilme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgCatalogoFilme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeCatalogo;
        private System.Windows.Forms.Button btnBuscaFilme;
        private System.Windows.Forms.Button btnLimparTudo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox imgFilme;
        private System.Windows.Forms.Label labNomeFilme;
        private System.Windows.Forms.Label labId;
        private System.Windows.Forms.Label labQtd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labGenero;
    }
}