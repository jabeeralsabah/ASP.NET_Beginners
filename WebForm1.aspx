<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="appPracitice.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
              <asp:Button ID="Button1" runat="server" Text="TestLifeCycle" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" EnableViewState="False"></asp:TextBox>
        &nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="ViewStateIncrement " />
              <br />
              <br />
            <br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        &nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="SessionStateIncrement " />
              <br />
              <br />
              <br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        &nbsp;<asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="ApplicationStateIncrement" />
              <br />
              <br />
              <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Move to ViewState Page</asp:LinkButton>
              <br />
        </div>
       
    </form>
  
</body>
</html>
