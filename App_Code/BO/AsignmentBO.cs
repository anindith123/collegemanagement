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
/// Summary description for AsignmentBO
/// </summary>
public class AsignmentBO
{
	public AsignmentBO()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private string _AsignmentsID;

    public string AsignmentsID
    {
        get { return _AsignmentsID; }
        set { _AsignmentsID = value; }
    }
    private string _Class;

    public string Class
    {
        get { return _Class; }
        set { _Class = value; }
    }
    private string _Subject;

    public string Subject
    {
        get { return _Subject; }
        set { _Subject = value; }
    }
    private string _NameOFasgmt;

    public string NameOFasgmt
    {
        get { return _NameOFasgmt; }
        set { _NameOFasgmt = value; }
    }
    private string _SubmissionDate;

    public string SubmissionDate
    {
        get { return _SubmissionDate; }
        set { _SubmissionDate = value; }
    }
    private string _FilePath;

    public string FilePath
    {
        get { return _FilePath; }
        set { _FilePath = value; }
    }


    public int Insert()
    {
        //throw new Exception("The method or operation is not implemented.");
        return AsignmentDAL.insert(Class, Subject, NameOFasgmt, SubmissionDate, FilePath);
    }

    public DataSet SubjectAssignment()
    {
        //throw new Exception("The method or operation is not implemented.");
        return AsignmentDAL.SubjectAssignment(Class,Subject);
    }

    public DataSet ClassAssignment()
    {
       // throw new Exception("The method or operation is not implemented.");
        return AsignmentDAL.CladdAssignment(Class);
    }

    public int DeleteAssignment()
    {
        //throw new Exception("The method or operation is not implemented.");
        return AsignmentDAL.Delete(AsignmentsID);
    }
}
