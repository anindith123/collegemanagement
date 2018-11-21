<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true"
    CodeFile="Student.aspx.cs" Inherits="Admin_Student" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <script language="javascript" type="text/javascript">
  function check()
   {
             var TxtFirstName=document.getElementById("<%=TxtFirstName.ClientID%>").value;
            if(TxtFirstName=="")
            {
                 alert("FirstName Required");
                 document.getElementById("<%=TxtFirstName.ClientID%>").focus();
                 return false;
            }
            if(TxtFirstName!="")
            {
                var name=/^[a-zA-Z .]+$/;
                if(!TxtFirstName.match(name))
                {
                        document.getElementById("<%=TxtFirstName.ClientID%>").focus();
                        alert ("FirstName Should be Character");
                        return false;
                }
            }
                var TxtLastName=document.getElementById("<%=TxtLastName.ClientID%>").value;
            if(TxtLastName=="")
            {
                   document.getElementById("<%=TxtLastName.ClientID%>").focus();
                   alert("LastName Name Required");
                   return false;
            }
            if(TxtLastName!="")
            {
                var LastName=/^[a-zA-Z _.]+$/;
                if(!TxtLastName.match(LastName))
                {
                   alert ("LastName  Should be Characters");
                   document.getElementById("<%=TxtLastName.ClientID%>").focus();
                   return false;
                }
            }
         //TxtAbbreviation
         
        var DdlClassTeacher=document.getElementById("<%=DdlClassTeacher.ClientID%>").selectedIndex;
            if(DdlClassTeacher==0)
            {
                alert('Select Class');
                return false;
            }
         
          
           
            var TxtDateofBirth=document.getElementById("<%=TxtDateofBirth.ClientID%>").value; 
            if(TxtDateofBirth=="")
            {
                alert("DOB Required");
                document.getElementById("<%=TxtDateofBirth.ClientID%>").focus();
                return false;
            }
                 //TxtFathersName
                  var TxtFathersName=document.getElementById("<%=TxtFathersName.ClientID%>").value;
            if(TxtFathersName=="")
            {
                   document.getElementById("<%=TxtFathersName.ClientID%>").focus();
                   alert("FathersName Name Required");
                   return false;
            }
            if(TxtFathersName!="")
            {
                var LastName=/^[a-zA-Z _.]+$/;
                if(!TxtFathersName.match(LastName))
                {
                   alert ("FathersName  Should be Characters");
                   document.getElementById("<%=TxtLastName.ClientID%>").focus();
                   return false;
                }
            }
                //TxtAddress     
                   var TxtAddress=document.getElementById("<%=TxtAddress.ClientID%>").value;
            if(TxtAddress=="")
            {
                   document.getElementById("<%=TxtAddress.ClientID%>").focus();
                   alert("Address Name Required");
                   return false;
            }
            //TxtArea
             var TxtArea=document.getElementById("<%=TxtArea.ClientID%>").value;
             if(TxtArea=="")
            {
                   document.getElementById("<%=TxtArea.ClientID%>").focus();
                   alert("Area Required");
                   return false;
            }
            //TxtCity
                    var TxtCity=document.getElementById("<%=TxtCity.ClientID%>").value;
            if(TxtCity=="")
            {
                   document.getElementById("<%=TxtCity.ClientID%>").focus();
                   alert("Citye Required");
                   return false;
            }
            if(TxtCity!="")
            {
                var LastName=/^[a-zA-Z ]+$/;
                if(!TxtCity.match(LastName))
                {
                   alert ("City  Should be Characters");
                   document.getElementById("<%=TxtCity.ClientID%>").focus();
                   return false;
                }
            }
            //TxtState
                       var TxtState=document.getElementById("<%=TxtState.ClientID%>").value;
            if(TxtState=="")
            {
                   document.getElementById("<%=TxtState.ClientID%>").focus();
                   alert("State Required");
                   return false;
            }
            if(TxtState!="")
            {
                var LastName=/^[a-zA-Z ]+$/;
                if(!TxtState.match(LastName))
                {
                   alert ("State  Should be Characters");
                   document.getElementById("<%=TxtState.ClientID%>").focus();
                   return false;
                }
            }
            //TxtCountry
                        var TxtCountry=document.getElementById("<%=TxtCountry.ClientID%>").value;
            if(TxtCountry=="")
            {
                   document.getElementById("<%=TxtCountry.ClientID%>").focus();
                   alert("Country Required");
                   return false;
            }
            if(TxtCountry!="")
            {
                var LastName=/^[a-zA-Z ]+$/;
                if(!TxtCountry.match(LastName))
                {
                   alert ("Country  Should be Characters");
                   document.getElementById("<%=TxtCountry.ClientID%>").focus();
                   return false;
                }
            }
            //TxtZip
             var TxtZip=document.getElementById("<%=TxtZip.ClientID%>").value;
          if(TxtZip=="")
            {
               
                document.getElementById("<%=TxtZip.ClientID%>").focus();
                alert('Zip Code Required');
                return false;
            }
           else if(TxtZip!="")
            {
             var Exp=/^[0-9 ()+-]+$/;
              if(!TxtZip.match(Exp))
                {
                    alert('Zip Digits Only');
                    document.getElementById("<%=TxtZip.ClientID%>").focus();
                    return false;
                }
            }
              var TxtPhoneNo=document.getElementById("<%=TxtPhoneNo.ClientID%>").value;
          if(TxtPhoneNo=="")
            {
               
                document.getElementById("<%=TxtPhoneNo.ClientID%>").focus();
                alert('PhoneNo Required');
                return false;
            }
           else if(TxtPhoneNo!="")
            {
             var Exp=/^[0-9 ()+-]+$/;
              if(!TxtPhoneNo.match(Exp))
                {
                    alert('PhoneNo Digits Only');
                    document.getElementById("<%=TxtPhoneNo.ClientID%>").focus();
                    return false;
                }
            }
            var TxtEmail=document.getElementById("<%=TxtEmail.ClientID%>").value;
            if(TxtEmail=="")
            {
               
                alert('EmailId Required');
                document.getElementById("<%=TxtEmail.ClientID%>").focus();
                return false;
            }
            else if(TxtEmail!="")
            {
                var Exp=/^(\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)+$/;
                if(!TxtEmail.match(Exp))
                {
                    alert('Invalid EmailId');
                    document.getElementById("<%=TxtEmail.ClientID%>").focus();
                    return false;
                }
            }
            
     }
    </script>

    <table cellspacing="5" cellpadding="0" align="center" width="600" class="border1">
        <tr>
            <td class="border" colspan="3" align="center">
                <b class="title">Add Student</b></td>
        </tr>
        <tr>
            <td align="right" width="50%">
                <font color="red">*</font><span><b>First Name:</b></span>
            </td>
            <td colspan="2">
                <input id="TxtFirstName" runat="server" />
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>Last Name:</b></span>
            </td>
            <td colspan="2">
                <input id="TxtLastName" runat="server" />
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>Class:</b></span>
            </td>
            <td colspan="2">
                <asp:DropDownList ID="DdlClassTeacher" runat="server" Width="153px" AppendDataBoundItems="True">
                    <asp:ListItem>Select....</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>Date of Birth:</b></span>
            </td>
            <td align="left">
                <input id="TxtDateofBirth" type="text" readonly="readOnly" runat="server" /><a href="javascript:NewCal('<%=TxtDateofBirth.ClientID %>','mmddyyyy')"><img
                    alt="Pick a date" border="0" height="16" src="../Images/cal.gif" width="16" /></a><br />
                mm/dd/yyyy
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b> Fathers Name:</b></span>
            </td>
            <td colspan="2">
                <input id="TxtFathersName" runat="server" type="text" />
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>Address:</b></span>
            </td>
            <td colspan="2">
                <input id="TxtAddress" runat="server" type="text" />
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b> Area:</b></span>
            </td>
            <td colspan="2">
                <input id="TxtArea" runat="server" type="text" />
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>City:</b></span>
            </td>
            <td colspan="2">
                <input id="TxtCity" runat="server" type="text" />
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>State:</b></span>
            </td>
            <td colspan="2">
                <input id="TxtState" runat="server" type="text" />
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>Country:</b></span>
            </td>
            <td colspan="2">
                <input id="TxtCountry" runat="server" type="text" />
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>Zip:</b></span>
            </td>
            <td colspan="2">
                <input id="TxtZip" runat="server" type="text" />
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>Phone No:</b></span>
            </td>
            <td colspan="2">
                <asp:TextBox ID="TxtPhoneNo" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>Email:</b></span>
            </td>
            <td colspan="2">
                <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right">
                <span><b>Image:</b></span>
            </td>
            <td>
                <asp:FileUpload ID="FuplImage" runat="server" Height="22px" /></td>
            <td rowspan="2" valign="top">
                <asp:Image ID="Image1" runat="server" Height="120px" Style="position: static" Width="120px" /></td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>More Info:</b></span>
            </td>
            <td>
                <input id="TxtMoreInfo" runat="server" style="width: 228px; height: 81px" />
            </td>
        </tr>
        <tr>
            <td align="right">
            </td>
            <td>
                <asp:Label ID="lblMessage" runat="server" Text="Label" Font-Bold="True" Font-Italic="False"
                    Font-Names="Arial"></asp:Label></td>
            <td rowspan="1" valign="top">
            </td>
        </tr>
        <tr>
            <td class="bg">
            </td>
            <td align="left">
                <asp:Button ID="Btm_AddTeacher" runat="server" OnClientClick="return check(this);"
                    Text="" CssClass="button" OnClick="Btm_AddTeacher_Click" Width="123px" />&nbsp;
                    <asp:Button
                        ID="Clear" runat="server" Text="Clear" CssClass="button" OnClick="Clear_Click"/>
                <asp:Button ID="Back" runat="server" Text="Back" CssClass="button" PostBackUrl="~/Admin/ViewStudent.aspx"  /></td>
            <td rowspan="1" valign="top">
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
        </tr>
    </table>
</asp:Content>
