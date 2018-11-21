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
/// Summary description for StudentBo
/// </summary>
public class StudentBo
{
	public StudentBo()
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
	
    private string _UserType;

    public string UserType
    {
        get { return _UserType; }
        set { _UserType = value; }
    }
	
    private string _StundentID;

    public string StundentID
    {
        get { return _StundentID; }
        set { _StundentID = value; }
    }
    private string _FirstName;

    public string FirstName
    {
        get { return _FirstName; }
        set { _FirstName = value; }
    }
    private string _LastName;

    public string LastName
    {
        get { return _LastName; }
        set { _LastName = value; }
    }
    private string _FullName;

    public string FullName
    {
        get { return _FullName; }
        set { _FullName = value; }
    }
    private string _UserName;

    public string UserName
    {
        get { return _UserName; }
        set { _UserName = value; }
    }
    private string _PassWord;

    public string PassWord
    {
        get { return _PassWord; }
        set { _PassWord = value; }
    }
    private string _RegistrationID;

    public string RegistrationID
    {
        get { return _RegistrationID; }
        set { _RegistrationID = value; }
    }
    private string _Class;

    public string Class
    {
        get { return _Class; }
        set { _Class = value; }
    }
    private string _DateofBirth;

    public string DateofBirth
    {
        get { return _DateofBirth; }
        set { _DateofBirth = value; }
    }
    private string _FathersName;

    public string FathersName
    {
        get { return _FathersName; }
        set { _FathersName = value; }
    }
    private string _Address;

    public string Address
    {
        get { return _Address; }
        set { _Address = value; }
    }
    private string _Area;

    public string Area
    {
        get { return _Area; }
        set { _Area = value; }
    }
    private string _City;

    public string City
    {
        get { return _City; }
        set { _City = value; }
    }
    private string _State;

    public string State
    {
        get { return _State; }
        set { _State = value; }
    }

    private string _Country;

    public string Country
    {
        get { return _Country; }
        set { _Country = value; }
    }
    private string _Zip;

    public string Zip
    {
        get { return _Zip; }
        set { _Zip = value; }
    }
    private string _Email;

    public string Email
    {
        get { return _Email; }
        set { _Email = value; }
    }
    private string _Image;

    public string Image
    {
        get { return _Image; }
        set { _Image = value; }
    }
    private string _MoreInfo;

    public string MoreInfo
    {
        get { return _MoreInfo; }
        set { _MoreInfo = value; }
    }
    private string _PhoneNo;

    public string PhoneNo
    {
        get { return _PhoneNo; }
        set { _PhoneNo = value; }
    }

	








    public string Insert()
    {
        //throw new Exception("The method or operation is not implemented.");
        return StudentDAL.Insert(StudentID, FirstName, LastName, UserName, PassWord, Class, DateofBirth, FathersName, Address, Area, City, State, Country, Zip, PhoneNo, Email, Image, MoreInfo, UserType);
    }

    public int Update()
    {
        //throw new Exception("The method or operation is not implemented.");
        return StudentDAL.Update(StundentID, FirstName, LastName, UserName, PassWord, Class, DateofBirth, FathersName, Address, Area, City, State, Country, Zip, PhoneNo, Email, Image, MoreInfo);
    }

    public DataSet SelectData()
    {
        //throw new Exception("The method or operation is not implemented.");
        return StudentDAL.SelectData(StundentID);
    }

    public DataSet GetData()
    {
       // throw new Exception("The method or operation is not implemented.");
        return StudentDAL.GetData();
    }

    public int Delete()
    {
       // throw new Exception("The method or operation is not implemented.");
        return StudentDAL.Delete(StundentID);
    }

    public DataSet select()
    {
        //throw new Exception("The method or operation is not implemented.");
        return StudentDAL.SelectClass(Class);
    }

    public DataSet StudentName()
    {
        //throw new Exception("The method or operation is not implemented.");
        return StudentDAL.StudentName(Class);

    }



    public DataSet GetStudent()
    {
        //throw new Exception("The method or operation is not implemented.");
        return StudentDAL.GetStudent(StudentID);
    }

   
}
