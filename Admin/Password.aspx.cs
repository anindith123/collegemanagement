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

public partial class Admin_Password : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GetPassword();
        }

    }
    private void GetPassword()
    {
        HolidayBO Data = new HolidayBO();
        DataSet ds = new DataSet();
        ds = Data.Password();
        GdVPassword.DataSource = ds;
        GdVPassword.DataBind();
    }
}
