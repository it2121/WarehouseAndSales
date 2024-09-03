using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseAndSales
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
            DataTable dt = BAL.GetAllSales();
            SalesDG.DataSource = dt;


        }

        private void button1_Click(object sender, EventArgs e)
        {

            SalesEditor salesEditor = new SalesEditor();
            salesEditor.Show();
            this.Close();

        }
    }
}
