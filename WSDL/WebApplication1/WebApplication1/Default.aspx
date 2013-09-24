<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<html>
<head>
<title>
my lab4
</title>
</head>
<body>
<form id="form1" runat="server">
<h1 align="center">
    Calculator</h1>
<p align="center">
<asp:Label ID="x_label" runat="server" Text="x_label" Height="10px" Width="40px"></asp:Label>
&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="x_box" runat="server" Width="72px" BorderStyle="Solid" 
        style="margin-left: 0px" BorderColor="#000099"></asp:TextBox>
<br />
<br />

    <asp:Label ID="y_label" runat="server" Text="y_label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="y_box" runat="server" Width="74px" BorderStyle="Solid" 
        BorderColor="#000099"></asp:TextBox>
<br />
<br />
<asp:Button ID="add_button" runat="server" onclick="Button1_Click" Text="add_button" />
<br />
<br />
<asp:Button ID="sub_button" runat="server" onclick="Button1_Click1" Text="sub_button" />
<br />
<br />
    <asp:Button ID="mul_button" runat="server" Text="mul_button" 
        onclick="mul_button_Click" Height="27px" />
<br />
<br />
    <asp:Button ID="div_button" runat="server" Text="div_button" 
        onclick="div_button_Click" />
<br />
<br />
<asp:TextBox ID="z_box" runat="server"  
        BorderStyle="Solid" BorderColor="#000099"></asp:TextBox>
</p>
</form>
</body>
</html>
