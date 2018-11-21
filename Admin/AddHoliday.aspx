<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="AddHoliday.aspx.cs" Inherits="AddHoliday" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
  function check()
   {
            var TextBox1=document.getElementById("<%=TextBox1.ClientID%>").value;
            if(TextBox1=="")
            {
               
                alert('Title Required');
                document.getElementById("<%=TextBox1.ClientID%>").focus();
                return false;
            }
            else if(TextBox1!="")
            {
                var Exp=/^[a-zA-Z ,]+$/;
                if(!TextBox1.match(Exp))
                {
                    alert('Title should Should be Character');
                    document.getElementById("<%=TextBox1.ClientID%>").focus();
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
            
             
   }
   </script>
    <table align="center" cellpadding="0" cellspacing="5" class="border1" style="position: static"
        width="700">
        <tr>
            <td align="center" class="border" colspan="3">
                <b class="title">Add Holiday</b></td>
        </tr>
        <tr>
            <td width="50%" align="right"><font color="red">*</font><span><b>Title:</b></span>
            </td>
            <td >
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>Holiday:</b></span>
            </td>
            <td align="left">
                <input id="TxtDate" type="text" readonly="readOnly" runat="server" /><a href="javascript:NewCal('<%=TxtDate.ClientID %>','mmddyyyy')"><img
                    alt="Pick a date" border="0" height="16" src="../images/cal.gif" width="16" /></a><br />
                mm/dd/yyyy
            </td>
        </tr>
        <tr>
            <td >
            </td>
            <td >
                <asp:Button ID="Submit" runat="server" Text=""  CssClass="button" OnClick="Submit_Click" onclientclick="return check(this);"/>
                <asp:Button ID="Clear" runat="server" Text="Clear"  CssClass="button" OnClick="Clear_Click"/>
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

