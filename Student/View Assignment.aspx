<%@ Page Language="C#" MasterPageFile="~/Student/StudentMaPage.master" AutoEventWireup="true" CodeFile="View Assignment.aspx.cs" Inherits="View_Assignment" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <table align="center" cellpadding="0" cellspacing="5" class="border1" style="position: static"
        width="600">
        <tr>
            <td align="center" class="border" colspan="4">
                <b class="title">View Assignment</b></td>
        </tr>
        <tr>
            <td colspan="4" align="center">
                <asp:Label ID="LblMsg" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="4" align="center">
                <asp:GridView ID="GdVAssignment" runat="server"  CssClass="gridalter" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="Subject" HeaderText="Subject" />
                        <asp:BoundField DataField="NameOFasgmt" HeaderText="Name" />
                        <asp:BoundField DataField="SubmissionDate" HeaderText="DateCreated" />
                        <asp:BoundField DataField="SubmissionDate" HeaderText="SubmissionDate" />
                       <asp:HyperLinkField DataNavigateUrlFields="FilePath" DataNavigateUrlFormatString="~/Image/{0}"
                    DataTextField="FilePath" HeaderText="File" Target="_blank" >
                           <ControlStyle ForeColor="Navy" />
                       </asp:HyperLinkField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>

