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

public partial class Admin_TimeTable : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           
            if (!IsPostBack)
            {
                
               
                if (Request.QueryString["id"] != null)
                {
                    Label1Class.Visible = false;
                    LblDay.Visible = false;
                    DdlDay.Visible = false;
                    DDLClass.Visible = false;
                    Submit.Text = "Upadate";
                    Back.Visible = true;
                    LblDayU.Visible = true;
                    LDay.Visible = true;
                    LDay.Text = Request.QueryString["id"].ToString();
                    LabelClass.Visible = true;
                    LClass.Visible = true;
                    LClass.Text = Session["Class"].ToString();
                    Subject();
                    Select();
                   // Class();

                }
                else if (Request.QueryString["id"] == null)
                {
                    Label1Class.Visible = true;
                    LabelClass.Visible = false;
                    LClass.Visible = false;
                    LblDay.Visible = true;
                    DdlDay.Visible = true;
                    LblDayU.Visible = false;
                    LDay.Visible = false;
                    Submit.Text = "Submit";
                    Back.Visible = false;
                    Class();
                   // ClassTeacher();
                }
            }
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
    private void Teacher()
    {
        Sub.Subject = DDLSubject1.SelectedItem.Text;
        dsSub = Sub.GetSujectTeacher();

        DDLSubjectTeacher1.Items.Clear();
        DDLSubjectTeacher1.Items.Add("Select..");
        DDLSubjectTeacher1.AppendDataBoundItems = true;
        DDLSubjectTeacher1.DataSource = dsSub;
        DDLSubjectTeacher1.DataTextField = "FullName";
        DDLSubjectTeacher1.DataValueField = "TeacherID";
        DDLSubjectTeacher1.DataBind();
    }
    private void Select()
    {
        TimeTableBO Data = new TimeTableBO();
       // Data.ID = int.Parse(Request.QueryString["id"].ToString());
        Data.Class = LClass.Text.Trim();
        Data.Day = LDay.Text.Trim();
        DataSet ds = new DataSet();
        ds = Data.SelectTimeTable();
        //string st = ds.Tables[0].Rows[0]["ClassTeacher"].ToString();
        //string[] ss = st.Split(',');

        //for (int i = 0; i > ss.Length; i++)
        //{
        //    LstBSubject.Items.Add(ss[i].ToString());
        //}

        string Sub1 = ds.Tables[0].Rows[0]["I"].ToString();
        string[] S1 = Sub1.Split(',');
        DDLSubject1.ClearSelection();
        if( DDLSubject1.Items.FindByText(S1[0].ToString())!=null)
            DDLSubject1.Items.FindByText(S1[0].ToString()).Selected = true;

                    Sub.Subject = S1[0].ToString();
                    dsSub = Sub.GetSujectTeacher();
                    DDLSubjectTeacher1.Items.Clear();
                    DDLSubjectTeacher1.Items.Add("Select..");
                    DDLSubjectTeacher1.AppendDataBoundItems = true;
                    DDLSubjectTeacher1.DataSource = dsSub;
                    DDLSubjectTeacher1.DataTextField = "FullName";
                    DDLSubjectTeacher1.DataValueField = "TeacherID";
                    DDLSubjectTeacher1.DataBind();

        DDLSubjectTeacher1.ClearSelection();
        if (DDLSubjectTeacher1.Items.FindByText(S1[1].ToString()) != null)
               DDLSubjectTeacher1.Items.FindByText(S1[1].ToString()).Selected = true;
   
        string Sub2 = ds.Tables[0].Rows[0]["II"].ToString();
        string[] s2 = Sub2.Split(',');
        DDLSubject2.ClearSelection();
        if (DDLSubject2.Items.FindByText(s2[0].ToString()) !=null)
            DDLSubject2.Items.FindByText(s2[0].ToString()).Selected = true;

                    Sub.Subject = s2[0].ToString();
                    dsSub = Sub.GetSujectTeacher();
                    DDLSubjectTeacher2.Items.Clear();
                    DDLSubjectTeacher2.Items.Add("Select..");
                    DDLSubjectTeacher2.AppendDataBoundItems = true;
                    DDLSubjectTeacher2.DataSource = dsSub;
                    DDLSubjectTeacher2.DataTextField = "FullName";
                    DDLSubjectTeacher2.DataValueField = "TeacherID";
                    DDLSubjectTeacher2.DataBind();
        DDLSubjectTeacher2.ClearSelection();
        if (DDLSubjectTeacher2.Items.FindByText(s2[1].ToString()) !=null )
            DDLSubjectTeacher2.Items.FindByText(s2[1].ToString()).Selected = true;

        string Sub3 = ds.Tables[0].Rows[0]["III"].ToString();
        string[] s3 = Sub3.Split(',');
        DDLSubject3.ClearSelection();
        if (DDLSubject3.Items.FindByText(s3[0].ToString()) != null)
            DDLSubject3.Items.FindByText(s3[0].ToString()).Selected = true;
                         Sub.Subject = s3[0].ToString();
                         dsSub = Sub.GetSujectTeacher();
                         DDLSubjectTeacher3.Items.Clear();
                        DDLSubjectTeacher3.Items.Add("Select..");
                        DDLSubjectTeacher3.AppendDataBoundItems = true;
                        DDLSubjectTeacher3.DataSource = dsSub;
                        DDLSubjectTeacher3.DataTextField = "FullName";
                        DDLSubjectTeacher3.DataValueField = "TeacherID";
                        DDLSubjectTeacher3.DataBind();
        DDLSubjectTeacher3.ClearSelection();
        if (DDLSubjectTeacher3.Items.FindByText(s3[1].ToString()) != null)
            DDLSubjectTeacher3.Items.FindByText(s3[1].ToString()).Selected = true;

        string Sub4 = ds.Tables[0].Rows[0]["IV"].ToString();
        string[] s4 = Sub4.Split(',');
        DDLSubject4.ClearSelection();
        if (DDLSubject4.Items.FindByText(s4[0].ToString()) != null)
            DDLSubject4.Items.FindByText(s4[0].ToString()).Selected = true;
                        Sub.Subject = s4[0].ToString();
                        dsSub = Sub.GetSujectTeacher();
                        DDLSubjectTeacher8.Items.Clear();
                        DDLSubjectTeacher8.Items.Add("Select..");
                        DDLSubjectTeacher8.AppendDataBoundItems = true;
                        DDLSubjectTeacher8.DataSource = dsSub;
                        DDLSubjectTeacher8.DataTextField = "FullName";
                        DDLSubjectTeacher8.DataValueField = "TeacherID";
                        DDLSubjectTeacher8.DataBind();
        DDLSubjectTeacher8.ClearSelection();
        if (DDLSubjectTeacher8.Items.FindByText(s4[1].ToString()) != null)
            DDLSubjectTeacher8.Items.FindByText(s4[1].ToString()).Selected = true;

        string Sub5 = ds.Tables[0].Rows[0]["V"].ToString();
        string[] s5 = Sub5.Split(',');
        DDLSubject5.ClearSelection();
        if (DDLSubject5.Items.FindByText(s5[0].ToString())!= null)
            DDLSubject5.Items.FindByText(s5[0].ToString()).Selected = true;

                        Sub.Subject = s5[0].ToString();
                        dsSub = Sub.GetSujectTeacher();
                        DDLSubjectTeacher4.Items.Clear();
                        DDLSubjectTeacher4.Items.Add("Select..");
                        DDLSubjectTeacher4.AppendDataBoundItems = true;
                        DDLSubjectTeacher4.DataSource = dsSub;
                        DDLSubjectTeacher4.DataTextField = "FullName";
                        DDLSubjectTeacher4.DataValueField = "TeacherID";
                        DDLSubjectTeacher4.DataBind();
        DDLSubjectTeacher4.ClearSelection();
        if (DDLSubjectTeacher4.Items.FindByText(s5[1].ToString()) != null)
            DDLSubjectTeacher4.Items.FindByText(s5[1].ToString()).Selected = true;


        string Sub6 = ds.Tables[0].Rows[0]["VI"].ToString();
        string[] s6 = Sub6.Split(',');
        DDLSubject6.ClearSelection();
        if (DDLSubject6.Items.FindByText(s6[0].ToString())!= null)
            DDLSubject6.Items.FindByText(s6[0].ToString()).Selected = true;
                        Sub.Subject = s6[0].ToString();
                        dsSub = Sub.GetSujectTeacher();
                        DDLSubjectTeacher5.Items.Clear();
                        DDLSubjectTeacher5.Items.Add("Select..");
                        DDLSubjectTeacher5.AppendDataBoundItems = true;
                        DDLSubjectTeacher5.DataSource = dsSub;
                        DDLSubjectTeacher5.DataTextField = "FullName";
                        DDLSubjectTeacher5.DataValueField = "TeacherID";
                        DDLSubjectTeacher5.DataBind();

        DDLSubjectTeacher5.ClearSelection();
        if (DDLSubjectTeacher5.Items.FindByText(s6[1].ToString()) != null)
            DDLSubjectTeacher5.Items.FindByText(s6[1].ToString()).Selected = true;


        string Sub7 = ds.Tables[0].Rows[0]["VII"].ToString();
        string[] s7 = Sub7.Split(',');
        DDLSubject7.ClearSelection();
        if (DDLSubject7.Items.FindByText(s7[0].ToString())!= null)
            DDLSubject7.Items.FindByText(s7[0].ToString()).Selected = true;
                    Sub.Subject = s7[0].ToString();
                    dsSub = Sub.GetSujectTeacher();
                    DDLSubjectTeacher6.Items.Clear();
                    DDLSubjectTeacher6.Items.Add("Select..");
                    DDLSubjectTeacher6.AppendDataBoundItems = true;
                    DDLSubjectTeacher6.DataSource = dsSub;
                    DDLSubjectTeacher6.DataTextField = "FullName";
                    DDLSubjectTeacher6.DataValueField = "TeacherID";
                    DDLSubjectTeacher6.DataBind();
        DDLSubjectTeacher6.ClearSelection();
        if (DDLSubjectTeacher6.Items.FindByText(s7[1].ToString()) != null)
            DDLSubjectTeacher6.Items.FindByText(s7[1].ToString()).Selected = true;

        string Sub8 = ds.Tables[0].Rows[0]["VIII"].ToString();
        string[] s8 = Sub8.Split(',');
        DDLSubject8.ClearSelection();
        if (DDLSubject8.Items.FindByText(s8[0].ToString())!= null)
            DDLSubject8.Items.FindByText(s8[0].ToString()).Selected = true;
                    Sub.Subject = s8[0].ToString();
                    dsSub = Sub.GetSujectTeacher();
                    DDLSubjectTeacher7.Items.Clear();
                    DDLSubjectTeacher7.Items.Add("Select..");
                    DDLSubjectTeacher7.AppendDataBoundItems = true;
                    DDLSubjectTeacher7.DataSource = dsSub;
                    DDLSubjectTeacher7.DataTextField = "FullName";
                    DDLSubjectTeacher7.DataValueField = "TeacherID";
                    DDLSubjectTeacher7.DataBind();
        DDLSubjectTeacher7.ClearSelection();
        if (DDLSubjectTeacher7.Items.FindByText(s8[1].ToString()) != null)
            DDLSubjectTeacher7.Items.FindByText(s8[1].ToString()).Selected = true;

    }

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

    static ClassBo Data = new ClassBo();
    static DataSet ds = new DataSet();
    private void Subject()
    {
        DDLSubject1.Items.Clear();
        DDLSubject1.Items.Add("Select..");
        DDLSubject1.AppendDataBoundItems = true;
        // DataSet ds = new DataSet();
        Data.Class = Session["Class"].ToString();
        ds = Data.select();
        for (int i = 4; i < ds.Tables[0].Columns.Count; i++)
        {

            DDLSubject1.Items.Add(ds.Tables[0].Rows[0][i].ToString());
        }

        DDLSubject1.Items.Clear();
        DDLSubject1.Items.Add("Select..");
        DDLSubject1.AppendDataBoundItems = true;
        // DataSet ds = new DataSet();
        Data.ClassID = Session["Class"].ToString();
        ds = Data.select();
        for (int i = 4; i < ds.Tables[0].Columns.Count; i++)
        {

            DDLSubject1.Items.Add(ds.Tables[0].Rows[0][i].ToString());
        }

        DDLSubject2.Items.Clear();
        DDLSubject2.Items.Add("Select..");
        DDLSubject2.AppendDataBoundItems = true;
        //ClassBo Data = new ClassBo();
        //DataSet ds = new DataSet();
        Data.ClassID =    Session["Class"].ToString();
        ds = Data.select();
        for (int i = 4; i < ds.Tables[0].Columns.Count; i++)
        {

            DDLSubject2.Items.Add(ds.Tables[0].Rows[0][i].ToString());
        }

        DDLSubject3.Items.Clear();
        DDLSubject3.Items.Add("Select..");
        DDLSubject3.AppendDataBoundItems = true;
        //ClassBo Data = new ClassBo();
        //DataSet ds = new DataSet();
        Data.ClassID =    Session["Class"].ToString();
        ds = Data.select();
        for (int i = 4; i < ds.Tables[0].Columns.Count; i++)
        {

            DDLSubject3.Items.Add(ds.Tables[0].Rows[0][i].ToString());
        }

        DDLSubject4.Items.Clear();
        DDLSubject4.Items.Add("Select..");
        DDLSubject4.AppendDataBoundItems = true;
        //ClassBo Data = new ClassBo();
        //DataSet ds = new DataSet();
        Data.ClassID =    Session["Class"].ToString();
        ds = Data.select();
        for (int i = 4; i < ds.Tables[0].Columns.Count; i++)
        {

            DDLSubject4.Items.Add(ds.Tables[0].Rows[0][i].ToString());
        }


        DDLSubject5.Items.Clear();
        DDLSubject5.Items.Add("Select..");
        DDLSubject5.AppendDataBoundItems = true;
        //ClassBo Data = new ClassBo();
        //DataSet ds = new DataSet();
        Data.ClassID =    Session["Class"].ToString();
        ds = Data.select();
        for (int i = 4; i < ds.Tables[0].Columns.Count; i++)
        {

            DDLSubject5.Items.Add(ds.Tables[0].Rows[0][i].ToString());
        }

        DDLSubject6.Items.Clear();
        DDLSubject6.Items.Add("Select..");
        DDLSubject6.AppendDataBoundItems = true;
        //ClassBo Data = new ClassBo();
        //DataSet ds = new DataSet();
        Data.ClassID =    Session["Class"].ToString();
        ds = Data.select();
        for (int i = 4; i < ds.Tables[0].Columns.Count; i++)
        {

            DDLSubject6.Items.Add(ds.Tables[0].Rows[0][i].ToString());
        }

        DDLSubject7.Items.Clear();
        DDLSubject7.Items.Add("Select..");
        DDLSubject7.AppendDataBoundItems = true;
        Data.ClassID =    Session["Class"].ToString();
        ds = Data.select();
        for (int i = 4; i < ds.Tables[0].Columns.Count; i++)
        {

            DDLSubject7.Items.Add(ds.Tables[0].Rows[0][i].ToString());
        }

        DDLSubject8.Items.Clear();
        DDLSubject8.Items.Add("Select..");
        DDLSubject8.AppendDataBoundItems = true;
        Data.ClassID =    Session["Class"].ToString();
        ds = Data.select();
        for (int i = 4; i < ds.Tables[0].Columns.Count; i++)
        {

            DDLSubject8.Items.Add(ds.Tables[0].Rows[0][i].ToString());
        }
    }
    protected void DDLClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        DDLSubject1.Items.Clear();
        DDLSubject1.Items.Add("Select..");
        DDLSubject1.AppendDataBoundItems = true;
       // DataSet ds = new DataSet();
        Data.Class = DDLClass.SelectedItem.Text;
        ds = Data.select();
        for (int i = 4; i < ds.Tables[0].Columns.Count; i++)
        {

            DDLSubject1.Items.Add(ds.Tables[0].Rows[0][i].ToString());
        }

        DDLSubject1.Items.Clear();
        DDLSubject1.Items.Add("Select..");
        DDLSubject1.AppendDataBoundItems = true;
       // DataSet ds = new DataSet();
        Data.Class = DDLClass.SelectedItem.Text;
        ds = Data.select();
        for (int i = 4; i < ds.Tables[0].Columns.Count; i++)
        {

            DDLSubject1.Items.Add(ds.Tables[0].Rows[0][i].ToString());
        }

        DDLSubject2.Items.Clear();
        DDLSubject2.Items.Add("Select..");
        DDLSubject2.AppendDataBoundItems = true;
        //ClassBo Data = new ClassBo();
        //DataSet ds = new DataSet();
        Data.Class = DDLClass.SelectedItem.Text;
        ds = Data.select();
        for (int i = 4; i < ds.Tables[0].Columns.Count; i++)
        {

            DDLSubject2.Items.Add(ds.Tables[0].Rows[0][i].ToString());
        }

        DDLSubject3.Items.Clear();
        DDLSubject3.Items.Add("Select..");
        DDLSubject3.AppendDataBoundItems = true;
        //ClassBo Data = new ClassBo();
        //DataSet ds = new DataSet();
        Data.Class = DDLClass.SelectedItem.Text;
        ds = Data.select();
        for (int i = 4; i < ds.Tables[0].Columns.Count; i++)
        {

            DDLSubject3.Items.Add(ds.Tables[0].Rows[0][i].ToString());
        }

        DDLSubject4.Items.Clear();
        DDLSubject4.Items.Add("Select..");
        DDLSubject4.AppendDataBoundItems = true;
        //ClassBo Data = new ClassBo();
        //DataSet ds = new DataSet();
        Data.Class = DDLClass.SelectedItem.Text;
        ds = Data.select();
        for (int i = 4; i < ds.Tables[0].Columns.Count; i++)
        {

            DDLSubject4.Items.Add(ds.Tables[0].Rows[0][i].ToString());
        }


        DDLSubject5.Items.Clear();
        DDLSubject5.Items.Add("Select..");
        DDLSubject5.AppendDataBoundItems = true;
        //ClassBo Data = new ClassBo();
        //DataSet ds = new DataSet();
        Data.Class = DDLClass.SelectedItem.Text;
        ds = Data.select();
        for (int i = 4; i < ds.Tables[0].Columns.Count; i++)
        {

            DDLSubject5.Items.Add(ds.Tables[0].Rows[0][i].ToString());
        }

        DDLSubject6.Items.Clear();
        DDLSubject6.Items.Add("Select..");
        DDLSubject6.AppendDataBoundItems = true;
        //ClassBo Data = new ClassBo();
        //DataSet ds = new DataSet();
        Data.Class = DDLClass.SelectedItem.Text;
        ds = Data.select();
        for (int i = 4; i < ds.Tables[0].Columns.Count; i++)
        {

            DDLSubject6.Items.Add(ds.Tables[0].Rows[0][i].ToString());
        }

        DDLSubject7.Items.Clear();
        DDLSubject7.Items.Add("Select..");
        DDLSubject7.AppendDataBoundItems = true;
        Data.Class = DDLClass.SelectedItem.Text;
        ds = Data.select();
        for (int i = 4; i < ds.Tables[0].Columns.Count; i++)
        {

            DDLSubject7.Items.Add(ds.Tables[0].Rows[0][i].ToString());
        }

        DDLSubject8.Items.Clear();
        DDLSubject8.Items.Add("Select..");
        DDLSubject8.AppendDataBoundItems = true;
        Data.Class = DDLClass.SelectedItem.Text;
        ds = Data.select();
        for (int i = 4; i < ds.Tables[0].Columns.Count; i++)
        {

            DDLSubject8.Items.Add(ds.Tables[0].Rows[0][i].ToString());
        }

    }
    static TeacherBo Sub = new TeacherBo();
    static DataSet dsSub = new DataSet();
    protected void DDLSubject1_SelectedIndexChanged(object sender, EventArgs e)
    {
        //TeacherBo Sub = new TeacherBo();
        //DataSet dsSub = new DataSet();
        Sub.Subject = DDLSubject1.SelectedItem.Text;
        dsSub = Sub.GetSujectTeacher();

        DDLSubjectTeacher1.Items.Clear();
        DDLSubjectTeacher1.Items.Add("Select..");
        DDLSubjectTeacher1.AppendDataBoundItems = true;
        DDLSubjectTeacher1.DataSource = dsSub;
        DDLSubjectTeacher1.DataTextField = "FullName";
        DDLSubjectTeacher1.DataValueField = "TeacherID";
        DDLSubjectTeacher1.DataBind();

       
    }
    protected void DDLSubject2_SelectedIndexChanged(object sender, EventArgs e)
    {
        Sub.Subject = DDLSubject2.SelectedItem.Text;
        dsSub = Sub.GetSujectTeacher();

        DDLSubjectTeacher2.Items.Clear();
        DDLSubjectTeacher2.Items.Add("Select..");
        DDLSubjectTeacher2.AppendDataBoundItems = true;
        DDLSubjectTeacher2.DataSource = dsSub;
        DDLSubjectTeacher2.DataTextField = "FullName";
        DDLSubjectTeacher2.DataValueField = "TeacherID";
        DDLSubjectTeacher2.DataBind();
    }
    protected void DDLSubject3_SelectedIndexChanged(object sender, EventArgs e)
    {
        Sub.Subject = DDLSubject3.SelectedItem.Text;
        dsSub = Sub.GetSujectTeacher();

        DDLSubjectTeacher3.Items.Clear();
        DDLSubjectTeacher3.Items.Add("Select..");
        DDLSubjectTeacher3.AppendDataBoundItems = true;
        DDLSubjectTeacher3.DataSource = dsSub;
        DDLSubjectTeacher3.DataTextField = "FullName";
        DDLSubjectTeacher3.DataValueField = "TeacherID";
        DDLSubjectTeacher3.DataBind();
    }
    protected void DDLSubject4_SelectedIndexChanged(object sender, EventArgs e)
    {
        Sub.Subject = DDLSubject4.SelectedItem.Text;
        dsSub = Sub.GetSujectTeacher();

        DDLSubjectTeacher8.Items.Clear();
        DDLSubjectTeacher8.Items.Add("Select..");
        DDLSubjectTeacher8.AppendDataBoundItems = true;
        DDLSubjectTeacher8.DataSource = dsSub;
        DDLSubjectTeacher8.DataTextField = "FullName";
        DDLSubjectTeacher8.DataValueField = "TeacherID";
        DDLSubjectTeacher8.DataBind();
    }
    protected void DDLSubject5_SelectedIndexChanged(object sender, EventArgs e)
    {
        Sub.Subject = DDLSubject5.SelectedItem.Text;
        dsSub = Sub.GetSujectTeacher();

        DDLSubjectTeacher4.Items.Clear();
        DDLSubjectTeacher4.Items.Add("Select..");
        DDLSubjectTeacher4.AppendDataBoundItems = true;
        DDLSubjectTeacher4.DataSource = dsSub;
        DDLSubjectTeacher4.DataTextField = "FullName";
        DDLSubjectTeacher4.DataValueField = "TeacherID";
        DDLSubjectTeacher4.DataBind();
    }
    protected void DDLSubject6_SelectedIndexChanged(object sender, EventArgs e)
    {
        Sub.Subject = DDLSubject6.SelectedItem.Text;
        dsSub = Sub.GetSujectTeacher();

        DDLSubjectTeacher5.Items.Clear();
        DDLSubjectTeacher5.Items.Add("Select..");
        DDLSubjectTeacher5.AppendDataBoundItems = true;
        DDLSubjectTeacher5.DataSource = dsSub;
        DDLSubjectTeacher5.DataTextField = "FullName";
        DDLSubjectTeacher5.DataValueField = "TeacherID";
        DDLSubjectTeacher5.DataBind();
    }
    protected void DDLSubject7_SelectedIndexChanged(object sender, EventArgs e)
    {
        Sub.Subject = DDLSubject7.SelectedItem.Text;
        dsSub = Sub.GetSujectTeacher();

        DDLSubjectTeacher6.Items.Clear();
        DDLSubjectTeacher6.Items.Add("Select..");
        DDLSubjectTeacher6.AppendDataBoundItems = true;
        DDLSubjectTeacher6.DataSource = dsSub;
        DDLSubjectTeacher6.DataTextField = "FullName";
        DDLSubjectTeacher6.DataValueField = "TeacherID";
        DDLSubjectTeacher6.DataBind();
    }
    protected void DDLSubject8_SelectedIndexChanged(object sender, EventArgs e)
    {
        Sub.Subject = DDLSubject8.SelectedItem.Text;
        dsSub = Sub.GetSujectTeacher();

        DDLSubjectTeacher7.Items.Clear();
        DDLSubjectTeacher7.Items.Add("Select..");
        DDLSubjectTeacher7.AppendDataBoundItems = true;
        DDLSubjectTeacher7.DataSource = dsSub;
        DDLSubjectTeacher7.DataTextField = "FullName";
        DDLSubjectTeacher7.DataValueField = "TeacherID";
        DDLSubjectTeacher7.DataBind();
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

            TimeTableBO Data = new TimeTableBO();
            Data.Day = DdlDay.SelectedItem.Text;
            Data.Class = DDLClass.SelectedItem.Text;
            Data.ClassID = DDLClass.SelectedValue.ToString();
            Data.I = DDLSubject1.SelectedItem.Text + ',' + DDLSubjectTeacher1.SelectedItem.Text;
            Data.II = DDLSubject2.SelectedItem.Text + ',' + DDLSubjectTeacher2.SelectedItem.Text;
            Data.III = DDLSubject3.SelectedItem.Text + ',' + DDLSubjectTeacher3.SelectedItem.Text;
            Data.IV = DDLSubject4.SelectedItem.Text + ',' + DDLSubjectTeacher8.SelectedItem.Text;
            Data.V = DDLSubject5.SelectedItem.Text + ',' + DDLSubjectTeacher4.SelectedItem.Text;
            Data.VI = DDLSubject6.SelectedItem.Text + ',' + DDLSubjectTeacher5.SelectedItem.Text;
            Data.VII = DDLSubject7.SelectedItem.Text + ',' + DDLSubjectTeacher6.SelectedItem.Text;
            Data.VIII = DDLSubject8.SelectedItem.Text + ',' + DDLSubjectTeacher7.SelectedItem.Text;
            int i = Data.InsertTimeTable();
            if (i > 0)
            {
                Page.RegisterStartupScript("SS", "<script> alert(' Completed Successfully ');</script>");
            }
            else
            {
                Page.RegisterStartupScript("SS", "<script> alert(' Day already Exists ');</script>");

            }

        }
        else if (Request.QueryString["id"] != null)
        {
            TimeTableBO Data = new TimeTableBO();
            Data.Day = LDay.Text;
            Data.Class = LClass.Text;
            Data.ClassID = DDLClass.SelectedValue.ToString();
            Data.I = DDLSubject1.SelectedItem.Text + ',' + DDLSubjectTeacher1.SelectedItem.Text;
            Data.II = DDLSubject2.SelectedItem.Text + ',' + DDLSubjectTeacher2.SelectedItem.Text;
            Data.III = DDLSubject3.SelectedItem.Text + ',' + DDLSubjectTeacher3.SelectedItem.Text;
            Data.IV = DDLSubject4.SelectedItem.Text + ',' + DDLSubjectTeacher8.SelectedItem.Text;
            Data.V = DDLSubject5.SelectedItem.Text + ',' + DDLSubjectTeacher4.SelectedItem.Text;
            Data.VI = DDLSubject6.SelectedItem.Text + ',' + DDLSubjectTeacher5.SelectedItem.Text;
            Data.VII = DDLSubject7.SelectedItem.Text + ',' + DDLSubjectTeacher6.SelectedItem.Text;
            Data.VIII = DDLSubject8.SelectedItem.Text + ',' + DDLSubjectTeacher7.SelectedItem.Text;
            int i = Data.UpdateTimeTable();
            if (i > 0)
            {
                Page.RegisterStartupScript("SS", "<script> alert(' Completed Successfully ');</script>");
            }
            else
            {
                Page.RegisterStartupScript("SS", "<script> alert(' Day already Exists ');</script>");

            }

        }
    }
    protected void Back_Click(object sender, EventArgs e)
    {
        Response.Redirect("View TimeTable.aspx?Back=1");
    }
}
