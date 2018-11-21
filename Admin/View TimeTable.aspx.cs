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
           // GetDat();
            Class();
            if (Request.QueryString["Back"] != null)
            {
                DDLClass.ClearSelection();
                DDLClass.Items.FindByText(Session["C"].ToString().Trim()).Selected = true;
                GdVTimeTable.PageIndex = int.Parse(Session["I"].ToString());
                BindData();
            }
        }

    }

    private void Class()
    {
       
        ClassBo Dataa = new ClassBo();
        DataSet ds1 = new DataSet();
        ds1 = Dataa.GetData();
        DDLClass.DataSource = ds1;
        DDLClass.DataTextField = "Class";
        DDLClass.DataValueField = "ClassID";
        DDLClass.DataBind();
    }
    protected void DDLClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
        
        
    }

    private void BindData()
    {
        if (DDLClass.SelectedIndex != 0)
        {
            GdVTimeTable.DataSource = null;
            GdVTimeTable.DataBind();
            TimeTableBO Data = new TimeTableBO();
            Data.Class = DDLClass.SelectedItem.Text;
            Session["Class"] = DDLClass.SelectedItem.Text;
            DataSet ds = new DataSet();
            ds = Data.GetData();
            GdVTimeTable.DataSource = ds;
            GdVTimeTable.DataBind();
        }
        else
        {
            GdVTimeTable.DataSource = null;
            GdVTimeTable.DataBind();
            //Page.RegisterStartupScript("SS", "<script> alert('Please Select Any Class')</script>");

        }
    }
    protected void GdVTimeTable_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        
        if (e.CommandName == "Edit")
        {
            string id = e.CommandArgument.ToString();
            if (DDLClass.SelectedIndex != 0)
            {
                Session["C"] = DDLClass.SelectedItem.Text;
                Session["I"] = GdVTimeTable.PageIndex.ToString();
            }
            Response.Redirect("TimeTable.aspx?Id=" + id);
        }
    }
    //protected void ddl_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    GdVTimeTable.DataSource = null;
    //    GdVTimeTable.DataBind();

    //    TimeTableBO Data = new TimeTableBO();
    //    Data.Teacher = ddl.SelectedItem.Text;
    //    Session["Class"] = ddl.SelectedItem.Text;
    //    DataSet ds = new DataSet();
    //    ds = Data.GetDataTeacherTTb();
    //    GdVTimeTable.DataSource = ds;
    //    GdVTimeTable.DataBind();
    //}
  
}
