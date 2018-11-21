<%@ Page Language="C#" MasterPageFile="~/Teacher/Teacher.master" AutoEventWireup="true" CodeFile="Assignment.aspx.cs" Inherits="Teacher_Assignment" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
  function check()
   {
            var DDLClass=document.getElementById("<%=DDLClass.ClientID%>").selectedIndex;
            if(DDLClass==0)
            {
                alert('Class Required');
                return false;
            }
           
         
             var DDLSubject=document.getElementById("<%=DDLSubject.ClientID%>").selectedIndex;
            if(DDLSubject==0)
            {
                alert('Subject Required');
                return false;
            }
            
            var TxtAssignment=document.getElementById("<%=TxtAssignment.ClientID%>").value;
            if(TxtAssignment=="")
            {
               
                alert('Assignment Required');
                document.getElementById("<%=TxtAssignment.ClientID%>").focus();
                return false;
            }
           }
             var TxtDate=document.getElementById("<%=TxtDate.ClientID%>").value; 
            if(TxtDate=="")
            {
                alert("Date Required");
                document.getElementById("<%=TxtDate.ClientID%>").focus();
                return false;
            }
            
              var FileUpload1=document.getElementById("<%=FileUpload1.ClientID%>").value;
            if(FileUpload1!="")
                {
                   
                    var i=FileUpload1.length;
                    var j=FileUpload1.indexOf('.');
                    var FileExt=(FileUpload1.substring(j,i)).toLowerCase();
                    if((FileExt!=".doc")&&(FileExt!=".docx")&&(FileExt!=".rtf"))
                    {
                        alert('UploadProfile Must be in Word Documents only');
                        document.getElementById("<%=FileUpload1.ClientID%>").focus();
                        return false;
                    }
                }
                else
                {
                    alert('Upload File');
                    document.getElementById("<%=FileUpload1.ClientID%>").focus();
                    return false;
                }
   }
   </script>
    <table align="center" cellpadding="0" cellspacing="5" class="border1"
        width="600">
        <tr>
            <td align="center" class="border" colspan="2">
                <b class="title">Assignment</b></td>
        </tr>
        <tr>
            <td align="right" width="50%">
                <font color="red">*</font><span><b>Select Class:</b></span>
            </td>
            <td align="left">
                <asp:DropDownList ID="DDLClass" runat="server" AppendDataBoundItems="True" AutoPostBack="True"
                    OnSelectedIndexChanged="DDLClass_SelectedIndexChanged" Width="152px">
                    <asp:ListItem>Select....</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="right">
                <font color="red"><span >*</span></font><span><b><span >Select</span>
                    Subject:</b></span>
            </td>
            <td align="left">
                <asp:DropDownList ID="DDLSubject" runat="server" Width="152px" >
                    <asp:ListItem>Select....</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="right">
                <strong><font color="red"><span >*</span></font><span><b> Name
                    OF Assignment:</b></span></strong>
            </td>
            <td align="left">
                <asp:TextBox ID="TxtAssignment" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red"><span >*</span></font><span><b> Last Date For
                    Submission:</b></span>
            </td>
            <td align="left">
                <input id="TxtDate" runat="server" readonly="readonly" type="text" /><a href="javascript:NewCal('<%=TxtDate.ClientID %>','mmddyyyy')"><img
                    alt="Pick a date" border="0" height="16" src="../Images/cal.gif" width="16" /></a><br />
                mm/dd/yyyy
            </td>
        </tr>
        <tr>
            <td>
                If you Want to Upload the Assignment In from of a doc
            </td>
            <td align="left">
                <asp:FileUpload ID="FileUpload1" runat="server" /></td>
        </tr>
        <tr>
            <td>
            </td>
            <td align="left">
                <asp:Button ID="Submit" runat="server" Text="Send" CssClass="button" 
                    OnClick="Submit_Click1" onclientclick="return check(this);" />
                <asp:Button ID="Clear" runat="server" Text="Clear" CssClass="button" OnClick="Clear_Click1"/></td>
        </tr>
    </table>
</asp:Content>

