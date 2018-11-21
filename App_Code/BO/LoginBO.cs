using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for LoginBO
/// </summary>
public class LoginBO
{
    public LoginBO()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    private string _OldPassword;

    public string OldPassword
    {
        get { return _OldPassword; }
        set { _OldPassword = value; }
    }
	

    private string _UserID;

    public string UserID
    {
        get { return _UserID; }
        set { _UserID = value; }
    }
    private string _Password;

    public string Password
    {
        get { return _Password; }
        set { _Password = value; }
    }



    public DataSet GetData()
    {
        //throw new Exception("The method or operation is not implemented.");
        return LoginDal.GetData(UserID, Password);
    }

    public DataSet AdminLogin()
    {
        //throw new Exception("The method or operation is not implemented.");
        return LoginDal.Adminlogin(UserID);
    }

    public int UpdatePassword()
    {
        //throw new Exception("The method or operation is not implemented.");
        return LoginDal.UpadatePassword(OldPassword,Password,UserID);
    }
}
