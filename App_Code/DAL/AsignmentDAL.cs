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
/// Summary description for AsignmentDAL
/// </summary>
public class AsignmentDAL
{
	public AsignmentDAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    static SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
    static DataSet ds = new DataSet();
    internal static int insert(string Class, string Subject, string NameOFasgmt, string SubmissionDate, string FilePath)
    {
        //throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        //throw new Exception("The method or operation is not implemented.");
        SqlCommand cmd = new SqlCommand("sp_Tbl_Assignment", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Class", Class);
        cmd.Parameters.AddWithValue("@Subject", Subject);
        cmd.Parameters.AddWithValue("@NameOFasgmt", NameOFasgmt);
        cmd.Parameters.AddWithValue("@SubmissionDate", SubmissionDate);
        cmd.Parameters.AddWithValue("@FilePath", FilePath);
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

    internal static DataSet SubjectAssignment(string Class, string Subject)
    {
       // throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_Assignment", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@Class", Class);
        da.SelectCommand.Parameters.AddWithValue("@Subject", Subject);
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

    internal static DataSet CladdAssignment(string Class)
    {
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_Assignment", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@Class", Class);
        da.SelectCommand.Parameters.AddWithValue("@Type", "sa");
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

    internal static int Delete(string AsignmentsID)
    {
        cn.Close();
        cn.Open();
        //throw new Exception("The method or operation is not implemented.");
        SqlCommand cmd = new SqlCommand("sp_Tbl_Assignment", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@AsignmentsID", AsignmentsID);
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
