<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayStatistics.aspx.cs" Inherits="P5_TylerNowakCodyThompson.DisplayStatistics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="Please select an option below:"></asp:Label>
        <br />
        <asp:RadioButtonList ID="StatsOptionsRBList" runat="server">
            <asp:ListItem>Calculate top three most destructive storms</asp:ListItem>
            <asp:ListItem>Determine overall fatalities in a state due to a type of storm</asp:ListItem>
            <asp:ListItem>Determine average tornado damage by state</asp:ListItem>
            <asp:ListItem>Go back to main menu</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="NoneSelected" runat="server" Text="Please select an option" Visible="False"></asp:Label>
        <br />
        <asp:Button ID="DisplayStatsButton" runat="server" OnClick="DisplayStatsButton_Click" Text="Go" />
        <br />
    </form>
</body>
</html>
