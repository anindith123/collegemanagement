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

public partial class Admin_ViewStudent : System.Web.UI.Page
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
        DataSet ds = new DataSet();
        ds = Data.GetData();
        if (ds.Tables[0].Rows.Count > 0)
        {
            GridView1.DataSource = ds;
            GridView1.DataBind();
            Label1.Visible = false;
        }
        else
        {
            GridView1.DataSource = null;
            GridView1.DataBind();
            Label1.Visible = true;
            Label1.Text = "No data Found";

        }
    }
   protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        StudentBo Data = new StudentBo();
        DataSet ds = new DataSet();
        Data.StundentID = GridView1.Rows[e.RowIndex].Cells[2].Text;
        int i = Data.Delete();
        if (i > 0)
        {
            Page.RegisterStartupScript("SS", "<script> alert(' Deleted Successful ');</script>");
        }
        GetData();
    }
   protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Edit")
        {
            string id = e.CommandArgument.ToString();
            Response.Redirect("Student.aspx?Id=" + id);
        }
    }
}
