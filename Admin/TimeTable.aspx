<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="TimeTable.aspx.cs" Inherits="Admin_TimeTable" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


     <table cellspacing="5" cellpadding="0" align="center" width="600" class="border1">
   
        <tr>
            <td class="border" colspan="3" align="center">
                <b class="title">Add TimeTable</b></td>
        </tr>
        <tr>
            <td style="width: 235px"><font color="red"></font><span><b><asp:Label ID="LblDay" runat="server" Text="Select Day:"></asp:Label></b></span>
            </td>
            <td >
                <asp:DropDownList ID="DdlDay" runat="server" AppendDataBoundItems="True" Style="position: static"
                    Width="131px" >
                    <asp:ListItem>Select..</asp:ListItem>
                    <asp:ListItem>Mon</asp:ListItem>
                    <asp:ListItem>Tue</asp:ListItem>
                    <asp:ListItem>Wed</asp:ListItem>
                    <asp:ListItem>Thu</asp:ListItem>
                    <asp:ListItem>Fri</asp:ListItem>
                    <asp:ListItem>Sat</asp:ListItem>
                </asp:DropDownList></td>
            <td >
            </td>
        </tr>
         <tr>
             <td ><font color="red"></font><span><b><asp:Label ID="LblDayU" runat="server" Text="Day:"></asp:Label></b></span>
             </td>
             <td>
                 <asp:Label ID="LDay" runat="server" Text=""></asp:Label></td>
             <td>
             </td>
         </tr>
         <tr>
             <td ><font color="red"></font><span><b><asp:Label ID="LabelClass" runat="server" Text="Class:"></asp:Label></b></span>
             </td>
             <td>
                 <asp:Label ID="LClass" runat="server" Text=""></asp:Label>
             </td>
             <td>
             </td>
         </tr>
        
        <tr>
            <td style="width: 235px" ><font color="red"></font><span><b><asp:Label ID="Label1Class" runat="server" Text="Select Class:"></asp:Label></b></span>
            </td>
            <td >
                &nbsp;<asp:DropDownList ID="DDLClass" runat="server" AppendDataBoundItems="True" OnSelectedIndexChanged="DDLClass_SelectedIndexChanged" Width="131px" AutoPostBack="True">
                    <asp:ListItem>Select..</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td >
            </td>
        </tr>
         <tr>
             <td style="width: 235px">
             </td>
             <td>
             </td>
             <td>
             </td>
         </tr>
        <tr>
            <td style="width: 235px" >
            </td>
            <td ><font color="red">*</font><span><b>Select Subject:</b></span>
            </td>
            <td ><font color="red">*</font><span><b>Select Teacher:</b></span>
            </td>
        </tr>
        <tr>
            <td style="width: 235px" ><font color="red">*</font><span><b>I period:</b></span>
            </td>
            <td >
                <asp:DropDownList ID="DDLSubject1" runat="server" AppendDataBoundItems="True" Width="134px" OnSelectedIndexChanged="DDLSubject1_SelectedIndexChanged" AutoPostBack="True">
                    <asp:ListItem>Select..</asp:ListItem>
                </asp:DropDownList></td>
            <td >
                <asp:DropDownList ID="DDLSubjectTeacher1" runat="server" 
                    AppendDataBoundItems="True" Width="134px" AutoPostBack="True">
                    <asp:ListItem>Select..</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 235px" ><font color="red">*</font><span><b>II period:</b></span>
            </td>
            <td >
                <asp:DropDownList ID="DDLSubject2" runat="server" AppendDataBoundItems="True" Width="134px" AutoPostBack="True" OnSelectedIndexChanged="DDLSubject2_SelectedIndexChanged">
                    <asp:ListItem>Select..</asp:ListItem>
                </asp:DropDownList></td>
            <td >
                <asp:DropDownList ID="DDLSubjectTeacher2" runat="server" 
                    AppendDataBoundItems="True" Width="134px" AutoPostBack="True">
                    <asp:ListItem>Select..</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 235px" ><font color="red">*</font><span><b>III period:</b></span>
            </td>
            <td >
                <asp:DropDownList ID="DDLSubject3" runat="server" AppendDataBoundItems="True" Width="134px" AutoPostBack="True" OnSelectedIndexChanged="DDLSubject3_SelectedIndexChanged">
                    <asp:ListItem>Select..</asp:ListItem>
                </asp:DropDownList></td>
            <td >
                <asp:DropDownList ID="DDLSubjectTeacher3" runat="server" 
                    AppendDataBoundItems="True" Width="134px" AutoPostBack="True">
                    <asp:ListItem>Select..</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 235px; height: 22px;" ><font color="red">*</font><span><b>IV period:</b></span>
            </td>
            <td style="height: 22px" >
                <asp:DropDownList ID="DDLSubject4" runat="server" AppendDataBoundItems="True" Width="134px" AutoPostBack="True" OnSelectedIndexChanged="DDLSubject4_SelectedIndexChanged">
                    <asp:ListItem>Select..</asp:ListItem>
                </asp:DropDownList></td>
            <td style="height: 22px" >
                <asp:DropDownList ID="DDLSubjectTeacher8" runat="server" 
                    AppendDataBoundItems="True" Width="134px" AutoPostBack="True">
                    <asp:ListItem>Select..</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
         <tr>
             <td style="height: 13px; width: 235px;">
                 <span style="color: #ff0000">*</span><span><b>V period:</b></span>
             </td>
             <td style="height: 13px"><asp:DropDownList ID="DDLSubject5" runat="server" AppendDataBoundItems="True" Width="134px" AutoPostBack="True" OnSelectedIndexChanged="DDLSubject5_SelectedIndexChanged">
                 <asp:ListItem>Select..</asp:ListItem>
             </asp:DropDownList></td>
             <td style="height: 13px"><asp:DropDownList ID="DDLSubjectTeacher4" runat="server" 
                     AppendDataBoundItems="True" Width="134px" AutoPostBack="True">
                 <asp:ListItem>Select..</asp:ListItem>
             </asp:DropDownList></td>
         </tr>
         <tr>
             <td style="width: 235px">
                 <span style="color: #ff0000">*</span><span><b>VI period:</b></span>
             </td>
             <td><asp:DropDownList ID="DDLSubject6" runat="server" AppendDataBoundItems="True" Width="134px" AutoPostBack="True" OnSelectedIndexChanged="DDLSubject6_SelectedIndexChanged">
                 <asp:ListItem>Select..</asp:ListItem>
             </asp:DropDownList></td>
             <td><asp:DropDownList ID="DDLSubjectTeacher5" runat="server" 
                     AppendDataBoundItems="True" Width="134px" AutoPostBack="True">
                 <asp:ListItem>Select..</asp:ListItem>
             </asp:DropDownList></td>
         </tr>
        <tr>
            <td style="width: 235px" ><font color="red">*</font><span><b>VII period:</b></span>
            </td>
            <td >
                <asp:DropDownList ID="DDLSubject7" runat="server" AppendDataBoundItems="True"
                    Width="134px" AutoPostBack="True" OnSelectedIndexChanged="DDLSubject7_SelectedIndexChanged">
                    <asp:ListItem>Select..</asp:ListItem>
                </asp:DropDownList></td>
            <td >
                <asp:DropDownList ID="DDLSubjectTeacher6" runat="server" AppendDataBoundItems="True"
                    Width="134px" AutoPostBack="True">
                    <asp:ListItem>Select..</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 235px" ><font color="red">*</font><span><b>VIII period:</b></span>
            </td>
            <td >
                <asp:DropDownList ID="DDLSubject8" runat="server" AppendDataBoundItems="True"
                    Width="134px" AutoPostBack="True" OnSelectedIndexChanged="DDLSubject8_SelectedIndexChanged">
                    <asp:ListItem>Select..</asp:ListItem>
                </asp:DropDownList></td>
            <td >
                <asp:DropDownList ID="DDLSubjectTeacher7" runat="server" AppendDataBoundItems="True"
                    Width="134px" AutoPostBack="True">
                    <asp:ListItem>Select..</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
       
        <tr>
            <td style="width: 235px" ><font color="red"></font>
            </td>
            <td >
                <asp:Button ID="Submit" runat="server" Text="Button" CssClass="button" OnClick="Submit_Click" />
                <asp:Button ID="Back" runat="server" Text="Back" CssClass="button" OnClick="Back_Click"/></td>
            <td >
            </td>
        </tr>
    </table>
</asp:Content>

