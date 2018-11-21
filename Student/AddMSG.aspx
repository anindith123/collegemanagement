<%@ Page Language="C#" MasterPageFile="~/Student/StudentMaPage.master" AutoEventWireup="true" CodeFile="AddMSG.aspx.cs" Inherits="Admin_AddMSG" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
  function check()
   {
            var DDLUserType=document.getElementById("<%=DDLUserType.ClientID%>").selectedIndex;
            if(DDLUserType==0)
            {
                alert('UserType Required');
                return false;
            }
           
                   
            var TxtMSG=document.getElementById("<%=TxtMSG.ClientID%>").value;
            if(TxtMSG=="")
            {
               
                alert('Enter Message');
                document.getElementById("<%=TxtMSG.ClientID%>").focus();
                return false;
            }
                
  }
   </script>
<script language="javascript" type="text/javascript">
// <!CDATA[



// ]]>
</script>

    <table cellspacing="0" cellpadding="0" width="100%">
                                <tr>
                                    <td align="left" class="border" colspan="3">
                                        <b class="title">Send Message:</b>
                                         
                                         </td>
                                </tr>
        <tr>
            <td align="right"  colspan="3"><b align="right" >
                                             </b> 
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Student/ViewMSG.aspx">Inbox</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="gentxt" colspan="2" valign="top">
                <div id="Panel1">
                    <table bgcolor="#efefef" border="0" cellpadding="3" cellspacing="1" class="gentxt"
                        width="100%">
                        <tr bgcolor="#ffffff">
                            <td>
                                Select user type to send message to:
                            </td>
                            <td>
                                <asp:DropDownList ID="DDLUserType" runat="server" Width="175px" AutoPostBack="True" OnSelectedIndexChanged="DDLUserType_SelectedIndexChanged" >
                                    <asp:ListItem>Please select a user type</asp:ListItem>
                                    <asp:ListItem>Teacher</asp:ListItem>
                                    <asp:ListItem>Admin</asp:ListItem>
                                </asp:DropDownList></td>
                        </tr>
                        <tr bgcolor="#ffffff">
                            <td>
                                Select User:
                            </td>
                            <td><asp:DropDownList ID="DDLUser" runat="server" AppendDataBoundItems="True" Width="175px">
                                    <asp:ListItem>Select...</asp:ListItem>
                                </asp:DropDownList>
                               </td>
                        </tr>
                        <tr bgcolor="#ffffff">
                            <td style="height: 92px">
                                Message:<br />
                                *maximum 500 characters</td>
                            <td style="height: 92px">
                                <asp:TextBox ID="TxtMSG" runat="server" Height="80px" TextMode="MultiLine" Width="239px"></asp:TextBox></td>
                        </tr>
                        <tr bgcolor="#ffffff">
                            <td>
                                &nbsp;</td>
                            <td>
                                <asp:Button ID="SendMSG" runat="server" Text="SendMessage" CssClass="button" OnClick="SendMSG_Click" onclientclick="return check(this);" /></td>
                        </tr>
                    </table>
                </div>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

