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

public partial class Admin_ViewMSG : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            MSG();
        }

    }
    private void MSG()
    {
        MSGBO Dataa = new MSGBO();
        DataSet ds1 = new DataSet();
        Dataa.UserID = Session["Userid"].ToString();
        ds1 = Dataa.GtDataStudentMSG();

       
        if (ds1.Tables[0].Rows.Count > 0)
        {
            GridView2.DataSource = ds1;
            GridView2.DataBind();
            LblMsg.Visible = false;
        }
        else
        {
            GridView2.DataSource = null;
            GridView2.DataBind();
            LblMsg.Visible = true;
            LblMsg.Text = "No TimeTable";

        }
    }
    protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        MSGBO Data = new MSGBO();
        Data.MSGID = GridView2.Rows[e.RowIndex].Cells[1].Text;
        int i = Data.DeleteMSGAdmin();
        if (i > 0)
        {
            Page.RegisterStartupScript("SS", "<script> alert(' Deleted Message ');</script>");
        }
        MSG();

    }
}
