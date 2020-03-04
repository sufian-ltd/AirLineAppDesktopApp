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
    public partial class Update : Form
    {
        string[] a = new string[12];
        ViewSeat ob = new ViewSeat();
        public Update()
        {
            InitializeComponent();
        }
        private void canButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            /*mainMenu ma = new mainMenu();
            ma.Show();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
           /* mainMenu ma = new mainMenu();
            ma.Show();*/
        }

        private void fNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            Boolean isSeat = false;
            string s = seatBox.Text;
            if (s == "")
                MessageBox.Show("Please enter seat number");
            else
            {
                isSeat = ob.loadSeatPlan(s);
                if (isSeat)
                {
                    a[0] = fNameTextBox.Text;
                    a[1] = lNameTextBox.Text;
                    a[2] = emailTextBox.Text;
                    a[3] = phoneTextBox.Text;
                    a[4] = bloodTextBox.Text;
                    a[5] = nationTextBox.Text;
                    a[6] = passportTextBox.Text;
                    a[7] = ageTextBox.Text;
                    a[8] = idNoTextBox.Text;
                    a[9] = typeTextBox.Text;
                    //a[10] = destiTextBox.Text;
                    a[10] = dateBox.Text;
                    a[11] = seatBox.Text;
                    string connectionString = @"Server=localhost;port=3306;database=AirLine;userid=root;password=;";
                    MySqlConnection connection = new MySqlConnection(connectionString);
                    Boolean flag = false;
                    for (int i = 0; i < 12; i++)
                    {
                        if (a[i] != "")
                            flag = true;
                        else
                        {
                            flag = false;
                            break;
                        }
                    }
                    connection.Open();

                    if (flag)
                    {
                        string query = "update airtable set First_name='" + a[0] + "',Last_name='" + a[1] + "',Email='" + a[2] + "',Phone='" + a[3] + "',Blood_Group='" + a[4] + "',NID='" + a[5] + "',Passport_No='" + a[6] + "',Age='" + a[7] + "',Flight_Id='" + a[8] + "',Ticket_Type='" + a[9] + "',Date='" + a[10] + "' where Seat_number='" + a[11] + "'";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Successfully update information");
                        connection.Close();

                    }
                    else
                        MessageBox.Show("Please fill all information\nif you don't want to update this\nfill this box with previous information");
                }
                else
                {
                    MessageBox.Show("Sorry..!!\nYou Entered wrong seat number");
                }
            }
        }

        private void Update_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = seatBox.Text;
            Boolean isSeat = false;
            if (s == "")
            {
                MessageBox.Show("Please enter seat number");
            }
            else
            {
                isSeat = ob.loadSeatPlan(s);
                if (isSeat)
                {
                    string[] query = new string[11];
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
                    query[10] = "select Date from airtable where Seat_number='" + s + "'";
                    for (int j = 0; j < 11; j++)
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
                    dateBox.Text = a[10];
                    a[11] = s;
                }
                else
                {
                    MessageBox.Show("Sorry..!!\nYou Entered wrong seat number");
                }
            }
        }

        private void passportTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
