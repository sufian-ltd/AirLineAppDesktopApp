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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            if (userBox.Text == "admin" && passBox.Text == "1234")
            {
                userBox.Text = null;
                passBox.Text = null;
                this.Hide();
                mainMenu menu = new mainMenu();
                menu.Show();
            }
            else
            {
                userBox.Text = null;
                passBox.Text = null;
                MessageBox.Show("You entered error information.....");
            }
        }
    }
}
