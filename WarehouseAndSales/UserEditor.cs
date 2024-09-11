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
    public partial class UserEditor : Form
    {
        public static int ID = 0;
        public UserEditor()
        {
            InitializeComponent();
            if (ID != 0)
            {

                foreach (DataRow dr in BAL.GetUserByID(ID).Rows)
                {
                    username.Text = dr["username"].ToString();
                    password.Text = dr["password"].ToString();
                    fullname.Text = dr["fullname"].ToString();


                }
                DelBtn.Visible = true;
            }
            else {

                username.Text = "";
                password.Text = "";
                fullname.Text = "";


            
            DelBtn.Visible = false;

        }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {

                BAL.UpdateUser(username.Text,password.Text,fullname.Text,ID);
            }
            else
            {

                 BAL.InsertUser(username.Text, password.Text, fullname.Text);


            }


            Users u = new Users();
            u.Show();
            this.Hide();
        }

        private void UserEditor_Load(object sender, EventArgs e)
        {

        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            BAL.DeleteUser(ID);
            Users u = new Users();
            u.Show();
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            Users u = new Users();
            u.Show();
            this.Hide();
        }
    }
}
