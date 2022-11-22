﻿using System;
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
    public partial class FormLOTE7 : Form
    {
        SqlConnection con = ClassConecta.ObterConexao();
        public FormLOTE7()
        {
            InitializeComponent();
        }

        private void FormLOTE7_Load(object sender, EventArgs e)
        {
            Lote7 lo = new Lote7();
            List<Lote7> lotes = lo.listalote();
            dgvLote1.DataSource = lotes;
        }

        private void dgvLote1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvLote1.Rows[e.RowIndex];
                lblId.Text = row.Cells[0].Value.ToString().Trim();
                txtModelo.Text = row.Cells[1].Value.ToString().Trim();
                txtPreco.Text = row.Cells[2].Value.ToString().Trim();
                lblQtde.Text = row.Cells[3].Value.ToString().Trim();
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            int id, qtde;
            id = Convert.ToInt32(lblId.Text);
            qtde = Convert.ToInt32(lblQtde.Text);

            int quantidade = qtde - 1;

            SqlCommand cmd = new SqlCommand("Vender", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.AddWithValue("@quantidade", SqlDbType.Int).Value = quantidade;
            cmd.ExecuteNonQuery();
            con.Close();
            Lote7 lo = new Lote7();
            List<Lote7> lotes = lo.listalote();
            dgvLote1.DataSource = lotes;
            MessageBox.Show("Vendido com sucesso!", "Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
