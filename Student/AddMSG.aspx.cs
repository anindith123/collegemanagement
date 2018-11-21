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
        if (Session["UserId"] != null)
        {
            if (!IsPostBack)
            {

                StudentName();
                DDLUser.Visible = false;
            }
        }
        else
        {
            Response.Redirect("~/Login/LoginPage.aspx");
        }
           
        }
    

    private void StudentName()
    {
        StudentBo Data = new StudentBo();
        Data.StundentID = Session["UserId"].ToString();
        DataSet ds = new DataSet();
        ds = Data.SelectData();
        Session["FullName"] = ds.Tables[0].Rows[0]["FullName"].ToString();


    }
    private void GetData()
    {
      
            MSGBO Data = new MSGBO();
            Data.SenderType = "Student";
            Data.From = Session["FullName"].ToString();
            Data.Message = TxtMSG.Text;
            if (DDLUserType.SelectedItem.Text == "Teacher")
            {
                Data.UserID = DDLUser.SelectedValue.ToString();
            }
            else if (DDLUserType.SelectedItem.Text == "Admin")
            {
                Data.UserID = DDLUserType.SelectedItem.Text;

            }
            Data.UserType = "s";
            int i = Data.InsertMSGAdmin();
            if (i > 0)
            {
                Page.RegisterStartupScript("SS", "<script> alert(' Message Send Successfully ');</script>");
            }
        }
        //else if (DDLUserType.SelectedItem.Text == "Admin")
        //{
        //    MSGBO Data = new MSGBO();
        //    Data.SenderType = DDLUserType.SelectedItem.Text;
        //    Data.From = DDLUserType.SelectedItem.Text;
        //    Data.Message = TxtMSG.Text;
        //    Data.UserID = DDLUserType.SelectedItem.Text;
        //    Data.UserType = "s";
        //    int i = Data.InsertMSGAdmin();
        //    if (i > 0)
        //    {
        //        Page.RegisterStartupScript("SS", "<script> alert(' Message Send Successfully ');</script>");
        //    }

        //}
 
    


   

    protected void DDLUserType_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (DDLUserType.SelectedItem.Text == "Teacher")
        {
            DDLUser.Visible = true;
            DDLUser.Items.Clear();
            DDLUser.Items.Add("Select..");
            DDLUser.AppendDataBoundItems = true;
            TeacherBo Data = new TeacherBo();
            DataSet ds = new DataSet();
            ds = Data.GetData();
            DDLUser.DataSource = ds;
            DDLUser.DataTextField = "FullName";
            DDLUser.DataValueField = "TeacherID";
            DDLUser.DataBind();

        }
        else if (DDLUserType.SelectedItem.Text == "Admin")
        {
            DDLUser.Visible = false;
        }

    }

    protected void SendMSG_Click(object sender, EventArgs e)
    {
        try
        {
            GetData();
        }
        catch
        { }
    }
}
