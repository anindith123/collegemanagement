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

public partial class Admin_View_TimeTable : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           // GetDat();
            Class();
            LblMsg.Visible = false;
        }

    }

    //private void ClassTeacher()
    //{
       
    //    TeacherBo Data = new TeacherBo();
    //    DataSet ds = new DataSet();
    //    ds = Data.GetData();
    //    ddl.DataSource = ds;
    //    ddl.DataTextField = "FullName";
    //    ddl.DataValueField = "FullName";
    //    ddl.DataBind();
    //}
    private void Class()
    {
       
        ClassBo Dataa = new ClassBo();
        DataSet ds1 = new DataSet();
        ds1 = Dataa.GetData();
        DDLClass.DataSource = ds1;
        DDLClass.DataTextField = "Class";
        DDLClass.DataValueField = "ClassID";
        DDLClass.DataBind();
    }
    protected void DDLClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        GdVTimeTable.DataSource = null;
        GdVTimeTable.DataBind();
        TimeTableBO Data = new TimeTableBO();
        Data.Class = DDLClass.SelectedItem.Text;
        Session["Class"] = DDLClass.SelectedItem.Text;
        DataSet ds = new DataSet();
        ds = Data.GetData();
        if (ds.Tables[0].Rows.Count > 0)
        {
            GdVTimeTable.DataSource = ds;
            GdVTimeTable.DataBind();
            LblMsg.Visible = false;
            
        }
        else
        {
            GdVTimeTable.DataSource = null;
            GdVTimeTable.DataBind();
            LblMsg.Visible = true;
            LblMsg.Text = "No TimeTable Found";
 
        }
    }
   
   
}
