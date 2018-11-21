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

public partial class Admin_View_TimeTable : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["UserId"] == null)
            {
                Response.Redirect("~/Login/LoginPage.aspx");
            }
           
            GetData();
           
        }

    }
    static string str;
    private void GetData()
    {
        StudentBo Data = new StudentBo();
        Data.StudentID= Session["Userid"].ToString();
        DataSet ds1 = new DataSet();
        ds1 = Data.GetStudent();
        str = ds1.Tables[0].Rows[0]["Class"].ToString();

        GdVTimeTable.DataSource = null;
        GdVTimeTable.DataBind();
        TimeTableBO DataT = new TimeTableBO();
        DataT.Class = str.ToString();
        DataSet ds = new DataSet();
        ds = DataT.GetData();
       
        if (ds.Tables[0].Rows.Count > 0)
        {
            GdVTimeTable.DataSource = ds;
            GdVTimeTable.DataBind();
            LblMsg.Visible = false;
        }
        else
        {
            GdVTimeTable.DataSource = null; 
            GdVTimeTable.DataBind();
            LblMsg.Visible = true;
            LblMsg.Text = "No TimeTable";

        }

    }
   
  
    
}
