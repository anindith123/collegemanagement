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
/// Summary description for ClassBo
/// </summary>
public class ClassBo
{
	public ClassBo()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private string _ClassID;

    public string ClassID
    {
        get { return _ClassID; }
        set { _ClassID = value; }
    }
    private string _Class;

    public string Class
    {
        get { return _Class; }
        set { _Class = value; }
    }
    private string _ClassTeacher;

    public string ClassTeacher
    {
        get { return _ClassTeacher; }
        set { _ClassTeacher = value; }
    }
    private string _Subject1;

    public string Subject1
    {
        get { return _Subject1; }
        set { _Subject1 = value; }
    }
    private string _Subject2;

    public string Subject2
    {
        get { return _Subject2; }
        set { _Subject2 = value; }
    }
    private string _Subject3;

    public string Subject3
    {
        get { return _Subject3; }
        set { _Subject3 = value; }
    }
    private string _Subject4;

    public string Subject4
    {
        get { return _Subject4; }
        set { _Subject4 = value; }
    }
    private string _Subject5;

    public string Subject5
    {
        get { return _Subject5; }
        set { _Subject5 = value; }
    }
	
    private string _Subject6;

    public string Subject6
    {
        get { return _Subject6; }
        set { _Subject6 = value; }
    }
    private string _Subject7;

    public string Subject7
    {
        get { return _Subject7; }
        set { _Subject7 = value; }
    }
    private string _Subject8;

    public string Subject8
    {
        get { return _Subject8; }
        set { _Subject8 = value; }
    }
	
    



    public int InsertClass()
    {
       // throw new Exception("The method or operation is not implemented.");
        return ClassDAl.InsertClass(Class,ClassTeacher);
    }

    public int Upadate()
    {
        //throw new Exception("The method or operation is not implemented.");
        return ClassDAl.Update(ClassID, Class, ClassTeacher);
    }

    public DataSet GetData()
    {
        //throw new Exception("The method or operation is not implemented.");
        return ClassDAl.GetData();

    }

    public int Delete()
    {
        //throw new Exception("The method or operation is not implemented.");
        return ClassDAl.Delete(ClassID);
    }

    public DataSet select()
    {
        //throw new Exception("The method or operation is not implemented.");
        return ClassDAl.select(Class);
    }



    public int InsertSubject()
    {
        //throw new Exception("The method or operation is not implemented.");
        return ClassDAl.InsertSubject(ClassID,Class, Subject1, Subject2, Subject3, Subject4, Subject5, Subject6, Subject7, Subject8);

    }

    public int UpdateSubject()
    {
       // throw new Exception("The method or operation is not implemented.");
        return ClassDAl.UpdateSubject(ClassID, Class, Subject1, Subject2, Subject3, Subject4, Subject5, Subject6, Subject7, Subject8);
    }

    public DataSet GetDataSelect()
    {
       // throw new Exception("The method or operation is not implemented.");
        return ClassDAl.GetDataSelect(ClassID);
    }

    public DataSet StudentName()
    {
        //throw new Exception("The method or operation is not implemented.");
        return StudentDAL.StudentName(Class);
    }

    public DataSet selectA()
    {
        //throw new Exception("The method or operation is not implemented.");
        return ClassDAl.SelectA(ClassID);
    }

   
}
