<%@ Page Language="C#" MasterPageFile="~/Student/StudentMaPage.master" AutoEventWireup="true"
    CodeFile="ViewMSG.aspx.cs" Inherits="Admin_ViewMSG" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table cellpadding="0" cellspacing="0" width="600">
        <tr>
            <td align="left" class="border" colspan="2" style="height: 15px">
                <b>My Messages:</b>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Label ID="LblMsg" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td>
                <%--  place for gridview--%>
                <asp:Panel ID="Panel1" runat="server" Height="330px" Width="600px" ScrollBars="Auto">
                    <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                        CssClass="gridalter" AutoGenerateDeleteButton="True" Font-Names="Arial" Font-Size="9pt"
                        OnRowDeleting="GridView2_RowDeleting" Width="738px">
                        <Columns>
                            <asp:BoundField DataField="MSGID" HeaderText="MSGID" />
                            <asp:BoundField DataField="MFrom" HeaderText="From" />
                            <asp:BoundField DataField="Message" HeaderText="Message" />
                            <asp:BoundField DataField="MTime" HeaderText="Date" />
                            <asp:BoundField DataField="SenderType" HeaderText="SenderType" />
                        </Columns>
                        <RowStyle HorizontalAlign="Center" />
                    </asp:GridView>
                </asp:Panel>
            </td>
        </tr>
    </table>
</asp:Content>