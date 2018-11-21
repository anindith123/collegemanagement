<%@ Page Language="C#" MasterPageFile="~/Login/Login.master" AutoEventWireup="true" CodeFile="start.aspx.cs" Inherits="Admin_LoginPage" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <table style="position: static; background-color: transparent;" height="150" >
        <tr>
            <td colspan="2" class="title" align="center" >Login
            </td>
        </tr>
        <tr>
            <td colspan="2" class="title" valign="middle" >
                </td>
        </tr>
        <tr>
            <td  width="40%" style="height: 14px" align="right"><font color="red">*</font><span><b>UserID :</b></span>
                </td>
            <td style="width: 147px"  >
                <asp:TextBox ID="TxtUserID" runat="server" Style="position: static" 
                    Height="17px" Width="127px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>Password :</b></span>
                </td>
            <td style="width: 147px" >
                <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password" Width="127px" 
                    Height="17px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >
            </td>
            <td style="width: 147px" >
                <asp:Button ID="btnSubmit" runat="server" Style="position: static" Text="Submit" CssClass="button" OnClick="btnSubmit_Click" /></td>
        </tr>
       <tr>
           <td>
           </td>
           <td style="width: 147px">
               <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Login/ForgetPassword.aspx">Forgot Password</asp:HyperLink></td>
       </tr>
    </table>
</asp:Content>

