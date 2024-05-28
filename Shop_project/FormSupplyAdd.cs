using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_project
{
    public partial class FormSupplyAdd : Form
    {

        private NpgsqlConnection con;
        private string conString =
            "Host = 127.0.0.1; Username = postgres; Password = 123; Database = shop";
        public FormSupplyAdd()
        {
            InitializeComponent();
            con = new NpgsqlConnection(conString);
            con.Open();
            loadSupplies();

            string sqlProviders = "SELECT name FROM provider";
            NpgsqlCommand cmd = new NpgsqlCommand(sqlProviders, con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            cbProvider.Items.Clear();
            while (reader.Read())
            {
                cbProvider.Items.Add(reader.GetString(0));
            }
            reader.Close();

            string sqlProduct = "SELECT name FROM product";
            NpgsqlCommand cmd2 = new NpgsqlCommand(sqlProduct, con);
            NpgsqlDataReader reader2 = cmd2.ExecuteReader();
            cbProduct.Items.Clear();
            while (reader2.Read())
            {
                cbProduct.Items.Add(reader2.GetString(0));
            }
            reader2.Close();
        }

        private void loadSupplies()
        {
            DataTable dt = new DataTable();
            string sqlQuery = "SELECT supply.id, product.name, provider.name, supply.quantity,product.unit_type, supply.price, supply.delivery_date, supply.paid " +
                              "FROM supply " +
                              "INNER JOIN product ON supply.product_id = product.id " + "INNER JOIN provider ON supply.provider_id = provider.id";
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter(sqlQuery, con);
            adap.Fill(dt);
            dgvSupplyAdd.DataSource = dt;

            dgvSupplyAdd.Columns["id"].HeaderText = "ID поставки";
            dgvSupplyAdd.Columns["name"].HeaderText = "Товар";
            dgvSupplyAdd.Columns["name1"].HeaderText = "Поставщик";
            dgvSupplyAdd.Columns["quantity"].HeaderText = "Количество";
            dgvSupplyAdd.Columns["unit_type"].HeaderText = "Ед.измерения";
            dgvSupplyAdd.Columns["price"].HeaderText = "Цена";
            dgvSupplyAdd.Columns["delivery_date"].HeaderText = "Дата поставки";
            dgvSupplyAdd.Columns["paid"].HeaderText = "Оплачен";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sqlProduct = "SELECT id, name FROM product";
            NpgsqlCommand cmd = new NpgsqlCommand(sqlProduct, con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            int product_id = 0;
            while (reader.Read())
            {
                //comboBoxTour.Items.Add(reader.GetString(0));
                if (cbProduct.SelectedItem.ToString() == reader.GetString(1))
                {
                    product_id = Convert.ToInt32(reader.GetValue(0));
                }
            }
            reader.Close();

            string sqlProvider = "SELECT id, name FROM provider";
            NpgsqlCommand cmd2 = new NpgsqlCommand(sqlProvider, con);
            NpgsqlDataReader reader2 = cmd2.ExecuteReader();
            int provider_id = 0;
            while (reader2.Read())
            {
                //comboBoxTour.Items.Add(reader.GetString(0));
                if (cbProvider.SelectedItem.ToString() == reader2.GetString(1))
                {
                    provider_id = Convert.ToInt32(reader2.GetValue(0));
                }
            }
            reader2.Close();

            string sqlAdd = "INSERT INTO supply(product_id, provider_id, quantity, price, delivery_date,paid) VALUES(@product_id, @provider_id, @quantity, @price, @delivery_date,@paid)";
            NpgsqlCommand cmd3 = new NpgsqlCommand(sqlAdd, con);
            cmd3.Parameters.AddWithValue("product_id", product_id);
            cmd3.Parameters.AddWithValue("provider_id", provider_id);
            cmd3.Parameters.AddWithValue("quantity", decimal.Parse(this.tbQuantity.Text));
            cmd3.Parameters.AddWithValue("price", decimal.Parse(this.tbPrice.Text));
            cmd3.Parameters.AddWithValue("delivery_date", this.dtpSupplyDate.Value);
            if (cbPaid.Checked)
                cmd3.Parameters.AddWithValue("paid", true);
            else cmd3.Parameters.AddWithValue("paid", false);
            cmd3.Prepare();
            cmd3.ExecuteNonQuery();
            loadSupplies();

            this.cbProvider.Text = "";
            this.cbProduct.Text = "";
            this.dtpSupplyDate.Text = "";
            this.tbPrice.Text = "";
            this.tbQuantity.Text = "";
            cbPaid.Checked = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
