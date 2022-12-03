<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="USERQUESTION.aspx.cs" Inherits="pr4.USERQUESTION" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>plese answer these question:</h1>
        <div>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            

            <div class="radio">
            <asp:RadioButton ID="RadioButton1" runat="server" value="ahmad" GroupName="ahmad"  Text="EXCELENT"/>
                </div>
         
             <div class="radio">
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="ahmad" Text="VERY GOOD" />
                  </div>

             <div class="radio">
            <asp:RadioButton ID="RadioButton3" runat="server"  GroupName="ahmad" Text="GOOD"  />
                  </div>
           <div class="radio">
         <asp:RadioButton ID="RadioButton4" runat="server" GroupName="ahmad"  Text="POOR" />
                </div>
             <div class="radio">

             <asp:Button ID="Button1" runat="server" Text="Next" OnClick="Button1_Click" />
                       </div>
        </div>
       
<%--                <div>
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
            


            <asp:RadioButton ID="RadioButton5" runat="server" value="ahmad" GroupName="ahmad"  Text="EXCELENT"/>
         
            <asp:RadioButton ID="RadioButton6" runat="server" GroupName="ahmad" Text="VERY GOOD" />
             
            <asp:RadioButton ID="RadioButton7" runat="server"  GroupName="ahmad" Text="GOOD"  />
           
         <asp:RadioButton ID="RadioButton8" runat="server" GroupName="ahmad"  Text="POOR" />
              

        </div>

                <div>
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
            


            <asp:RadioButton ID="RadioButton9" runat="server" value="ahmad" GroupName="ahmad"  Text="EXCELENT"/>
         
            <asp:RadioButton ID="RadioButton10" runat="server" GroupName="ahmad" Text="VERY GOOD" />
             
            <asp:RadioButton ID="RadioButton11" runat="server"  GroupName="ahmad" Text="GOOD"  />
           
         <asp:RadioButton ID="RadioButton12" runat="server" GroupName="ahmad"  Text="POOR" />
              

        </div>

                <div>
            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
            


            <asp:RadioButton ID="RadioButton13" runat="server" value="ahmad" GroupName="ahmad"  Text="EXCELENT"/>
         
            <asp:RadioButton ID="RadioButton14" runat="server" GroupName="ahmad" Text="VERY GOOD" />
             
            <asp:RadioButton ID="RadioButton15" runat="server"  GroupName="ahmad" Text="GOOD"  />
           
         <asp:RadioButton ID="RadioButton16" runat="server" GroupName="ahmad"  Text="POOR" />
              

        </div>--%>
    </form>
</body>
</html>
