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
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

    

        private void ticketButton_Click(object sender, EventArgs e)
        {
            ViewSeat ob = new ViewSeat();
            ob.Show();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            PassengerInformationWindow ob = new PassengerInformationWindow();
            ob.Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            CancelWindow ob = new CancelWindow();
            ob.Show();
        }

        private void updateButton1_Click(object sender, EventArgs e)
        {
            Update ob = new AirLineApp.Update();
            ob.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewSeatButton_Click(object sender, EventArgs e)
        {
            ViewSeat ob = new ViewSeat();
            ob.setEnable(true);
            ob.Show();
        }
    }
}
