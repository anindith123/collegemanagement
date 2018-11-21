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
/// Summary description for ReportsDAL
/// </summary>
public class ReportsDAL
{
	public ReportsDAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    static SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
    static DataSet ds = new DataSet();

    internal static int InsertMarks(string Class, string Subjects, string StudentName, string StudentID,string TypeOfExam, string Marks)
    {
        cn.Close();
        cn.Open();
        //throw new Exception("The method or operation is not implemented.");
        SqlCommand cmd = new SqlCommand("sp_Tbl_Marks", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Class", Class);
        cmd.Parameters.AddWithValue("@Subjects", Subjects);
        cmd.Parameters.AddWithValue("@StudentName", StudentName);
        cmd.Parameters.AddWithValue("@StudentID", StudentID);
        cmd.Parameters.AddWithValue("@TypeOfExam", TypeOfExam);
        cmd.Parameters.AddWithValue("@Marks", Marks);
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

    internal static int UpdateMarks(string MarksID, string Class, string Subjects, string StudentName, string StudentID, string TypeOfExam, string Marks)
    {
        cn.Close();
        cn.Open();
        //throw new Exception("The method or operation is not implemented.");
        SqlCommand cmd = new SqlCommand("sp_Tbl_Marks", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@MarksID", MarksID);
        cmd.Parameters.AddWithValue("@Class", Class);
        cmd.Parameters.AddWithValue("@Subjects", Subjects);
        cmd.Parameters.AddWithValue("@StudentName", StudentName);
        cmd.Parameters.AddWithValue("@StudentID", StudentID);
        cmd.Parameters.AddWithValue("@TypeOfExam", TypeOfExam);
        cmd.Parameters.AddWithValue("@Marks", Marks);
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

    internal static DataSet Select(string MarksID)
    {
        //throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_Marks", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@MarksID", MarksID);
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

    internal static DataSet GetData(string StudentName,string Class)
    {
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_Marks", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@StudentName", StudentName);
        da.SelectCommand.Parameters.AddWithValue("@Class", Class);
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

    internal static int DeleteReport(string MarksID)
    {
        cn.Close();
        cn.Open();
        //throw new Exception("The method or operation is not implemented.");
        SqlCommand cmd = new SqlCommand("sp_Tbl_Marks", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@MarksID", MarksID);
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

    internal static DataSet GetStudentReports(string StudentID)
    {
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_Marks", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@StudentID", StudentID);
        da.SelectCommand.Parameters.AddWithValue("@Type", "sr");
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
