using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseAndSales
{
    internal class Helper
    {
        public static DataTable RemoveDuplicateRows(DataTable dTable, string colName)
        {
            Hashtable hTable = new Hashtable();
            ArrayList duplicateList = new ArrayList();

            //Add list of all the unique item value to hashtable, which stores combination of key, value pair.
            //And add duplicate item value in arraylist.
            foreach (DataRow drow in dTable.Rows)
            {
                if (hTable.Contains(drow[colName]))
                    duplicateList.Add(drow);
                else
                    hTable.Add(drow[colName], string.Empty);
            }

            //Removing a list of duplicate items from datatable.
            foreach (DataRow dRow in duplicateList)
                dTable.Rows.Remove(dRow);

            //Datatable which contains unique records will be return as output.
            return dTable;
        }

        public static bool UserHasRole(string UserRole)
        {
            bool HasRole = false;
            foreach (DataRow dr in Global.getUserRoles().Rows)
            {
                if (dr["UserRole"].Equals(UserRole))
                    HasRole = true;


            }
            return HasRole;
        }  
        
        public static bool UserHasRole(string UserRole ,DataTable Roles)
        {
            bool HasRole = false;
            foreach (DataRow dr in Roles.Rows)
            {
                if (dr["UserRole"].Equals(UserRole))
                    HasRole = true;


            }
            return HasRole;
        }


        public static DataTable GetTableAfterDateCheck(DataTable InTbl, string StartDate, string EndDate,string FeildName)
        {

            DataTable AfterDateDT = InTbl.Clone();
            DataTable retunrDT = AfterDateDT.Clone();
            retunrDT.Clone();
            if (StartDate.Length > 0 && EndDate.Length > 0)
            {
                AfterDateDT.Clear();

                foreach (DataRow dr in InTbl.Rows)
                {

                    DateTime Date = DateTime.ParseExact(dr[FeildName].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    DateTime Startdate = DateTime.ParseExact(StartDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    DateTime Enddate = DateTime.ParseExact(EndDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);


                    int startResult = DateTime.Compare(Date, Startdate);
                    int endResult = DateTime.Compare(Enddate, Date);

                    if (startResult >= 0 && endResult >= 0)
                    {
                        AfterDateDT.ImportRow(dr);

                    }


                }


                retunrDT = AfterDateDT;


            }
            else
            {
                retunrDT = InTbl;

            }

            return retunrDT;
        }


    }
}
