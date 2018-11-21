<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true"
    CodeFile="AddMSG.aspx.cs" Inherits="Admin_AddMSG" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <script language="javascript" type="text/javascript">
  function check()
   {
            var DDLUserType=document.getElementById("<%=DDLUserType.ClientID%>").selectedIndex;
            if(DDLUserType==0)
            {
                alert('UserType Required');
                return false;
            }
           
         
             var DropDownList1=document.getElementById("<%=DropDownList1.ClientID%>").selectedIndex;
            if(DropDownList1==0)
            {
                alert('UserName Required');
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

    <table cellspacing="0" cellpadding="0" width="100%" class="border1">
        <tr>
            <td align="left" class="border" colspan="2">
                <b class="title">Send Message:</b>
            </td>
        </tr>
        <tr>
            <td align="right" colspan="2" style="height: 12px">
                <b ></b>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Admin/ViewMSG.aspx">Inbox</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td class="gentxt" colspan="2" valign="top">
                <div id="Panel1">
                    <table bgcolor="#efefef" border="0" cellpadding="3" cellspacing="1" class="gentxt"
                        width="100%">
                        <tr bgcolor="#ffffff">
                            <td>
                                <font color="red">*</font><span><b> Select user type to send message to:</b></span>
                            </td>
                            <td>
                                <asp:DropDownList ID="DDLUserType" runat="server" Width="175px" AutoPostBack="True"
                                    OnSelectedIndexChanged="DDLUserType_SelectedIndexChanged">
                                    <asp:ListItem>Please select a user type</asp:ListItem>
                                    <asp:ListItem>Student</asp:ListItem>
                                    <asp:ListItem>Teacher</asp:ListItem>
                                </asp:DropDownList></td>
                        </tr>
                        <tr bgcolor="#ffffff">
                            <td>
                                <font color="red">*</font><span><b> Select User:</b></span>
                            </td>
                            <td>
                                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged1"
                                    Width="173px" AppendDataBoundItems="True">
                                    <asp:ListItem>Select...</asp:ListItem>
                                </asp:DropDownList>
                                <asp:DropDownList ID="DDLUser" runat="server" AppendDataBoundItems="True" Width="175px">
                                    <asp:ListItem>Select...</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr bgcolor="#ffffff">
                            <td style="height: 92px">
                                Message:<br />
                                *maximum 500 characters</td>
                            <td>
                                <asp:TextBox ID="TxtMSG" runat="server" Height="80px" TextMode="MultiLine" Width="239px" MaxLength="30"></asp:TextBox></td>
                        </tr>
                        <tr bgcolor="#ffffff">
                            <td>
                                &nbsp;</td>
                            <td>
                                <asp:Button ID="Submit" runat="server" Text="Send Message" CssClass="button" OnClick="Submit_Click"
                                    OnClientClick="return check(this);" />&nbsp;
                                <asp:Button ID="Claer" runat="server" Text="Clear" CssClass="button" OnClick="Claer_Click" /></td>
                        </tr>
                    </table>
                </div>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
