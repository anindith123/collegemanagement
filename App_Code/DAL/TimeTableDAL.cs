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
/// Summary description for TimeTableDAL
/// </summary>
public class TimeTableDAL
{
	public TimeTableDAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    static SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
    static DataSet ds = new DataSet();

    internal static int InsertTimeTable(string ClassID, string Class, object Day, string I, string II, string III, string IV, string V, string VI, string VII, string VIII)
    {
        cn.Close();
        cn.Open();
        //throw new Exception("The method or operation is not implemented.");
        SqlCommand cmd = new SqlCommand("sp_Tbl_TimeTable", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ClassID", ClassID);
        cmd.Parameters.AddWithValue("@Class", Class);
        cmd.Parameters.AddWithValue("@Days", Day);
        cmd.Parameters.AddWithValue("@I", I);
        cmd.Parameters.AddWithValue("@II", II);
        cmd.Parameters.AddWithValue("@III", III);
        cmd.Parameters.AddWithValue("@IV", IV);
        cmd.Parameters.AddWithValue("@V", V);
        cmd.Parameters.AddWithValue("@VI", VI);
        cmd.Parameters.AddWithValue("@VII", VII);
        cmd.Parameters.AddWithValue("@VIII", VIII);
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

    internal static int UpdateTimeTable(string ClassID, string Class, string Day, string I, string II, string III, string IV, string V, string VI, string VII, string VIII)
    {
        //throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        //throw new Exception("The method or operation is not implemented.");
        SqlCommand cmd = new SqlCommand("sp_Tbl_TimeTable", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ClassID", ClassID);
        cmd.Parameters.AddWithValue("@Class", Class);
        cmd.Parameters.AddWithValue("@Days", Day);
        cmd.Parameters.AddWithValue("@I", I);
        cmd.Parameters.AddWithValue("@II", II);
        cmd.Parameters.AddWithValue("@III", III);
        cmd.Parameters.AddWithValue("@IV", IV);
        cmd.Parameters.AddWithValue("@V", V);
        cmd.Parameters.AddWithValue("@VI", VI);
        cmd.Parameters.AddWithValue("@VII", VII);
        cmd.Parameters.AddWithValue("@VIII", VIII);
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

    internal static DataSet SelectTimeTable(string Class, string Day)
    {
       // throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_TimeTable", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@Class", Class);
        da.SelectCommand.Parameters.AddWithValue("@Days", Day);
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

    internal static DataSet GetData(string Class)
    {
        //throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_TimeTable", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@Class", Class);
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

   
    internal static DataSet GetadataTeachTTB(string Teacher)
    {
       // throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_TimeTable", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@Teacher", Teacher);
        da.SelectCommand.Parameters.AddWithValue("@Type", "tt");
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
