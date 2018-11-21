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
/// Summary description for StudentDAL
/// </summary>
public class StudentDAL
{
	public StudentDAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    static SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
    static DataSet ds = new DataSet();

    internal static string Insert(object StudentID, string FirstName, string LastName, string UserName, string PassWord, string Class, string DateofBirth, string FathersName, string Address, string Area, string City, string State, string Country, string Zip, object PhoneNo, string Email, string Image, string MoreInfo,string UserType)
    {
       // throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();

        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_Student", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        SqlParameter k = da.SelectCommand.Parameters.Add("@Kumar", SqlDbType.VarChar, 50);
         k.Direction = ParameterDirection.Output;
        da.SelectCommand.Parameters.AddWithValue("@UserType", UserType);
        da.SelectCommand.Parameters.AddWithValue("@FirstName", FirstName);
        da.SelectCommand.Parameters.AddWithValue("@LastName", LastName);
        da.SelectCommand.Parameters.AddWithValue("@Class", Class);
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
        return k.Value.ToString();


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

    internal static int Update(string StundentID, string FirstName, string LastName, string UserName, string PassWord, string Class, string DateofBirth, string FathersName, string Address, string Area, string City, string State, string Country, string Zip, object PhoneNo, string Email, string Image, string MoreInfo)
    {
       // throw new Exception("The method or operation is not implemented.");

        cn.Close();
        cn.Open();
        //throw new Exception("The method or operation is not implemented.");
        SqlCommand cmd = new SqlCommand("sp_Tbl_Student", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@StundentID", StundentID);
        cmd.Parameters.AddWithValue("@FirstName", FirstName);
        cmd.Parameters.AddWithValue("@LastName", LastName);
        cmd.Parameters.AddWithValue("@Class", Class);
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

    internal static DataSet SelectData(string StundentID)
    {
       // throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_Student", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@StundentID", StundentID);
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

    internal static DataSet GetData()
    {
       // throw new Exception("The method or operation is not implemented.");

        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_Student", cn);
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

    internal static int Delete(string StundentID)
    {
       // throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_Student", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@StundentID", StundentID);
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



    internal static DataSet SelectClass(string Class)
    {
       // throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_Students", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@Class", Class);
        da.SelectCommand.Parameters.AddWithValue("@Type", "sc");
        DataSet ds1 = new DataSet();
        da.Fill(ds1);

        try
        {
            return ds1;
        }
        catch
        {
            throw;
        }

    }

    internal static DataSet StudentName(string Class)
    {
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_Student", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@Class", Class);
        da.SelectCommand.Parameters.AddWithValue("@Type", "sn");
        DataSet ds1 = new DataSet();
        da.Fill(ds1);

        try
        {
            return ds1;
        }
        catch
        {
            throw;
        }
    }

    internal static DataSet GetStudent(string StudentID)
    {
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_Student", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@StundentID", StudentID);
        da.SelectCommand.Parameters.AddWithValue("@Type", "g");
        DataSet ds1 = new DataSet();
        da.Fill(ds1);

        try
        {
            return ds1;
        }
        catch
        {
            throw;
        }
    }
}
