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
/// Summary description for ExamDal
/// </summary>
public class ExamDal
{
	public ExamDal()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    static SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
    static DataSet ds = new DataSet();

    internal static int InsertExam(string Class, string NameOfExam, string EDate, string FilePath)
    {
        cn.Close();
        cn.Open();
        //throw new Exception("The method or operation is not implemented.");
        SqlCommand cmd = new SqlCommand("sp_Tbl_Exam", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Class", Class);
        cmd.Parameters.AddWithValue("@NameOfExam", NameOfExam);
        cmd.Parameters.AddWithValue("@EDate", EDate);
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

    internal static int upDateExam(string EXMID, string Class, string NameOfExam, string EDate, string FilePath)
    {
        cn.Close();
        cn.Open();
        //throw new Exception("The method or operation is not implemented.");
        SqlCommand cmd = new SqlCommand("sp_Tbl_Exam", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@EXMID", EXMID);
        cmd.Parameters.AddWithValue("@Class", Class);
        cmd.Parameters.AddWithValue("@NameOfExam", NameOfExam);
        cmd.Parameters.AddWithValue("@EDate", EDate);
        cmd.Parameters.AddWithValue("@FilePath", FilePath);
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

    internal static DataSet SelectExam(string EXMID)
    {
       // throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_Exam", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@EXMID", EXMID);
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
       // throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_Exam", cn);
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

    internal static int DeleteExam(string EXMID)
    {
        cn.Close();
        cn.Open();
        //throw new Exception("The method or operation is not implemented.");
        SqlCommand cmd = new SqlCommand("sp_Tbl_Exam", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@EXMID", EXMID);
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
