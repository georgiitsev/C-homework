<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sysytem.aspx.cs" Inherits="exam_Georgi_Itsev_29._02._2016.Sysytem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <title>Country Population</title>
    <style>
        .button {
            margin-left: 30px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <asp:LinkButton ID="LinkButton1" Text="Search Population" runat="server" CssClass="button" PostBackUrl="~/Search Page.aspx" />
            <br />
            <br />
        </div>
        <div style="float: left; padding-left: 50px;">
            <asp:Label Text="Country:" runat="server" ID="Country" />
            <br />
            <br />
            <asp:Label Text="Capital:" runat="server" ID="Capital" />
            <br />
            <br />
            <asp:Label Text="Population:" runat="server" ID="Population" />
        </div>
        <div style="display: block; padding-left: 150px;">
            <asp:TextBox runat="server" ID="countryTextBox" />
            <br />
            <br />
            <asp:TextBox runat="server" ID="capitalTextBox" />
            <br />
            <br />
            <asp:TextBox TextMode="Number" runat="server" ID="populationTextBox" />
            <asp:Label Style="padding-left: 5px;" Text="people." runat="server" ID="People" />
            <br />
            <br />
            <asp:Button Text="ADD" runat="server" ID="btnSubmit" OnClick="btnSubmit_Click" />
        </div>
    </form>
</body>
</html>
    
   