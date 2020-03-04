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
    public partial class PassengerInformationWindow : Form
    {
        ViewSeat ob = new ViewSeat();
        public PassengerInformationWindow()
        {
            InitializeComponent();
        }

        private void canButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            /*mainMenu ob = new mainMenu();
            ob.Show();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            /*mainMenu ob = new mainMenu();
            ob.Show();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s =seatBox.Text;
            Boolean flag = false;
            if (s == "")
                MessageBox.Show("Please enter seat number");
            else
            {
                flag = ob.loadSeatPlan(s);
                if (flag)
                {
                    string[] query = new string[12];
                    query[0] = "select First_name from airtable where Seat_number='" + s + "'";
                    query[1] = "select Last_name from airtable where Seat_number='" + s + "'";
                    query[2] = "select Email from airtable where Seat_number='" + s + "'";
                    query[3] = "select Phone from airtable where Seat_number='" + s + "'";
                    query[4] = "select Blood_Group from airtable where Seat_number='" + s + "'";
                    query[5] = "select NID from airtable where Seat_number='" + s + "'";
                    query[6] = "select Passport_No from airtable where Seat_number='" + s + "'";
                    query[7] = "select Age from airtable where Seat_number='" + s + "'";
                    query[8] = "select Flight_Id from airtable where Seat_number='" + s + "'";
                    query[9] = "select Ticket_Type from airtable where Seat_number='" + s + "'";
                    query[10] = "select Destination from airtable where Seat_number='" + s + "'";
                    query[11] = "select Date from airtable where Seat_number='" + s + "'";
                    string[] a = new string[12];
                    for (int j = 0; j < 12; j++)
                    {
                        string connectionString = @"Server=localhost;port=3306;database=AirLine;userid=root;password=;";
                        MySqlConnection connection = new MySqlConnection(connectionString);
                        connection.Open();
                        MySqlCommand cmd = new MySqlCommand(query[j], connection);
                        MySqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            a[j] = (string)reader[0];
                        }
                        connection.Close();
                    }
                    fNameTextBox.Text = a[0];
                    lNameTextBox.Text = a[1];
                    emailTextBox.Text = a[2];
                    phoneTextBox.Text = a[3];
                    bloodTextBox.Text = a[4];
                    nationTextBox.Text = a[5];
                    passportTextBox.Text = a[6];
                    ageTextBox.Text = a[7];
                    idNoTextBox.Text = a[8];
                    typeTextBox.Text = a[9];
                    destiTextBox.Text = a[10];
                    dateBox.Text = a[11];
                }
                else
                {

                    MessageBox.Show("Sorry..!!\nYou Entered wrong seat number");
                }
            }
        }
        private void PassengerInformationWindow_Load(object sender, EventArgs e)
        {


        }
    }
}
