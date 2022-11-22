using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SAEP
{
    internal class Areas
    {
        public int id { get; set; }
        public int area { get; set; }
        public int automovel { get; set; }
        public int concessionaria { get; set; }
        public int quantidade { get; set; }


        public List<Areas> listaareas()
        {
            List<Areas> ar = new List<Areas>();
            SqlConnection con = ClassConecta.ObterConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM alocacao";
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Areas a = new Areas();
                a.id = (int)dr["id"];
                a.area = (int)dr["area"];
                a.automovel = (int)dr["automovel"];
                a.quantidade = (int)dr["quantidade"];
                ar.Add(a);
            }
            return ar;
        }
    }
}
