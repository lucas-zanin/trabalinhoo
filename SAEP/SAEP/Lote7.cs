using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SAEP
{
    internal class Lote7
    {
        public int id { get; set; }
        public string modelo { get; set; }
        public decimal preco { get; set; }
        public int quantidade { get; set; }

        public List<Lote7> listalote()
        {
            List<Lote7> lo = new List<Lote7>();
            SqlConnection con = ClassConecta.ObterConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT automoveis.id,automoveis.modelo,automoveis.preco,alocacao.quantidade FROM automoveis LEFT JOIN alocacao ON alocacao.automovel=automoveis.id WHERE area = 10 AND alocacao.quantidade > 0";
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Lote7 l = new Lote7();
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
