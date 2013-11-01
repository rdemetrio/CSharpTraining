using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SelectDisplayQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        static void SelectDisplayQuery()
        {
            const string CONN_STR = @"Server=it-rogelea\localdev;Database=CSharpExample;Integrated Security=true;";
            const string SELECT_QUERY = "SELECT * FROM Cities ORDER BY City,State ";

            //create sql connection and open it
            SqlConnection sqlConn = new SqlConnection(CONN_STR);

            sqlConn.Open();
            try
            {
                //Create a command object 
                SqlCommand sqlcmd = new SqlCommand(SELECT_QUERY, sqlConn);

                //Create and execute data reader
                SqlDataReader dr = sqlcmd.ExecuteReader();
                try
                {
                    Console.WriteLine("**Records Returned**\n");
                    while (dr.Read())
                    {
                        #region//1st method
                        //StringBuilder outputLine = new StringBuilder();
                        //outputLine.Append("City:");
                        //outputLine.Append(dr["City"].ToString());
                        //outputLine.Append(", ");
                        //outputLine.Append("State:");
                        //outputLine.Append(dr["State"].ToString());

                        //Console.WriteLine(outputLine.ToString());
                        #endregion
                        //2nd method way better
                        Console.WriteLine("City: {0}, State: {1}", dr["City"].ToString(), dr["State"].ToString());
                            
                        //research this and understand it
                        //dr.GetInt32(dr.GetOrdinal("IntVal"));
                    }
                }
                finally
                {
                    //Make sure reader is closed
                    dr.Close();
                }
            }
            finally
            {
                sqlConn.Close();
            }
        }
        static void PromptUser()
        {
            Console.WriteLine("Select Choice: \n");
            StringBuilder menuChoices = new StringBuilder();
            try
            {

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void UpdateDatabase()
        {

        }
    }
}
