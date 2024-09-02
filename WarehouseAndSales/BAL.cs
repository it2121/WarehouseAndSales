using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseAndSales
{
    internal class BAL
    {
        public static DataTable GetMatsOfAWarehouse(int WarehouseID)
        {
            SqlCommand cm;
            cm = DAL.CreateCommand();

            cm.CommandText = "GetMatsOfAWarehouse";
            cm.Parameters.AddWithValue("@WarehouseID", WarehouseID);
            SqlConnection.ClearAllPools();
            return DAL.ExecuteSelectCommand(cm);
        }
           public static DataTable LogIn(string username, string password)
        {
            SqlCommand cm;
            cm = DAL.CreateCommand();

            cm.CommandText = "LogIn";
            cm.Parameters.AddWithValue("@username", username);
            cm.Parameters.AddWithValue("@password", password);
            SqlConnection.ClearAllPools();
            return DAL.ExecuteSelectCommand(cm);
        }


        public static DataTable GetAllMats()
        {
            SqlCommand cm;
            cm = DAL.CreateCommand();

            cm.CommandText = "GetAllMats";


            SqlConnection.ClearAllPools();
            return DAL.ExecuteSelectCommand(cm);
        }  public static DataTable GetAllWarehouses()
        {
            SqlCommand cm;
            cm = DAL.CreateCommand();

            cm.CommandText = "GetAllWarehouses";


            SqlConnection.ClearAllPools();
            return DAL.ExecuteSelectCommand(cm);
        }



        public static bool InsertIntoMatToWarehouses(int MatID, int WarehouseID, int Quant, string MovingDate, string Notes, string MovingAction)
        {
            SqlCommand cm;
            cm = DAL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "InsertIntoMatToWarehouses";

            cm.Parameters.AddWithValue("@MatID", MatID);
            cm.Parameters.AddWithValue("@WarehouseID", WarehouseID);
            cm.Parameters.AddWithValue("@Quant", Quant);
            cm.Parameters.AddWithValue("@MovingDate", MovingDate);
            cm.Parameters.AddWithValue("@Notes", Notes);
            cm.Parameters.AddWithValue("@MovingAction", MovingAction);





            SqlConnection.ClearAllPools();
            return DAL.ExecuteCommand(cm);



        }    public static bool UpdateMatToWarehouses(int MatID, int WarehouseID, int Quant, string MovingDate, string Notes, string MovingAction,int ID)
        {
            SqlCommand cm;
            cm = DAL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "UpdateMatToWarehouses";

            cm.Parameters.AddWithValue("@MatID", MatID);
            cm.Parameters.AddWithValue("@WarehouseID", WarehouseID);
            cm.Parameters.AddWithValue("@Quant", Quant);
            cm.Parameters.AddWithValue("@MovingDate", MovingDate);
            cm.Parameters.AddWithValue("@Notes", Notes);
            cm.Parameters.AddWithValue("@MovingAction", MovingAction);
            cm.Parameters.AddWithValue("@ID", ID);





            SqlConnection.ClearAllPools();
            return DAL.ExecuteCommand(cm);



        }

    }
}
