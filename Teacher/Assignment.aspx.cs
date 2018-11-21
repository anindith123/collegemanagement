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

public partial class Teacher_Assignment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Class();
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
    
    private void button()
    {
        if (Request.QueryString["id"] == null)
        {
            AsignmentBO Data = new AsignmentBO();
            Data.Class = DDLClass.SelectedItem.Text;
            Data.Subject = DDLSubject.SelectedItem.Text;
            Data.NameOFasgmt = TxtAssignment.Text;
            Data.SubmissionDate = TxtDate.Value;
            Data.FilePath = FileUpload1.FileName;
            FileUpload1.SaveAs(Server.MapPath("~\\Image\\" + FileUpload1.FileName));
            int i = Data.Insert();
            if (i > 0)
            {
                Page.RegisterStartupScript("SS", "<script> alert(' Completed Successfully ');</script>");
            }


        }
        else if (Request.QueryString["id"] != null)
        {

        }
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
    protected void Submit_Click1(object sender, EventArgs e)
    {
        try
        {
            button();

        }
        catch
        {

        }

    }

    protected void Clear_Click1(object sender, EventArgs e)
    {
        try
        {
            TxtDate.Value = "";
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
}

