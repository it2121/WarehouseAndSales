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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();

            usersDG.DataSource = BAL.GetAllUsers();
            usersDG.Columns["ID"].Visible = false;

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            Home home = new Home();
            home.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            UserEditor.ID = 0;
            UserEditor UserEditor2 = new UserEditor();
            UserEditor2.Show();
            this.Hide();
        }

        private void Return_Click(object sender, EventArgs e)
        {

            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void buyingDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewButtonCell btn = (DataGridViewButtonCell)usersDG.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (btn.Value.Equals("تعديل"))
            {



                int id = Convert.ToInt32(usersDG.Rows[e.RowIndex].Cells["ID"].Value.ToString());




                UserEditor.ID = id;
                UserEditor UserEditor2 = new UserEditor();
                UserEditor2.Show();
                this.Hide();
            }
            else if (btn.Value.Equals("الصلاحيات"))
            {



                int id = Convert.ToInt32(usersDG.Rows[e.RowIndex].Cells["ID"].Value.ToString());




                UserRolesEditorcs.UserID = id;
                UserRolesEditorcs UserRolesEditor2 = new UserRolesEditorcs();
                UserRolesEditor2.Show();
                this.Hide();
            }
        }

        private void Users_Load(object sender, EventArgs e)
        {

        }
    }
}
