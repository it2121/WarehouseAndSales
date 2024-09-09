using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseAndSales
{
    // blue #0d5dba
    // dark #262e36
    // green #56c077
    // gray #e6e9f0
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Warehouses warehouses = new Warehouses();   
            warehouses.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mats mats = new Mats();
            mats.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
            this.Hide();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            Environment.Exit(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProvidersAndCustomers.ProviderOrCustomer = "provider";
            ProvidersAndCustomers providersAndCustomers = new ProvidersAndCustomers();
            providersAndCustomers.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProvidersAndCustomers.ProviderOrCustomer = "customer";
            ProvidersAndCustomers providersAndCustomers = new ProvidersAndCustomers();
            providersAndCustomers.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Buying b = new Buying();
            b.Show();
            this.Hide();
        }
    }
}
