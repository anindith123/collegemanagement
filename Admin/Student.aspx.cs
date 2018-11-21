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
            Label1.Visible = false;
            lblMessage.Visible = false;
            if (Request.QueryString["id"] != null)
            {
                Class();
                Btm_AddTeacher.Text = "Upadate";
                Back.Visible = true;
                Select();
                Image1.Visible = true;
               

            }
            else if (Request.QueryString["id"] == null)
            {
                Btm_AddTeacher.Text = "Submit";
                Back.Visible = false;
                Image1.Visible = false;
                Class();
            }
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
        Data.StundentID = Request.QueryString["id"].ToString();
        DataSet ds = new DataSet();
        ds = Data.SelectData();
        TxtFirstName.Value = ds.Tables[0].Rows[0]["FirstName"].ToString();
        TxtLastName.Value = ds.Tables[0].Rows[0]["LastName"].ToString();

        DdlClassTeacher.ClearSelection();
        if (DdlClassTeacher.Items.FindByText(ds.Tables[0].Rows[0]["Class"].ToString()) != null)

            DdlClassTeacher.Items.FindByText(ds.Tables[0].Rows[0]["Class"].ToString()).Selected = true;
        TxtDateofBirth.Value = ds.Tables[0].Rows[0]["DateofBirth"].ToString();
        TxtFathersName.Value = ds.Tables[0].Rows[0]["FathersName"].ToString();
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
    protected void Btm_AddTeacher_Click(object sender, EventArgs e)
    {
        try
        {
            button();
        }
        catch
        {

        }
    }
    private void button()
    {
        if (Request.QueryString["id"] == null)
        {
            StudentBo GetData = new StudentBo();
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
            if (FuplImage.PostedFile.ContentType == "image/gif" || FuplImage.PostedFile.ContentType == "image/bmp" || FuplImage.PostedFile.ContentType == "image/jpeg" || FuplImage.PostedFile.ContentType == "image/pjpeg")
            {
                GetData.Image = FuplImage.FileName;
                FuplImage.SaveAs(Server.MapPath("..\\Images\\" + FuplImage.FileName));
            }
            else
            {
                Page.RegisterStartupScript("ss", "<script>alert('Place Select Image')</script>");

                return;
            }
            GetData.MoreInfo = TxtMoreInfo.Value;
            string i = GetData.Insert();
            if (i != "")
            {
                lblMessage.Visible = true;
                lblMessage.Text = TxtLastName.Value + " Registred Successfully with UserId and Password is :" + i;

                //Page.RegisterStartupScript("SS", "<script> alert('Complet Successfully');</script>");
            }
            else
            {
                Page.RegisterStartupScript("SS", "<script> alert(' Teacher Name Already Exists ');</script>");
            }


        }
        else if (Request.QueryString["id"] != null)
        {
            StudentBo GetData = new StudentBo();
            GetData.StundentID = Request.QueryString["id"].ToString();
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
        }
    }

    protected void Clear_Click(object sender, EventArgs e)
    {
        try
        {
            foreach (Control ctrl in ((ContentPlaceHolder)Master.FindControl("ContentPlaceHolder1")).Controls)
            {
                TxtFirstName.Value = "";
                TxtLastName.Value = "";
                TxtDateofBirth.Value = "";
                TxtFathersName.Value = "";
                TxtAddress.Value = "";
                TxtArea.Value = "";
                TxtCity.Value = "";
                TxtState.Value = "";
                TxtCountry.Value = "";
                TxtZip.Value = "";
                TxtMoreInfo.Value = "";
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
