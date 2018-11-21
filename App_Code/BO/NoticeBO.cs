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
/// Summary description for NoticeBO
/// </summary>
public class NoticeBO
{
    public NoticeBO()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    private string _Class;

    public string Class
    {
        get { return _Class; }
        set { _Class = value; }
    }
	
    private string _NoticeID;

    public string NoticeID
    {
        get { return _NoticeID; }
        set { _NoticeID = value; }
    }
    private string _Title;

    public string Title
    {
        get { return _Title; }
        set { _Title = value; }
    }
    private string _Description;

    public string Description
    {
        get { return _Description; }
        set { _Description = value; }
    }
    private string _NoticeFor;

    public string NoticeFor
    {
        get { return _NoticeFor; }
        set { _NoticeFor = value; }
    }
    private string _NDate;

    public string NDate
    {
        get { return _NDate; }
        set { _NDate = value; }
    }


    public int InsertNotice()
    {
       // throw new Exception("The method or operation is not implemented.");
        return NoticeDAL.InsertNotice(Title, Description, NoticeFor, Class);
    }

    public DataSet GetData()
    {
        //throw new Exception("The method or operation is not implemented.");
        return NoticeDAL.GetData();
    
    
    
    
    
    }



    public int Delete()
    {
        //throw new Exception("The method or operation is not implemented.");
        return NoticeDAL.Delete(NoticeID);
    }
}
