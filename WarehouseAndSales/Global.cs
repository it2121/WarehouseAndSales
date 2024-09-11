using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseAndSales
{
    
    class Global
    {
        public  static int WarehousID = 0;
        public  static int UserID = 0;
        public  static string fullname = "";
        public  static DataTable UserRoles ;

        public static void setUserRoles(DataTable table) {

            UserRoles = table;
        
        
        }

        public static DataTable getUserRoles( )
        {

         return UserRoles;


        }  
        public static void setUserID(int Userid) {

            UserID = Userid;
        
        
        }

        public static string getfullname( )
        {

         return fullname;


        }  
        
        
        
        public static void setfullname(string Fullname) {

            fullname = Fullname;
        
        
        }

        public static int getUserID( )
        {

         return UserID;


        }     public static void setWarehousID(int warehouseid) {

            WarehousID = warehouseid;
        
        
        }

        public static int getWarehousID( )
        {

         return   WarehousID;


        }
    }
}
