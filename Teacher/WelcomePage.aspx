<%@ Page Language="C#" MasterPageFile="~/Teacher/Teacher.master" AutoEventWireup="true"
    CodeFile="WelcomePage.aspx.cs" Inherits="Teacher_WelcomePage" Title="Untitled Page" %>

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

    <asp:Label ID="LblMSG" runat="server" Text="Label" Font-Bold="True" Font-Size="9pt" ForeColor="#404040"></asp:Label><br />
    <br />
    <table cellpadding="0" cellspacing="0" width="500">
        <tr>
            <td align="left" class="border" colspan="2">
                <b>My Messages:</b>
            </td>
        </tr>
        <tr>
            <td>
                <%--  place for gridview--%>
                <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                    Font-Names="Arial" Font-Size="9pt" PageSize="4" Width="615px" OnPageIndexChanging="GridView2_PageIndexChanging">
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
            </td>
        </tr>
        <tr>
            <td align="left" class="border" colspan="2">
                <b>Change Password :</b>
            </td>
        </tr>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                        </td>
                        <td>
                        </td>
                        <td>
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
                        </td>
                        <td>
                            <asp:Button ID="ChangePassword" runat="server" Text="ChangePassword" Width="100px"
                                OnClientClick="return check(this);" CssClass="button" OnClick="ChangePassword_Click" /></td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
