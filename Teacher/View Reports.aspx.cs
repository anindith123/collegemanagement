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

public partial class Admin_View_Reports : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Class();
            LblMsg.Visible = false;
            if (Request.QueryString["Back"] != null)
            {
                DDLClass.ClearSelection();
                DDLClass.Items.FindByText(Session["C"].ToString().Trim()).Selected = true;
                BindData();
                DDLStudent.ClearSelection();
                DDLStudent.Items.FindByText(Session["S"].ToString().Trim()).Selected = true;
                GdVReports.PageIndex = int.Parse(Session["I"].ToString());
                DDlStudentData();
            }
        }
    }
    private void GetData()
    {
        ReportsBO Data = new ReportsBO();
        DataSet ds = new DataSet();
        ds = Data.GetData();
    }
    private void Class()
    {
        ClassBo Data = new ClassBo();
        DataSet ds = new DataSet();
        ds = Data.GetData();
        DDLClass.DataSource = ds;
        DDLClass.DataTextField = "Class";
        DDLClass.DataValueField = "ClassID";
        DDLClass.DataBind();
    }
    protected void DDLClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();

        Session["Class"] = DDLClass.SelectedItem.Text;
        DDLStudent.Items.Clear();
        DDLStudent.Items.Add("Select..");
        DDLStudent.AppendDataBoundItems = true;
        StudentBo data = new StudentBo();
        data.Class = DDLClass.SelectedItem.Text;
        DataSet ds1 = new DataSet();
        ds1 = data.StudentName();

        DDLStudent.DataSource = ds1;
        DDLStudent.DataTextField = "FullName";
        DDLStudent.DataValueField = "StundentID";
        DDLStudent.DataBind();
    }

    private void BindData()
    {
        Session["Class"] = DDLClass.SelectedItem.Text;
        DDLStudent.Items.Clear();
        DDLStudent.Items.Add("Select..");
        DDLStudent.AppendDataBoundItems = true;
        StudentBo data = new StudentBo();
        data.Class = DDLClass.SelectedItem.Text;
        DataSet ds1 = new DataSet();
        ds1 = data.StudentName();

        DDLStudent.DataSource = ds1;
        DDLStudent.DataTextField = "FullName";
        DDLStudent.DataValueField = "StundentID";
        DDLStudent.DataBind();
    }
    protected void DDLStudent_SelectedIndexChanged(object sender, EventArgs e)
    {
        DDlStudentData();
       
    }
    private void DDlStudentData()
    {
        ReportsBO Data = new ReportsBO();
        DataSet ds = new DataSet();
        Data.StudentName = DDLStudent.SelectedItem.Text;
        Session["StudentName"]=DDLStudent.SelectedItem.Text;
        Data.Class = DDLClass.SelectedItem.Text;
        ds = Data.GetData();
        if (ds.Tables[0].Rows.Count > 0)
        {
            GdVReports.DataSource = ds;
            GdVReports.DataBind();
            LblMsg.Visible = false;

        }
        else
        {
            GdVReports.DataSource = null;
            GdVReports.DataBind();
            LblMsg.Visible = true;
            LblMsg.Text = "No TimeTable Found";

        }

 
    }
    protected void GdVClass_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Edit")
        {
           
            string id = e.CommandArgument.ToString();
            Session["C"] = DDLClass.SelectedItem.Text;
            Session["S"] = DDLStudent.SelectedItem.Text;
            Session["I"] = GdVReports.PageIndex.ToString();
            Response.Redirect("AddReport.aspx?Id=" + id);
        }
    }
    protected void GdVClass_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        ReportsBO Data = new ReportsBO();
        Data.MarksID = GdVReports.Rows[e.RowIndex].Cells[2].Text;
        int i = Data.DeleteReport();
        if (i > 0)
        {
            Page.RegisterStartupScript("SS", "<script> alert(' Deleted Successfully');</script>");
        }
        else
        {
            Page.RegisterStartupScript("SS", "<script> alert(' Not Deleted ');</script>");
        }
        DDlStudentData();

    }
}
