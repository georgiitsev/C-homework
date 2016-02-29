<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search Page.aspx.cs" Inherits="exam_Georgi_Itsev_29._02._2016.Search_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Population Statistics</title>
    <style>
        .button {
            margin-left: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton ID="LinkButton1" Text="Add New Country" runat="server" CssClass="button" PostBackUrl="~/Home Page.aspx" />
            <br />
            <br />
        </div>
        <div style="float: left; padding-left: 50px;">
            <asp:Label Text="Search by country:" runat="server" ID="CountrySearch" />
            <br />
            <br />
            <asp:Label Text="Search by capital:" runat="server" ID="CapitalSearch" />
            <br />
            <br />
            <asp:Label Text="Search by population:" runat="server" ID="PopulationSearch" />
        </div>
        <div style="display: block; padding-left: 200px;">
            <asp:TextBox runat="server" ID="countryTextBox" />
            <br />
            <br />
            <asp:TextBox runat="server" ID="capitalTextBox" />
            <br />
            <br />
            <asp:TextBox TextMode="Number" runat="server" ID="populationTextBox" />
            <br />
            <br />
            <asp:Button Text="SEARCH" runat="server" ID="btnSearch" OnClick="btnSearch_Click" />
            </div>
        <div>
            <h1>Statistics:</h1>
        </div>
        <div style="float: left; padding-left: 50px;">
            <asp:Repeater runat="server" ID="infoRepeater">
                <ItemTemplate>
                    <asp:Label ID="Label1" Text='<%# Eval("Country") %>' runat="server" />
                    <br />
                    <asp:Label ID="Label2" Text='<%# Eval("Capital") %>' runat="server" />
                    <br />
                    <asp:Label ID="Label3" Text='<%# Eval("Population") %>' runat="server" />
                    <br />
                    <br />
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
