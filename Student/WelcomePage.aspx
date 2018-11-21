<%@ Page Language="C#" MasterPageFile="~/Student/StudentMaPage.master" AutoEventWireup="true"
    CodeFile="WelcomePage.aspx.cs" Inherits="Student_WelcomePage" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <script language="javascript" type="text/javascript">
  function check()
   {
            var TxtOldPassword=document.getElementById("<%=TxtOldPassword.ClientID%>").value;
            if(TxtOldPassword=="")
            {
                 alert("OldPassword Required");
                 document.getElementById("<%=TxtOldPassword.ClientID%>").focus();
                 return false;
            }
             var TxtNewpassword=document.getElementById("<%=TxtNewpassword.ClientID%>").value;
            if(TxtNewpassword=="")
            {
                 alert("Newpassword Required");
                 document.getElementById("<%=TxtNewpassword.ClientID%>").focus();
                 return false;
            }
             var TxtNewpassword=document.getElementById("<%=TxtNewpassword.ClientID%>").value;
             var TextBox3=document.getElementById("<%=TextBox3.ClientID%>").value;
            if(TextBox3!=TxtNewpassword)
            {
                 alert("NewPassword and RetypPassword Not Match");
                 document.getElementById("<%=TxtOldPassword.ClientID%>").focus();
                 return false;
            }
            
   }
    </script>
    <table>
    <tr>
    <td width="1000" align="center">
        <asp:Label ID="LblMSG" runat="server" Font-Bold="True" Font-Size="9pt" ForeColor="#404040"
            Text="Label"></asp:Label></td>
    </tr>
    </table>

    <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AutoGenerateColumns="False"
        Font-Names="Arial" Font-Size="9pt" OnPageIndexChanging="GridView2_PageIndexChanging"
        PageSize="5" Width="615px">
        <RowStyle HorizontalAlign="Center" />
        <Columns>
            <asp:BoundField DataField="MFrom" HeaderText="From" />
            <asp:BoundField DataField="Message" HeaderText="Message" />
            <asp:BoundField DataField="MTime" HeaderText="Date" />
            <asp:BoundField DataField="SenderType" HeaderText="SenderType" />
        </Columns>
    </asp:GridView>
    <br />
    <br />
    <br />
    <br />
    <br />
    <table cellpadding="0" cellspacing="0" width="100%">
        <tr>
            <td align="left" class="border" colspan="4">
                <b>Change Password :</b>
            </td>
        </tr>
        <tr>
            <td>
                <font color="red">*</font><span><b>Old Password:</b></span>
            </td>
            <td>
                <font color="red">*</font><span><b>New Password:</b></span>
            </td>
            <td>
                <font color="red">*</font><span><b> Retype New Password:</b></span>
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="TxtOldPassword" runat="server" TextMode="Password"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="TxtNewpassword" runat="server" TextMode="Password"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
                <asp:Button ID="ChangePassword" runat="server" Text="ChangePassword" CssClass="button"
                    OnClientClick="return check(this);" OnClick="ChangePassword_Click" Width="122px" /></td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
    </table>
</asp:Content>
