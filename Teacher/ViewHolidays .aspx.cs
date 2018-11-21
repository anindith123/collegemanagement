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

public partial class ViewHolidays_ : System.Web.UI.Page
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
        HolidayBO Data = new HolidayBO();
        DataSet ds = new DataSet();
        ds = Data.GetData();
        if (ds.Tables[0].Rows.Count > 0)
        {
            Label1.Visible = false;
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        else
        {
            Label1.Visible = true;
            Label1.Text = "Data Not Found";

        }

    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GetData();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        HolidayBO Data = new HolidayBO();
        Data.HolidayID = GridView1.Rows[e.RowIndex].Cells[2].Text;
        int i = Data.Delete();
        GetData();
        if (i > 0)
        {
            Page.RegisterStartupScript("SS", "<script> alert(' Deleted Successfully');</script>");
        }
        
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Edit")
        {
            string id = e.CommandArgument.ToString();
            Response.Redirect("AddHoliday.aspx?Id=" + id);
        }
    }
}
