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
        <asp:DropDownList ID="StormTypeDropDown" runat="server" OnSelectedIndexChanged="StormTypeDropDown_SelectedIndexChanged" AutoPostBack="True">
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
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="PropertyUpdatePanel" runat="server">
            <ContentTemplate>
                <asp:Label ID="FieldNameLabel" runat="server" Text="Choose the field name you want to search:"></asp:Label>
                &nbsp;
                <asp:DropDownList ID="PropertyDropDown" runat="server" OnSelectedIndexChanged="PropertyDropDown_SelectedIndexChanged" style="height: 22px" AutoPostBack="True">
                    <asp:ListItem Value="&quot; &quot;">Pick One</asp:ListItem>
                    <asp:ListItem Value="EVENT TYPE">Event Type</asp:ListItem>
                    <asp:ListItem Value="STATE">State</asp:ListItem>
                    <asp:ListItem Value="COUNTY">County</asp:ListItem>
                    <asp:ListItem Value="START AZIMUTH">Start Azimuth</asp:ListItem>
                    <asp:ListItem Value="START LOCATION">Start Location</asp:ListItem>
                    <asp:ListItem Value="END AZIMUTH">End Azimuth</asp:ListItem>
                    <asp:ListItem Value="END LOCATION">End Location</asp:ListItem>
                    <asp:ListItem Value="TIME ZONE">Time Zone</asp:ListItem>
                    <asp:ListItem Value="INJURIES">Injuries</asp:ListItem>
                    <asp:ListItem Value="FATALITIES">Fatalities</asp:ListItem>
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
                    <asp:ListItem Value="START LATITUDE">Start Latitude</asp:ListItem>
                    <asp:ListItem Value="START LONGITUDE">Start Longitude</asp:ListItem>
                    <asp:ListItem Value="END LATITUDE">End Latitude</asp:ListItem>
                    <asp:ListItem Value="END LONGITUDE">End Longitude</asp:ListItem>
                    <asp:ListItem Value="PROPERTY DAMAGE">Property Damage</asp:ListItem>
                    <asp:ListItem Value="CROP DAMAGE">Crop Damage</asp:ListItem>
                </asp:DropDownList>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="StormTypeDropDown" />
            </Triggers>
        </asp:UpdatePanel>
        <br />
    
    </div>
&nbsp;<asp:UpdatePanel ID="ValueUpdatePanel" runat="server">
            <ContentTemplate>
                <asp:Label ID="Value1QuestionLabel" runat="server"></asp:Label>
                &nbsp;
                <asp:TextBox ID="Value1TextBox" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <br />
                <asp:Label ID="Value2QuestionLabel" runat="server"></asp:Label>
                &nbsp;
                <asp:TextBox ID="Value2TextBox" runat="server"></asp:TextBox>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="PropertyDropDown" />
            </Triggers>
        </asp:UpdatePanel>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="MainMenuButton" runat="server" OnClick="MainMenuButton_Click" Text="Main Menu" />
    </form>
</body>
</html>
