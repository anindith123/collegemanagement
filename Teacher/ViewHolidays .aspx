<%@ Page Language="C#" MasterPageFile="~/Teacher/Teacher.master" AutoEventWireup="true" CodeFile="ViewHolidays .aspx.cs" Inherits="ViewHolidays_" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="5" class="border1" style="position: static"
        width="600">
        <tr>
            <td align="center" class="border" colspan="3">
                <b class="title">View &nbsp;Holiday</b></td>
        </tr>
        <tr>
            <td colspan="3" align="center" >
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="3" align="center" >
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" CssClass="gridalter" AutoGenerateColumns="False" Width="522px">
                    <Columns>
                        <asp:BoundField DataField="HolidayID" HeaderText="HolidayID" />
                        <asp:BoundField DataField="Title" HeaderText="Title" />
                        <asp:BoundField DataField="HolidayDate" HeaderText="HolidayDate" />
                    </Columns>
                    <RowStyle HorizontalAlign="Center" />
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>

