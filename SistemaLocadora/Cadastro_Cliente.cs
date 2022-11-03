using SistemaLocadora.Data;
using SistemaLocadora.Domain;
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
    public partial class Cliente1 : Form
    {
       
        public Cliente1()
        {
            InitializeComponent();
        }
        private void Cliente1_Load(object sender, EventArgs e)
        {
            cbGenero.SelectedIndex = 0;
            cbPessoa.SelectedIndex = 0;
        }
        RepositorioCliente repositorioCliente = new RepositorioCliente();
       
        
        private void btnCadastra_Click(object sender, EventArgs e)
        {
            var novoCliente = new Cliente();

            //Verificar();
            if (String.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Entre com um nome!");
                return;

            }

            if (txtId.Text != string.Empty)
            {
                novoCliente.nCdCliente = Convert.ToDecimal(txtId.Text);
            }

            //novoCliente.nCdCliente = Convert.ToDecimal(txtId.Text);
            novoCliente.cNmNome = txtNome.Text;
            novoCliente.dNascimento = txtNasc.Text;
            novoCliente.cGenero = Convert.ToString(cbGenero.SelectedIndex + 1);
            novoCliente.cEmail = txtEmail.Text;
            novoCliente.cTelefone = txtTel.Text;
            novoCliente.cCelular = txtCel.Text;
            novoCliente.cPessoa = Convert.ToString(cbPessoa.SelectedIndex + 1);
            novoCliente.cCpf = txtCpf.Text;
            novoCliente.cRG = txtRg.Text;
            novoCliente.cOrgExp = txtOrg.Text;
            novoCliente.cUfExp = txtUf.Text;
            novoCliente.cCep = txtCep.Text;
            novoCliente.cEndereco = txtEnd.Text;
            novoCliente.cNumero = Convert.ToInt32(txtNumCasa.Text);
            novoCliente.cUF = txtUf.Text;
            novoCliente.cBairro = txtBairro.Text;
            novoCliente.cCidade = txtCidade.Text;
            novoCliente.cComplemento = txtComplemento.Text;

            repositorioCliente.Save(novoCliente);
            txtId.Text = novoCliente.nCdCliente.ToString();

            MessageBox.Show("Cliente Cadastrado com sucesso");

            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
           this.Close(); // fecha o formulario
          


        }
        #region Metodos()
        private void Limpar()
        {
            txtNome.Clear();
            txtId.Clear();
            txtTel.Clear();
            txtEnd.Clear();
            txtEmail.Clear();
            txtCpf.Clear(); 
            txtCep.Clear();
        }

        public void Verificar()
        {
            if (String.IsNullOrWhiteSpace(txtNome.Text)) 
            {
                MessageBox.Show("Entre com um nome!");
                return;
                
            }
            else if(txtCpf.Text == String.Empty)
            {
                MessageBox.Show("Entre com um Cpf!");
            }
            else if (txtEnd.Text == String.Empty)
            {
                MessageBox.Show("Entre com um endereço!");
            }
            else if(txtTel.Text == String.Empty)
            {
                MessageBox.Show("Entre com um Telefone!");
            }
            else if(txtEmail.Text == String.Empty)
            {
                MessageBox.Show("Entre com um email!");
            }
            else if(txtCep.Text == String.Empty)
            {
                MessageBox.Show("Entre com um Cep!");
            }
        }



        #endregion

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            repositorioCliente.Delet(Convert.ToDecimal(txtId.Text));

            MessageBox.Show("Cliente Excluido");
        }
    }
}
