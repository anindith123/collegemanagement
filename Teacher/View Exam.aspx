<%@ Page Language="C#" MasterPageFile="~/Teacher/Teacher.master" AutoEventWireup="true"
    CodeFile="View Exam.aspx.cs" Inherits="View_Exam" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table align="center" cellpadding="0" cellspacing="5" class="border1" style="position: static"
        width="600">
        <tr>
            <td align="center" class="border" colspan="3">
                <b class="title">View Exam Schedule</b></td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>Select Class:</b></span>
            </td>
            <td align="left">
                <asp:DropDownList ID="DDLClass" runat="server" OnSelectedIndexChanged="DDLClass_SelectedIndexChanged" AppendDataBoundItems="True" AutoPostBack="True">
                    <asp:ListItem>Select..</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td align="right">
            </td>
            <td align="left">
                <asp:Label ID="LblMsg" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:GridView ID="GdVExam" runat="server" AllowPaging="True" AutoGenerateDeleteButton="True" OnPageIndexChanging="GdVExam_PageIndexChanging" OnRowCommand="GdVExam_RowCommand" OnRowDeleting="GdVExam_RowDeleting" AutoGenerateColumns="False">
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"EXMID") %>'
                                    CommandName="Edit">Edit</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="EXMID" HeaderText="EXMID" />
                        <asp:BoundField DataField="Class" HeaderText="Class" />
                        <asp:BoundField DataField="NameOfExam" HeaderText="Type of Exam" />
                        <asp:BoundField DataField="EDate" HeaderText="Date" />
                        <asp:BoundField DataField="FilePath" HeaderText="FileName" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
