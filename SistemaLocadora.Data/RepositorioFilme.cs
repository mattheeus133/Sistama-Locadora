using SistemaLocadora.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadora.Data
{
    public class RepositorioFilme
    {
        public int nCdDVD { get; set; }
        public string cNmNome { get; set; }
        public string cGenero { get; set; }
        public string cClassificacao { get; set; }
        public Int32 iQtd { get; set; }
        public string CaminhoFoto { get; set; }
        public byte[] cFoto { get; set; }

        public void Get(int id, RepositorioFilme filme)
        {
            var sql = "SELECT cNmNome, cGenero, cClassificacao, iQtd, cFoto FROM DVD WHERE nCdDVD = " + id;

            using (var con = new SqlConnection(Conn.StrCon))
            {
                con.Open();
                using (var cmd = new SqlCommand(sql, con))
                {
                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            if (dr.Read())
                            {
                                filme.nCdDVD = id;
                                filme.cNmNome = dr["cNmNome"].ToString();
                                filme.cGenero = dr["cGenero"].ToString();
                                filme.cClassificacao = dr["cClassificacao"].ToString();
                                filme.iQtd = Convert.ToInt32(dr["iQtd"]);
                                filme.CaminhoFoto = "";
                                filme.cFoto = (byte[])dr["cFoto"];



                            }
                        }
                    }
                }
            }

        }

        public void Salvar(RepositorioFilme filme)
        {
            byte[] foto = GetFoto(filme.CaminhoFoto);

            var sql = "INSERT INTO DVD (cNmNome,cGenero,cClassificacao,iQtd,cFoto) values (@cNmNome, @cGenero, @cClassificacao, @iQtd, @cFoto)";

            using (var con = new SqlConnection(Conn.StrCon))
            {
                con.Open();
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@cNmNome", filme.cNmNome);
                    cmd.Parameters.AddWithValue("@cGenero", filme.cGenero);
                    cmd.Parameters.AddWithValue("@cClassificacao", filme.cClassificacao);
                    cmd.Parameters.AddWithValue("@iQtd", filme.iQtd);
                    cmd.Parameters.Add("@cFoto", System.Data.SqlDbType.Image, foto.Length).Value = foto;

                    cmd.ExecuteNonQuery();

                }
            }
        }
        public byte[] GetFoto(string caminhoFoto)
        {
            byte[] foto;
            using (var stream = new FileStream(caminhoFoto, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(stream))
                {
                    foto = reader.ReadBytes((int)stream.Length);
                }


            }
            return foto;
        }

            

    }
}
