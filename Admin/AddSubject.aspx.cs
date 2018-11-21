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

public partial class Admin_AddSubject : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            if (Request.QueryString["id"] != null)
            {
                Class();
                Submit.Text = "Upadate";
                Back.Visible = true;
                Select();

            }
            else if (Request.QueryString["id"] == null)
            {
                Class();
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
        ds = Data.GetDataSelect();
        DDLClass.ClearSelection();
        if (DDLClass.Items.FindByText(ds.Tables[0].Rows[0]["Class"].ToString())!=null)
            DDLClass.Items.FindByText(ds.Tables[0].Rows[0]["Class"].ToString()).Selected=true;
        TxtSub1.Text = ds.Tables[0].Rows[0]["Subject1"].ToString();
        TxtSub2.Text = ds.Tables[0].Rows[0]["Subject2"].ToString();
        TxtSub3.Text = ds.Tables[0].Rows[0]["Subject3"].ToString();
        TxtSub4.Text = ds.Tables[0].Rows[0]["Subject4"].ToString();
        TxtSub5.Text = ds.Tables[0].Rows[0]["Subject5"].ToString();
        TxtSub6.Text = ds.Tables[0].Rows[0]["Subject6"].ToString();
        TxtSub7.Text = ds.Tables[0].Rows[0]["Subject7"].ToString();
        TxtSub8.Text = ds.Tables[0].Rows[0]["Subject8"].ToString();
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
    protected void Clear_Click(object sender, EventArgs e)
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
    protected void Submit_Click(object sender, EventArgs e)
    {
        button();

    }
    private void button()
    {
        if (Request.QueryString["id"] == null)
        {
            ClassBo Data = new ClassBo();
            Data.ClassID = DDLClass.SelectedValue.ToString();
            Data.Class = DDLClass.SelectedItem.ToString();
            Data.Subject1 = TxtSub1.Text;
            Data.Subject2 = TxtSub2.Text;
            Data.Subject3 = TxtSub3.Text;
            Data.Subject4 = TxtSub4.Text;
            Data.Subject5 = TxtSub5.Text;
            Data.Subject6 = TxtSub6.Text;
            Data.Subject7 = TxtSub7.Text;
            Data.Subject8 = TxtSub8.Text;
            int i = Data.InsertSubject();
            if (i > 0)
            {
                Page.RegisterStartupScript("SS", "<script> alert('Completed Successfully');</script>");
            }
            else
            {
                Page.RegisterStartupScript("SS", "<script> alert('Subjects Already exists');</script>");
            }
            
        }
        else if (Request.QueryString["id"] != null)
        {

            ClassBo Data = new ClassBo();

            Data.ClassID = Request.QueryString["id"].ToString();
            Data.Class = DDLClass.SelectedItem.ToString();
            Data.Subject1 = TxtSub1.Text;
            Data.Subject2 = TxtSub2.Text;
            Data.Subject3 = TxtSub3.Text;
            Data.Subject4 = TxtSub4.Text;
            Data.Subject5 = TxtSub5.Text;
            Data.Subject6 = TxtSub6.Text;
            Data.Subject7 = TxtSub7.Text;
            Data.Subject8 = TxtSub8.Text;
            int i = Data.UpdateSubject();
            if (i > 0)
            {
                Page.RegisterStartupScript("SS", "<script> alert('Updated Successfully');</script>");
            }
            else
            {
                Page.RegisterStartupScript("SS", "<script> alert('Subjects Already exists');</script>");
            }
            
 
        }

    }

    protected void Back_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewSubjects.aspx");
    }
}
