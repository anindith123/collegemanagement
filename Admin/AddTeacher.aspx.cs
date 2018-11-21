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

public partial class Admin_AddTeacher : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Label1.Visible = false;
            lblMessage.Visible = false;
            if (Request.QueryString["id"] != null)
            {
                Btm_AddTeacher.Text = "Upadate";
                Back.Visible = true;
                Select();
                Image1.Visible = true;
                Sub();

            }
            else if (Request.QueryString["id"] == null)
            {
                Btm_AddTeacher.Text = "Submit";
                Back.Visible = false;
                Image1.Visible = false;
                Sub();
            }
        }

    }

    private void Sub()
    {
        ClassBo Data = new ClassBo();
        DataSet ds = new DataSet();
        ds = Data.GetData();
        for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
        {
            for (int i = 4; i < ds.Tables[0].Columns.Count; i++)
            {

                if (LstBSubject.Items.FindByText(ds.Tables[0].Rows[j][i].ToString()) == null)
                {

                    LstBSubject.Items.Add(ds.Tables[0].Rows[j][i].ToString());

                }
            }
        }
    }
    string str;
    private void Select()
    {
        TeacherBo Data = new TeacherBo();
        Data.TeacherID = Request.QueryString["id"].ToString();
        DataSet ds = new DataSet();
        ds = Data.SelectData();
        TxtFirstName.Value = ds.Tables[0].Rows[0]["FirstName"].ToString();
        TxtLastName.Value = ds.Tables[0].Rows[0]["LastName"].ToString();
        TxtAbbreviation.Value = ds.Tables[0].Rows[0]["Abbreviation"].ToString();
        LstBSubject.Items.Clear();
        string st = ds.Tables[0].Rows[0]["ClassTeacher"].ToString();
        string[] ss = st.Split(',');

        for (int i = 0; i > ss.Length; i++)
        {
            LstBSubject.Items.Add(ss[i].ToString());
        }
        //    LstBSubject.ClearSelection();
        //if (LstBSubject.Items.FindByText(ds.Tables[0].Rows[0]["ClassTeacher"].ToString()) != null)

        //    LstBSubject.Items.FindByText(ds.Tables[0].Rows[0]["ClassTeacher"].ToString()).Selected = true;
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
        TxtEmail.Text = ds.Tables[0].Rows[0]["Email"].ToString();
        Image1.ImageUrl = "..\\Images\\" + ds.Tables[0].Rows[0]["Image"].ToString();
        Label1.Text = ds.Tables[0].Rows[0]["Image"].ToString();
        TxtMoreInfo.Value = ds.Tables[0].Rows[0]["MoreInfo"].ToString();

    }
    protected void Clear_Click(object sender, EventArgs e)
    {
        try
        {
            foreach (Control ctrl in ((ContentPlaceHolder)Master.FindControl("ContentPlaceHolder1")).Controls)
            {
                TxtFirstName.Value ="";
                TxtLastName.Value = "";
                 TxtDateofBirth.Value="";
                 TxtFathersName.Value="";
                 TxtAddress.Value="";
                 TxtArea.Value="";
                 TxtCity.Value="";
                 TxtState.Value="";
                 TxtCountry.Value="";
                 TxtZip.Value="";
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
    protected void Btm_AddTeacher_Click(object sender, EventArgs e)
    {
        GetData();

    }

    private void GetData()
    {
        if (Request.QueryString["id"] == null)
        {
            TeacherBo GetData = new TeacherBo();
            GetData.UserType = "Teacher";
            GetData.FirstName = TxtFirstName.Value;
            GetData.LastName = TxtLastName.Value;
            GetData.Abbreviation = TxtAbbreviation.Value;

            for (int i = 0; i < LstBSubject.Items.Count; i++)
            {
                if (LstBSubject.Items[i].Selected == true)
                {

                    str = str + LstBSubject.Items[i].Text + ",";
                }
            }
            str = str.TrimEnd(',');
            GetData.ClassTeacher = str.ToString();

            //GetData.ClassTeacher =LstBSubject.Items.s
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
            string ds = GetData.insert();
            
            if (ds != "0")
            {
                lblMessage.Visible = true;
                lblMessage.Text = TxtLastName.Value + " Registred Successfully with UserId and Password is :" + ds;

                //Page.RegisterStartupScript("SS", "<script> alert('Complet Successfully');</script>");
            }
            else
            {
                Page.RegisterStartupScript("SS", "<script> alert(' Teacher Name Already Exists ');</script>");
            }

        }
        else if (Request.QueryString["id"] != null)
        {
            TeacherBo GetData = new TeacherBo();
            GetData.TeacherID = Request.QueryString["id"].ToString();
            GetData.FirstName = TxtFirstName.Value;
            GetData.LastName = TxtLastName.Value;
            GetData.Abbreviation = TxtAbbreviation.Value;
            // GetData.ClassTeacher = DdlClassTeacher.SelectedItem.Text;
            GetData.DateofBirth = TxtDateofBirth.Value;
            GetData.FathersName = TxtFathersName.Value;
            GetData.Address = TxtAddress.Value;
            GetData.Area = TxtArea.Value;
            GetData.City = TxtCity.Value;
            GetData.State = TxtState.Value;
            GetData.Country = TxtCountry.Value;
            GetData.Zip = TxtZip.Value;
            GetData.PhoneNo = TxtPhoneNo.Text;

            if (FuplImage.FileName == "")
            {
                GetData.Image = Label1.Text;
                //FuplImage.SaveAs(Server.MapPath("Images/" + FuplImage.FileName));
            }
            else
            {
                GetData.Image = FuplImage.FileName;
                FuplImage.SaveAs(Server.MapPath("..\\Images\\" + FuplImage.FileName));
            }

            GetData.MoreInfo = TxtMoreInfo.Value;
            int i = GetData.Upadate();
            if (i > 0)
            {
                //lblMessage.Visible = true;
                //lblMessage.Text = TxtLastName.Value + " Registred Successfully with UserId and Password is :" + ds.Tables[0].Rows[0]["UserID"].ToString();

                Page.RegisterStartupScript("SS", "<script> alert('Updated Successfully');</script>");
            }
            else
            {
                Page.RegisterStartupScript("SS", "<script> alert(' Teacher Name Already Exists ');</script>");
            }


        }

    }
    
}
