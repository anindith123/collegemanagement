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
/// Summary description for TeacherDAL
/// </summary>
public class TeacherDAL
{
	public TeacherDAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    static SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
   static  DataSet ds = new DataSet();
   
    internal static string Insert(string UserType,string FirstName, string LastName, string Abbreviation, string ClassTeacher, string DateofBirth, string FathersName, string Address, string Area, string City, string State, string Country, string Zip, string PhoneNo, string Email, string Image, string MoreInfo)
    {
        cn.Close();
        cn.Open();
       
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_Teacher", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        SqlParameter P = da.SelectCommand.Parameters.Add("@Kumar", SqlDbType.VarChar, 50);
        P.Direction = ParameterDirection.Output;
        da.SelectCommand.Parameters.AddWithValue("@UserType", UserType);
        da.SelectCommand.Parameters.AddWithValue("@FirstName", FirstName);
        da.SelectCommand.Parameters.AddWithValue("@LastName", LastName);
        da.SelectCommand.Parameters.AddWithValue("@Abbreviation", Abbreviation);
        da.SelectCommand.Parameters.AddWithValue("@ClassTeacher", ClassTeacher);
        da.SelectCommand.Parameters.AddWithValue("@DateofBirth", DateofBirth);
        da.SelectCommand.Parameters.AddWithValue("@FathersName", FathersName);
        da.SelectCommand.Parameters.AddWithValue("@Address", Address);
        da.SelectCommand.Parameters.AddWithValue("@Area", Area);
        da.SelectCommand.Parameters.AddWithValue("@City", City);
        da.SelectCommand.Parameters.AddWithValue("@State", State);
        da.SelectCommand.Parameters.AddWithValue("@Country", Country);
        da.SelectCommand.Parameters.AddWithValue("@Zip", Zip);
        da.SelectCommand.Parameters.AddWithValue("@PhoneNo", PhoneNo);
        da.SelectCommand.Parameters.AddWithValue("@Email", Email);
        da.SelectCommand.Parameters.AddWithValue("@Image", Image);
        da.SelectCommand.Parameters.AddWithValue("@MoreInfo", MoreInfo);
        da.SelectCommand.Parameters.AddWithValue("@Type", "i");
        da.SelectCommand.ExecuteNonQuery();
        return P.Value.ToString();
       
      
        try
        {
            return "";
        }
        catch
        {
            throw;
        }
        finally
        {
           cn.Close();
            //cmd.Dispose();
        }
        
    }

    internal static int Update(string TeacherID, string FirstName, string LastName, string Abbreviation, string ClassTeacher, string DateofBirth, string FathersName, string Address, string Area, string City, string State, string Country, string Zip, string PhoneNo, string Email, string Image, string MoreInfo)
    {
        //throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        //throw new Exception("The method or operation is not implemented.");
        SqlCommand cmd = new SqlCommand("sp_Tbl_Teacher", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@TeacherID", TeacherID);
        cmd.Parameters.AddWithValue("@FirstName", FirstName);
        cmd.Parameters.AddWithValue("@LastName", LastName);
        cmd.Parameters.AddWithValue("@Abbreviation", Abbreviation);
        cmd.Parameters.AddWithValue("@ClassTeacher", ClassTeacher);
        cmd.Parameters.AddWithValue("@DateofBirth", DateofBirth);
        cmd.Parameters.AddWithValue("@FathersName", FathersName);
        cmd.Parameters.AddWithValue("@Address", Address);
        cmd.Parameters.AddWithValue("@Area", Area);
        cmd.Parameters.AddWithValue("@City", City);
        cmd.Parameters.AddWithValue("@State", State);
        cmd.Parameters.AddWithValue("@Country", Country);
        cmd.Parameters.AddWithValue("@Zip", Zip);
        cmd.Parameters.AddWithValue("@PhoneNo", PhoneNo);
        cmd.Parameters.AddWithValue("@Email", Email);
        cmd.Parameters.AddWithValue("@Image", Image);
        cmd.Parameters.AddWithValue("@MoreInfo", MoreInfo);
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
       // throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_Teacher", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
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

    internal static int Delete(string TeacherID)
    {
        //throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_Teacher", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@TeacherID", TeacherID);
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

    internal static DataSet SelectData(string TeacherID)
    {
        //throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_Teacher", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@TeacherID", TeacherID);
        cmd.Parameters.AddWithValue("@Type", "g");
        SqlDataAdapter da = new SqlDataAdapter(cmd);
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
        finally
        {
            cn.Close();
            cmd.Dispose();
        }
    }

    internal static DataSet GetSubjectTeach(string Subject)
    {
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_Teacher", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@Subject", Subject);
        da.SelectCommand.Parameters.AddWithValue("@Type", "z");
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
