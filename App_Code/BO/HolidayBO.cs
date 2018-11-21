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
/// Summary description for HolidayBO
/// </summary>
public class HolidayBO
{
	public HolidayBO()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private string _HolidayID;

    public string HolidayID
    {
        get { return _HolidayID; }
        set { _HolidayID = value; }
    }
    private string _Title;

    public string Title
    {
        get { return _Title; }
        set { _Title = value; }
    }
    private string _HolidayDate;

    public string HolidayDate
    {
        get { return _HolidayDate; }
        set { _HolidayDate = value; }
    }



    public int Insert()
    {
        //throw new Exception("The method or operation is not implemented.");
        return HolidayDAL.Insert(Title, HolidayDate);
    }

    public int Update()
    {
        //throw new Exception("The method or operation is not implemented.");
        return HolidayDAL.Update(HolidayID, Title, HolidayDate);
    }

    public DataSet GetData()
    {
       // throw new Exception("The method or operation is not implemented.");
        return HolidayDAL.GetData();
    }

    public int Delete()
    {
       // throw new Exception("The method or operation is not implemented.");
        return HolidayDAL.Delete(HolidayID);
    }

    public DataSet Select()
    {
       // throw new Exception("The method or operation is not implemented.");
        return HolidayDAL.Select(HolidayID);
    }

    public DataSet Password()
    {
        //throw new Exception("The method or operation is not implemented.");
        return HolidayDAL.Password();
    }

    public DataSet StudentPassword()
    {
        //throw new Exception("The method or operation is not implemented.");
        return HolidayDAL.studentPwd();
    }
}
