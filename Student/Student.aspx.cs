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

public partial class Admin_Student : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
             if (Session["UserId"] == null)
            {
                Response.Redirect("~/Login/LoginPage.aspx");
            }


            lblMessage.Visible = false;
                Select();
               Class();
        }
      
    }
    private void Class()
    {
        ClassBo Data = new ClassBo();
        DataSet ds = new DataSet();
        ds = Data.GetData();
        DdlClassTeacher.DataSource = ds;
        DdlClassTeacher.DataTextField = "Class";
        DdlClassTeacher.DataValueField = "ClassID";
        DdlClassTeacher.DataBind();
    }
    private void Select()
    {
        StudentBo Data = new StudentBo();
        Data.StundentID = Session["Userid"].ToString();
        DataSet ds = new DataSet();
        ds = Data.SelectData();
        TxtFirstName.Value = ds.Tables[0].Rows[0]["FirstName"].ToString();
        TxtLastName.Value = ds.Tables[0].Rows[0]["LastName"].ToString();
      
        DdlClassTeacher.ClearSelection();
        if (DdlClassTeacher.Items.FindByText(ds.Tables[0].Rows[0]["Class"].ToString()) != null)

            DdlClassTeacher.Items.FindByText(ds.Tables[0].Rows[0]["Class"].ToString()).Selected = true;
        TxtDateofBirth.Value = ds.Tables[0].Rows[0]["DateofBirth"].ToString();
        TxtFathersName.Value= ds.Tables[0].Rows[0]["FathersName"].ToString();
        TxtAddress.Value = ds.Tables[0].Rows[0]["Address"].ToString();
        TxtArea.Value = ds.Tables[0].Rows[0]["Area"].ToString();
        TxtCity.Value = ds.Tables[0].Rows[0]["City"].ToString();
        TxtState.Value = ds.Tables[0].Rows[0]["State"].ToString();
        TxtCountry.Value = ds.Tables[0].Rows[0]["Country"].ToString();
        TxtZip.Value = ds.Tables[0].Rows[0]["Zip"].ToString();
        TxtEmail.Text = ds.Tables[0].Rows[0]["Email"].ToString();
        TxtPhoneNo.Text = ds.Tables[0].Rows[0]["PhoneNo"].ToString();
        Image1.ImageUrl = "..\\Images\\" + ds.Tables[0].Rows[0]["Image"].ToString();
        Label1.Text = ds.Tables[0].Rows[0]["Image"].ToString();
        TxtMoreInfo.Value = ds.Tables[0].Rows[0]["MoreInfo"].ToString();

    }
   
    private void button()
    {
        
            StudentBo GetData = new StudentBo();
            GetData.StundentID = Session["Userid"].ToString();
            GetData.UserType = "Student";
            GetData.FirstName = TxtFirstName.Value;
            GetData.LastName = TxtLastName.Value;
           
            GetData.Class = DdlClassTeacher.SelectedItem.Text;
            GetData.DateofBirth = TxtDateofBirth.Value;
            GetData.FathersName = TxtFathersName.Value;
            GetData.Address = TxtAddress.Value;
            GetData.Area = TxtArea.Value;
            GetData.City = TxtCity.Value;
            GetData.State = TxtState.Value;
            GetData.Country = TxtCountry.Value;
            GetData.Zip = TxtZip.Value;
            GetData.PhoneNo = TxtPhoneNo.Text;
            GetData.Email = TxtEmail.Text;
            if (FuplImage.FileName == "")
            {
                GetData.Image = Label1.Text;
                //FuplImage.SaveAs(Server.MapPath("~/Admin/Images/" + Label1.Text));
            }
            else
            {
                GetData.Image = FuplImage.FileName;
                FuplImage.SaveAs(Server.MapPath("..\\Images\\" + FuplImage.FileName));
            }
            int i = GetData.Update();
            if (i > 0)
            {
                Page.RegisterStartupScript("SS", "<script> alert(' Updated Successfully');</script>");
            }
            else
            {
                Page.RegisterStartupScript("SS", "<script> alert(' Not Updated ');</script>");
            }
        }
    protected void  Update_Click(object sender, EventArgs e)
    {
        try
        {
            button();
        }
        catch
        { }
     }

}
