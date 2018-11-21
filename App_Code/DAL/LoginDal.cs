using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

/// <summary>
/// Summary description for LoginDal
/// </summary>
public class LoginDal
{
	public LoginDal()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    static SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
    static DataSet ds = new DataSet();
    internal static DataSet GetData(string UserID, string Password)
    {
       // throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("Sp_Tbl_Admin", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@UserID",UserID);
        da.SelectCommand.Parameters.AddWithValue("@PassWord", Password);
        da.SelectCommand.Parameters.AddWithValue("@Type","s");
        ds.Clear();
        da.Fill(ds);

        try
        {
            return ds;

        }
        catch
        {
            throw;
        }
        


    }

    internal static DataSet Adminlogin(string UserID)
    {
        //throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("Sp_Tbl_Admin", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@UserID", UserID);
        da.SelectCommand.Parameters.AddWithValue("@Type", "g");
        ds.Clear();
        da.Fill(ds);

        try
        {
            return ds;

        }
        catch
        {
            throw;
        }

    }

    internal static int UpadatePassword(string OldPassword,string Password,string UserID)
    {
        //throw new Exception("The method or operation is not implemented.");
        //ds.Clear();
        cn.Close();
        cn.Open();
        SqlDataAdapter da = new SqlDataAdapter("Sp_Tbl_Admin", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@UserID", UserID);
        da.SelectCommand.Parameters.AddWithValue("@OldPassword", OldPassword);
        da.SelectCommand.Parameters.AddWithValue("@Password", Password);
        da.SelectCommand.Parameters.AddWithValue("@Type", "u");
        try
        {
            return da.SelectCommand.ExecuteNonQuery();

        }
        catch
        {
            throw;
        }

    }
}
