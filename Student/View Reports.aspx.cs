using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Admin_View_Reports : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DDlStudentData();
        }
    }
      
    private void DDlStudentData()
    {
        ReportsBO Data = new ReportsBO();
        DataSet ds = new DataSet();
        Data.StudentID = Session["Userid"].ToString();
        ds = Data.GetStudentReport();
       
        if (ds.Tables[0].Rows.Count > 0)
        {
            GdVReports.DataSource = ds;
            GdVReports.DataBind();
            LblMsg.Visible = false;
        }
        else
        {
            GdVReports.DataSource = null;
            GdVReports.DataBind();
            LblMsg.Visible = true;
            LblMsg.Text = "No Reports Found";

        }

    }
   
}
