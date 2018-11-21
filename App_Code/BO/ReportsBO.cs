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
/// Summary description for ReportsBO
/// </summary>
public class ReportsBO
{
	public ReportsBO()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private string _StudentID;

    public string StudentID
    {
        get { return _StudentID; }
        set { _StudentID = value; }
    }
	
    private string _MarksID;

    public string MarksID
    {
        get { return _MarksID; }
        set { _MarksID = value; }
    }
    private string _Class;

    public string Class
    {
        get { return _Class; }
        set { _Class = value; }
    }
    private string _Subjects;

    public string Subjects
    {
        get { return _Subjects; }
        set { _Subjects = value; }
    }
    private string _StudentName;

    public string StudentName
    {
        get { return _StudentName; }
        set { _StudentName = value; }
    }
    private string _TypeOfExam;

    public string TypeOfExam
    {
        get { return _TypeOfExam; }
        set { _TypeOfExam = value; }
    }
    private string _Marks;

    public string Marks
    {
        get { return _Marks; }
        set { _Marks = value; }
    }




    public int InsertMarks()
    {
       // throw new Exception("The method or operation is not implemented.");
        return ReportsDAL.InsertMarks(Class, Subjects, StudentName,StudentID, TypeOfExam, Marks);
    }

    public int UpdateMarks()
    {
       // throw new Exception("The method or operation is not implemented.");
        return ReportsDAL.UpdateMarks(MarksID,Class, Subjects, StudentName,StudentID, TypeOfExam, Marks);
    }

    public DataSet Select()
    {
        //throw new Exception("The method or operation is not implemented.");
        return ReportsDAL.Select(MarksID);
    }

    public DataSet GetData()
    {
        //throw new Exception("The method or operation is not implemented.");
        return ReportsDAL.GetData(StudentName,Class);
    }

    public int DeleteReport()
    {
        //throw new Exception("The method or operation is not implemented.");
        return ReportsDAL.DeleteReport(MarksID);
    }

    public DataSet GetStudentReport()
    {
        //throw new Exception("The method or operation is not implemented.");
        return ReportsDAL.GetStudentReports(StudentID);
    }
}
