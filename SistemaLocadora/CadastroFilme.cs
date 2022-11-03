using SistemaLocadora.Data;
using SistemaLocadora.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLocadora
{
    public partial class CadastroFilme : Form
    {
        string caminhoFoto = "";

        private RepositorioFilme filme = new RepositorioFilme();

      
        public CadastroFilme()
        {
            InitializeComponent();
        }

        private void btnCarregarFoto_Click(object sender, EventArgs e)
        {
            CarregarFoto();
        }

        private void CarregarFoto()
        {
            var openFile = new OpenFileDialog();

            openFile.Title = "Filmes";
            openFile.Filter = "Arquivos de imagens jpg e png|*.jpg; *.png";
            openFile.InitialDirectory = @"C:\Users\User\Documents\Nuvem3\Projeto Locadora - Copia\ImagensFilmes";
            openFile.Multiselect = false;

            if (openFile.ShowDialog() == DialogResult.OK)
                caminhoFoto = openFile.FileName;

            if (caminhoFoto != "")
                pictureBox1.Load(caminhoFoto);
        }

        private void btnCadastraFilme_Click(object sender, EventArgs e)
        {
            SalvarFilme();
        }

        private void SalvarFilme()
        {
            filme.cNmNome = txtNomeFilme.Text;
            filme.cGenero = Convert.ToString(cboGenero.SelectedIndex + 1);
            filme.cClassificacao = txtClassificacao.Text;
            filme.iQtd =Convert.ToInt32(txtQtd.Text);
            filme.CaminhoFoto = caminhoFoto;

            filme.Salvar(filme); // Chamando o metodo de salvamento

            MessageBox.Show("Filme gravado");
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            CarregarFilme(Convert.ToInt32("0" + txtCodFilme.Text));
        }

        private void CarregarFilme(int id)
        {
           filme.Get(id,filme);

            txtNomeFilme.Text = filme.cNmNome;
            txtClassificacao.Text = filme.cClassificacao;
            cboGenero.SelectedIndex = Convert.ToInt32(filme.cGenero) - 1;
            txtQtd.Text = Convert.ToInt32(filme.iQtd).ToString();

            using (var foto = new MemoryStream(filme.cFoto))
            {
                pictureBox1.Image = Image.FromStream(foto); 
            }
            

        }

        private void btnLimparFilme_Click(object sender, EventArgs e)
        {
            filme.nCdDVD = 0;
            filme.cNmNome = "";
            filme.cGenero = "";
            filme.cClassificacao = "";
            filme.iQtd = 0;
            filme.cFoto = null;

            txtCodFilme.Clear();
            txtNomeFilme.Clear();
            txtClassificacao.Clear();
            txtQtd.Clear();
            cboGenero.Text = string.Empty;
            pictureBox1.Image = null;

            txtNomeFilme.Focus();
        }
    }
}
