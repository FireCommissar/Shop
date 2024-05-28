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
using Npgsql;
using Excel = Microsoft.Office.Interop.Excel;
using System.Security.Cryptography;

namespace Shop_project
{
    public partial class MainForm : Form
    {
        private NpgsqlConnection con;
        private string conString =
            "Host = 127.0.0.1; Username = postgres; Password = 123; Database = shop";
        public MainForm()
        {
            InitializeComponent();
            con = new NpgsqlConnection(conString);
            con.Open();
            loadProducts();
            loadProviders();
            loadSupplies();

            string sqlProviders = "SELECT name FROM provider";
            NpgsqlCommand cmd = new NpgsqlCommand(sqlProviders, con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            cbProviderPick.Items.Clear();
            while (reader.Read())
            {
                cbProviderPick.Items.Add(reader.GetString(0));
            }
            reader.Close();

            string sqlProducts = "SELECT name FROM product";
            NpgsqlCommand cmd2 = new NpgsqlCommand(sqlProducts, con);
            NpgsqlDataReader reader2 = cmd2.ExecuteReader();
            checkedListBox1.Items.Clear();
            while (reader2.Read())
            {
                checkedListBox1.Items.Add(reader2.GetString(0));
            }
            reader2.Close();
        }
        private void loadProducts()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM product";

            using (NpgsqlDataAdapter adap = new NpgsqlDataAdapter(query, con))
            {
                adap.Fill(dt);
            }
            dgvProducts.DataSource = dt;
        }
        private void loadProviders()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM provider";

            using (NpgsqlDataAdapter adap = new NpgsqlDataAdapter(query, con))
            {
                adap.Fill(dt);
            }
            dgvProviders.DataSource = dt;
        }
        private void loadSupplies()
        {
            //DataTable dt = new DataTable();
            //string query = "SELECT * FROM supply";

            //using (NpgsqlDataAdapter adap = new NpgsqlDataAdapter(query, con))
            //{
            //    adap.Fill(dt);
            //}
            //dgvSupply.DataSource = dt;

            DataTable dt = new DataTable();
            string sqlQuery = "SELECT supply.id, product.name, provider.name, supply.quantity,product.unit_type, supply.price, supply.delivery_date, supply.paid " +
                              "FROM supply " +
                              "INNER JOIN product ON supply.product_id = product.id "+ "INNER JOIN provider ON supply.provider_id = provider.id";
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter(sqlQuery, con);
            adap.Fill(dt);
            dgvSupply.DataSource = dt;

            dgvSupply.Columns["id"].HeaderText = "ID поставки";
            dgvSupply.Columns["name"].HeaderText = "Товар";
            dgvSupply.Columns["name1"].HeaderText = "Поставщик";
            dgvSupply.Columns["quantity"].HeaderText = "Количество";
            dgvSupply.Columns["unit_type"].HeaderText = "Ед.измерения";
            dgvSupply.Columns["price"].HeaderText = "Цена";
            dgvSupply.Columns["delivery_date"].HeaderText = "Дата поставки";
            dgvSupply.Columns["paid"].HeaderText = "Оплачен";
        }


        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FormProductAdd p = new FormProductAdd();
            p.ShowDialog();
            loadProducts();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            string sql = $"DELETE FROM product WHERE id=(@id)";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            int id = int.Parse(dgvProducts.CurrentRow.Cells[0].Value.ToString());
            cmd.Parameters.AddWithValue("id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            loadProducts();
        }

        private void btnChangeProduct_Click(object sender, EventArgs e)
        {
            FormProductChange p = new FormProductChange();
            p.ShowDialog();
            loadProducts();
        }
        //provider
        private void btnAddProvider_Click(object sender, EventArgs e)
        {
            FormProviderAdd p = new FormProviderAdd();
            p.ShowDialog();
            loadProviders();
        }

