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

public partial class AddHoliday : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            if (Request.QueryString["id"] != null)
            {
                
                Submit.Text = "Upadate";
                Back.Visible = true;
                Select();

            }
            else if (Request.QueryString["id"] == null)
            {
              
                Submit.Text = "Submit";
                Back.Visible = false;
            }
        }
    }
    private void Select()
    {
        HolidayBO Data = new HolidayBO();
        DataSet ds = new DataSet();
        Data.HolidayID = Request.QueryString["id"].ToString();
        ds = Data.Select();
        TxtDate.Value = ds.Tables[0].Rows[0]["HolidayDate"].ToString();
        TextBox1.Text = ds.Tables[0].Rows[0]["Title"].ToString();
    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        button();
    }
    private void button()
    {
        if (Request.QueryString["id"] == null)
        {
            HolidayBO Data = new HolidayBO();
            Data.Title = TextBox1.Text;
            Data.HolidayDate = TxtDate.Value;
            int i = Data.Insert();
            if (i > 0)
            {
                Page.RegisterStartupScript("SS", "<script> alert(' Completed Successfully ');</script>");
            }
            else
            {
                Page.RegisterStartupScript("SS", "<script> alert(' Holiday Alreay Exists ');</script>");
            }


        }
        else if (Request.QueryString["id"] != null)
        {
            HolidayBO Data = new HolidayBO();
            Data.HolidayID = Request.QueryString["id"].ToString();
            Data.Title = TextBox1.Text;
            Data.HolidayDate = TxtDate.Value;
            int i = Data.Update();
            if (i > 0)
            {
                Page.RegisterStartupScript("SS", "<script> alert(' Completed Successfully ');</script>");
            }
            else
            {
                Page.RegisterStartupScript("SS", "<script> alert(' Holiday Alreay Exists ');</script>");
            }

        }
    }
    protected void Clear_Click(object sender, EventArgs e)
    {
        try
        {
            foreach (Control ctrl in ((ContentPlaceHolder)Master.FindControl("ContentPlaceHolder1")).Controls)
            {
                TxtDate.Value = string.Empty;
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
        Response.Redirect("ViewHolidays .aspx");
    }
}
