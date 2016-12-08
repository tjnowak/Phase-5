<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Fatalities.aspx.cs" Inherits="P5_TylerNowakCodyThompson.Fatalities" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Button ID="FatalToMain" runat="server" OnClick="FatalToMain_Click" Text="Go Back To Main Menu" />
&nbsp;
        <asp:Button ID="FatalToStats" runat="server" OnClick="FatalToStats_Click" Text="Go Back To Statistics Options" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Determine overall fatalities in a state due to a type of storm"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Please select a storm type:"></asp:Label>
        <br />
        <asp:DropDownList ID="StormTypeDropDown2" runat="server" OnSelectedIndexChanged="StormTypeDropDown_SelectedIndexChanged" AutoPostBack="True">
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
        <asp:Label ID="Label2" runat="server" Text="Please select a state:"></asp:Label>
        <br />
        <asp:DropDownList ID="StateDropDown0" runat="server" OnSelectedIndexChanged="StateDropDown0_SelectedIndexChanged">
            <asp:ListItem>Pick One</asp:ListItem>
            <asp:ListItem>ALABAMA</asp:ListItem>
            <asp:ListItem>ALASKA</asp:ListItem>
            <asp:ListItem>AMERICAN SAMOA</asp:ListItem>
            <asp:ListItem>ARIZONA</asp:ListItem>
            <asp:ListItem>ARKANSAS</asp:ListItem>
            <asp:ListItem>ATLANTIC NORTH</asp:ListItem>
            <asp:ListItem>ATLANTIC SOUTH</asp:ListItem>
            <asp:ListItem>CALIFORNIA</asp:ListItem>
            <asp:ListItem>COLORADO</asp:ListItem>
            <asp:ListItem>CONNECTICUT</asp:ListItem>
            <asp:ListItem>DELAWARE</asp:ListItem>
            <asp:ListItem>DISTRICT OF COLUMBIA</asp:ListItem>
            <asp:ListItem>E PACIFIC</asp:ListItem>
            <asp:ListItem>FLORIDA</asp:ListItem>
            <asp:ListItem>GEORGIA</asp:ListItem>
            <asp:ListItem>GUAM</asp:ListItem>
            <asp:ListItem>GULF OF MEXICO</asp:ListItem>
            <asp:ListItem>HAWAII</asp:ListItem>
            <asp:ListItem>HAWAII WATERS</asp:ListItem>
            <asp:ListItem>IDAHO</asp:ListItem>
            <asp:ListItem>ILLINOIS</asp:ListItem>
            <asp:ListItem>INDIANA</asp:ListItem>
            <asp:ListItem>IOWA</asp:ListItem>
            <asp:ListItem>KANSAS</asp:ListItem>
            <asp:ListItem>KENTUCKY</asp:ListItem>
            <asp:ListItem>LAKE ERIE</asp:ListItem>
            <asp:ListItem>LAKE HURON</asp:ListItem>
            <asp:ListItem>LAKE MICHIGAN</asp:ListItem>
            <asp:ListItem>LAKE ONTARIO</asp:ListItem>
            <asp:ListItem>LAKE ST CLAIR</asp:ListItem>
            <asp:ListItem>LAKE SUPERIOR</asp:ListItem>
            <asp:ListItem>LOUISIANA</asp:ListItem>
            <asp:ListItem>MAINE</asp:ListItem>
            <asp:ListItem>MARYLAND</asp:ListItem>
            <asp:ListItem>MASSACHUSETTS</asp:ListItem>
            <asp:ListItem>MICHIGAN</asp:ListItem>
            <asp:ListItem>MINNESOTA</asp:ListItem>
            <asp:ListItem>MISSISSIPPI</asp:ListItem>
            <asp:ListItem>MISSOURI</asp:ListItem>
            <asp:ListItem>MONTANA</asp:ListItem>
            <asp:ListItem>NEBRASKA</asp:ListItem>
            <asp:ListItem>NEVADA</asp:ListItem>
            <asp:ListItem>NEW HAMPSHIRE</asp:ListItem>
            <asp:ListItem>NEW JERSEY</asp:ListItem>
            <asp:ListItem>NEW MEXICO</asp:ListItem>
            <asp:ListItem>NEW YORK</asp:ListItem>
            <asp:ListItem>NORTH CAROLINA</asp:ListItem>
            <asp:ListItem>NORTH DAKOTA</asp:ListItem>
            <asp:ListItem>OHIO</asp:ListItem>
            <asp:ListItem>OKLAHOMA</asp:ListItem>
            <asp:ListItem>OREGON</asp:ListItem>
            <asp:ListItem>PENNSYLVANIA</asp:ListItem>
            <asp:ListItem>PUERTO RICO</asp:ListItem>
            <asp:ListItem>RHODE ISLAND</asp:ListItem>
            <asp:ListItem>SOUTH CAROLINA</asp:ListItem>
            <asp:ListItem>SOUTH DAKOTA</asp:ListItem>
            <asp:ListItem>TENNESSEE</asp:ListItem>
            <asp:ListItem>TEXAS</asp:ListItem>
            <asp:ListItem>UTAH</asp:ListItem>
            <asp:ListItem>VERMONT</asp:ListItem>
            <asp:ListItem>VIRGIN ISLANDS</asp:ListItem>
            <asp:ListItem>VIRGINIA</asp:ListItem>
            <asp:ListItem>WASHINGTON</asp:ListItem>
            <asp:ListItem>WEST VIRGINIA</asp:ListItem>
            <asp:ListItem>WISCONSIN</asp:ListItem>
            <asp:ListItem>WYOMING</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="CalcFatalities" runat="server" OnClick="CalcFatalities_Click" Text="Get Fatalities" />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Visible="False"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="If you would like to pick a new state and/or storm type and try again, click the button below:" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Button ID="TryAgain1" runat="server" OnClick="TryAgain1_Click" Text="Try Again" Visible="False" />
        <br />
        <br />
    </form>
</body>
</html>
