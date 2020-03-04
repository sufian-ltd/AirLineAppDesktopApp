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
    public partial class GetTicket : Form
    {
        public GetTicket()
        {
            InitializeComponent();
        }
        private void clickTicketButton_Click_1(object sender, EventArgs e)
        {
            String[] a = new String[14];
            
            /*String fn = fNameTextBox.Text;
            string ln = lNameTextBox.Text;
            string mail = emailTextBox.Text;
            string pho = phoneTextBox.Text;
            string blg = bloodTextBox.Text;
            string nid = nationTextBox.Text;
            string pass = passportTextBox.Text;
            string age = ageTextBox.Text;
            string flid = idNoTextBox.Text;
            string seat = seatTextBox.Text;
            string type = typeTextBox.Text;
            string dest = destiTextBox.Text;
            string price = totalPriceTextBox.Text;
            string date = dateBox.Text;*/
            a[0] = fNameTextBox.Text;
            a[1] = lNameTextBox.Text;
            a[2] = emailTextBox.Text;
            a[3] = phoneTextBox.Text;
            a[4] = bloodTextBox.Text;
            a[5]= nationTextBox.Text;
            a[6]= passportTextBox.Text;
            a[7]= ageTextBox.Text;
            a[8]= idNoTextBox.Text;
            a[9]= seatTextBox.Text;
            a[10]= typeTextBox.Text;
            a[11]= destiTextBox.Text;
            //a[12]= totalPriceTextBox.Text;
            a[13]= dateBox.Text;
            Boolean flag = false;
            Random r = new Random();
            long pr=10+r.Next(55555);
            a[12] = pr + " $";
            
            string connectionString = @"Server=localhost;port=3306;database=AirLine;userid=root;password=;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            for (int i = 0; i < 14; i++)
            {
                if (a[i] != "")
                    flag = true;
                else
                {
                    flag = false;
                    break;
                }
            }
            if(flag==true)
            {
                totalPriceTextBox.Text = a[12];
                //string query = "insert into airtable values('" + fn + "','" + ln + "','" + mail + "','" + pho + "','" + blg + "','" + nid + "','" + pass + "','" + age + "','" + flid + "','" + seat + "','" + type + "','" + dest + "','" + price + "','" + date + "')";
                string query = "insert into airtable values('" + a[0] + "','" + a[1] + "','" + a[2] + "','" + a[3] + "','" + a[4] + "','" + a[5] + "','" + a[6] + "','" + a[7] + "','" + a[8] + "','" + a[9] + "','" + a[10] + "','" + a[11] + "','" + a[12] + "','" + a[13] + "')";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Ticket Processing complete");
                this.Hide();
            }
            else
                MessageBox.Show("Please fill all...");
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void destiComboBox_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            destiTextBox.Text = destiComboBox.SelectedItem.ToString();
        }

        private void returnRadioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            typeTextBox.Text = "Return";
        }
        public void getNumber(string a)
        {
           seatTextBox.Text = a;
        }

        private void GetTicket_Load(object sender, EventArgs e)
        {

        }

  

        private void ageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }



        private void label8_Click(object sender, EventArgs e)
        {

        }
  

        private void singleRadioButton_CheckedChanged_2(object sender, EventArgs e)
        {
            typeTextBox.Text = "Single";
        }
    }
}
