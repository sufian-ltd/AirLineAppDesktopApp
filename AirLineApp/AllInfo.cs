using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirLineApp
{
    public partial class AllInfo : Form
    {
        public AllInfo()
        {
            InitializeComponent();
        }

        private void AllInfo_Load(object sender, EventArgs e)
        {
            string connectionString = @"Server=localhost;port=3306;database=airline;userid=root;password=;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = "select * from airtable";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = command;
            DataTable table = new DataTable();
            sda.Fill(table);
            BindingSource bind = new BindingSource();
            bind.DataSource = table;
            dataGridView1.DataSource = bind;
            sda.Update(table);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
