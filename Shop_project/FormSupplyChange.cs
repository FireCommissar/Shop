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
    public partial class FormSupplyChange : Form
    {
        private NpgsqlConnection con;
        private string conString =
            "Host = 127.0.0.1; Username = postgres; Password = 123; Database = shop";
        public FormSupplyChange()
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
            dgvSupplyChange.DataSource = dt;

            dgvSupplyChange.Columns["id"].HeaderText = "ID поставки";
            dgvSupplyChange.Columns["name"].HeaderText = "Товар";
            dgvSupplyChange.Columns["name1"].HeaderText = "Поставщик";
            dgvSupplyChange.Columns["quantity"].HeaderText = "Количество";
            dgvSupplyChange.Columns["unit_type"].HeaderText = "Ед.измерения";
            dgvSupplyChange.Columns["price"].HeaderText = "Цена";
            dgvSupplyChange.Columns["delivery_date"].HeaderText = "Дата поставки";
            dgvSupplyChange.Columns["paid"].HeaderText = "Оплачен";
        }

        private void dgvSupplyChange_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbProduct.SelectedItem = dgvSupplyChange.SelectedRows[0].Cells[1].Value.ToString();
            cbProvider.SelectedItem = dgvSupplyChange.SelectedRows[0].Cells[2].Value.ToString();
            tbQuantity.Text = dgvSupplyChange.SelectedRows[0].Cells[3].Value.ToString();
            tbPrice.Text = dgvSupplyChange.SelectedRows[0].Cells[5].Value.ToString();
            dtpSupplyDate.Text = dgvSupplyChange.SelectedRows[0].Cells[6].Value.ToString();
            cbPaid.Checked = (bool)dgvSupplyChange.SelectedRows[0].Cells[7].Value;

            //this.dateTimePickerDate.Text = dataGridView1.SelectedCells[3].Value.ToString();
            // this.dateTimePickerDate.Text = dataGridView1.SelectedCells[3].Value.ToString();
        }

        private void btnChange_Click(object sender, EventArgs e)
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

            string sqlChange = "UPDATE supply SET product_id = @product_id, provider_id = @provider_id, quantity = @quantity, price = @price, delivery_date = @delivery_date, paid = @paid WHERE id = @id";
            NpgsqlCommand cmd3 = new NpgsqlCommand(sqlChange, con);
            cmd3.Parameters.AddWithValue("product_id", product_id);
            cmd3.Parameters.AddWithValue("provider_id", provider_id);
            cmd3.Parameters.AddWithValue("quantity", decimal.Parse(this.tbQuantity.Text));
            cmd3.Parameters.AddWithValue("price", decimal.Parse(this.tbPrice.Text));
            cmd3.Parameters.AddWithValue("delivery_date", this.dtpSupplyDate.Value);
            if (cbPaid.Checked)
                cmd3.Parameters.AddWithValue("paid", true);
            else cmd3.Parameters.AddWithValue("paid", false);
            int id = int.Parse(dgvSupplyChange.CurrentRow.Cells[0].Value.ToString());
            cmd3.Parameters.AddWithValue("id", id);
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
