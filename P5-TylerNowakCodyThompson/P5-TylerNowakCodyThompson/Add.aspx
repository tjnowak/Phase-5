<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="P5_TylerNowakCodyThompson.Add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="TitleLabel" runat="server" Font-Size="XX-Large" Text="Add a Storm Event"></asp:Label>
        <br />
        <br />
        <asp:Label ID="StormTypeLabel" runat="server" Text="Choose a storm type:"></asp:Label>
&nbsp;
        <asp:DropDownList ID="StormTypeDropdown" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>Astronomical Low Tide</asp:ListItem>
            <asp:ListItem>Avalanche</asp:ListItem>
            <asp:ListItem>Blizzard</asp:ListItem>
            <asp:ListItem>Coastal Flood</asp:ListItem>
            <asp:ListItem>Cold/Wind Chill</asp:ListItem>
            <asp:ListItem>Debris Flow</asp:ListItem>
            <asp:ListItem>Dense Fog</asp:ListItem>
            <asp:ListItem>Dense Smoke</asp:ListItem>
            <asp:ListItem>Drought</asp:ListItem>
            <asp:ListItem>Dust Devil</asp:ListItem>
            <asp:ListItem>Dust Storm</asp:ListItem>
            <asp:ListItem>Excessive Heat</asp:ListItem>
            <asp:ListItem>Exteme Cold/Wind Chill</asp:ListItem>
            <asp:ListItem>Flash Flood</asp:ListItem>
            <asp:ListItem>Flood</asp:ListItem>
            <asp:ListItem>Frost/Freeze</asp:ListItem>
            <asp:ListItem>Funnel Cloud</asp:ListItem>
            <asp:ListItem>Freezing Fog</asp:ListItem>
            <asp:ListItem>Hail</asp:ListItem>
            <asp:ListItem>Heat</asp:ListItem>
            <asp:ListItem>Heavy Rain</asp:ListItem>
            <asp:ListItem>Heavy Snow</asp:ListItem>
            <asp:ListItem>High Surf</asp:ListItem>
            <asp:ListItem>High Wind</asp:ListItem>
            <asp:ListItem>Hurrican</asp:ListItem>
            <asp:ListItem>Ice Storm</asp:ListItem>
            <asp:ListItem>Lake-effect Snow</asp:ListItem>
            <asp:ListItem>Lakeshore Flood</asp:ListItem>
            <asp:ListItem>Lightning</asp:ListItem>
            <asp:ListItem>Marine Hail</asp:ListItem>
            <asp:ListItem>Marine High Wind</asp:ListItem>
            <asp:ListItem>Marine Strong Wind</asp:ListItem>
            <asp:ListItem>Marine Thunderstorm Wind</asp:ListItem>
            <asp:ListItem>Rip Current</asp:ListItem>
            <asp:ListItem>Seiche</asp:ListItem>
            <asp:ListItem>Sleet</asp:ListItem>
            <asp:ListItem>Storm Surge/Tide</asp:ListItem>
            <asp:ListItem>Strong Wind</asp:ListItem>
            <asp:ListItem>Thunderstorm Wind</asp:ListItem>
            <asp:ListItem>Tornado</asp:ListItem>
            <asp:ListItem>Tropical Depression</asp:ListItem>
            <asp:ListItem>Tropical Storm</asp:ListItem>
            <asp:ListItem>Tsunami</asp:ListItem>
            <asp:ListItem>Volcanic Ash</asp:ListItem>
            <asp:ListItem>Waterspout</asp:ListItem>
            <asp:ListItem>Wildfire</asp:ListItem>
            <asp:ListItem>Winter Storm</asp:ListItem>
            <asp:ListItem>Winter Weather</asp:ListItem>
        </asp:DropDownList>
    
        <br />
    
    </div>
        <asp:Label ID="StartYearLabel" runat="server" Text="Enter event start year (Ex: 1976):"></asp:Label>
&nbsp;
        <asp:TextBox ID="StartYearTextBox" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="StartYearError" runat="server" ForeColor="Red" Text="*"></asp:Label>
        <br />
        <br />
        <asp:Label ID="StartMonthLabel" runat="server" Text="Choose event start month:  "></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Value="1">January</asp:ListItem>
            <asp:ListItem Value="2">February</asp:ListItem>
            <asp:ListItem Value="3">March</asp:ListItem>
            <asp:ListItem Value="4">April</asp:ListItem>
            <asp:ListItem Value="5">May</asp:ListItem>
            <asp:ListItem Value="6">June</asp:ListItem>
            <asp:ListItem Value="7">July</asp:ListItem>
            <asp:ListItem Value="8">August</asp:ListItem>
            <asp:ListItem Value="9">September</asp:ListItem>
            <asp:ListItem Value="10">October</asp:ListItem>
            <asp:ListItem Value="11">November</asp:ListItem>
            <asp:ListItem Value="12">December</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="MainMenuButton" runat="server" OnClick="Button1_Click" Text="Main Menu" />
    </form>
</body>
</html>
