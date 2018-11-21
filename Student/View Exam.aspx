<%@ Page Language="C#" MasterPageFile="~/Student/StudentMaPage.master" AutoEventWireup="true"
    CodeFile="View Exam.aspx.cs" Inherits="View_Exam" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table align="center" cellpadding="0" cellspacing="5" class="border1" style="position: static"
        width="600">
        <tr>
            <td align="center" class="border" colspan="3">
                <b class="title">View Exam Schedule</b></td>
        </tr>
        <tr>
            <td align="center" colspan="2" style="height: 14px">
                <font color="red"></font>&nbsp;<asp:Label ID="Label1" runat="server" Font-Bold="True"
                    Font-Names="Arial" Font-Size="8pt" ForeColor="#C00000" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Label ID="LblMsg" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:GridView ID="GdVExam" runat="server" AllowPaging="True" OnPageIndexChanging="GdVExam_PageIndexChanging" AutoGenerateColumns="False" Width="485px">
                    <Columns>
                        <asp:BoundField DataField="EXMID" HeaderText="EXMID" />
                        <asp:BoundField DataField="NameOfExam" HeaderText="Type of Exam" />
                        <asp:BoundField DataField="EDate" HeaderText="Date" />
                        <asp:HyperLinkField DataNavigateUrlFields="FilePath" DataNavigateUrlFormatString="~/Image/{0}"
                            DataTextField="FilePath" HeaderText="File" Target="_blank" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
