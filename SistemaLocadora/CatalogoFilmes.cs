using SistemaLocadora.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLocadora
{
    public partial class CatalogoFilmes : Form
    {
        public CatalogoFilmes()
        {
            InitializeComponent();
        }
        RepositorioFilme repositorioFilme = new RepositorioFilme();
        Conn conn = new Conn();
        private void btnBuscaFilme_Click(object sender, EventArgs e)
        {
            try
            {
                using(SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    var sqlQuery = "";

                    if (txtCodFilme.Text != "")
                    {
                        sqlQuery = "SELECT nCdDVD ,cNmNome, cGenero, iQtd, cFoto  FROM DVD WHERE nCdDVD = " + txtCodFilme.Text; // Pesquisa catalogo filme por id
                        
                        
                    }
                    if(txtNomeCatalogo.Text != "")
                    {
                        sqlQuery = "SELECT nCdDVD, cNmNome, iQtd, cFoto FROM DVD WHERE cNmNome LIKE '%" + txtNomeCatalogo.Text + "%'"; 
                        // pesquisa no catalogo filme por parte do nome do filme
                    }


                    using(SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dtgCatalogoFilme.DataSource = dt;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Falha\n\n" + ex.Message);
            }

        }

        private void dtgCatalogoFilme_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtgCatalogoFilme.Rows[e .RowIndex];
            labId.Text = row.Cells[0].Value.ToString();
            labNomeFilme.Text = row.Cells[1].Value.ToString();
            labGenero.Text = row.Cells[2].Value.ToString();
            labQtd.Text = row.Cells[3].Value.ToString();

            //Convert.ToByte((byte[])row.Cells[4].Value) = imgFilme.Image;




            Genero();

            for (int i = 0; i < dtgCatalogoFilme.RowCount; i++)
            {
                dtgCatalogoFilme.Rows[i].DataGridView.Columns.Clear();
            }

            txtCodFilme.Clear();



        }

        public void Genero()
        {
            if (labGenero.Text == "1")
            {
                labGenero.Text = "Ação";
            }
            if (labGenero.Text == "2")
            {
                labGenero.Text = "Comédia";
            }
            if (labGenero.Text == "3")
            {
                labGenero.Text = "Drama";
            }
            if (labGenero.Text == "4")
            {
                labGenero.Text = "Romance";
            }
            if (labGenero.Text == "5")
            {
                labGenero.Text = "Documentário";
            }
            if (labGenero.Text == "6")
            {
                labGenero.Text = "Suspense";
            }
            if (labGenero.Text == "7")
            {
                labGenero.Text = "Terror";
            }
            if (labGenero.Text == "8")
            {
                labGenero.Text = "Ficção científica";
            }
        }
    }
}
