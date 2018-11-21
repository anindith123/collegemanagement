<%@ Page Language="C#" MasterPageFile="~/Teacher/Teacher.master" AutoEventWireup="true"
    CodeFile="View TimeTable.aspx.cs" Inherits="Admin_View_TimeTable" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table align="center" cellpadding="0" cellspacing="5" class="border1" width="600">
        <tr>
            <td align="center" class="border" colspan="3" style="height: 23px">
                <b class="title">View Time Table Details</b>
            </td>
        </tr>
        <tr>
            <td>
                Select Class
            </td>
            <td>
                <asp:DropDownList ID="DDLClass" runat="server" AppendDataBoundItems="True" AutoPostBack="True"
                    OnSelectedIndexChanged="DDLClass_SelectedIndexChanged" Width="131px">
                    <asp:ListItem>Select..</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td>
            </td>
            <td align="left">
                <asp:Label ID="LblMsg" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td align="center" colspan="3">
                <asp:Panel ID="Panel1" runat="server" Height="130px" Width="600px" ScrollBars="Auto">
                    <asp:GridView ID="GdVTimeTable" runat="server" CssClass="gridalter" AutoGenerateColumns="False"
                        Width="543px">
                        <Columns>
                            <asp:BoundField DataField="Class" HeaderText="Class" />
                            <asp:BoundField DataField="Days" HeaderText="Days" />
                            <asp:BoundField DataField="I" HeaderText="I" />
                            <asp:BoundField DataField="II" HeaderText="II" />
                            <asp:BoundField DataField="III" HeaderText="III" />
                            <asp:BoundField DataField="IV" HeaderText="IV" />
                            <asp:BoundField DataField="V" HeaderText="V" />
                            <asp:BoundField DataField="VI" HeaderText="VI" />
                            <asp:BoundField DataField="VII" HeaderText="VII" />
                            <asp:BoundField DataField="VIII" HeaderText="VIII" />
                        </Columns>
                    </asp:GridView>
                </asp:Panel>
            </td>
        </tr>
    </table>
</asp:Content>
