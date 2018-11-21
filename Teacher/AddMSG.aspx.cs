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
            GetData();
        }
    }


    private void GetData()
    {
        TeacherBo Data = new TeacherBo();
        Data.TeacherID = Session["UserId"].ToString();
        DataSet ds = new DataSet();
        ds = Data.SelectData();
        Session["FullName"] = ds.Tables[0].Rows[0]["FullName"].ToString();
    }
   
    protected void Submit_Click(object sender, EventArgs e)
    {
       
            MSGBO Data = new MSGBO();
            Data.SenderType = "Teacher";
            Data.From = Session["FullName"].ToString();
            Data.Class = DropDownList1.SelectedItem.Text;
            Data.Message = TxtMSG.Text;
            if (DDLUserType.SelectedItem.Text == "Student")
            {
                Data.UserID = DDLUser.SelectedValue.ToString();
            }
            else if (DDLUserType.SelectedItem.Text == "Admin")
            {
                Data.UserID = DropDownList1.SelectedValue.ToString();

            }
            Data.UserType = "T";
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
            //DropDownList1.ClearSelection();
            ClassBo Data = new ClassBo();
            DataSet ds = new DataSet();
            ds = Data.GetData();
            DropDownList1.DataSource = ds;
            DropDownList1.DataTextField = "Class";
            DropDownList1.DataValueField = "ClassID";
            DropDownList1.DataBind();
            DDLUser.Visible = true;
           
        }
        else if (DDLUserType.SelectedItem.Text == "Admin")
        {
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
}
