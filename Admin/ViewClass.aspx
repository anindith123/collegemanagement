<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="ViewClass.aspx.cs" Inherits="Admin_ViewClass" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellspacing="5" cellpadding="0" align="center" width="600" class="border1">
        <tr>
            <td class="border" colspan="2" align="center" style="height: 23px">
                <b class="title">View Class Details</b>
            </td>
        </tr>
        <tr>
            <td align="center" ><asp:Label id="Label1" runat="server" Text="Label"></asp:Label>
              
            </td>
        </tr>
        <tr>
            <td align="center" ><asp:GridView ID="GdVClass" runat="server" AutoGenerateColumns="False" AutoGenerateDeleteButton="True" AllowPaging="True" OnPageIndexChanging="GdVClass_PageIndexChanging" OnRowCommand="GdVClass_RowCommand" OnRowDeleting="GdVClass_RowDeleting" OnSelectedIndexChanged="GdVClass_SelectedIndexChanged" CssClass="gridalter" Width="509px">
                <Columns>
                    <asp:TemplateField>
                    <ItemTemplate>
                     <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Edit" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"ClassID") %>'>Edit</asp:LinkButton>
                    </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="ClassID" HeaderText="ClassID" />
                    <asp:BoundField DataField="Class" HeaderText="Class" />
                    <asp:BoundField DataField="ClassTeacher" HeaderText="ClassTeacher" />
                </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>

