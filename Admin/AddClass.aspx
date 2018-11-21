<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="AddClass.aspx.cs" Inherits="Admin_AddClass" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
  function check()
   {
                               
            var TxClass=document.getElementById("<%=TxClass.ClientID%>").value;
            if(TxClass=="")
            {
               
                alert('Class Required');
                document.getElementById("<%=TxClass.ClientID%>").focus();
                return false;
            }
            else if(TxClass!="")
            {
                var Exp=/^[a-zA-Z 0-9 ,.]+$/;
                if(!TxClass.match(Exp))
                {
                    alert('Class Should Character Only');
                    document.getElementById("<%=TxClass.ClientID%>").focus();
                    return false;
                }
            }
           
              var ddl=document.getElementById("<%=ddl.ClientID%>").selectedIndex;
            if(ddl==0)
            {
                alert('Select ClassTeacher');
                return false;
            }
           
            
   }
   </script>
     <table cellspacing="5" cellpadding="0" align="center" width="700" class="border1">
   
        <tr>
            <td class="border" colspan="3" align="center">
                <b class="title">Add Class</b></td>
        </tr>  
           
        <tr >
            <td >
                &nbsp;</td>
            <td >
                <strong>ClassName </strong>
            </td>
            <td >
                <strong>Class Teacher </strong>
            </td>
        </tr>
        <tr >
            <td >
                </td>
            <td >
                <asp:TextBox ID="TxClass" runat="server" Style="position: static"></asp:TextBox></td>
            <td >
                <asp:DropDownList ID="ddl" runat="server" AppendDataBoundItems="True" Width="120px"  >
                    <asp:ListItem>Select....</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr >
            <td >
            </td>
            <td align="center" colspan="2" >
                <asp:Button ID="Submit" runat="server" OnClick="Button1_Click"  CssClass="button" onclientclick="return check(this);" />
                <asp:Button ID="clear" runat="server" Text="Clear" CssClass="button"/>
                <asp:Button ID="Back" runat="server" Text="Back" CssClass="button" OnClick="Back_Click"/></td>
        </tr>
    </table>
</asp:Content>

