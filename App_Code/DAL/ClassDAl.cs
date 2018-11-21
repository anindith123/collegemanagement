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
/// Summary description for ClassDAl
/// </summary>
public class ClassDAl
{
	public ClassDAl()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    static SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
    static DataSet ds = new DataSet();
    internal static int InsertClass(string Class, string ClassTeacher)
    {
        cn.Close();
        cn.Open();
        //throw new Exception("The method or operation is not implemented.");
        SqlCommand cmd = new SqlCommand("sp_Tbl_Class", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Class", Class);
        cmd.Parameters.AddWithValue("@ClassTeacher", ClassTeacher);
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

    internal static DataSet GetData()
    {
       // throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_Class", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        //da.SelectCommand.Parameters.AddWithValue("@ClassID", ClassID);
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

   
    internal static int Update(string ClassID, string Class, string ClassTeacher)
    {
       // throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        //throw new Exception("The method or operation is not implemented.");
        SqlCommand cmd = new SqlCommand("sp_Tbl_Class", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ClassID", ClassID);
        cmd.Parameters.AddWithValue("@Class", Class);
        cmd.Parameters.AddWithValue("@ClassTeacher", ClassTeacher);
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

    internal static int Delete(string ClassID)
    {
        //throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        //throw new Exception("The method or operation is not implemented.");
        SqlCommand cmd = new SqlCommand("sp_Tbl_Class", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ClassID", ClassID);
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

    internal static DataSet select(string Class)
    {
       // throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_Class", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
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



    internal static int InsertSubject(string ClassID,string Class, string Subject1, string Subject2, string Subject3, string Subject4, string Subject5, string Subject6, string Subject7, string Subject8)
    {
       // throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        //throw new Exception("The method or operation is not implemented.");
        SqlCommand cmd = new SqlCommand("sp_Tbl_Class", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ClassID", ClassID);
        cmd.Parameters.AddWithValue("@Class", Class);
        cmd.Parameters.AddWithValue("@Subject1", Subject1);
        cmd.Parameters.AddWithValue("@Subject2", Subject2);
        cmd.Parameters.AddWithValue("@Subject3", Subject3);
        cmd.Parameters.AddWithValue("@Subject4", Subject4);
        cmd.Parameters.AddWithValue("@Subject5", Subject5);
        cmd.Parameters.AddWithValue("@Subject6", Subject6);
        cmd.Parameters.AddWithValue("@Subject7", Subject7);
        cmd.Parameters.AddWithValue("@Subject8", Subject8);
        cmd.Parameters.AddWithValue("@Type", "is");
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

    internal static int UpdateSubject(string ClassID, string Class, string Subject1, string Subject2, string Subject3, string Subject4, string Subject5, string Subject6, string Subject7, string Subject8)
    {
       // throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        //throw new Exception("The method or operation is not implemented.");
        SqlCommand cmd = new SqlCommand("sp_Tbl_Class", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ClassID", ClassID);
        cmd.Parameters.AddWithValue("@Class", Class);
        cmd.Parameters.AddWithValue("@Subject1", Subject1);
        cmd.Parameters.AddWithValue("@Subject2", Subject2);
        cmd.Parameters.AddWithValue("@Subject3", Subject3);
        cmd.Parameters.AddWithValue("@Subject4", Subject4);
        cmd.Parameters.AddWithValue("@Subject5", Subject5);
        cmd.Parameters.AddWithValue("@Subject6", Subject6);
        cmd.Parameters.AddWithValue("@Subject7", Subject7);
        cmd.Parameters.AddWithValue("@Subject8", Subject8);
        cmd.Parameters.AddWithValue("@Type", "us");
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

    internal static DataSet GetDataSelect(string ClassID)
    {
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_Class", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@ClassID", ClassID);
        da.SelectCommand.Parameters.AddWithValue("@Type", "cc");
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

    internal static DataSet SelectA(string ClassID)
    {
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_Class", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@ClassID", ClassID);
        da.SelectCommand.Parameters.AddWithValue("@Type", "cc");
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
