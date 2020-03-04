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
    public partial class CancelWindow : Form
    {
        ViewSeat ob = new ViewSeat();
        public CancelWindow()
        {
            InitializeComponent();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            string num = cancelTextBox.Text;
            string connectionString = @"Server=localhost;port=3306;database=AirLine;userid=root;password=;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            if (num != "" && ob.loadSeatPlan(num))
            {
                connection.Open();
                string query = "delete from airtable where Seat_number='" + num + "'";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Flight canceled...........");
                this.Hide();
                connection.Close();
            }
            else
                MessageBox.Show("Please enter a valid seat number....");
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
