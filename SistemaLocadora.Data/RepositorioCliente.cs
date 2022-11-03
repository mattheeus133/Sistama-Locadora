using Dapper;
using SistemaLocadora.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaLocadora.Data
{
    public class RepositorioCliente : Repositorio
    {
        public void Save (Cliente cliente)
        {
            var parameters = new Dictionary<string, object>();

			parameters.Add("@AnCdCliente", cliente.nCdCliente);
			parameters.Add("@AcNmNome", cliente.cNmNome);
			parameters.Add("@AdNascimento", cliente.dNascimento);
			parameters.Add("@AcGenero ", cliente.cGenero);
			parameters.Add("@AcEmail", cliente.cEmail);
			parameters.Add("@AcTelefone", cliente.cTelefone);
			parameters.Add("@AcCelular ", cliente.cCelular);
			parameters.Add("@AcPessoa ", cliente.cPessoa);
			parameters.Add("@AcCpf", cliente.cCpf);
			parameters.Add("@AcRG", cliente.cRG);
			parameters.Add("@AcOrgExp", cliente.cOrgExp);
			parameters.Add("@AcUfExp ", cliente.cUfExp);
			parameters.Add("@AcCep", cliente.cCep);
			parameters.Add("@AcEndereco", cliente.cEndereco);
			parameters.Add("@AcNumero", cliente.cNumero);
			parameters.Add("@AcUF", cliente.cUF);
			parameters.Add("@AcBairro", cliente.cBairro);
			parameters.Add("@AcCidade", cliente.cCidade);
			parameters.Add("@AcComplemento ", cliente.cComplemento);

			var codigo = Sql.Query<decimal>("EXEC dbo.SP_SalvarCliente @AnCdCliente,@AcNmNome ,@AdNascimento " +
                "                          ,@AcGenero ,@AcEmail ,@AcTelefone ,@AcCelular ,@AcPessoa ,@AcCpf ,@AcRG " +
                "                          ,@AcOrgExp ,@AcUfExp ,@AcCep ,@AcEndereco ,@AcNumero ,@AcUF ,@AcBairro ,@AcCidade ,@AcComplemento ", parameters).ToString();

            cliente.nCdCliente = codigo.FirstOrDefault();
        }

	

		public void Delet(decimal nCdCliente)
        {
			var parameters = new Dictionary<string, object>();
			parameters.Add("@AnCdCliente", nCdCliente);

			Sql.Query<Cliente>("dbo.SP_ExcluirCliente @AnCdCliente", parameters);
        }

    }
}
