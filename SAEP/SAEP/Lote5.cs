using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SAEP
{
    internal class Lote5
    {
        public int id { get; set; }
        public string modelo { get; set; }
        public decimal preco { get; set; }
        public int quantidade { get; set; }

        public List<Lote5> listalote()
        {
            List<Lote5> lo = new List<Lote5>();
            SqlConnection con = ClassConecta.ObterConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT automoveis.id,automoveis.modelo,automoveis.preco,alocacao.quantidade FROM automoveis LEFT JOIN alocacao ON alocacao.automovel=automoveis.id WHERE area = 8 AND alocacao.quantidade > 0";
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Lote5 l = new Lote5();
                l.id = (int)dr["id"];
                l.modelo = dr["modelo"].ToString().Trim();
                l.preco = (decimal)dr["preco"];
                l.quantidade = (int)dr["quantidade"];
                lo.Add(l);
            }
            return lo;
        }
    }
}
