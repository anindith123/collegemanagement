<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true"
    CodeFile="Welcomepage.aspx.cs" Inherits="Admin_Welcomepage" Title="Untitled Page" %>

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

<script language="javascript" type="text/javascript">
  function chec()
   {
            var TxtTitle=document.getElementById("<%=TxtTitle.ClientID%>").value;
            if(TxtTitle=="")
            {
                 alert("Title Required");
                 document.getElementById("<%=TxtTitle.ClientID%>").focus();
                 return false;
            }
             var TxtDescription=document.getElementById("<%=TxtDescription.ClientID%>").value;
            if(TxtDescription=="")
            {
                 alert("Description Required");
                 document.getElementById("<%=TxtDescription.ClientID%>").focus();
                 return false;
            }
            var TxtClass=document.getElementById("<%=DDLClass.ClientID%>").value;
            if(TxtClass=="Select...")
            {
                alert("Select Class Required");
                 document.getElementById("<%=TxtDescription.ClientID%>").focus();
                 return false;
            }
            
   }
    </script>
    <table cellspacing="0" cellpadding="0" width="90%">
        <tr>
            <td>
                <table cellspacing="0" cellpadding="0" width="90%">
                    <tr>
                        <td>
                            <table cellspacing="0" cellpadding="0" width="100%">
                                <tr>
                                    <td align="left" class="border" colspan="3">
                                        <b class="title">Add Notice:</b></td>
                                </tr>
                                <tr>
                                    <td align="left" width="20%">
                                        <font color="red">*</font><span><b>Title:</b></span>
                                    </td>
                                    <td colspan="2">
                                        <asp:TextBox ID="TxtTitle" runat="server" Width="332px"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td align="left">
                                        <font color="red">*</font><span><b>Description:</b></span>
                                    </td>
                                    <td colspan="2">
                                        <asp:TextBox ID="TxtDescription" runat="server" TextMode="MultiLine" Height="66px"
                                            Width="433px" Columns="50"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td align="left">
                                        <font color="red">*</font><span><b>NoticeFor:</b></span>
                                    </td>
                                    <td width="40%">
                                        &nbsp;&nbsp;
                                        <asp:RadioButtonList ID="RdBLNoticeFor" runat="server" RepeatDirection="Horizontal"
                                            Width="366px" onselectedindexchanged="RdBLNoticeFor_SelectedIndexChanged" 
                                            AutoPostBack="True">
                                            <asp:ListItem Selected="True">Whole College</asp:ListItem>
                                            <asp:ListItem>Class</asp:ListItem>
                                        </asp:RadioButtonList>&nbsp;
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="DDLClass" runat="server" AppendDataBoundItems="True" 
                                            Visible="False">
                                            <asp:ListItem>Select...</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2" align="center">
                                        <asp:Button ID="BtnNotice" runat="server" OnClick="Button1_Click" CssClass="button" onclientclick="return chec(this);"
                                            Text="Submit Notice" Width="93px" /></td>
                                </tr>
                                <tr>
                                    <td align="center" colspan="2">
                                    </td>
                                </tr>
                            </table>
                            <br />
                            <br />
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table cellspacing="0" cellpadding="0" width="90%">
                                <tr>
                                    <td align="left" class="border" colspan="2">
                                        <b>My Messages:</b>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="height: 124px">
                                        <%--  place for gridview--%>
                                        <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                                            Font-Names="Arial" Font-Size="9pt" OnPageIndexChanging="GridView2_PageIndexChanging"
                                            PageSize="4" Width="615px">
                                            <RowStyle HorizontalAlign="Center" />
                                            <Columns>
                                                <asp:BoundField DataField="MFrom" HeaderText="From" />
                                                <asp:TemplateField HeaderText="Message" >
                                                <ItemTemplate>
                                                    <asp:TextBox ID="TextBox1" TextMode="MultiLine"   Height="25" runat="server" Text='<%#Eval("Message") %>'>'>Message</asp:TextBox>
                                                </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:BoundField DataField="MTime" HeaderText="Date" />
                                                <asp:BoundField DataField="SenderType" HeaderText="SenderType" />
                                            </Columns>
                                        </asp:GridView>
                                    </td>
                                </tr>
                            </table>
                            <br />
                            <br />
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 87px">
                            <table cellspacing="0" cellpadding="0" width="100%">
                                <tr>
                                    <td align="left" class="border" colspan="4" style="height: 15px">
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
                                        &nbsp;<asp:TextBox ID="TxtOldPassword" runat="server" TextMode="Password"></asp:TextBox></td>
                                    <td>
                                        <asp:TextBox ID="TxtNewpassword" runat="server" TextMode="Password"></asp:TextBox></td>
                                    <td>
                                        <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox></td>
                                    <td>
                                        <asp:Button ID="ChangePassword" runat="server" Text="Submit"  CssClass="button" OnClick="ChangePassword_Click" onclientclick="return check(this);"   /></td>
                                </tr>
                                <tr>
                                    <td style="height: 12px">
                                    </td>
                                    <td style="height: 12px">
                                    </td>
                                    <td style="height: 12px">
                                    </td>
                                    <td style="height: 12px">
                                    </td>
                                </tr>
                                <tr>
                                    <td style="height: 12px">
                                    </td>
                                    <td style="height: 12px">
                                    </td>
                                    <td style="height: 12px">
                                    </td>
                                    <td style="height: 12px">
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table cellspacing="0" cellpadding="0" width="100%">
                                <tr>
                                    <td width="5">
                                        *</td>
                                    <td>
                                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Admin/AddClass.aspx"
                                            Font-Bold="True" CssClass="bottomlinks">Add Class</asp:HyperLink>
                                    </td>
                                    <td>
                                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Admin/AddSubject.aspx"
                                            Font-Bold="True" Font-Names="Arial" Font-Size="8pt" CssClass="bottomlinks">Add Subject</asp:HyperLink>
                                    </td>
                                    <td>
                                        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Admin/AddTeacher.aspx"
                                            Font-Bold="True" Font-Names="Arial" Font-Size="8pt" CssClass="bottomlinks">Add Teacher</asp:HyperLink>
                                    </td>
                                    <td>
                                        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Admin/Student.aspx"
                                            Font-Bold="True" Font-Names="Arial" Font-Size="8pt" CssClass="bottomlinks">Add Students</asp:HyperLink>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
            <td valign="top">
            </td>
        </tr>
    </table>
</asp:Content>
