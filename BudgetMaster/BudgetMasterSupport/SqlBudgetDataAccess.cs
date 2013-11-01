using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace BudgetMasterSupport
{
    public class SqlBudgetDataAccess : IBudgetDataAccess
    {

        public void RetrieveData()
        {
            const string CONN_STR = @"Server=it-rogelea\localdev;Database=CSharpExample;Integrated Security=true;";
            const string SELECT_QUERY = "SELECT * FROM Cities ORDER BY City,State ";
            
            //Create a connection and open it then create a command obj
            using(SqlConnection sqlConn = new SqlConnection(CONN_STR))
            using(SqlCommand sqlCmd = new SqlCommand(SELECT_QUERY,sqlConn))
            {
                sqlConn.Open();
                //Create data adapter and fill to datatable
                using(SqlDataAdapter sda = new SqlDataAdapter(SELECT_QUERY, sqlConn))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                }
            }
            
        }

        public void InsertData()
        {
            //TODO: Insert new records
        }

        public void UpdateData()
        {
            //TODO: Update existing data
        }

        public void DeleteData()
        {
            //TODO: Delete data 
        }
    }
}
