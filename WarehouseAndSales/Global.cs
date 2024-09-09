using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseAndSales
{
    
    class Global
    {
        public  static int WarehousID = 0;

        public static void setWarehousID(int warehouseid) {

            WarehousID = warehouseid;
        
        
        }

        public static int getWarehousID( )
        {

         return   WarehousID;


        }
    }
}
