using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SAEP
{
    public partial class Form1 : Form
    {
        SqlConnection con = ClassConecta.ObterConexao();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            string sql = "SELECT area FROM alocacao WHERE area=1";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                pbxL1.BackColor = Color.Blue;
            }

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            string sql1 = "SELECT area FROM alocacao WHERE area=2";
            SqlCommand cmd1 = new SqlCommand(sql1, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                pbxL2.BackColor = Color.Blue;
            }

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            string sql2 = "SELECT area FROM alocacao WHERE area=3";
            SqlCommand cmd2 = new SqlCommand(sql2, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                pbxL3.BackColor = Color.Blue;
            }

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            string sql3 = "SELECT area FROM alocacao WHERE area=4";
            SqlCommand cmd3 = new SqlCommand(sql3, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr3 = cmd3.ExecuteReader();
            if (dr3.Read())
            {
                pbxL4.BackColor = Color.Blue;
            }

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            string sql4 = "SELECT area FROM alocacao WHERE area=5";
            SqlCommand cmd4 = new SqlCommand(sql4, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr4 = cmd4.ExecuteReader();
            if (dr4.Read())
            {
                pbxL5.BackColor = Color.Blue;
            }

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            string sql5 = "SELECT area FROM alocacao WHERE area=6";
            SqlCommand cmd5 = new SqlCommand(sql5, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr5 = cmd5.ExecuteReader();
            if (dr5.Read())
            {
                pbxL6.BackColor = Color.Blue;
            }

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            string sql6 = "SELECT area FROM alocacao WHERE area=7";
            SqlCommand cmd6 = new SqlCommand(sql6, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr6 = cmd6.ExecuteReader();
            if (dr6.Read())
            {
                pbxL7.BackColor = Color.Blue;
            }

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            string sql7 = "SELECT area FROM alocacao WHERE area=8";
            SqlCommand cmd7 = new SqlCommand(sql7, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr7 = cmd7.ExecuteReader();
            if (dr7.Read())
            {
                pbxL8.BackColor = Color.Blue;
            }

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            string sql8 = "SELECT area FROM alocacao WHERE area=9";
            SqlCommand cmd8 = new SqlCommand(sql8, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr8 = cmd8.ExecuteReader();
            if (dr8.Read())
            {
                pbxL9.BackColor = Color.Blue;
            }

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            string sql9 = "SELECT area FROM alocacao WHERE area=10";
            SqlCommand cmd9 = new SqlCommand(sql9, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr9 = cmd9.ExecuteReader();
            if (dr9.Read())
            {
                pbxL10.BackColor = Color.Blue;
            }

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            string sql10 = "SELECT area FROM alocacao WHERE area=11";
            SqlCommand cmd10 = new SqlCommand(sql10, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr10 = cmd10.ExecuteReader();
            if (dr10.Read())
            {
                pbcL11.BackColor = Color.Blue;
            }
            con.Close();
        }

        private void pbxL1_Click(object sender, EventArgs e)
        {
            FormLOTE1 lote = new FormLOTE1();
            lote.Show();
        }

        private void pbxL2_Click(object sender, EventArgs e)
        {
            FormLOTE2 lote = new FormLOTE2();
            lote.Show();
        }

        private void pbxL4_Click(object sender, EventArgs e)
        {
            FormLOTE3 lote = new FormLOTE3();
            lote.Show();
        }

        private void pbxL7_Click(object sender, EventArgs e)
        {
            FormLOTE4 lote = new FormLOTE4();
            lote.Show();
        }

        private void pbxL8_Click(object sender, EventArgs e)
        {
            FormLOTE5 lote = new FormLOTE5();
            lote.Show();
        }

        private void pbxL9_Click(object sender, EventArgs e)
        {
            FormLOTE6 lote = new FormLOTE6();
            lote.Show();
        }

        private void pbxL10_Click(object sender, EventArgs e)
        {
            FormLOTE7 lote = new FormLOTE7();
            lote.Show();
        }
    }
}
