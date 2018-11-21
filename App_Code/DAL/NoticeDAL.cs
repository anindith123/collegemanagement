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
/// Summary description for NoticeDAL
/// </summary>
public class NoticeDAL
{
	public NoticeDAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}


    static SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
    internal static int InsertNotice(string Title, string Description, string NoticeFor, string Class)
    {
        cn.Close();
        cn.Open();
        //throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter Da = new SqlDataAdapter("sp_Tbl_AddNotice", cn);
        Da.SelectCommand.CommandType=CommandType.StoredProcedure;
        Da.SelectCommand.Parameters.AddWithValue("@Title",Title);
        Da.SelectCommand.Parameters.AddWithValue("@Description",Description);
        Da.SelectCommand.Parameters.AddWithValue("@NoticeFor",NoticeFor);
        Da.SelectCommand.Parameters.AddWithValue("@Class",Class);
        Da.SelectCommand.Parameters.AddWithValue("@Type","i");
                
        try
        {
            return Da.SelectCommand.ExecuteNonQuery();
        }
        catch
        {
            throw;
        }
        finally
        {

            cn.Close();
        }

    }

    internal static DataSet GetData()
    {
       // throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_AddNotice", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@Type", "s");
        DataSet ds = new DataSet();
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

    internal static int Delete(string NoticeID)
    {
        //throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        //throw new Exception("The method or operation is not implemented.");
        SqlCommand cmd = new SqlCommand("sp_Tbl_AddNotice", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@NoticeID", NoticeID);
         cmd.Parameters.AddWithValue("@Type", "d");
        try
        {
            return cmd.ExecuteNonQuery();
        }
        catch
        {
            throw;
        }
        finally
        {
            cn.Close();
            cmd.Dispose();
        }
    }
}
