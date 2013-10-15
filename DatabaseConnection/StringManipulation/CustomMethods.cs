using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.ComponentModel;
using System.Drawing;

namespace DatabaseConnect
{
    public partial class Customers
    {
        //initialize an empty query string
        private string sqlQuery = string.Empty;

        //custom methods
        #region//method reads/loads the gridview with data from database
        public void LoadDBase()
        {
            sqlQuery = "SELECT cust_id,cust_name,cust_address,cust_city,cust_state,cust_zip,cust_country,cust_contact,cust_email FROM Customers ORDER BY cust_id";

            DataTable dt = RunQuery(sqlQuery);

            gvCustomers.DataSource = dt;
            gvCustomers.DataBind(); //bind data to gridview

            gvCustomers.Visible = true;
            Panel1.Visible = false;
        }
        #endregion

        #region//method retrieves data from the database and populates textboxes
        public void RetrieveData()
        {
            try
            {
                //get requested obj for the page
                if (Request.QueryString["id"] != null)
                {
                    sqlQuery = "SELECT cust_id,cust_name,cust_address,cust_city,cust_state,cust_zip,cust_country,cust_contact,cust_email " +
                               "FROM Customers " +
                               "WHERE cust_id = " + Request.QueryString["id"];

                    //execute query
                    DataTable dt = RunQuery(sqlQuery);

                    //create datarow and initialize table with rows
                    DataRow dr = dt.Rows[0];

                    //assign textbox values with values from datarows
                    tbCustID.Text = dr["cust_id"].ToString();
                    tbCustName.Text = dr["cust_name"].ToString();
                    tbCustAddy.Text = dr["cust_address"].ToString();
                    tbCustCity.Text = dr["cust_city"].ToString();
                    tbCustState.Text = dr["cust_state"].ToString();
                    tbCustZip.Text = dr["cust_zip"].ToString();
                    tbCustCountry.Text = dr["cust_country"].ToString();
                    tbCustContact.Text = dr["cust_contact"].ToString();
                    tbCustEmail.Text = dr["cust_email"].ToString();

                    Panel1.Visible = true;
                }
                else
                {
                    throw new ApplicationException("ID is null");
                }
            }
            catch (Exception ex)
            {
                if (Request.IsLocal)
                {
                    Session["Current Error"] = ex.Message;
                }
                else
                {
                    Session["Current Error"] = "Error Processing Page.";
                    Server.Transfer("ApplicationError.aspx");
                }
            }
        }
        #endregion

        #region//method to create/add new fields in the database
        public void CreateField()
        {

        }
        #endregion
        
        #region//method to update data
        //ask warren about exception handling
        public void UpdateDatabase()
        {
            string cID = tbCustID.Text.Trim();
            string cEmail = tbCustEmail.Text.Trim();
            string cContact = tbCustContact.Text.Trim();

            string query = "UPDATE Customers " +
                           "SET  cust_contact = '{0}', " +
                                "cust_email = '{1}' " +
                           "WHERE cust_id = " + cID;

            string strSql = string.Format(query, cContact, cEmail);

            using(SqlConnection sqlConn = new SqlConnection(strConn))
            using (SqlCommand sqlCmd = new SqlCommand(strSql, sqlConn))
            {
                sqlConn.Open();
                sqlCmd.ExecuteNonQuery();
            }

            //force page to reload itself
            Response.Redirect("Customers.aspx");

        }
        #endregion

        #region//method to delete data
        public void DeleteRecord()
        {

        }
        #endregion
    }
}