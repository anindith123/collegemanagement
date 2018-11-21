<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="AddSubject.aspx.cs" Inherits="Admin_AddSubject" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
  function check()
   {
            var DDLClass=document.getElementById("<%=DDLClass.ClientID%>").selectedIndex;
            if(DDLClass==0)
            {
                alert('Class Required');
                return false;
            }
             var TxtSub2=document.getElementById("<%=TxtSub2.ClientID%>").value;
              var TxtSub3=document.getElementById("<%=TxtSub3.ClientID%>").value;
               var TxtSub4=document.getElementById("<%=TxtSub4.ClientID%>").value;
                var TxtSub5=document.getElementById("<%=TxtSub5.ClientID%>").value;
                 var TxtSub6=document.getElementById("<%=TxtSub6.ClientID%>").value;              
                  var TxtSub7=document.getElementById("<%=TxtSub7.ClientID%>").value;
                   var TxtSub8=document.getElementById("<%=TxtSub8.ClientID%>").value;
            var TxtSub1=document.getElementById("<%=TxtSub1.ClientID%>").value;
            if(TxtSub1=="")
            {
               
                alert('Subject1 Required');
                document.getElementById("<%=TxtSub1.ClientID%>").focus();
                return false;
            }
                       
            
            
             var TxtSub2=document.getElementById("<%=TxtSub2.ClientID%>").value;
            if(TxtSub2=="")
            {
               
                alert('Subject2 Required');
                document.getElementById("<%=TxtSub2.ClientID%>").focus();
                return false;
            }
          
            //&&  TxtSub2==TxtSub3 && TxtSub2==TxtSub3 && TxtSub2==TxtSub4 && TxtSub2==TxtSub5 && TxtSub2==TxtSub6 && TxtSub2==TxtSub7 && TxtSub2==TxtSub8) 
            if(TxtSub1==TxtSub2) 
            {
               
                alert('Subject2 Already Exists');
                document.getElementById("<%=TxtSub2.ClientID%>").focus();
                return false;
            }
            
             var TxtSub3=document.getElementById("<%=TxtSub3.ClientID%>").value;
            if(TxtSub3=="")
            {
               
                alert('Subject3 Required');
                document.getElementById("<%=TxtSub3.ClientID%>").focus();
                return false;
            }
            
            // && TxtSub2==TxtSub3 && TxtSub2==TxtSub4 && TxtSub2==TxtSub5 && TxtSub2==TxtSub6 && TxtSub2==TxtSub7 && TxtSub2==TxtSub8) 
            if(TxtSub1==TxtSub3 || TxtSub2==TxtSub3 )
            {
               
                alert('Subject3 Already Exists');
                document.getElementById("<%=TxtSub3.ClientID%>").focus();
                return false;
            }
            
            var TxtSub4=document.getElementById("<%=TxtSub4.ClientID%>").value;
            if(TxtSub4=="")
            {
               
                alert('Subject4 Required');
                document.getElementById("<%=TxtSub4.ClientID%>").focus();
                return false;
            }
           
             // && TxtSub2==TxtSub3 && TxtSub2==TxtSub4 && TxtSub2==TxtSub5 && TxtSub2==TxtSub6 && TxtSub2==TxtSub7 && TxtSub2==TxtSub8) 
            if(TxtSub1==TxtSub4 || TxtSub2==TxtSub4 || TxtSub3==TxtSub4)
            {
               
                alert('Subject4 Already Exists');
                document.getElementById("<%=TxtSub4.ClientID%>").focus();
                return false;
            }
            
            var TxtSub4=document.getElementById("<%=TxtSub4.ClientID%>").value;
            if(TxtSub4=="")
            {
               
                alert('Subject4 Required');
                document.getElementById("<%=TxtSub4.ClientID%>").focus();
                return false;
            }
            
            
          
            var TxtSub5=document.getElementById("<%=TxtSub5.ClientID%>").value;
            if(TxtSub5=="")
            {
               
                alert('Subject5 Required');
                document.getElementById("<%=TxtSub5.ClientID%>").focus();
                return false;
            }
           
            
                // && TxtSub2==TxtSub3 && TxtSub2==TxtSub4 && TxtSub2==TxtSub5 && TxtSub2==TxtSub6 && TxtSub2==TxtSub7 && TxtSub2==TxtSub8) 
            if(TxtSub1==TxtSub5 || TxtSub2==TxtSub5 || TxtSub3==TxtSub5 || TxtSub4==TxtSub5)
            {
               
                alert('Subject5 Already Exists');
                document.getElementById("<%=TxtSub5.ClientID%>").focus();
                return false;
            }
            var TxtSub6=document.getElementById("<%=TxtSub6.ClientID%>").value;
            if(TxtSub6=="")
            {
               
                alert('Subject6 Required');
                document.getElementById("<%=TxtSub6.ClientID%>").focus();
                return false;
            }
           
              // && TxtSub2==TxtSub3 && TxtSub2==TxtSub4 && TxtSub2==TxtSub5 && TxtSub2==TxtSub6 && TxtSub2==TxtSub7 && TxtSub2==TxtSub8) 
            if(TxtSub1==TxtSub6 || TxtSub2==TxtSub6 || TxtSub3==TxtSub6 || TxtSub4==TxtSub6 || TxtSub5==TxtSub6)
            {
               
                alert('Subject4 Already Exists');
                document.getElementById("<%=TxtSub6.ClientID%>").focus();
                return false;
            }
            
            var TxtSub7=document.getElementById("<%=TxtSub7.ClientID%>").value;
            if(TxtSub7=="")
            {
               
                alert('Subject7 Required');
                document.getElementById("<%=TxtSub7.ClientID%>").focus();
                return false;
            }
           
             // && TxtSub2==TxtSub3 && TxtSub2==TxtSub4 && TxtSub2==TxtSub5 && TxtSub2==TxtSub6 && TxtSub2==TxtSub7 && TxtSub2==TxtSub8) 
            if(TxtSub1==TxtSub7 || TxtSub2==TxtSub7 || TxtSub3==TxtSub7 || TxtSub4==TxtSub7 || TxtSub5==TxtSub7 || TxtSub6==TxtSub7)
            {
               
                alert('Subject4 Already Exists');
                document.getElementById("<%=TxtSub7.ClientID%>").focus();
                return false;
            }
   }
   </script>
   <table cellspacing="5" cellpadding="0" align="center" width="600" class="border1">
   
        <tr>
            <td class="border" colspan="3" align="center">
                <b class="title">Add Subject</b></td>
        </tr>  
       <tr>
           <td align="right" width="50%"><font color="red">*</font><span><b>Select Class:</b></span>
           </td>
           <td>
               <asp:DropDownList ID="DDLClass" runat="server" AppendDataBoundItems="True" Width="87px">
                   <asp:ListItem>Select...</asp:ListItem>
               </asp:DropDownList></td>
       </tr>
        <tr>
            <td align="right"  width="50%" > <font color="red">*</font><span><b>Subject1</b></span>
           
               </td>
            <td >
                <asp:TextBox ID="TxtSub1" runat="server" 
                    ></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>Subject2</b></span>
                </td>
            <td >
                <asp:TextBox ID="TxtSub2" runat="server" 
                    ></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>Subject3</b></span>
                </td>
            <td >
                <asp:TextBox ID="TxtSub3" runat="server" 
                    ></asp:TextBox></td>
        </tr>
        <tr>
            <td style="height: 24px" align="right" ><font color="red">*</font><span><b>Subject4</b></span>
                </td>
            <td style="height: 24px" >
                <asp:TextBox ID="TxtSub4" runat="server" 
                    ></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>Subject5</b></span>
                </td>
            <td >
                <asp:TextBox ID="TxtSub5" runat="server" 
                    ></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>Subject6</b></span>
                </td>
            <td >
                <asp:TextBox ID="TxtSub6" runat="server" 
                    ></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>Subject7</b></span>
                </td>
            <td >
                <asp:TextBox ID="TxtSub7" runat="server" 
                    ></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" ><strong> Subject8 </strong>
                </td>
            <td >
                <asp:TextBox ID="TxtSub8" runat="server" Style="position: static" Width="152px"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <br />
                <asp:Button ID="Submit" runat="server" 
                    Text="" CssClass="button" OnClick="Submit_Click" onclientclick="return check(this);" />
                <asp:Button ID="Clear" runat="server" Text="Clear" CssClass="button" OnClick="Clear_Click"/>
                <asp:Button ID="Back" runat="server" Text="Back" CssClass="button" OnClick="Back_Click" /></td>
        </tr>
    </table>
</asp:Content>

