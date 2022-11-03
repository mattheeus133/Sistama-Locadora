using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadora.Data
{
    public class Repositorio
    {
		private ConexaoBanco conexao = new ConexaoBanco();

		public SqlConnection Sql
		{
			get
			{
				return conexao.GetConexao();
				
			}
		}
	}
}
