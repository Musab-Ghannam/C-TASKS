<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cal.aspx.cs" Inherits="cal30nov.cal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body>
    <form id="form1" runat="server">
       
        <div>
            <asp:Label runat="server" Text="Number1"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

            <asp:Label ID="Label1" runat="server" Text="Number2"></asp:Label>
               <asp:TextBox ID="TextBox2" runat="server" style="width: 168px"></asp:TextBox>
          
        
        <asp:Button ID="Buttonsum" runat="server" Text="+" OnClick="Buttonsum_Click" />

        <asp:Button ID="Buttonsub" runat="server" Text="-" OnClick="Buttonsub_Click" />
        <asp:Button ID="ButtonMul" runat="server" Text="*" OnClick="ButtonMul_Click" />
        <asp:Button ID="ButtonDiv" runat="server" Text="/" OnClick="ButtonDiv_Click" />

            </div>

        <div id="result"><br />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="TextResult" runat="server"></asp:TextBox>
            <asp:Button ID="Clear" runat="server" Text="Clear" OnClick="Clear_Click" />




        </div>
    </form>
</body>
</html>
