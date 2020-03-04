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
    
    public partial class ViewSeat : Form
    {
        GetTicket ob = new GetTicket();
        Button[] b = new Button[25];
        string[] a = new string[25];
        public ViewSeat()
        {
            InitializeComponent();
            addButton();
        }
        public void addButton()
        {
            b[0] = button1;
            b[1] = button2;
            b[2] = button3;
            b[3] = button4;
            b[4] = button5;
            b[5] = button6;
            b[6] = button7;
            b[7] = button8;
            b[8] = button9;
            b[9] = button10;
            b[10] = button11;
            b[11] = button12;
            b[12] = button13;
            b[13] = button14;
            b[14] = button15;
            b[15] = button16;
            b[16] = button17;
            b[17] = button18;
            b[18] = button19;
            b[19] = button20;
            b[20] = button21;
            b[21] = button22;
            b[22] = button23;
            b[23] = button24;
            b[24] = button25;
        }
        private void button36_Click(object sender, EventArgs e)
        {
            ob.getNumber(textBox1.Text);
            if (a.Contains(textBox1.Text))
            {
                MessageBox.Show("Sorry the seat is not available now....!!!\nTry again...............");
            }
            else
            {
                this.Hide();
                ob.Show();
            }
        }
        public void setEnable(Boolean flag)
        {
            if(flag)
            {
                textBox1.Hide();
                button36.Hide();
                label2.Hide();
            }
        }
        private void ViewSeat_Load(object sender, EventArgs e)
        {
            loadSeatPlan("");
            for(int j=0;j<25;j++)
            {
                if (a[j] != null)
                {
                    int temp =int.Parse(a[j]);
                    b[temp-1].BackColor = Color.Red;
                  
                }
            }
        }
        /*public Boolean isAvailable(string s)
        {
            Boolean haveSeat = false;
            for(int i=0;i<25;i++)
            {
                if (a[i]+""==s+"")
                {
                    haveSeat = true;
                    break;
                }
                   
                else
                    haveSeat = false;
            }
            return haveSeat;
        }*/
        public Boolean loadSeatPlan(string s)
        {
            string connectionString = @"Server=localhost;port=3306;database=AirLine;userid=root;password=;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = "select Seat_number from airtable";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = null;
            reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                a[i] = (string)reader[0];
                ++i;
            }
            connection.Close();
            if (a.Contains(s))
                return true;
            else
                return false;
        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }
    }
}
