using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseConnect
{
    public class DBaseHelper : System.Web.UI.Page
    {
        //the database connection string
        protected string strConn = @"Data Source = IT-ROGELEA\LOCALDEV; Initial Catalog = tysql; Integrated Security = true";
        //protected string strConn = @"Data Source = RSDEMETRIO-PC\SQLEXPRESS; Initial Catalog = tysql; Integrated Security = true";

        public DBaseHelper()
        {
            
        }

        //this method to execute the query
        protected DataTable RunQuery(string query)
        {
            DataTable dt = new DataTable();

            using(SqlConnection sqlConn = new SqlConnection(strConn))
            using (SqlCommand sqlCmd = new SqlCommand(query,sqlConn))
            {
                SqlDataAdapter sda = new SqlDataAdapter(sqlCmd);
                sda.Fill(dt);
            }
            return dt;
        }
    }
}