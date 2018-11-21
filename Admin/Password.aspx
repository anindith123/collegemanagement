<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Password.aspx.cs" Inherits="Admin_Password" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="5" class="border1" width="600">
        <tr>
            <td align="center" class="border" colspan="2" style="height: 23px">
                <b class="title">View Leaturer Login Details</b>&nbsp;</td>
        </tr>
        <tr>
            <td align="center">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="center">
                <asp:GridView ID="GdVPassword" runat="server" AutoGenerateColumns="False" 
                    Height="172px" Width="340px" CellPadding="4" ForeColor="#333333" 
                    GridLines="None">
                    <RowStyle BackColor="#E3EAEB" />
                    <Columns>
                        <asp:BoundField DataField="UserID" HeaderText="UserID" />
                        <asp:BoundField DataField="Password" HeaderText="Password" />
                    </Columns>
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#7C6F57" />
                    <AlternatingRowStyle BackColor="White" />
                </asp:GridView>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

