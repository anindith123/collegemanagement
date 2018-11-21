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

public partial class View_Exam : System.Web.UI.Page
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

        Label1.Text = str.ToString();
        ExamBO DataE = new ExamBO();
        DataSet ds = new DataSet();
        DataE.Class = str.ToString();
        ds = DataE.GetData();
        if (ds.Tables[0].Rows.Count > 0)
        {
            GdVExam.DataSource = ds;
            GdVExam.DataBind();
            LblMsg.Visible = false;
        }
        else
        {
            GdVExam.DataSource = null;
                GdVExam.DataBind();
            LblMsg.Visible = true;
            LblMsg.Text = "No Examinations";

        }
       
    }
       
    protected void GdVExam_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GdVExam.PageIndex = e.NewPageIndex;
        GetData();
    }
    
}
