<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TopThree.aspx.cs" Inherits="P5_TylerNowakCodyThompson.TopThree" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Button ID="TopThreeToMain" runat="server" OnClick="FatalToMain_Click" Text="Go Back To Main Menu" />
&nbsp;
        <asp:Button ID="TopThreeToStats" runat="server" OnClick="FatalToStats_Click" Text="Go Back To Statistics Options" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Please select a storm type below for the top three most damaging storms you would like to see:"></asp:Label>
        <br />
        <br />
        <asp:DropDownList ID="StormTypeDropDown1" runat="server" OnSelectedIndexChanged="StormTypeDropDown_SelectedIndexChanged" AutoPostBack="True">
            <asp:ListItem Value="&quot; &quot;">Pick One</asp:ListItem>
            <asp:ListItem Value="ASTRONOMICAL LOW TIDE">Astronomical Low Tide</asp:ListItem>
            <asp:ListItem Value="AVALANCHE">Avalanche</asp:ListItem>
            <asp:ListItem Value="BLIZZARD">Blizzard</asp:ListItem>
            <asp:ListItem Value="COASTAL FLOOD">Coastal Flood</asp:ListItem>
            <asp:ListItem Value="COLD/WIND CHILL">Cold/Wind Chill</asp:ListItem>
            <asp:ListItem Value="DEBRIS FLOW">Debris Flow</asp:ListItem>
            <asp:ListItem Value="DENSE FOG">Dense Fog</asp:ListItem>
            <asp:ListItem Value="DENSE SMOKE">Dense Smoke</asp:ListItem>
            <asp:ListItem Value="DROUGHT">Drought</asp:ListItem>
            <asp:ListItem Value="DUST DEVIL">Dust Devil</asp:ListItem>
            <asp:ListItem Value="DUST STORM">Dust Storm</asp:ListItem>
            <asp:ListItem Value="EXCESSIVE HEAT">Excessive Heat</asp:ListItem>
            <asp:ListItem Value="EXTREME COLD/WIND CHILL">Exteme Cold/Wind Chill</asp:ListItem>
            <asp:ListItem Value="FLASH FLOOD">Flash Flood</asp:ListItem>
            <asp:ListItem Value="FLOOD">Flood</asp:ListItem>
            <asp:ListItem Value="FROST/FREEZE">Frost/Freeze</asp:ListItem>
            <asp:ListItem Value="FUNNEL CLOUD">Funnel Cloud</asp:ListItem>
            <asp:ListItem Value="FREEZING FOG">Freezing Fog</asp:ListItem>
            <asp:ListItem Value="HAIL">Hail</asp:ListItem>
            <asp:ListItem Value="HEAT">Heat</asp:ListItem>
            <asp:ListItem Value="HEAVY RAIN">Heavy Rain</asp:ListItem>
            <asp:ListItem Value="HEAVY SNOW">Heavy Snow</asp:ListItem>
            <asp:ListItem Value="HIGH SURF">High Surf</asp:ListItem>
            <asp:ListItem Value="HIGH WIND">High Wind</asp:ListItem>
            <asp:ListItem Value="HURRICANE">Hurricane</asp:ListItem>
            <asp:ListItem Value="ICE STORM">Ice Storm</asp:ListItem>
            <asp:ListItem Value="LAKE-EFFECT SNOW">Lake-effect Snow</asp:ListItem>
            <asp:ListItem Value="LAKESHORE FLOOD">Lakeshore Flood</asp:ListItem>
            <asp:ListItem Value="LIGHTNING">Lightning</asp:ListItem>
            <asp:ListItem Value="MARINE HAIL">Marine Hail</asp:ListItem>
            <asp:ListItem Value="MARINE HIGH WIND">Marine High Wind</asp:ListItem>
            <asp:ListItem Value="MARINE STRONG WIND">Marine Strong Wind</asp:ListItem>
            <asp:ListItem Value="MARINE THUNDERSTORM WIND">Marine Thunderstorm Wind</asp:ListItem>
            <asp:ListItem Value="RIP CURRENT">Rip Current</asp:ListItem>
            <asp:ListItem Value="SEICHE">Seiche</asp:ListItem>
            <asp:ListItem Value="SLEET">Sleet</asp:ListItem>
            <asp:ListItem Value="STORM SURGE/TIDE">Storm Surge/Tide</asp:ListItem>
            <asp:ListItem Value="STRONG WIND">Strong Wind</asp:ListItem>
            <asp:ListItem Value="THUNDERSTORM WIND">Thunderstorm Wind</asp:ListItem>
            <asp:ListItem Value="TORNADO">Tornado</asp:ListItem>
            <asp:ListItem Value="TROPICAL DEPRESSION">Tropical Depression</asp:ListItem>
            <asp:ListItem Value="TROPICAL STORM">Tropical Storm</asp:ListItem>
            <asp:ListItem Value="TSUNAMI">Tsunami</asp:ListItem>
            <asp:ListItem Value="VOLCANIC ASH">Volcanic Ash</asp:ListItem>
            <asp:ListItem Value="WATERSPOUT">Waterspout</asp:ListItem>
            <asp:ListItem Value="WILDFIRE">Wildfire</asp:ListItem>
            <asp:ListItem Value="WINTER STORM">Winter Storm</asp:ListItem>
            <asp:ListItem Value="WINTER WEATHER">Winter Weather</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:Button ID="CalculateTopThree" runat="server" OnClick="CalculateTopThree_Click" Text="Get Top Three" />
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:ListBox ID="DisplayResults" runat="server" Visible="False"></asp:ListBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="If you would like to pick another storm type and try again, click the button below:" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Button ID="TryAgain" runat="server" OnClick="TryAgain_Click" Text="Try again" Visible="False" />
        <br />
        <br />
    </form>
</body>
</html>
