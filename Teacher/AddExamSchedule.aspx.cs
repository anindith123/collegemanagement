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

public partial class AddExamSchedule : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!IsPostBack)
        {
           
            if (Request.QueryString["id"] != null)
            {
                FileUpload1.Enabled = false;
                // ClassTeacher();
                Class();
                Submit.Text = "Upadate";
                Back.Visible = true;
                Select();

            }
            else if (Request.QueryString["id"] == null)
            {
                //ClassTeacher();
                HyperLink1.Visible = false;
                lnkbtnUpdate.Visible = false;
                Submit.Text = "Submit";
                Back.Visible = false;
            }
            Class();
        }

    }
    private void Select()
    {
        ExamBO Data = new ExamBO();
        Data.EXMID = Request.QueryString["id"].ToString();
        DataSet ds = new DataSet();
        ds = Data.SelectExam();
        DDLClass.ClearSelection();
        if (DDLClass.Items.FindByText(ds.Tables[0].Rows[0]["Class"].ToString()) != null)
            DDLClass.Items.FindByText(ds.Tables[0].Rows[0]["Class"].ToString()).Selected = true;
        TxtExam.Text = ds.Tables[0].Rows[0]["NameOfExam"].ToString();
        TxtDate.Value = ds.Tables[0].Rows[0]["EDate"].ToString();
        if (ds.Tables[0].Rows[0]["FilePath"].ToString() != "")
        {
            HyperLink1.Text = ds.Tables[0].Rows[0]["FilePath"].ToString();
            HyperLink1.NavigateUrl = "~/Admin/Images/" + ds.Tables[0].Rows[0]["FilePath"].ToString();
        }
        else
        {
            HyperLink1.Text = "No Document";
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
    protected void SubMit_Click(object sender, EventArgs e)
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
            ExamBO Data = new ExamBO();
            Data.Class = DDLClass.SelectedItem.Text.Trim();
            Data.NameOfExam = TxtExam.Text;
            Data.EDate = TxtDate.Value;
            Data.FilePath = FileUpload1.FileName;
            FileUpload1.SaveAs(Server.MapPath("~\\Image\\" + FileUpload1.FileName));
            int i = Data.InsertExam();
            if (i > 0)
            {
                Page.RegisterStartupScript("SS", "<script> alert('  Completed Successfully ');</script>");
            }
            else
            {
                Page.RegisterStartupScript("SS", "<script> alert(' Exam Already Exists ');</script>");
            }

        }
        else if (Request.QueryString["id"] != null)
        {
            ExamBO Data = new ExamBO();
            Data.EXMID = Request.QueryString["id"].ToString();
            Data.Class = DDLClass.SelectedItem.Text;
            Data.NameOfExam = TxtExam.Text;
            Data.EDate = TxtDate.Value;
            if (FileUpload1.Enabled == false)
            {

                Data.FilePath = HyperLink1.Text;
            }
            else
            {
                Data.FilePath = FileUpload1.FileName;
                FileUpload1.SaveAs(Server.MapPath("~\\Images\\" + FileUpload1.FileName));
            }
            int i = Data.UpdateExam();
            if (i > 0)
            {
                Page.RegisterStartupScript("SS", "<script> alert('  Added Successfully ');</script>");
            }
            else
            {
                Page.RegisterStartupScript("SS", "<script> alert(' Exam Already Exists ');</script>");
            }

        }
    }
    protected void Back_Click(object sender, EventArgs e)
    {
        Response.Redirect("View Exam.aspx?Back=1");
    }
    protected void Clear_Click(object sender, EventArgs e)
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
