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
/// Summary description for ExamBO
/// </summary>
public class ExamBO
{
	public ExamBO()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private string _EXMID;

    public string EXMID
    {
        get { return _EXMID; }
        set { _EXMID = value; }
    }
    private string _Class;

    public string Class
    {
        get { return _Class; }
        set { _Class = value; }
    }
    private string _NameOfExam;

    public string NameOfExam
    {
        get { return _NameOfExam; }
        set { _NameOfExam = value; }
    }
    private string _EDate;

    public string EDate
    {
        get { return _EDate; }
        set { _EDate = value; }
    }
    private string _FilePath;

    public string FilePath
    {
        get { return _FilePath; }
        set { _FilePath = value; }
    }


    public int InsertExam()
    {
        //throw new Exception("The method or operation is not implemented.");
        return ExamDal.InsertExam(Class, NameOfExam, EDate, FilePath);
    }

    public int UpdateExam()
    {
       // throw new Exception("The method or operation is not implemented.");
        return ExamDal.upDateExam(EXMID, Class, NameOfExam, EDate, FilePath);
    }

    public DataSet SelectExam()
    {
       // throw new Exception("The method or operation is not implemented.");
        return ExamDal.SelectExam(EXMID);
    }

    public DataSet GetData()
    {
        //throw new Exception("The method or operation is not implemented.");
        return ExamDal.GetData(Class);
    }

    public int DeleteExam()
    {
        //throw new Exception("The method or operation is not implemented.");
        return ExamDal.DeleteExam(EXMID);
    }
}
