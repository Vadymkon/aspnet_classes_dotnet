﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebPageForLib.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

        <p> X:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></p>
        <p>
             Y: 
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox> </p>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" /> <br/>
        <asp:Label ID="Label1" runat="server" Text="RES" Font-Bold="true" Font-Size="16"></asp:Label>
    </form>
</body>
</html>
