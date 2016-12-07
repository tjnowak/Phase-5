﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="P5_TylerNowakCodyThompson.Search" %>

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
        <asp:UpdatePanel ID="ValueUpdatePanel" runat="server">
            <ContentTemplate>
                <asp:Label ID="TornadoTypeQLabel" runat="server" Visible="False">Choose the tornado type you are searching for:</asp:Label>
                &nbsp;
                <asp:DropDownList ID="TornadoTypeDropDown" runat="server" OnSelectedIndexChanged="TornadoTypeDropDown_SelectedIndexChanged" Visible="False">
                    <asp:ListItem Value="&quot; &quot;">Pick One</asp:ListItem>
                    <asp:ListItem>EF0</asp:ListItem>
                    <asp:ListItem>EF1</asp:ListItem>
                    <asp:ListItem>EF2</asp:ListItem>
                    <asp:ListItem>EF3</asp:ListItem>
                    <asp:ListItem>EF4</asp:ListItem>
                    <asp:ListItem>EF5</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <asp:Label ID="StateQLabel" runat="server" Visible="False">Choose the state you are searching for:</asp:Label>
                &nbsp;
                <asp:DropDownList ID="StateDropDown" runat="server" Visible="False">
                    <asp:ListItem Value="&quot; &quot;">Pick One</asp:ListItem>
                    <asp:ListItem Value="ALABAMA">Alabama</asp:ListItem>
                    <asp:ListItem Value="ALASKA">Alaska</asp:ListItem>
                    <asp:ListItem Value="ARIZONA">Arizona</asp:ListItem>
                    <asp:ListItem Value="ARKANSAS">Arkansas</asp:ListItem>
                    <asp:ListItem Value="CALIFORNIA">California</asp:ListItem>
                    <asp:ListItem Value="COLORADO">Colorado</asp:ListItem>
                    <asp:ListItem Value="CONNECTICUT">Connecticut</asp:ListItem>
                    <asp:ListItem Value="DELAWARE">Delaware</asp:ListItem>
                    <asp:ListItem Value="DISTRICT OF COLUMBIA">District of Columbia</asp:ListItem>
                    <asp:ListItem Value="FLORIDA">Florida</asp:ListItem>
                    <asp:ListItem Value="GEORGIA">Georgia</asp:ListItem>
                    <asp:ListItem Value="GUAM">Guam</asp:ListItem>
                    <asp:ListItem Value="HAWAII">Hawaii</asp:ListItem>
                    <asp:ListItem Value="IDAHO">Idaho</asp:ListItem>
                    <asp:ListItem Value="ILLINOIS">Illinois</asp:ListItem>
                    <asp:ListItem Value="INDIANA">Indiana</asp:ListItem>
                    <asp:ListItem Value="IOWA">Iowa</asp:ListItem>
                    <asp:ListItem Value="KANSAS">Kansas</asp:ListItem>
                    <asp:ListItem Value="KENTUCKY">Kentucky</asp:ListItem>
                    <asp:ListItem Value="LOUISIANA">Louisiana</asp:ListItem>
                    <asp:ListItem Value="MAINE">Maine</asp:ListItem>
                    <asp:ListItem Value="MARYLAND">Maryland</asp:ListItem>
                    <asp:ListItem Value="MASSACHUSETTS">Massachusetts</asp:ListItem>
                    <asp:ListItem Value="MICHIGAN">Michigan</asp:ListItem>
                    <asp:ListItem Value="MINNESOTA">Minnesota</asp:ListItem>
                    <asp:ListItem Value="MISSISSIPPI">Mississippi</asp:ListItem>
                    <asp:ListItem Value="MISSOURI">Missouri</asp:ListItem>
                    <asp:ListItem Value="MONTANA">Montana</asp:ListItem>
                    <asp:ListItem Value="NEBRASKA">Nebraska</asp:ListItem>
                    <asp:ListItem Value="NEVADA">Nevada</asp:ListItem>
                    <asp:ListItem Value="NEW HAMPSHIRE">New Hampshire</asp:ListItem>
                    <asp:ListItem Value="NEW JERSEY">New Jersey</asp:ListItem>
                    <asp:ListItem Value="NEW MEXICO">New Mexico</asp:ListItem>
                    <asp:ListItem Value="NEW YORK">New York</asp:ListItem>
                    <asp:ListItem Value="NORTH CAROLINA">North Carolina</asp:ListItem>
                    <asp:ListItem Value="NORTH DAKOTA">North Dakota</asp:ListItem>
                    <asp:ListItem Value="OHIO">Ohio</asp:ListItem>
                    <asp:ListItem Value="OKLAHOMA">Oklahoma</asp:ListItem>
                    <asp:ListItem Value="OREGON">Oregon</asp:ListItem>
                    <asp:ListItem Value="PENNSYLVANIA">Pennsylvania</asp:ListItem>
                    <asp:ListItem Value="PUERTO RICO">Puerto Rico</asp:ListItem>
                    <asp:ListItem Value="RHODE ISLAND">Rhode Island</asp:ListItem>
                    <asp:ListItem Value="SOUTH CAROLINA">South Carolina</asp:ListItem>
                    <asp:ListItem Value="SOUTH DAKOTA">South Dakota</asp:ListItem>
                    <asp:ListItem Value="TENNESSEE">Tennessee</asp:ListItem>
                    <asp:ListItem Value="TEXAS">Texas</asp:ListItem>
                    <asp:ListItem Value="UTAH">Utah</asp:ListItem>
                    <asp:ListItem Value="VERMONT">Vermont</asp:ListItem>
                    <asp:ListItem Value="VIRGIN ISLANDS">Virgin Islands</asp:ListItem>
                    <asp:ListItem Value="VIRGINIA">Virginia</asp:ListItem>
                    <asp:ListItem Value="WASHINGTON">Washington</asp:ListItem>
                    <asp:ListItem Value="WEST VIRGINIA">West Virginia</asp:ListItem>
                    <asp:ListItem Value="WISCONSIN">Wisconsin</asp:ListItem>
                    <asp:ListItem Value="WYOMING">Wyoming</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <asp:Label ID="CountyQLabel" runat="server" Text="Enter the full county name you are searching for:" Visible="False"></asp:Label>
                &nbsp;
                <asp:TextBox ID="CountyTextBox" runat="server" Visible="False" Width="193px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="StartAzimuthQlabel" runat="server" Text="Choose the starting azimuth (Compass direction) you are searching for:" Visible="False"></asp:Label>
                &nbsp;
                <asp:DropDownList ID="StartAzimuthDropDown" runat="server" Visible="False">
                    <asp:ListItem Value="&quot; &quot;">Pick One</asp:ListItem>
                    <asp:ListItem>E</asp:ListItem>
                    <asp:ListItem>ENE</asp:ListItem>
                    <asp:ListItem>ESE</asp:ListItem>
                    <asp:ListItem>N</asp:ListItem>
                    <asp:ListItem>NE</asp:ListItem>
                    <asp:ListItem>NNE</asp:ListItem>
                    <asp:ListItem>NNW</asp:ListItem>
                    <asp:ListItem>NW</asp:ListItem>
                    <asp:ListItem>S</asp:ListItem>
                    <asp:ListItem>SE</asp:ListItem>
                    <asp:ListItem>SSE</asp:ListItem>
                    <asp:ListItem>SSW</asp:ListItem>
                    <asp:ListItem>SW</asp:ListItem>
                    <asp:ListItem>W</asp:ListItem>
                    <asp:ListItem>WNW</asp:ListItem>
                    <asp:ListItem>WSW</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <asp:Label ID="StartLocationQlabel" runat="server" Text="Enter the full start location name (nearest city) you are searching for:" Visible="False"></asp:Label>
                &nbsp;
                <asp:TextBox ID="StartLocationTextBox" runat="server" OnTextChanged="StartLocationTextBox_TextChanged" Visible="False" Width="197px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="EndAzimuthQLabel" runat="server" Text="Choose the ending azimuth (Compass direction) you are searching for:" Visible="False"></asp:Label>
                &nbsp;
                <asp:DropDownList ID="EndAzimuthDropDown" runat="server" Visible="False">
                    <asp:ListItem Value="&quot; &quot;">Pick One</asp:ListItem>
                    <asp:ListItem>E</asp:ListItem>
                    <asp:ListItem>ENE</asp:ListItem>
                    <asp:ListItem>ESE</asp:ListItem>
                    <asp:ListItem>N</asp:ListItem>
                    <asp:ListItem>NE</asp:ListItem>
                    <asp:ListItem>NNE</asp:ListItem>
                    <asp:ListItem>NNW</asp:ListItem>
                    <asp:ListItem>NW</asp:ListItem>
                    <asp:ListItem>S</asp:ListItem>
                    <asp:ListItem>SE</asp:ListItem>
                    <asp:ListItem>SSE</asp:ListItem>
                    <asp:ListItem>SSW</asp:ListItem>
                    <asp:ListItem>SW</asp:ListItem>
                    <asp:ListItem>W</asp:ListItem>
                    <asp:ListItem>WNW</asp:ListItem>
                    <asp:ListItem>WSW</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <asp:Label ID="EndLocationQLabel" runat="server" Text="Enter the full end location name (nearest city) you are searching for:" Visible="False"></asp:Label>
                &nbsp;
                <asp:TextBox ID="EndLocationTextBox" runat="server" OnTextChanged="StartLocationTextBox_TextChanged" Visible="False" Width="197px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="TimeZoneQLabel" runat="server" Text="Choose the time zone you are searching for:" Visible="False"></asp:Label>
                &nbsp;
                <asp:DropDownList ID="TimeZoneDropDown" runat="server" Visible="False">
                    <asp:ListItem Value="&quot; &quot;">Pick One</asp:ListItem>
                    <asp:ListItem>AKST</asp:ListItem>
                    <asp:ListItem>AKDT</asp:ListItem>
                    <asp:ListItem>AST</asp:ListItem>
                    <asp:ListItem>CST</asp:ListItem>
                    <asp:ListItem>CDT</asp:ListItem>
                    <asp:ListItem>EST</asp:ListItem>
                    <asp:ListItem>EDT</asp:ListItem>
                    <asp:ListItem>GST</asp:ListItem>
                    <asp:ListItem>HST</asp:ListItem>
                    <asp:ListItem>HDT</asp:ListItem>
                    <asp:ListItem>MST</asp:ListItem>
                    <asp:ListItem>MDT</asp:ListItem>
                    <asp:ListItem>PST</asp:ListItem>
                    <asp:ListItem>PDT</asp:ListItem>
                    <asp:ListItem>SST</asp:ListItem>
                    <asp:ListItem>ChST</asp:ListItem>
                    <asp:ListItem>HAST</asp:ListItem>
                    <asp:ListItem>HADT</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <asp:Label ID="InjuriesQ1Label" runat="server" Text="Enter the lower bound (integer) on number of injuries you are searching for:" Visible="False"></asp:Label>
                &nbsp;
                <asp:TextBox ID="LowerInjuriesTextBox" runat="server" Visible="False" Width="97px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="InjuriesQ2Label" runat="server" Text="Enter the upper bound (integer) on number of injuries you are searching for:" Visible="False"></asp:Label>
                &nbsp;
                <asp:TextBox ID="UpperInjuriesTextBox" runat="server" Visible="False" Width="97px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="FatalitiesQ1Label" runat="server" Text="Enter the lower bound (integer) on the number of fatalities you are searching for:" Visible="False"></asp:Label>
                &nbsp;
                <asp:TextBox ID="LowerFatalitiesTextBox" runat="server" Visible="False" Width="97px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="FatalitiesQ2Label" runat="server" Text="Enter the upper bound (integer) on the number of fatalities you are searching for:" Visible="False"></asp:Label>
                &nbsp;
                <asp:TextBox ID="UpperFatalitiesTextBox" runat="server" Visible="False" Width="97px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="WindSpeedQ1Label" runat="server" Text="Enter the lower bound (integer) on the wind speeds (measured in knots) you are searching for:" Visible="False"></asp:Label>
                &nbsp;
                <asp:TextBox ID="LowerWindSpeedsTextBox" runat="server" Visible="False" Width="97px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="WindSpeedQ2Label" runat="server" Text="Enter the upper bound (integer) on the wind speeds (measured in knots) you are searching for:" Visible="False"></asp:Label>
                &nbsp;
                <asp:TextBox ID="UpperWindSpeedsTextBox" runat="server" Visible="False" Width="97px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="HailSizeQ1Label" runat="server" Text="Enter the lower bound (number in inches) on the hail sizes you are searching for:" Visible="False"></asp:Label>
                &nbsp;
                <asp:TextBox ID="LowerHailSizeTextBox" runat="server" Visible="False" Width="97px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="HailSizeQ2Label" runat="server" Text="Enter the upper bound (number in inches) on the hail sizes you are searching for:" Visible="False"></asp:Label>
                &nbsp;
                <asp:TextBox ID="UpperHailSizeTextBox" runat="server" Visible="False" Width="97px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="StartRangeQ1Label" runat="server" Text="Enter the lower bound of event start ranges (miles from nearest city as integer) you are searching for:" Visible="False"></asp:Label>
                &nbsp;
                <asp:TextBox ID="LowerStartRangeTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Visible="False" Width="97px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="StartRangeQ2Label" runat="server" Text="Enter the upper bound of event start ranges (miles from nearest city as integer) you are searching for:" Visible="False"></asp:Label>
                &nbsp;
                <asp:TextBox ID="UpperStartRangeTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Visible="False" Width="97px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="EndRangeQ1Label" runat="server" Text="Enter the lower bound of event end ranges (miles from nearest city as integer) you are searching for:" Visible="False"></asp:Label>
                &nbsp;
                <asp:TextBox ID="LowerEndRangeTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Visible="False" Width="97px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="EndRangeQ2Label" runat="server" Text="Enter the upper bound of event end ranges (miles from nearest city as integer) you are searching for:" Visible="False"></asp:Label>
                &nbsp;
                <asp:TextBox ID="UpperEndRangeTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Visible="False" Width="97px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="StartYearQ1Label" runat="server" Text="Enter the lower bound (as integer) on the event start years you are searching for:" Visible="False"></asp:Label>
                &nbsp;
                <asp:TextBox ID="LowerStartYearTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Visible="False" Width="97px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="StartYearQ2Label" runat="server" Text="Enter the upper bound (as integer) on the event start years you are searching for:" Visible="False"></asp:Label>
                &nbsp;
                <asp:TextBox ID="UpperStartYearTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Visible="False" Width="97px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="StartMonthQ1Label" runat="server" Text="Enter the lower bound (as integer, 1-12) on the event start months you are searching for:" Visible="False"></asp:Label>
                &nbsp;
                <asp:TextBox ID="LowerStartMonthTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Visible="False" Width="97px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="StartMonthQ2Label" runat="server" Text="Enter the upper bound (as integer, 1-12) on the event start months you are searching for:" Visible="False"></asp:Label>
                &nbsp;
                <asp:TextBox ID="UpperStartMonthTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Visible="False" Width="97px"></asp:TextBox>
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
