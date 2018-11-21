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

public partial class Admin_ViewNotices : System.Web.UI.Page
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
        NoticeBO Data = new NoticeBO();
        DataSet ds = new DataSet();
        ds = Data.GetData();
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        NoticeBO Data = new NoticeBO();
        Data.NoticeID = GridView1.Rows[e.RowIndex].Cells[1].Text;
        int i = Data.Delete();
        if (i > 0)
        {
            Page.RegisterStartupScript("SS", "<script> alert(' Deleted Successfully ');</script>");
        }
        GetData();

    }
}