        private void btnDeleteProvider_Click(object sender, EventArgs e)
        {
            string sql = $"DELETE FROM provider WHERE id=(@id)";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            int id = int.Parse(dgvProviders.CurrentRow.Cells[0].Value.ToString());
            cmd.Parameters.AddWithValue("id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            loadProviders();
        }

        private void btnChangeProvider_Click(object sender, EventArgs e)
        {
            FormProviderChange p = new FormProviderChange();
            p.ShowDialog();
            loadProviders();
        }
        //supply
        private void btnAddSupply_Click(object sender, EventArgs e)
        {
            FormSupplyAdd p = new FormSupplyAdd();
            p.ShowDialog();
            loadSupplies();
        }

        private void btnChangeSupply_Click(object sender, EventArgs e)
        {
            FormSupplyChange p = new FormSupplyChange();
            p.ShowDialog();
            loadSupplies();
        }

        private void btnDeleteSupply_Click(object sender, EventArgs e)
        {
            string sql = $"DELETE FROM supply WHERE id=(@id)";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            int id = int.Parse(dgvSupply.CurrentRow.Cells[0].Value.ToString());
            cmd.Parameters.AddWithValue("id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            loadSupplies();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            //Excel.Application excelApp = new Excel.Application();
            //Excel.Workbook excelWorkbook = excelApp.Workbooks.Add();
            //Excel.Worksheet excelWorksheet = excelWorkbook.Sheets[1];
            //excelWorksheet.Cells[1, 1] = dgvSupply.SelectedRows[0].Cells[0].Value;
            //excelWorksheet.Cells[1,2] = dgvSupply.SelectedRows[0].Cells[0].Value;

            //excelWorkbook.SaveAs("marker.xlsx");
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook excelWorkbook = excelApp.Workbooks.Open("D:\\Третий курс\\РПВиС\\Shop_project\\Shop_project\\bin\\invoice.xlsx");
            Excel.Worksheet excelWorksheet = excelWorkbook.Sheets[1];
            excelWorksheet.Cells[2, 2] = dgvSupply.SelectedRows[0].Cells[2].Value;
            excelWorksheet.Cells[1, 6] = dgvSupply.SelectedRows[0].Cells[6].Value;
            excelWorksheet.Cells[5, 1] = dgvSupply.SelectedRows[0].Cells[1].Value;
            excelWorksheet.Cells[5, 2] = dgvSupply.SelectedRows[0].Cells[3].Value;
            excelWorksheet.Cells[5, 3] = dgvSupply.SelectedRows[0].Cells[4].Value;
            excelWorksheet.Cells[5, 4] = dgvSupply.SelectedRows[0].Cells[5].Value;

            excelApp.Visible = true;
        }

        private void btnProviderForm_Click(object sender, EventArgs e)
        {
            string sqlProvider = "SELECT id, name FROM provider";
            NpgsqlCommand cmd2 = new NpgsqlCommand(sqlProvider, con);
            NpgsqlDataReader reader2 = cmd2.ExecuteReader();
            int provider_id = 0;
            while (reader2.Read())
            {
                //comboBoxTour.Items.Add(reader.GetString(0));
                if (cbProviderPick.SelectedItem.ToString() == reader2.GetString(1))
                {
                    provider_id = Convert.ToInt32(reader2.GetValue(0));
                }
            }
            reader2.Close();

            string sql = "SELECT price, paid FROM supply WHERE provider_id=@provider_id AND delivery_date BETWEEN @first_date AND @second_date";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("provider_id", provider_id);
            cmd.Parameters.AddWithValue("first_date", this.providerChartFirstDate.Value);
            cmd.Parameters.AddWithValue("second_date", this.providerChartSecondDate.Value);
            NpgsqlDataReader reader3 = cmd.ExecuteReader();
            int total_price = 0;
            int total_paid_price = 0;
            while (reader3.Read())
            {
                total_price+= Convert.ToInt32(reader2.GetValue(0));
                if ((bool)reader3.GetValue(1))
                    total_paid_price+= Convert.ToInt32(reader2.GetValue(0));
            }
            reader3.Close();
            providerChart.Series[0].Points.Clear();
            providerChart.Series[1].Points.Clear();
            providerChart.Series[0].Points.AddXY(1,total_price);
            providerChart.Series[1].Points.AddXY(1, total_paid_price);

        }

        private void btnProductForm_Click(object sender, EventArgs e)
        {
            productChart.Series[0].Points.Clear();
            int counter = 0;
            for (int i=0; i<checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    string sqlProduct = "SELECT id, name FROM product";
                    NpgsqlCommand cmd2 = new NpgsqlCommand(sqlProduct, con);
                    NpgsqlDataReader reader2 = cmd2.ExecuteReader();
                    int product_id = 0;

                    while (reader2.Read())
                    {
                        //comboBoxTour.Items.Add(reader.GetString(0));
                        if (checkedListBox1.Items[i].ToString() == reader2.GetString(1))
                        {
                            product_id = Convert.ToInt32(reader2.GetValue(0));
                            
                        }
                    }
                    reader2.Close();

                    string sql = "SELECT price, paid FROM supply WHERE product_id=@product_id";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("product_id", product_id);
                    NpgsqlDataReader reader3 = cmd.ExecuteReader();
                    int price_for_paid = 0;
                    
                    while (reader3.Read())
                    {
                        
                        if ((bool)reader3.GetValue(1)==false)
                            price_for_paid += Convert.ToInt32(reader2.GetValue(0));
                    }
                    reader3.Close();
                    //productChart.Series[counter].Points.Clear();
                    productChart.Series[0].Points.AddXY(checkedListBox1.Items[i].ToString(), price_for_paid);

                }
            }
        }
    }
}
