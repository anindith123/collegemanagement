<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="AddExamSchedule.aspx.cs" Inherits="AddExamSchedule" Title="Untitled Page" %>
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
              var TxtExam=document.getElementById("<%=TxtExam.ClientID%>").value;
            if(TxtExam=="")
            {
               
                alert('Exam Required');
                document.getElementById("<%=TxtExam.ClientID%>").focus();
                return false;
            }
          //else if(TxtExam!="")
           // {
           //     var Exp=/^[a-zA-Z]+$/;
             //   if(!TxtExam.match(Exp))
             //   {
             //       alert('Exam should Should be Character');
            //        document.getElementById("<%=TxtExam.ClientID%>").focus();
             //       return false;
               // }
           // }
             var TxtDate=document.getElementById("<%=TxtDate.ClientID%>").value; 
            if(TxtDate=="")
            {
                alert("Date Required");
                document.getElementById("<%=TxtDate.ClientID%>").focus();
                return false;
            }
            
              var FileUpload1=document.getElementById("<%=FileUpload1.ClientID%>").value;
              if(document.getElementById("<%=FileUpload1.ClientID%>").disabled==false)
              {
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
              else
              {
                return true;
              }
              
   }
   function Enable()
   {
       document.getElementById("<%=FileUpload1.ClientID%>").disabled=false;
        return false;
   }
   </script>
    <table align="center" cellpadding="0" cellspacing="5" class="border1" style="position: static"
        width="700">
        <tr>
            <td align="center" class="border" colspan="3">
                <b class="title">Add Exam Schedule</b></td>
        </tr>
        <tr>
            <td width="50%" align="right"><font color="red">*</font><span><b>Select Class:</b></span>
            </td>
            <td >
                <asp:DropDownList ID="DDLClass" runat="server" AppendDataBoundItems="True">
                    <asp:ListItem>Select...</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>Name of Exam:</b></span>
            </td>
            <td >
                <asp:TextBox ID="TxtExam" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>Date:</b></span>
            </td>
           <td align="left">
                <input id="TxtDate" type="text" readonly="readOnly" runat="server" /><a href="javascript:NewCal('<%=TxtDate.ClientID %>','mmddyyyy')"><img
                    alt="Pick a date" border="0" height="16" src="../images/cal.gif" width="16" /></a><br />
                mm/dd/yyyy
            </td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>Upload the Exam Schedule:</b></span>
            </td>
            <td >
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr>
            <td align="right">
            </td>
            <td>
                <asp:HyperLink ID="HyperLink1" runat="server" Font-Underline="False">[HyperLink1]</asp:HyperLink>
                <asp:LinkButton ID="lnkbtnUpdate" runat="server" Font-Underline="False" OnClientClick="return Enable(this);">Update Exam File</asp:LinkButton></td>
        </tr>
        <tr>
            <td style="height: 17px" >
            </td>
            <td style="height: 17px" >
                <asp:Button ID="Submit" runat="server" Text=""  CssClass="button" OnClick="SubMit_Click" onclientclick="return check(this);"/>
                <asp:Button ID="Clear" runat="server" Text="Clear" CssClass="button" OnClick="Clear_Click"/>
                <asp:Button ID="Back" runat="server" Text="Back" CssClass="button" OnClick="Back_Click" /></td>
        </tr>
        <tr>
            <td >
            </td>
            <td >
            </td>
        </tr>
    </table>
</asp:Content>

