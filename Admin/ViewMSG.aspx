<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="ViewMSG.aspx.cs" Inherits="Admin_ViewMSG" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" width="100%">
        <tr>
            <td align="left" class="border" colspan="2">
                <b>My Messages:</b>
            </td>
        </tr>
        <tr>
            <td>
                <%--  place for gridview--%>
                <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AutoGenerateColumns="False" CssClass="gridalter"
                    AutoGenerateDeleteButton="True" Font-Names="Arial" Font-Size="9pt" 
                    OnRowDeleting="GridView2_RowDeleting" PageSize="8" Width="538px" OnPageIndexChanging="GridView2_PageIndexChanging">
                    <Columns>
                        <asp:BoundField DataField="MSGID" HeaderText="MSGID" />
                        <asp:BoundField DataField="MFrom" HeaderText="From" />
                        <asp:BoundField DataField="Message" HeaderText="Message" />
                        <asp:BoundField DataField="MTime" HeaderText="Date" />
                        <asp:BoundField DataField="SenderType" HeaderText="SenderType" />
                    </Columns>
                    <RowStyle HorizontalAlign="Center" />
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>

