using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseAndSales
{
    public partial class PrinterNameSetting : Form
    {
        public PrinterNameSetting()
        {
            InitializeComponent();
            PrinterName.Text = File.ReadAllText("PrinterName.txt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("PrinterName.txt", PrinterName.Text);
            MessageBox.Show("تم ضبط اسم الطابعة بنجاح");
            Home HomeHome = new Home();
            HomeHome.Show();
            this.Hide();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            Home HomeHome = new Home();
            HomeHome.Show();
            this.Hide();
        }
    }
}
