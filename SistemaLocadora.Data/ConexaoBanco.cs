using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadora.Data
{
    public class ConexaoBanco
    {
		internal SqlConnection GetConexao()
		{
			//Conexão com o banco de dados
			string connectionString = "Data Source=DESKTOP-G2HQT10\\SQLEXPRESS; Initial Catalog=Dados_Locadora; Persist Security Info=True;Integrated Security=SSPI; Pooling=True;";
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			return sqlConnection;
		}
	}
}
