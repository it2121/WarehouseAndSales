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
        public static DataTable GetLatBuyingID()
        {
            SqlCommand cm;
            cm = DAL.CreateCommand();

            cm.CommandText = "GetLatBuyingID";
            SqlConnection.ClearAllPools();
            return DAL.ExecuteSelectCommand(cm);
        } public static DataTable GetAllBuying()
        {
            SqlCommand cm;
            cm = DAL.CreateCommand();

            cm.CommandText = "GetAllBuying";
            SqlConnection.ClearAllPools();
            return DAL.ExecuteSelectCommand(cm);
        }   public static DataTable GetAllItemsWithInStock()
        {
            SqlCommand cm;
            cm = DAL.CreateCommand();

            cm.CommandText = "GetAllItemsWithInStock";
            SqlConnection.ClearAllPools();
            return DAL.ExecuteSelectCommand(cm);
        }
        public static DataTable GetBuyingByID(int ID)
        {
            SqlCommand cm;
            cm = DAL.CreateCommand();

            cm.CommandText = "GetBuyingByID";
            cm.Parameters.AddWithValue("@ID", ID);
            SqlConnection.ClearAllPools();
            return DAL.ExecuteSelectCommand(cm);
        }   public static DataTable GetSalesRecordByID(int ID)
        {
            SqlCommand cm;
            cm = DAL.CreateCommand();

            cm.CommandText = "GetSalesRecordByID";
            cm.Parameters.AddWithValue("@ID", ID);
            SqlConnection.ClearAllPools();
            return DAL.ExecuteSelectCommand(cm);
        }
        public static DataTable GetAllMatToWarehouseRecordByID(int ID)
        {
            SqlCommand cm;
            cm = DAL.CreateCommand();

            cm.CommandText = "GetAllMatToWarehouseRecordByID";
            cm.Parameters.AddWithValue("@ID", ID);
            SqlConnection.ClearAllPools();
            return DAL.ExecuteSelectCommand(cm);
        }
        public static DataTable GetAllMatToWarehouseRecords(int WarehouseID)
        {
            SqlCommand cm;
            cm = DAL.CreateCommand();

            cm.CommandText = "GetAllMatToWarehouseRecords";
            cm.Parameters.AddWithValue("@WarehouseID", WarehouseID);
            SqlConnection.ClearAllPools();
            return DAL.ExecuteSelectCommand(cm);
        }
        public static DataTable GetAllInStockOfAMat(int MatID)
        {
            SqlCommand cm;
            cm = DAL.CreateCommand();

            cm.CommandText = "GetAllInStockOfAMat";
            cm.Parameters.AddWithValue("@MatID", MatID);
            SqlConnection.ClearAllPools();
            return DAL.ExecuteSelectCommand(cm);
        }
        public static DataTable GetMatByID(int MatID)
        {
            SqlCommand cm;
            cm = DAL.CreateCommand();

            cm.CommandText = "GetMatByID";
            cm.Parameters.AddWithValue("@MatID", MatID);
            SqlConnection.ClearAllPools();
            return DAL.ExecuteSelectCommand(cm);
        }
        public static DataTable GetWarehouseName(int WarehouseID)
        {
            SqlCommand cm;
            cm = DAL.CreateCommand();

            cm.CommandText = "GetWarehouseName";
            cm.Parameters.AddWithValue("@WarehouseID", WarehouseID);
            SqlConnection.ClearAllPools();
            return DAL.ExecuteSelectCommand(cm);
        }


        public static DataTable GetAllRemMatsOfAWarehouse(int WarehouseID)
        {
            SqlCommand cm;
            cm = DAL.CreateCommand();

            cm.CommandText = "GetAllRemMatsOfAWarehouse";
            cm.Parameters.AddWithValue("@WarehouseID", WarehouseID);
            SqlConnection.ClearAllPools();
            return DAL.ExecuteSelectCommand(cm);
        }


        public static DataTable GetMatsOfAWarehouse(int WarehouseID)
        {
            SqlCommand cm;
            cm = DAL.CreateCommand();

            cm.CommandText = "GetMatsOfAWarehouse";
            cm.Parameters.AddWithValue("@WarehouseID", WarehouseID);
            SqlConnection.ClearAllPools();
            return DAL.ExecuteSelectCommand(cm);
        }



        public static DataTable GetDeposetedMatSumByID(int MatID)
        {
            SqlCommand cm;
            cm = DAL.CreateCommand();

            cm.CommandText = "GetDeposetedMatSumByID";
            cm.Parameters.AddWithValue("@MatID", MatID);
            SqlConnection.ClearAllPools();
            return DAL.ExecuteSelectCommand(cm);
        }


        public static DataTable GetAllCustomers()
        {
            SqlCommand cm;
            cm = DAL.CreateCommand();

            cm.CommandText = "GetAllCustomers";
            SqlConnection.ClearAllPools();
            return DAL.ExecuteSelectCommand(cm);
        }
        public static DataTable GetAllProviders()
        {
            SqlCommand cm;
            cm = DAL.CreateCommand();

            cm.CommandText = "GetAllProviders";
            SqlConnection.ClearAllPools();
            return DAL.ExecuteSelectCommand(cm);
        }
        public static DataTable GetProviderOrCustomerByID(int ID)
        {
            SqlCommand cm;
            cm = DAL.CreateCommand();

            cm.CommandText = "GetProviderOrCustomerByID";
            cm.Parameters.AddWithValue("@ID", ID);
            SqlConnection.ClearAllPools();
            return DAL.ExecuteSelectCommand(cm);
        }
        public static DataTable GetWarehouseByID(int ID)
        {
            SqlCommand cm;
            cm = DAL.CreateCommand();

            cm.CommandText = "GetWarehouseByID";
            cm.Parameters.AddWithValue("@ID", ID);
            SqlConnection.ClearAllPools();
            return DAL.ExecuteSelectCommand(cm);
        }


        public static DataTable GetInstockItemsOfAllWarehousesAndOneMat(int MatID)
        {
            SqlCommand cm;
            cm = DAL.CreateCommand();

            cm.CommandText = "GetInstockItemsOfAllWarehousesAndOneMat";
            cm.Parameters.AddWithValue("@MatID", MatID);
            SqlConnection.ClearAllPools();
            return DAL.ExecuteSelectCommand(cm);
        }
        public static DataTable GetAllWarehousesThatContainsAMat(int MatID)
        {
            SqlCommand cm;
            cm = DAL.CreateCommand();

            cm.CommandText = "GetAllWarehousesThatContainsAMat";
            cm.Parameters.AddWithValue("@MatID", MatID);
            SqlConnection.ClearAllPools();
            return DAL.ExecuteSelectCommand(cm);
        }
        public static DataTable GetOneRemMatsOfAWarehouseByMatID(int WarehouseID, int MatID)
        {
            SqlCommand cm;
            cm = DAL.CreateCommand();

            cm.CommandText = "GetOneRemMatsOfAWarehouseByMatID";
            cm.Parameters.AddWithValue("@WarehouseID", WarehouseID);
            cm.Parameters.AddWithValue("@MatID", MatID);
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


        public static DataTable GetAllSales()
        {
            SqlCommand cm;
            cm = DAL.CreateCommand();

            cm.CommandText = "GetAllSales";


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
        }



        public static DataTable GetLastSailID()
        {
            SqlCommand cm;
            cm = DAL.CreateCommand();

            cm.CommandText = "GetLastSailID";


            SqlConnection.ClearAllPools();
            return DAL.ExecuteSelectCommand(cm);
        }

        public static DataTable GetAllWarehouses()
        {
            SqlCommand cm;
            cm = DAL.CreateCommand();

            cm.CommandText = "GetAllWarehouses";


            SqlConnection.ClearAllPools();
            return DAL.ExecuteSelectCommand(cm);
        }



        public static bool UpdateMat(string MatName, string MatType, int MatUnitWeight, int MatUnitSize, string StorageType,
           
           string Notes, int ID)
        {



            SqlCommand cm;
            cm = DAL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "UpdateMat";

            cm.Parameters.AddWithValue("@MatName", MatName);
            cm.Parameters.AddWithValue("@MatType", MatType);
            cm.Parameters.AddWithValue("@MatUnitWeight", MatUnitWeight);
            cm.Parameters.AddWithValue("@MatUnitSize", MatUnitSize);
            cm.Parameters.AddWithValue("@StorageType", StorageType);
            cm.Parameters.AddWithValue("@Notes", Notes);
            cm.Parameters.AddWithValue("@ID", ID);





            SqlConnection.ClearAllPools();
            return DAL.ExecuteCommand(cm);



        }
        public static bool InsertMat(string MatName, string MatType, int MatUnitWeight, int MatUnitSize, string StorageType,

           string Notes)
        {



            SqlCommand cm;
            cm = DAL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "InsertMat";

            cm.Parameters.AddWithValue("@MatName", MatName);
            cm.Parameters.AddWithValue("@MatType", MatType);
            cm.Parameters.AddWithValue("@MatUnitWeight", MatUnitWeight);
            cm.Parameters.AddWithValue("@MatUnitSize", MatUnitSize);
            cm.Parameters.AddWithValue("@StorageType", StorageType);
            cm.Parameters.AddWithValue("@Notes", Notes);





            SqlConnection.ClearAllPools();
            return DAL.ExecuteCommand(cm);



        }


        public static bool UpdateSales(int MatID, int WarehouseID, int Quant, string SaleDate, int TotalPrice, string TypeOfSale,
            string Notes, int ID, int BuyerID)
        {



            SqlCommand cm;
            cm = DAL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "UpdateSales";

            cm.Parameters.AddWithValue("@MatID", MatID);
            cm.Parameters.AddWithValue("@WarehouseID", WarehouseID);
            cm.Parameters.AddWithValue("@Quant", Quant);
            cm.Parameters.AddWithValue("@SaleDate", SaleDate);
            cm.Parameters.AddWithValue("@TotalPrice", TotalPrice);
            cm.Parameters.AddWithValue("@TypeOfSale", TypeOfSale);
            cm.Parameters.AddWithValue("@Notes", Notes);
            cm.Parameters.AddWithValue("@ID", ID);
            cm.Parameters.AddWithValue("@BuyerID", BuyerID);





            SqlConnection.ClearAllPools();
            return DAL.ExecuteCommand(cm);



        }




        public static bool UpdateProviderOrCustomer(string FullName, string PhoneNumber,
            string LivingAddress,
            string Note,
            string ProviderOrCustomer
            , int ID)
        {



            SqlCommand cm;
            cm = DAL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "UpdateProviderOrCustomer";

            cm.Parameters.AddWithValue("@FullName", FullName);
            cm.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            cm.Parameters.AddWithValue("@LivingAddress", LivingAddress);
            cm.Parameters.AddWithValue("@Note", Note);
            cm.Parameters.AddWithValue("@ProviderOrCustomer", ProviderOrCustomer);
            cm.Parameters.AddWithValue("@ID", ID);

            SqlConnection.ClearAllPools();
            return DAL.ExecuteCommand(cm);



        }
        public static bool InsertProviderOrCustomer(string FullName, string PhoneNumber,
            string LivingAddress,
            string Note,
            string ProviderOrCustomer)
        {



            SqlCommand cm;
            cm = DAL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "InsertProviderOrCustomer";

            cm.Parameters.AddWithValue("@FullName", FullName);
            cm.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            cm.Parameters.AddWithValue("@LivingAddress", LivingAddress);
            cm.Parameters.AddWithValue("@Note", Note);
            cm.Parameters.AddWithValue("@ProviderOrCustomer", ProviderOrCustomer);

            SqlConnection.ClearAllPools();
            return DAL.ExecuteCommand(cm);



        }
        public static bool UpdateBuying(int MatID,
int SellerID,
int Quant,
string BuyingDate,
int TotalPrice,
string TypeOfSale,
string Notes,
int ID)
        {



            SqlCommand cm;
            cm = DAL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "UpdateBuying";

            cm.Parameters.AddWithValue("@MatID", MatID);
            cm.Parameters.AddWithValue("@SellerID", SellerID);
            cm.Parameters.AddWithValue("@Quant", Quant);
            cm.Parameters.AddWithValue("@BuyingDate", BuyingDate);
            cm.Parameters.AddWithValue("@TotalPrice", TotalPrice);
            cm.Parameters.AddWithValue("@TypeOfSale", TypeOfSale);
            cm.Parameters.AddWithValue("@Notes", Notes);
            cm.Parameters.AddWithValue("@ID", ID);

            SqlConnection.ClearAllPools();
            return DAL.ExecuteCommand(cm);



        } public static bool InsertIntoBuying(int MatID,
int SellerID,
int Quant,
string BuyingDate,
int TotalPrice,
string TypeOfSale,
string Notes)
        {



            SqlCommand cm;
            cm = DAL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "InsertIntoBuying";

            cm.Parameters.AddWithValue("@MatID", MatID);
            cm.Parameters.AddWithValue("@SellerID", SellerID);
            cm.Parameters.AddWithValue("@Quant", Quant);
            cm.Parameters.AddWithValue("@BuyingDate", BuyingDate);
            cm.Parameters.AddWithValue("@TotalPrice", TotalPrice);
            cm.Parameters.AddWithValue("@TypeOfSale", TypeOfSale);
            cm.Parameters.AddWithValue("@Notes", Notes);

            SqlConnection.ClearAllPools();
            return DAL.ExecuteCommand(cm);



        }

        public static bool InsertWarehouse(string WarehouseName, string Notes)
        {



            SqlCommand cm;
            cm = DAL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "InsertWarehouse";

            cm.Parameters.AddWithValue("@WarehouseName", WarehouseName);
            cm.Parameters.AddWithValue("@Notes", Notes);

            SqlConnection.ClearAllPools();
            return DAL.ExecuteCommand(cm);



        }

        public static bool UpdateWarehouse(string WarehouseName, string Notes, int ID)
        {



            SqlCommand cm;
            cm = DAL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "UpdateWarehouse";

            cm.Parameters.AddWithValue("@WarehouseName", WarehouseName);
            cm.Parameters.AddWithValue("@Notes", Notes);
            cm.Parameters.AddWithValue("@ID", ID);
            SqlConnection.ClearAllPools();
            return DAL.ExecuteCommand(cm);



        }



        public static bool DeleteFromBuying(int ID)
        {



            SqlCommand cm;
            cm = DAL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "DeleteFromBuying";

            cm.Parameters.AddWithValue("@ID", ID);
            SqlConnection.ClearAllPools();
            return DAL.ExecuteCommand(cm);



        }

        public static bool DeleteProviderOrCustomer(int ID)
        {



            SqlCommand cm;
            cm = DAL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "DeleteProviderOrCustomer";

            cm.Parameters.AddWithValue("@ID", ID);
            SqlConnection.ClearAllPools();
            return DAL.ExecuteCommand(cm);



        }
        public static bool DeleteMatToWarehouses(int ID)
        {



            SqlCommand cm;
            cm = DAL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "DeleteMatToWarehouses";

            cm.Parameters.AddWithValue("@ID", ID);
            SqlConnection.ClearAllPools();
            return DAL.ExecuteCommand(cm);



        }

        public static bool DeleteSales(int ID)
        {



            SqlCommand cm;
            cm = DAL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "DeleteSales";

            cm.Parameters.AddWithValue("@ID", ID);
            SqlConnection.ClearAllPools();
            return DAL.ExecuteCommand(cm);



        }



        public static bool DeleteMat(int ID)
        {



            SqlCommand cm;
            cm = DAL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "DeleteMat";

            cm.Parameters.AddWithValue("@ID", ID);
            SqlConnection.ClearAllPools();
            return DAL.ExecuteCommand(cm);



        }
        public static bool DeleteWarehouse(int ID)
        {



            SqlCommand cm;
            cm = DAL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "DeleteWarehouse";

            cm.Parameters.AddWithValue("@ID", ID);
            SqlConnection.ClearAllPools();
            return DAL.ExecuteCommand(cm);



        }
        public static bool InsertIntoSales(string WarehouseName, string Notes)
        {



            SqlCommand cm;
            cm = DAL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "InsertIntoSales";

            cm.Parameters.AddWithValue("@WarehouseName", WarehouseName);
            cm.Parameters.AddWithValue("@Notes", Notes);
            SqlConnection.ClearAllPools();
            return DAL.ExecuteCommand(cm);



        }




        public static bool InsertIntoSales(int MatID, int WarehouseID, int Quant, string SaleDate, int TotalPrice, string TypeOfSale,
            string Notes, int BuyerID)
        {



            SqlCommand cm;
            cm = DAL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "InsertIntoSales";

            cm.Parameters.AddWithValue("@MatID", MatID);
            cm.Parameters.AddWithValue("@WarehouseID", WarehouseID);
            cm.Parameters.AddWithValue("@Quant", Quant);
            cm.Parameters.AddWithValue("@SaleDate", SaleDate);
            cm.Parameters.AddWithValue("@TotalPrice", TotalPrice);
            cm.Parameters.AddWithValue("@TypeOfSale", TypeOfSale);
            cm.Parameters.AddWithValue("@Notes", Notes);
            cm.Parameters.AddWithValue("@BuyerID", BuyerID);





            SqlConnection.ClearAllPools();
            return DAL.ExecuteCommand(cm);



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



        }
        public static bool UpdateMatToWarehouses(int MatID, int WarehouseID, int Quant, string MovingDate, string Notes, string MovingAction, int ID)
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
