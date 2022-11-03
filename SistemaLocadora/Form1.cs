using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLocadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PesquisarCliente cad = new PesquisarCliente();
            cad.ShowDialog();
        }

        private void cadastraClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente1 cli = new Cliente1(); // chamando outro forms
            cli.ShowDialog();
        }

        private void cadastraFilmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFilme cadFilme = new CadastroFilme();
            cadFilme.ShowDialog();
        }

        private void catalogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogoFilmes catalogoFilmes = new CatalogoFilmes();
            catalogoFilmes.ShowDialog();
        }
    }
}
