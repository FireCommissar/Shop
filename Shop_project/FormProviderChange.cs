using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_project
{
    public partial class FormProviderChange : Form
    {
        private NpgsqlConnection con;
        private string conString =
            "Host = 127.0.0.1; Username = postgres; Password = 123; Database = shop";

        //private int Provider_id;
        public FormProviderChange()
        {
            InitializeComponent();
            con = new NpgsqlConnection(conString);
            con.Open();
            loadProviders();
        }

        private void loadProviders()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM provider";

            using (NpgsqlDataAdapter adap = new NpgsqlDataAdapter(query, con))
            {
                adap.Fill(dt);
            }
            dgvProviderChange.DataSource = dt;
        }

        private void dgvProviderChange_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbProviderName.Text = dgvProviderChange.SelectedCells[1].Value.ToString();
            tbProviderAdress.Text = dgvProviderChange.CurrentRow.Cells[2].Value.ToString();
            tbProviderNumber.Text = dgvProviderChange.CurrentRow.Cells[3].Value.ToString();
            tbProviderPaymentDetails.Text = dgvProviderChange.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
           

            string sql = "UPDATE provider SET name = @name, adress = @adress, phone_number = @phone_number, payment_details = @payment_details  WHERE id = @id";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("name", this.tbProviderName.Text);
            cmd.Parameters.AddWithValue("adress", this.tbProviderAdress.Text);
            cmd.Parameters.AddWithValue("phone_number", this.tbProviderNumber.Text);
            cmd.Parameters.AddWithValue("payment_details", this.tbProviderPaymentDetails.Text);
            int id = int.Parse(dgvProviderChange.CurrentRow.Cells[0].Value.ToString());
            cmd.Parameters.AddWithValue("id", id);
            cmd.Prepare();

            cmd.ExecuteNonQuery();

            this.tbProviderName.Text = "";
            this.tbProviderAdress.Text = "";
            this.tbProviderNumber.Text = "";
            this.tbProviderPaymentDetails.Text = "";

            loadProviders();
        }
    }
}