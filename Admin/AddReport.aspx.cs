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

public partial class Admin_AddReport : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            if (Request.QueryString["id"] != null)
            {
                
                Submit.Text = "Upadate";
                Back.Visible = true;
                Class();
                Subjects();
                Select();
               // GetData();

            }
            else if (Request.QueryString["id"] == null)
            {
                //ClassTeacher();
                Submit.Text = "Submit";
                Back.Visible = false;
                Class();
            }
        }

    }
    private void Select()
    {
        ReportsBO Data = new ReportsBO();
        Data.MarksID = Request.QueryString["id"].ToString();
        DataSet ds = new DataSet();
        ds = Data.Select();
        //Session["Class"]
        DDLClass.ClearSelection();
        if (DDLClass.Items.FindByText(ds.Tables[0].Rows[0]["Class"].ToString()) != null)
            DDLClass.Items.FindByText(ds.Tables[0].Rows[0]["Class"].ToString()).Selected = true;

        DDLSubject.ClearSelection();
        if (DDLSubject.Items.FindByText(ds.Tables[0].Rows[0]["Subjects"].ToString()) != null)
            DDLSubject.Items.FindByText(ds.Tables[0].Rows[0]["Subjects"].ToString()).Selected = true;

        DDLStudent.ClearSelection();
        if (DDLStudent.Items.FindByText(ds.Tables[0].Rows[0]["StudentName"].ToString()) != null)
            DDLStudent.Items.FindByText(ds.Tables[0].Rows[0]["StudentName"].ToString()).Selected = true;

                           
        DDLExam.ClearSelection();
        if (DDLExam.Items.FindByText(ds.Tables[0].Rows[0]["TypeOfExam"].ToString()) != null)
            DDLExam.Items.FindByText(ds.Tables[0].Rows[0]["TypeOfExam"].ToString()).Selected = true;
        TxtMarks.Text = ds.Tables[0].Rows[0]["Marks"].ToString();

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
    private void Subjects()
    {
        DDLSubject.Items.Clear();
        DDLSubject.Items.Add("Select..");
        DDLSubject.AppendDataBoundItems = true;
        ClassBo Data = new ClassBo();
        DataSet ds = new DataSet();
        Data.Class = Session["Class"].ToString();
        ds = Data.select();
        for (int i = 4; i < ds.Tables[0].Columns.Count; i++)
        {

            DDLSubject.Items.Add(ds.Tables[0].Rows[0][i].ToString());
        }

        DDLStudent.Items.Clear();
        DDLStudent.Items.Add("Select..");
        DDLStudent.AppendDataBoundItems = true;
        StudentBo data = new StudentBo();
        data.Class = Session["Class"].ToString();
        DataSet ds1 = new DataSet();
        ds1 = data.StudentName();

        DDLStudent.DataSource = ds1;
        DDLStudent.DataTextField = "FullName";
        DDLStudent.DataValueField = "StundentID";
        DDLStudent.DataBind();

        DDLExam.Items.Clear();
        DDLExam.Items.Add("Select..");
        DDLExam.AppendDataBoundItems = true;
        ExamBO DataE = new ExamBO();
        DataSet dsE = new DataSet();
        DataE.Class = Session["Class"].ToString();
        dsE = DataE.GetData();
        DDLExam.DataSource = dsE;
        DDLExam.DataTextField = "NameOfExam";
        DDLExam.DataValueField = "NameOfExam";
        DDLExam.DataBind();
    }
    protected void DDLClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            GetData();
        }
        catch { }
    

    }
    private void GetData()
    {
        DDLSubject.Items.Clear();
        DDLSubject.Items.Add("Select..");
        DDLSubject.AppendDataBoundItems = true;
        ClassBo Data = new ClassBo();
        DataSet ds = new DataSet();
        Data.Class = DDLClass.SelectedItem.Text;
        ds = Data.select();
        for (int i = 4; i < ds.Tables[0].Columns.Count; i++)
        {

            DDLSubject.Items.Add(ds.Tables[0].Rows[0][i].ToString());
        }

        DDLStudent.Items.Clear();
        DDLStudent.Items.Add("Select..");
        DDLStudent.AppendDataBoundItems = true;
        StudentBo data = new StudentBo();
        data.Class = DDLClass.SelectedItem.Text;
        DataSet ds1 = new DataSet();
        ds1 = data.StudentName();

        DDLStudent.DataSource = ds1;
        DDLStudent.DataTextField = "FullName";
        DDLStudent.DataValueField = "StundentID";
        DDLStudent.DataBind();


        DDLExam.Items.Clear();
        DDLExam.Items.Add("Select..");
        DDLExam.AppendDataBoundItems = true;
        ExamBO DataE = new ExamBO();
        DataSet dsE = new DataSet();
        DataE.Class = DDLClass.SelectedItem.Text;
        dsE = DataE.GetData();
        DDLExam.DataSource = dsE;
        DDLExam.DataTextField = "NameOfExam";
        DDLExam.DataValueField = "NameOfExam";
        DDLExam.DataBind();
    }
    protected void Submit_Click(object sender, EventArgs e)
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
                ReportsBO Data=new ReportsBO();
                Data.Class=DDLClass.SelectedItem.Text;
                Data.Subjects=DDLSubject.SelectedItem.Text;
                Data.StudentName=DDLStudent.SelectedItem.Text;
                Data.StudentID = DDLStudent.SelectedValue.ToString();
                Data.TypeOfExam=DDLExam.SelectedItem.Text;
                Data.Marks=TxtMarks.Text;
                int i=Data.InsertMarks();
                if (i > 0)
                {
                    Page.RegisterStartupScript("SS", "<script> alert(' Completed Successfully ');</script>");
                }
                else
                {
                    Page.RegisterStartupScript("SS", "<script> alert(' Already Record Exists ');</script>");
 
                }

               

            }
            else if (Request.QueryString["id"]!= null)
            {
                ReportsBO Data = new ReportsBO();
                Data.MarksID = Request.QueryString["id"].ToString();
                Data.Class = DDLClass.SelectedItem.Text;
                Data.Subjects = DDLSubject.SelectedItem.Text;
                Data.StudentName = DDLStudent.SelectedItem.Text;
                Data.StudentID = DDLStudent.SelectedValue.ToString();
                Data.TypeOfExam = DDLExam.SelectedItem.Text;
                Data.Marks = TxtMarks.Text;
                int i = Data.UpdateMarks();
                if (i > 0)
                {
                    Page.RegisterStartupScript("SS", "<script> alert(' Updated Successfully ');</script>");
                }
                else
                {
                    Page.RegisterStartupScript("SS", "<script> alert(' Already Record Exists ');</script>");

                }
               
            }
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
    protected void Back_Click(object sender, EventArgs e)
    {
        Response.Redirect("View Reports.aspx?Back=1");
    }
}
