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

public partial class Admin_AddMSG : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DDLUser.Visible = false;
        }
    }
   
       

   
    protected void Submit_Click(object sender, EventArgs e)
    {
        MSGBO Data = new MSGBO();
        Data.SenderType ="Admin";
        Data.From = "Admin";
        Data.Class = DropDownList1.SelectedItem.Text;
        Data.Message = TxtMSG.Text;
        if (DDLUserType.SelectedItem.Text == "Student")
        {
            Data.UserID = DDLUser.SelectedValue.ToString();
        }
        else if(DDLUserType.SelectedItem.Text=="Teacher")
        {
            Data.UserID = DropDownList1.SelectedValue.ToString();

        }
        Data.UserType="A";
        int i = Data.InsertMSGAdmin();
        if (i > 0)
        {
            Page.RegisterStartupScript("SS", "<script> alert(' Message Send Successfully ');</script>");
        }


    }
   
    protected void DDLUserType_SelectedIndexChanged(object sender, EventArgs e)
    {
       
        if (DDLUserType.SelectedItem.Text == "Student")
        {
            DropDownList1.Items.Clear();
            DropDownList1.Items.Add("Select..");
            DropDownList1.AppendDataBoundItems = true;
            ClassBo Data = new ClassBo();
            DataSet ds = new DataSet();
            ds = Data.GetData();
            DropDownList1.DataSource = ds;
            DropDownList1.DataTextField = "Class";
            DropDownList1.DataValueField = "ClassID";
            DropDownList1.DataBind();
            DDLUser.Visible = true;
            //DDLUser.Items.Clear();
            //StudentBo Data = new StudentBo();
            //DataSet ds = new DataSet();
            //ds = Data.GetData();
            //DDLUser.DataSource = ds;
            //DDLUser.DataTextField = "FullName";
            //DDLUser.DataValueField = "FullName";
            //DDLUser.DataBind();

        }
        else if (DDLUserType.SelectedItem.Text == "Teacher")
        {
            DropDownList1.Items.Clear();
            DropDownList1.Items.Add("Select..");
            DropDownList1.AppendDataBoundItems = true;
            TeacherBo Data = new TeacherBo();
            DataSet ds = new DataSet();
            ds = Data.GetData();
            DropDownList1.DataSource = ds;
            DropDownList1.DataTextField = "FullName";
            DropDownList1.DataValueField = "TeacherID";
            DropDownList1.DataBind();
            DDLUser.Visible = false;

        }

    }
    
    protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        DDLUser.Items.Clear();
        DDLUser.Items.Add("Select..");
        DDLUser.AppendDataBoundItems = true;
        StudentBo Data = new StudentBo();
        DataSet ds = new DataSet();
        Data.Class = DropDownList1.SelectedItem.Text;
        ds = Data.select();
        DDLUser.DataSource = ds;
        DDLUser.DataTextField = "FullName";
        DDLUser.DataValueField = "StundentID";
        DDLUser.DataBind();
    }
    protected void Claer_Click(object sender, EventArgs e)
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
}
