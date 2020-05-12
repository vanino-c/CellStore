using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellStore
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            labelUser.Text = "Продавец: " + FormAuthorization.users.login;
            if (FormAuthorization.users.type == "Admin")
            {
                buttonSellers.Enabled = true;
            }
        }

        private void buttonSellers_Click(object sender, EventArgs e)
        {
            FormSellers sellers = new FormSellers();
            sellers.Show();
        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonDeals_Click(object sender, EventArgs e)
        {
            FormDeals formDeals = new FormDeals();
            formDeals.Show();
        }

        private void buttonProviders_Click(object sender, EventArgs e)
        {
            FormProviders formProviders = new FormProviders();
            formProviders.Show();
        }

        private void buttonPhones_Click(object sender, EventArgs e)
        {
            FormPhones formPhones = new FormPhones();
            formPhones.Show();
        }
    }
}
