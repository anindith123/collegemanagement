<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="SendMSG.aspx.cs" Inherits="SendMSG" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<%--<script language="javascript" type="text/javascript">
  function check()
   {
            var DDLUserType=document.getElementById("<%=DDLUserType.ClientID%>").selectedIndex;
            if(DDLUserType==0)
            {
                alert('UserType Required');
                return false;
            }
           
         
             var DDLUserName=document.getElementById("<%=DDLUserName.ClientID%>").selectedIndex;
            if(DDLUserName==0)
            {
                alert('UserName Required');
                return false;
            }
            
           
             var TxtMSG=document.getElementById("<%=TxtMSG.ClientID%>").value; 
            if(TxtMSG=="")
            {
                alert("Enter ");
                document.getElementById("<%=TxtDate.ClientID%>").focus();
                return false;
            }
            
              var FileUpload1=document.getElementById("<%=FileUpload1.ClientID%>").value;
            if(FileUpload1!="")
                {
                   
                    var i=FileUpload1.length;
                    var j=FileUpload1.indexOf('.');
                    var FileExt=(FileUpload1.substring(j,i)).toLowerCase();
                    if((FileExt!=".doc")&&(FileExt!=".docx")&&(FileExt!=".rtf"))
                    {
                        alert('UploadProfile Must be in Word Documents only');
                        document.getElementById("<%=FileUpload1.ClientID%>").focus();
                        return false;
                    }
                }
                else
                {
                    alert('Upload File');
                    document.getElementById("<%=FileUpload1.ClientID%>").focus();
                    return false;
                }
   }
   </script>--%>
    <table align="center" cellpadding="0" cellspacing="5" class="border1" style="position: static"
        width="700">
        <tr>
            <td align="center" class="border" colspan="3">
                <b class="title">Send Message</b></td>
        </tr>
        <tr>
            <td ><font color="red">*</font><span><b>Select UserType:</b></span>
            </td>
            <td >
                <asp:DropDownList ID="DDLUserType" runat="server" AppendDataBoundItems="True" Width="142px">
                    <asp:ListItem>Select..</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td ><font color="red">*</font><span><b>Select UserName:</b></span>
            </td>
            <td >
                <asp:DropDownList ID="DDLUserName" runat="server" AppendDataBoundItems="True" Width="144px">
                    <asp:ListItem>Select...</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td ><span><b>Message :</b></span>
            </td>
            <td >
                <asp:TextBox ID="TxtMSG" runat="server" Height="103px" TextMode="MultiLine" Width="427px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >
            </td>
            <td >
            </td>
        </tr>
        <tr>
            <td >
            </td>
            <td >
                <asp:Button ID="MSG" runat="server" Text="SendMessage"  CssClass="button" Width="109px" OnClick="MSG_Click"/></td>
        </tr>
    </table>
</asp:Content>

