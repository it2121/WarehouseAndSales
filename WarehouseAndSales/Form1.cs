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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            DataTable dt =  BAL.LogIn(username.Text, password.Text);
            if (dt.Rows.Count > 0)
            {
                Global.setUserID(Convert.ToInt32(dt.Rows[0]["ID"].ToString()));
                Global.setfullname(dt.Rows[0]["fullname"].ToString());
                Global.setUserRoles(BAL.GetUserRolesByUserID(Convert.ToInt32(dt.Rows[0]["ID"].ToString())));
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("الرجاء التاكد من صحة المعلومات المدخلة.");


            }


        }
    }
}
