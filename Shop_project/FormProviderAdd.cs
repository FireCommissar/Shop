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
    public partial class FormProviderAdd : Form
    {

        private NpgsqlConnection con;
        private string conString =
            "Host = 127.0.0.1; Username = postgres; Password = 123; Database = shop";
        public FormProviderAdd()
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
            dgvProviderAdd.DataSource = dt;
        }

        private void FormProviderAdd_Load(object sender, EventArgs e)
        {

        }

        //private void tblastname_Click(object sender, EventArgs e)
        //{
        //    tbLastname.Clear();
        //}

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO provider(name, adress, phone_number, payment_details) VALUES (@name, @adress, @phone_number, @payment_details)";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("name", this.tbProviderName.Text);
            cmd.Parameters.AddWithValue("adress", this.tbProviderAdress.Text);
            cmd.Parameters.AddWithValue("phone_number", this.tbProviderNumber.Text);
            cmd.Parameters.AddWithValue("payment_details", this.tbProviderPaymentDetails.Text);
            cmd.Prepare();

            cmd.ExecuteNonQuery();

            this.tbProviderName.Text = "";
            this.tbProviderAdress.Text = "";
            this.tbProviderNumber.Text = "";
            this.tbProviderPaymentDetails.Text = "";

            loadProviders();


        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}