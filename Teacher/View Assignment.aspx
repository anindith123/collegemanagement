<%@ Page Language="C#" MasterPageFile="~/Teacher/Teacher.master" AutoEventWireup="true" CodeFile="View Assignment.aspx.cs" Inherits="View_Assignment" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <table align="center" cellpadding="0" cellspacing="5" class="border1" style="position: static"
        width="600">
        <tr>
            <td align="center" class="border" colspan="4">
                <b class="title">View Assignment</b></td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b> Please Select Class:</b></span>
               </td>
            <td style="width: 221px" >
                <asp:DropDownList ID="DDLClass" runat="server" Width="95px" AppendDataBoundItems="True" AutoPostBack="True" OnSelectedIndexChanged="DDLClass_SelectedIndexChanged">
                    <asp:ListItem>Select...</asp:ListItem>
                </asp:DropDownList>
                &nbsp; &nbsp;&nbsp;
            </td>
            <td align="right"><font color="red">*</font><span><b> Please Select Subject:</b></span>
            </td>
            <td >
                <asp:DropDownList ID="DDLSubject" runat="server" Width="95px" AppendDataBoundItems="True" AutoPostBack="True" OnSelectedIndexChanged="DDLSubject_SelectedIndexChanged">
                    <asp:ListItem>Select...</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Label ID="LblMsg" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="4" align="center">
                <asp:GridView ID="GdVAssignment" runat="server" AutoGenerateColumns="False" AutoGenerateDeleteButton="True" AllowPaging="True" OnPageIndexChanging="GdVAssignment_PageIndexChanging" OnRowCommand="GdVAssignment_RowCommand" PageSize="8" CssClass="gridalter" OnRowDeleting="GdVAssignment_RowDeleting">
                    <Columns>
                        <asp:BoundField DataField="AsignmentsID" HeaderText="AsignmentsID" />
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

