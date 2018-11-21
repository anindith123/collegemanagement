<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="ViewSubjects.aspx.cs" Inherits="Admin_ViewSubjects" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="5" class="border1" width="700">
        <tr>
            <td align="center" class="border" colspan="2" style="height: 23px">
                <b class="title">View Class Details</b>
            </td>
        </tr>
        <tr>
            <td align="center">
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="center">
                <asp:GridView ID="GdVClass" runat="server" AllowPaging="True" AutoGenerateColumns="False" CssClass="gridalter"
                    AutoGenerateDeleteButton="True" OnPageIndexChanging="GdVClass_PageIndexChanging"
                    OnRowCommand="GdVClass_RowCommand" OnRowDeleting="GdVClass_RowDeleting" PageSize="6">
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"ClassID") %>'
                                    CommandName="Edit">Edit</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="ClassID" HeaderText="ClassID" />
                        <asp:BoundField DataField="Class" HeaderText="Class" />
                        <asp:BoundField DataField="Subject1" HeaderText="Subject1" />
                        <asp:BoundField DataField="Subject2" HeaderText="Subject2" />
                        <asp:BoundField DataField="Subject3" HeaderText="Subject3" />
                        <asp:BoundField DataField="Subject4" HeaderText="Subject4" />
                        <asp:BoundField DataField="Subject6" HeaderText="Subject5" />
                        <asp:BoundField DataField="Subject7" HeaderText="Subject7" />
                        <asp:BoundField DataField="Subject8" HeaderText="Subject8" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
