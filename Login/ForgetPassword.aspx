<%@ Page Language="C#" MasterPageFile="~/Login/ForgetPasswordPage.master" AutoEventWireup="true" CodeFile="ForgetPassword.aspx.cs" Inherits="Admin_ForgetPassword" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <table cellspacing="5" cellpadding="0" align="center" width="1000" height="20%">
        <tr>
            <td align="right">
                <asp:HyperLink ID="HyperLink1" runat="server" Style="position: static" NavigateUrl="~/Login/LoginPage.aspx">Login</asp:HyperLink></td>
        </tr>
    </table>
    <table cellspacing="5" cellpadding="0" align="center" width="700" height="20%" class="border1">
        <tr>
            <td class="border" colspan="2" align="center">
                <b class="title">ForgetPassword </b>
            </td>
        </tr>
        <tr>
            <td width="50%" align="right">
                Username</td>
            <td width="50">
                <asp:TextBox ID="Txt_UserName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td width="50">
            </td>
            <td width="50">
                <asp:Button ID="Submit" runat="server" Text="Submit" CssClass="button" OnClick="Submit_Click" />
            </td>
        </tr>
        <tr>
            <td width="50">
            </td>
            <td width="50">
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Label ID="lblMessage" runat="server" ForeColor="Red" Style="position: static"></asp:Label></td>
        </tr>
    </table>
</asp:Content>

