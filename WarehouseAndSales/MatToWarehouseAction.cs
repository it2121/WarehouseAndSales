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
    public partial class MatToWarehouseAction : Form
    {
        public static int WarehouseID = 0;
        public static int fromWarehouseID = 0;
        public static int MatID = 0;
        public static int RecordID = 0;
        public static string Action = "";
        public static bool Edit = false;
        public MatToWarehouseAction()
        {
            InitializeComponent();

            if (Edit)
            {


                DataTable dt = BAL.GetAllMatToWarehouseRecordByID(RecordID);
                foreach (DataRow dr in dt.Rows)
                {
                    ActionList.SelectedItem = dr["MovingAction"].ToString();
                    Quant.Text = dr["Quant"].ToString();
                    MovingDate.Text = dr["MovingDate"].ToString();
                    Notes.Text = dr["Notes"].ToString();


                }
            }
            else
            {
                ActionList.SelectedItem = Action;
                //   ActionList.Text = Action;
            }


            if (Action.Equals("سحب من مخزن اخر"))
            {


                ActionList.Enabled = false;

                // ActionList.Text =  toWarehouseName + "  سحبت هذه المادة الى المخزن المعنون";



            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Edit)
            {

                if (Action.Equals("سحب") || Action.Equals("ايداع") || Action.Equals("تالف"))
                {
                    BAL.InsertIntoMatToWarehouses(MatID, WarehouseID, Convert.ToInt32(Quant.Text), MovingDate.Text, Notes.Text, ActionList.Text);



                }
                else if (Action.Equals("سحب من مخزن اخر"))
                {
                    string fromWarehouseName = BAL.GetWarehouseName(fromWarehouseID).Rows[0][0].ToString();
                    string toWarehouseName = BAL.GetWarehouseName(WarehouseID).Rows[0][0].ToString();
                    //سحب من مخزن الى مخزن جديد
                    BAL.InsertIntoMatToWarehouses(MatID, fromWarehouseID, Convert.ToInt32(Quant.Text), MovingDate.Text, Notes.Text + " (" + toWarehouseName + ")  سحبت الى", "نقل - سحب");
                    // ايداع الى الخزن الجديد
                    BAL.InsertIntoMatToWarehouses(MatID, WarehouseID, Convert.ToInt32(Quant.Text), MovingDate.Text, Notes.Text + " (" + fromWarehouseName + ")  سحب من", "نقل - ايداع");







                }

            }
            else
            {

                BAL.UpdateMatToWarehouses(MatID, WarehouseID, Convert.ToInt32(Quant.Text), MovingDate.Text, Notes.Text, ActionList.Text, RecordID);


            }
            Edit = false;
            WarehouseMats.WarehouseID = WarehouseID;
            WarehouseMats warehouseMats = new WarehouseMats();
            warehouseMats.Show();
            this.Hide();
        }

        private void ActionList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            Edit = false;
            WarehouseMats.WarehouseID = WarehouseID;
            WarehouseMats warehouseMats = new WarehouseMats();
            warehouseMats.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BAL.DeleteMatToWarehouses(RecordID);


            Edit = false;
            WarehouseMats.WarehouseID = WarehouseID;
            WarehouseMats warehouseMats = new WarehouseMats();
            warehouseMats.Show();
            this.Hide();
        }
    }
}
