<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true"
    CodeFile="AddReport.aspx.cs" Inherits="Admin_AddReport" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <script language="javascript" type="text/javascript">
  function check()
   {
            var DDLClass=document.getElementById("<%=DDLClass.ClientID%>").selectedIndex;
            if(DDLClass==0)
            {
                alert('Class Required');
                return false;
            }
           
         
             var DDLSubject=document.getElementById("<%=DDLSubject.ClientID%>").selectedIndex;
            if(DDLSubject==0)
            {
                alert('Subject Required');
                return false;
            }
            //DDLStudent
             var DDLStudent=document.getElementById("<%=DDLStudent.ClientID%>").selectedIndex;
            if(DDLStudent==0)
            {
                alert('Student Name Required');
                return false;
            }
             var DDLExam=document.getElementById("<%=DDLExam.ClientID%>").selectedIndex;
            if(DDLExam==0)
            {
                alert('Exam Type Required');
                return false;
            }
            
            var TxtMarks=document.getElementById("<%=TxtMarks.ClientID%>").value;
            if(TxtMarks=="")
            {
               
                alert('Marks Required');
                document.getElementById("<%=TxtMarks.ClientID%>").focus();
                return false;
            }
            else if(TxtMarks!="")
            {
                var Exp=/^[0-9.]+$/;
                if(!TxtMarks.match(Exp))
                {
                    alert('Marks Digits Only');
                    document.getElementById("<%=TxtMarks.ClientID%>").focus();
                    return false;
                }
            }
           
   }
    </script>

    <table align="center" cellpadding="0" cellspacing="5" class="border1" width="600">
        <tr>
            <td align="center" class="border" colspan="2">
                <b class="title">Add Marks</b></td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>Select Class:</b></span>
            </td>
            <td>
                <asp:DropDownList ID="DDLClass" runat="server" AppendDataBoundItems="True" AutoPostBack="True"
                    OnSelectedIndexChanged="DDLClass_SelectedIndexChanged" Width="152px">
                    <asp:ListItem>Select....</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>Select Subject:</b></span>
            </td>
            <td>
                <asp:DropDownList ID="DDLSubject" runat="server" Width="152px">
                    <asp:ListItem>Select....</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>Select Student:</b></span>
            </td>
            <td>
                <asp:DropDownList ID="DDLStudent" runat="server" AppendDataBoundItems="True" Width="151px">
                    <asp:ListItem>Select...</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>Select Type Of Exam:</b></span>
            </td>
            <td>
                <asp:DropDownList ID="DDLExam" runat="server" AppendDataBoundItems="True" Width="153px">
                    <asp:ListItem>Select..</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>Marks:</b></span>
            </td>
            <td>
                <asp:TextBox ID="TxtMarks" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <asp:Button ID="Submit" runat="server" Text="Button" CssClass="button" OnClick="Submit_Click"
                    OnClientClick="return check(this);" />
                <asp:Button ID="Claer" runat="server" Text="Clear" CssClass="button" OnClick="Claer_Click"/>
                <asp:Button ID="Back" runat="server" Text="Back" CssClass="button" OnClick="Back_Click"/></td>
        </tr>
    </table>
</asp:Content>
