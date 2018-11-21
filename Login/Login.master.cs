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

public partial class Admin_Login : System.Web.UI.MasterPage
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
        GdVNotice.DataSource = ds;
        GdVNotice.DataBind();
    }
    protected void GdVNotice_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GdVNotice.PageIndex = e.NewPageIndex;
        GetData();
    }
}
