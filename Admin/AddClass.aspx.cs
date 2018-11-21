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

public partial class Admin_AddClass : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           
            if (Request.QueryString["id"] != null)
            {
                ClassTeacher();
                Submit.Text = "Upadate";
                Back.Visible = true;
                Select();

            }
            else if (Request.QueryString["id"] == null)
            {
                ClassTeacher();
                Submit.Text = "Submit";
                Back.Visible = false;
            }
        }


    }
    private void Select()
    {

        ClassBo Data = new ClassBo();
        DataSet ds = new DataSet();
        Data.ClassID = Request.QueryString["id"].ToString();
        ds = Data.selectA();
        TxClass.Text = ds.Tables[0].Rows[0]["Class"].ToString();
        
       
        if (ds.Tables[0].Rows[0]["ClassTeacher"].ToString() != null)
            ddl.Items.FindByText(ds.Tables[0].Rows[0]["ClassTeacher"].ToString()).Selected = true;
 
    }
    private void ClassTeacher()
    {
        TeacherBo Data = new TeacherBo();
        DataSet ds = new DataSet();
        ds = Data.GetData();
        ddl.DataSource = ds;
        ddl.DataTextField = "FullName";
        ddl.DataValueField = "FullName";
        ddl.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        button();

    }
    private void button()
    {
        if (Request.QueryString["id"] == null)
        {
            ClassBo Data = new ClassBo();
            Data.Class = TxClass.Text;
            Data.ClassTeacher = ddl.SelectedItem.Text;
            int i = Data.InsertClass();
            if (i > 0)
            {
                Page.RegisterStartupScript("SS", "<script> alert(' Class Added Successfully ');</script>");
            }
            else
            {
                Page.RegisterStartupScript("SS", "<script> alert(' Class Name Already Exists ');</script>");
            }

        }
        else if (Request.QueryString["id"] != null)
        {
            ClassBo Data = new ClassBo();
            Data.ClassID = Request.QueryString["id"].ToString();
            Data.Class = TxClass.Text;
            Data.ClassTeacher = ddl.SelectedItem.Text;
            int i = Data.Upadate();
            if (i > 0)
            {
                Page.RegisterStartupScript("SS", "<script> alert(' Updated Successfully');</script>");
            }
            else
            {
                Page.RegisterStartupScript("SS", "<script> alert(' Not Updated ');</script>");
            }
        }

    }

    protected void clear_Click(object sender, EventArgs e)
    {
        try
        {
            foreach (Control ctrl in ((ContentPlaceHolder)Master.FindControl("ContentPlaceHolder1")).Controls)
            {
                if (ctrl.GetType() == typeof(TextBox))
                {
                    ((TextBox)ctrl).Text = string.Empty;
                }
                if (ctrl.GetType() == typeof(DropDownList))
                {
                    ((DropDownList)ctrl).SelectedIndex = 0;
                }
            }
        }
        catch
        {
            throw;
        }
    }
    protected void Back_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewClass.aspx");
    }
}
