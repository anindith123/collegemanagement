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
/// Summary description for MSGBO
/// </summary>
public class MSGBO
{
	public MSGBO()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private string _UserID;

    public string UserID
    {
        get { return _UserID; }
        set { _UserID = value; }
    }
	
    private string _Class;

    public string Class
    {
        get { return _Class; }
        set { _Class = value; }
    }
	
    private string _MSGID;

    public string MSGID
    {
        get { return _MSGID; }
        set { _MSGID = value; }
    }
    private string _From;

    public string From
    {
        get { return _From; }
        set { _From = value; }
    }
    private string _Message;

    public string Message
    {
        get { return _Message; }
        set { _Message = value; }
    }
   
    private string _SenderType;

    public string SenderType
    {
        get { return _SenderType; }
        set { _SenderType = value; }
    }
    private string _UserType;

    public string UserType
    {
        get { return _UserType; }
        set { _UserType = value; }
    }
	

    public DataSet MSGGetData()
    {
        // throw new Exception("The method or operation is not implemented.");
        return MSGDAL.GetDataMSG();
    }

    public int InsertMSGAdmin()
    {
       // throw new Exception("The method or operation is not implemented.");
        return MSGDAL.InsertMsgAdmin(From, Message, SenderType, UserType,Class,UserID);
    }

    public int DeleteMSGAdmin()
    {
        //throw new Exception("The method or operation is not implemented.");
        return MSGDAL.DeleteMSGAdmin(MSGID);
    }

    public DataSet MSGGetTEach()
    {
       // throw new Exception("The method or operation is not implemented.");
        return MSGDAL.MSGTeach(UserID);
    }

    public DataSet MSGGetStudent()
    {
        //throw new Exception("The method or operation is not implemented.");
        return MSGDAL.MSGStudent(UserID);
    }

    public DataSet GtDataStudentMSG()
    {
        //throw new Exception("The method or operation is not implemented.");
        return MSGDAL.GetDataStudentMSG(UserID);
    }
}
