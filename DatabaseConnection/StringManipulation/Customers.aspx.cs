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
    public partial class Customers : DBaseHelper
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    LoadDBase();
                    RetrieveData();
                }
                else
                {
                    LoadDBase();
                    Panel1.Visible = false;
                }
            }
            else
            {
                RetrieveData();
            }

        }

        //methods related to button action
        
        #region//button events
        //add new record to database
        protected void btnCreate_Click(object sender, EventArgs e)
        {

        }
        
        //updates database when changes are made to textboxes
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateDatabase();
            Panel1.Visible = false;
        }

        //delete record from database
        protected void btnDelete_Click(object sender, EventArgs e)
        {

        }
        
        //clear contents of text box
        protected void btnClear_Click(object sender, EventArgs e)
        {
            tbCustID.Text = "";
            tbCustName.Text = "";
            tbCustAddy.Text = "";
            tbCustCity.Text = "";
            tbCustState.Text = "";
            tbCustZip.Text = "";
            tbCustCountry.Text = "";
            tbCustContact.Text = "";
            tbCustEmail.Text = "";
        }
        #endregion

     
    }
}