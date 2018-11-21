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
/// Summary description for MSGDAL
/// </summary>
public class MSGDAL
{
	public MSGDAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    static SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
    static DataSet ds = new DataSet();

    internal static DataSet GetDataMSG()
    {
        //throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_MSG", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
       
        da.SelectCommand.Parameters.AddWithValue("@Type", "as");
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

    internal static int InsertMsgAdmin(string From, string Message, string SenderType, string UserType,string Class,string UserID)
    {
        cn.Close();
        cn.Open();
        //throw new Exception("The method or operation is not implemented.");
        SqlCommand cmd = new SqlCommand("sp_Tbl_MSG", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@MFrom", From);
        cmd.Parameters.AddWithValue("@Message", Message);
        cmd.Parameters.AddWithValue("@SenderType", SenderType);
        cmd.Parameters.AddWithValue("@UserType", UserType);
        cmd.Parameters.AddWithValue("@Class", Class);
        cmd.Parameters.AddWithValue("@UserID", UserID);
        cmd.Parameters.AddWithValue("@Type", "i");
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

    internal static int DeleteMSGAdmin(string MSGID)
    {
        cn.Close();
        cn.Open();
        //throw new Exception("The method or operation is not implemented.");
        SqlCommand cmd = new SqlCommand("sp_Tbl_MSG", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@MSGID", MSGID);
        cmd.Parameters.AddWithValue("@Type", "da");
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

    internal static DataSet MSGTeach(string UserID)
    {
        //throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_MSG", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@UserID", UserID);
        da.SelectCommand.Parameters.AddWithValue("@Type", "st");
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

    internal static DataSet MSGStudent(string UserID)
    {
       // throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_MSG", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@UserID", UserID);
        da.SelectCommand.Parameters.AddWithValue("@Type", "ss");
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

    internal static DataSet GetDataStudentMSG(string UserID)
    {
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_MSG", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@UserID", UserID);
        da.SelectCommand.Parameters.AddWithValue("@Type", "ss");
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
}
