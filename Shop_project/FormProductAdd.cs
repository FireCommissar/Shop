using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//ФОРМА ДЛЯ КНОПКИ ДОБАВИТЬ ТУРИСТА + ИНФОО С ГЛАВНОЙ ФОРМЫ

namespace Shop_project
{
    public partial class FormProductAdd : Form
    {

        private NpgsqlConnection con;
        private string conString =
            "Host = 127.0.0.1; Username = postgres; Password = 123; Database = shop";
        public FormProductAdd()
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
            dgvProductAdd.DataSource = dt;
        }

        private void FormProductAdd_Load(object sender, EventArgs e)
        {

        }

        //private void tblastname_Click(object sender, EventArgs e)
        //{
        //    tbLastname.Clear();
        //}

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO product(name, vendor_code, unit_type) VALUES (@name, @vendor_code, @unit_type)";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("name", this.tbProductName.Text);
            cmd.Parameters.AddWithValue("vendor_code", this.tbProductVendorCode.Text);
            cmd.Parameters.AddWithValue("unit_type", this.tbProductUnitType.Text);
            cmd.Prepare();

            cmd.ExecuteNonQuery();

            this.tbProductName.Text = "";
            this.tbProductVendorCode.Text = "";
            this.tbProductUnitType.Text = "";

            loadProducts();


        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}