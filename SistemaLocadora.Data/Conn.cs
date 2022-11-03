using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadora.Data
{
    public class Conn
    {
        private static string server = @"DESKTOP-G2HQT10\SQLEXPRESS";
        private static string dataBase = "Dados_Locadora";
        private static string user = "DESKTOP-G2HQT10";
        private static string password = "senha";

        public static string StrCon
        {
            get { return $"Data Source={server}; Integrated Security=true;Initial Catalog={dataBase}; User ID={user}; Password={password}"; }

        }
    }
}
