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
/// Summary description for TimeTableBO
/// </summary>
public class TimeTableBO
{
	public TimeTableBO()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private string _Teacher;

    public string Teacher
    {
        get { return _Teacher; }
        set { _Teacher = value; }
    }
	
    private int _ID;

    public int ID
    {
        get { return _ID; }
        set { _ID = value; }
    }
	
    private string _ClassID;

	public string ClassID
	{
		get { return _ClassID;}
		set { _ClassID = value;}
	}
	
    private string _Day;

	public string Day
	{
		get { return _Day;}
		set { _Day = value;}
	}
	
    private string _TBID;

    public string TBID
    {
        get { return _TBID; }
        set { _TBID = value; }
    }
    private string _Class;

    public string Class
    {
        get { return _Class; }
        set { _Class = value; }
    }
	private string _I;

	public string I
	{
		get { return _I;}
		set { _I = value;}
	}
	private string _II;

	public string II
	{
		get { return _II;}
		set { _II = value;}
	}
	private string _III;

	public string III
	{
		get { return _III;}
		set { _III = value;}
	}
	private string _IV;

	public string IV
	{
		get { return _IV;}
		set { _IV = value;}
	}
	private string _V;

	public string V
	{
		get { return _V;}
		set { _V = value;}
	}
    private string _VI;

	public string VI
	{
		get { return _VI;}
		set { _VI = value;}
	}
	private string _VII;

	public string VII
	{
		get { return _VII;}
		set { _VII = value;}
	}
	private string _VIII;

	public string VIII
	{
		get { return _VIII;}
		set { _VIII = value;}
	}




    public int InsertTimeTable()
    {
       // throw new Exception("The method or operation is not implemented.");
        return TimeTableDAL.InsertTimeTable(ClassID, Class, Day, I, II, III, IV, V, VI, VII, VIII);
    }

    public int UpdateTimeTable()
    {
        //throw new Exception("The method or operation is not implemented.");
        return TimeTableDAL.UpdateTimeTable(ClassID, Class, Day, I, II, III, IV, V, VI, VII, VIII);
    }

    public DataSet SelectTimeTable()
    {
        //throw new Exception("The method or operation is not implemented.");
        return TimeTableDAL.SelectTimeTable(Class,Day);
    }

    public DataSet GetData()
    {
        //throw new Exception("The method or operation is not implemented.");
        return TimeTableDAL.GetData(Class);
    }

    public DataSet GetDataTeacherTTb()
    {
        //throw new Exception("The method or operation is not implemented.");
        return TimeTableDAL.GetadataTeachTTB(Teacher);
    }
}
