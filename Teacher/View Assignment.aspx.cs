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
            Class();
            LblMsg.Visible = false;
        }

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
        DDLSubject.Items.Clear();
        DDLSubject.Items.Add("Select..");
        DDLSubject.AppendDataBoundItems = true;
        ClassBo Data = new ClassBo();
        DataSet ds = new DataSet();
        Data.ClassID = DDLClass.SelectedValue.ToString();
        ds = Data.selectA();
        for (int i = 4; i < ds.Tables[0].Columns.Count; i++)
        {

            DDLSubject.Items.Add(ds.Tables[0].Rows[0][i].ToString());
        }
    }
    protected void DDLSubject_SelectedIndexChanged(object sender, EventArgs e)
    {
        GetData();
       

    }
    private void GetData()
    {
        AsignmentBO Data = new AsignmentBO();
        Data.Class = DDLClass.SelectedItem.Text;
        Data.Subject = DDLSubject.SelectedItem.Text;
        DataSet ds = new DataSet();
        ds = Data.SubjectAssignment();
      
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
            LblMsg.Text = "No Assignment";

        }
    }
    protected void GdVAssignment_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GdVAssignment.PageIndex = e.NewPageIndex;
        GetData();
    }
    protected void GdVAssignment_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Edit")
        {
            string id = e.CommandArgument.ToString();
            //Response.Redirect("AddClass.aspx?Id=" + id);
        }
    }

    protected void GdVAssignment_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        AsignmentBO Data = new AsignmentBO();
        Data.AsignmentsID = GdVAssignment.Rows[e.RowIndex].Cells[1].Text;

        int i = Data.DeleteAssignment();
        if (i > 0)
        {
            Page.RegisterStartupScript("SS", "<script> alert(' Deleted Successfully');</script>");
        }
        else
        {
            Page.RegisterStartupScript("SS", "<script> alert(' Not Deleted ');</script>");
        }
        GetData();
    }
}
