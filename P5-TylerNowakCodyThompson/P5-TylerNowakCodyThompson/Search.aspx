<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="P5_TylerNowakCodyThompson.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="TitleLabel" runat="server" Font-Size="XX-Large" Text="Search for Storm Events"></asp:Label>
        <br />
        <br />
        <asp:Label ID="StormTypeLabel" runat="server" Text="Choose a storm type to search for:"></asp:Label>
&nbsp;
        <asp:DropDownList ID="StormTypeDropdown" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Value="&quot; &quot;">Pick One</asp:ListItem>
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
        <asp:Label ID="FieldNameLabel" runat="server" Text="Choose the field name you want to search:"></asp:Label>
&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" style="height: 22px">
            <asp:ListItem Value="&quot; &quot;">Pick One</asp:ListItem>
            <asp:ListItem Value="EVENT TYPE">Event Type</asp:ListItem>
            <asp:ListItem Value="TORNADO TYPE">Tornado Type</asp:ListItem>
            <asp:ListItem Value="STATE">State</asp:ListItem>
            <asp:ListItem Value="COUNTY">County</asp:ListItem>
            <asp:ListItem Value="START AZIMUTH">Start Azimuth</asp:ListItem>
            <asp:ListItem Value="START LOCATION">Start Location</asp:ListItem>
            <asp:ListItem Value="END AZIMUTH">End Azimuth</asp:ListItem>
            <asp:ListItem Value="END LOCATION">End Location</asp:ListItem>
            <asp:ListItem Value="TIME ZONE">Time Zone</asp:ListItem>
            <asp:ListItem Value="INJURIES">Injuries</asp:ListItem>
            <asp:ListItem Value="FATALITIES">Fatalities</asp:ListItem>
            <asp:ListItem Value="WIND SPEED">Wind Speed</asp:ListItem>
            <asp:ListItem Value="HAIL SIZE">Hail Size</asp:ListItem>
            <asp:ListItem Value="START RANGE">Start Range</asp:ListItem>
            <asp:ListItem Value="END RANGE">End Range</asp:ListItem>
            <asp:ListItem Value="START YEAR">Start Year</asp:ListItem>
            <asp:ListItem Value="START MONTH">Start Month</asp:ListItem>
            <asp:ListItem Value="START DAY">Start Day</asp:ListItem>
            <asp:ListItem Value="START TIME">Start Time</asp:ListItem>
            <asp:ListItem Value="END YEAR">End Year</asp:ListItem>
            <asp:ListItem Value="END MONTH">End Month</asp:ListItem>
            <asp:ListItem Value="END DAY">End Day</asp:ListItem>
            <asp:ListItem Value="END TIME">End Time</asp:ListItem>
            <asp:ListItem Value="TORNADO LENGTH">Tornado Length</asp:ListItem>
            <asp:ListItem Value="TORNADO WIDTH">Tornado Width</asp:ListItem>
            <asp:ListItem Value="START LATITUDE">Start Latitude</asp:ListItem>
            <asp:ListItem Value="START LONGITUDE">Start Longitude</asp:ListItem>
            <asp:ListItem Value="END LATITUDE">End Latitude</asp:ListItem>
            <asp:ListItem Value="END LONGITUDE">End Longitude</asp:ListItem>
            <asp:ListItem Value="PROPERTY DAMAGE">Property Damage</asp:ListItem>
            <asp:ListItem Value="CROP DAMAGE">Crop Damage</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="MainMenuButton" runat="server" OnClick="Button1_Click" Text="Main Menu" />
    </form>
</body>
</html>
