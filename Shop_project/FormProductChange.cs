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
    public partial class FormProductChange : Form
    {
        private NpgsqlConnection con;
        private string conString =
            "Host = 127.0.0.1; Username = postgres; Password = 123; Database = shop";

        //private int Product_id;
        public FormProductChange()
        {
            InitializeComponent();
            con = new NpgsqlConnection(conString);
            con.Open();
            loadProducts();
        }

        private void loadProducts()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM product";

            using (NpgsqlDataAdapter adap = new NpgsqlDataAdapter(query, con))
            {
                adap.Fill(dt);
            }
            dgvProductChange.DataSource = dt;
        }

        private void dgvProductChange_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbProductName.Text = dgvProductChange.SelectedCells[1].Value.ToString();
            tbProductVendorCode.Text = dgvProductChange.CurrentRow.Cells[2].Value.ToString();
            tbProductUnitType.Text = dgvProductChange.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {

            string sql = "UPDATE Product SET name=@name, vendor_code=@vendor_code, unit_type=@unit_type WHERE id = @id";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("name", this.tbProductName.Text);
            cmd.Parameters.AddWithValue("vendor_code", this.tbProductVendorCode.Text);
            cmd.Parameters.AddWithValue("unit_type", this.tbProductUnitType.Text);
            int id = int.Parse(dgvProductChange.CurrentRow.Cells[0].Value.ToString());
            cmd.Parameters.AddWithValue("id", id);
            
            cmd.Prepare();

            cmd.ExecuteNonQuery();

            this.tbProductName.Text = "";
            this.tbProductVendorCode.Text = "";
            this.tbProductUnitType.Text = "";

            loadProducts();
        }
    }
}