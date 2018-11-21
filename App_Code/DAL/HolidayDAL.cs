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
/// Summary description for HolidayDAL
/// </summary>
public class HolidayDAL
{
	public HolidayDAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    static SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
    static DataSet ds = new DataSet();

    internal static int Insert(string Title, string HolidayDate)
    {
        //throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        //throw new Exception("The method or operation is not implemented.");
        SqlCommand cmd = new SqlCommand("sp_Tbl_Holiday", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Title", Title);
        cmd.Parameters.AddWithValue("@HolidayDate", HolidayDate);
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

    internal static int Update(string HolidayID, string Title, string HolidayDate)
    {
        //throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        //throw new Exception("The method or operation is not implemented.");
        SqlCommand cmd = new SqlCommand("sp_Tbl_Holiday", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@HolidayID", HolidayID);
        cmd.Parameters.AddWithValue("@Title", Title);
        cmd.Parameters.AddWithValue("@HolidayDate", HolidayDate);
        cmd.Parameters.AddWithValue("@Type", "u");
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

    internal static DataSet GetData()
    {
        //throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_Holiday", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@Type", "c");
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

    internal static int Delete(string HolidayID)
    {
        cn.Close();
        cn.Open();
        //throw new Exception("The method or operation is not implemented.");
        SqlCommand cmd = new SqlCommand("sp_Tbl_Holiday", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@HolidayID", HolidayID);
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

    internal static DataSet Select(string HolidayID)
    {
       // throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_Holiday", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@HolidayID", HolidayID);
        da.SelectCommand.Parameters.AddWithValue("@Type", "s");
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

    internal static DataSet Password()
    {
    //  throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("Sp_Tbl_Admin", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        //da.SelectCommand.Parameters.AddWithValue("@HolidayID", HolidayID);
        da.SelectCommand.Parameters.AddWithValue("@Type", "p");
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

    internal static DataSet studentPwd()
    {
        SqlDataAdapter da = new SqlDataAdapter("Sp_Tbl_Admin", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        
        da.SelectCommand.Parameters.AddWithValue("@Type", "sp");
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
