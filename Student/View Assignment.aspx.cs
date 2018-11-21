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

public partial class View_Assignment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GetData();
        }

    }
    
    private void GetData()
    {
        StudentBo Data = new StudentBo();
        Data.StudentID = Session["Userid"].ToString();
        DataSet ds1 = new DataSet();
        ds1 = Data.GetStudent();
        string str = ds1.Tables[0].Rows[0]["Class"].ToString();

        AsignmentBO DataA = new AsignmentBO();
        DataA.Class = str.ToString();
        DataSet ds = new DataSet();
        ds = DataA.ClassAssignment();
        if (ds.Tables[0].Rows.Count > 0)
        {
            GdVAssignment.DataSource = ds;
            GdVAssignment.DataBind();
            LblMsg.Visible = false;
        }
        else
        {
            GdVAssignment.DataSource = null; 
            GdVAssignment.DataBind();
            LblMsg.Visible = true;
            LblMsg.Text = "No Assignments";
 
        }
        
    }
   
}
