<%@ Page Language="C#" MasterPageFile="~/Student/StudentMaPage.master" AutoEventWireup="true" CodeFile="View Reports.aspx.cs" Inherits="Admin_View_Reports" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="5" class="border1" width="600">
        <tr>
            <td align="center" class="border" colspan="5" >
                <b class="title">View Reports Details</b>
            </td>
        </tr>
        <tr>
            <td align="center"  colspan="5" >
                <asp:Label ID="LblMsg" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td align="center" colspan="5">
             <asp:Panel ID="Panel1" runat="server" Height="130px" Width="600px" ScrollBars="Auto">
                <asp:GridView ID="GdVReports" runat="server"  CssClass="gridalter" AutoGenerateColumns="False" >
                    <Columns>
                        <asp:BoundField DataField="MarksID" HeaderText="MarksID" />
                        <asp:BoundField DataField="Class" HeaderText="Class" />
                        <asp:BoundField DataField="Subjects" HeaderText="Subjects" />
                        <asp:BoundField DataField="StudentName" HeaderText="StudentName" />
                        <asp:BoundField DataField="TypeOfExam" HeaderText="Type Of Exam" />
                        <asp:BoundField DataField="Marks" HeaderText="Marks" />
                    </Columns>
                </asp:GridView>
                </asp:Panel>
            </td>
        </tr>
    </table>
</asp:Content>

