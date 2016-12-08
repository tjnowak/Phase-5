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
            <asp:ListItem Value="PICK ONE">Pick One</asp:ListItem>
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
        <asp:CompareValidator ID="StormTypeCompareValidator" runat="server" ControlToValidate="StormTypeDropDown" ForeColor="Red" Operator="NotEqual" ValueToCompare="&quot;PICK ONE&quot;">* Pick One</asp:CompareValidator>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="PropertyUpdatePanel" runat="server">
            <ContentTemplate>
                <asp:Label ID="FieldNameLabel" runat="server" Text="Choose the field name you want to search:"></asp:Label>
                &nbsp;
                <asp:DropDownList ID="PropertyDropDown" runat="server" OnSelectedIndexChanged="PropertyDropDown_SelectedIndexChanged" AutoPostBack="True" Width="135px">
                    <asp:ListItem Value="PICK ONE">Pick One</asp:ListItem>
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
                <asp:CompareValidator ID="PropertyCompareValidator" runat="server" ControlToValidate="PropertyDropDown" ForeColor="Red" Operator="NotEqual" ValueToCompare="&quot;PICK ONE&quot;">* Pick One</asp:CompareValidator>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="StormTypeDropDown" />
            </Triggers>
        </asp:UpdatePanel>
        <br />
    
    </div>
        <asp:UpdatePanel ID="ValueUpdatePanel" runat="server">
            <ContentTemplate>
                <asp:Label ID="TornadoTypeQLabel" runat="server">Choose the tornado type you are searching for:</asp:Label>
                <asp:DropDownList ID="TornadoTypeDropDown" runat="server" OnSelectedIndexChanged="TornadoTypeDropDown_SelectedIndexChanged">
                    <asp:ListItem Value="PICK ONE">Pick One</asp:ListItem>
                    <asp:ListItem>EF0</asp:ListItem>
                    <asp:ListItem>EF1</asp:ListItem>
                    <asp:ListItem>EF2</asp:ListItem>
                    <asp:ListItem>EF3</asp:ListItem>
                    <asp:ListItem>EF4</asp:ListItem>
                    <asp:ListItem>EF5</asp:ListItem>
                </asp:DropDownList>
                <asp:CompareValidator ID="TornadoTypeCompareValidator" runat="server" ControlToValidate="TornadoTypeDropDown" ForeColor="Red" Operator="NotEqual" ValueToCompare="&quot;PICK ONE&quot;">* Pick One</asp:CompareValidator>
                <asp:Label ID="StateQLabel" runat="server">Choose the state you are searching for:</asp:Label>
                <asp:DropDownList ID="StateDropDown" runat="server" OnSelectedIndexChanged="StateDropDown_SelectedIndexChanged" Height="16px" Width="132px">
                    <asp:ListItem Value="PICK ONE">Pick One</asp:ListItem>
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
                <asp:CompareValidator ID="StateCompareValidator" runat="server" ControlToValidate="StateDropDown" ForeColor="Red" Operator="NotEqual" ValueToCompare="&quot;PICK ONE&quot;">* Pick One</asp:CompareValidator>
                <asp:Label ID="CountyQLabel" runat="server" Text="Enter the full county name you are searching for:"></asp:Label>
                <asp:TextBox ID="CountyTextBox" runat="server" Width="193px" OnTextChanged="CountyTextBox_TextChanged"></asp:TextBox>
                <asp:RequiredFieldValidator ID="CountyRequiredFieldValidator" runat="server" ControlToValidate="CountyTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:Label ID="StartAzimuthQlabel" runat="server" Text="Choose the starting azimuth (Compass direction) you are searching for:"></asp:Label>
                <asp:DropDownList ID="StartAzimuthDropDown" runat="server" OnSelectedIndexChanged="StartAzimuthDropDown_SelectedIndexChanged">
                    <asp:ListItem Value="PICK ONE">Pick One</asp:ListItem>
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
                <asp:CompareValidator ID="StartAzimuthCompareValidator" runat="server" ControlToValidate="StartAzimuthDropDown" ForeColor="Red" Operator="NotEqual" ValueToCompare="&quot;PICK ONE&quot;">* Pick One</asp:CompareValidator>
                <asp:Label ID="StartLocationQlabel" runat="server" Text="Enter the full start location name (nearest city) you are searching for:"></asp:Label>
                <asp:TextBox ID="StartLocationTextBox" runat="server" OnTextChanged="StartLocationTextBox_TextChanged" Width="197px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="StartLocationRequiredFieldValidator" runat="server" ControlToValidate="StartLocationTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:Label ID="EndAzimuthQLabel" runat="server" Text="Choose the ending azimuth (Compass direction) you are searching for:"></asp:Label>
                <asp:DropDownList ID="EndAzimuthDropDown" runat="server" OnSelectedIndexChanged="EndAzimuthDropDown_SelectedIndexChanged">
                    <asp:ListItem Value="PICK ONE">Pick One</asp:ListItem>
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
                <asp:CompareValidator ID="EndAzimuthCompareValidator" runat="server" ControlToValidate="EndAzimuthDropDown" ForeColor="Red" Operator="NotEqual" ValueToCompare="&quot;PICK ONE&quot;">* Pick One</asp:CompareValidator>
                <asp:Label ID="EndLocationQLabel" runat="server" Text="Enter the full end location name (nearest city) you are searching for:"></asp:Label>
                <asp:TextBox ID="EndLocationTextBox" runat="server" OnTextChanged="StartLocationTextBox_TextChanged" Width="197px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="EndLocationRequiredFieldValidator" runat="server" ControlToValidate="EndLocationTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:Label ID="TimeZoneQLabel" runat="server" Text="Choose the time zone you are searching for:"></asp:Label>
                <asp:DropDownList ID="TimeZoneDropDown" runat="server" OnSelectedIndexChanged="TimeZoneDropDown_SelectedIndexChanged">
                    <asp:ListItem Value="PICK ONE">Pick One</asp:ListItem>
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
                <asp:CompareValidator ID="TimeZoneCompareValidator" runat="server" ControlToValidate="TimeZoneDropDown" ForeColor="Red" Operator="NotEqual" ValueToCompare="&quot;PICK ONE&quot;">* Pick One</asp:CompareValidator>
                <asp:Label ID="InjuriesQ1Label" runat="server" Text="Enter the lower bound (integer) on number of injuries you are searching for:"></asp:Label>
                <asp:TextBox ID="LowerInjuriesTextBox" runat="server" Width="97px" OnTextChanged="LowerInjuriesTextBox_TextChanged"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerInjuriesRequiredFieldValidator" runat="server" ControlToValidate="LowerInjuriesTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerInjuriesRangeValidator" runat="server" ControlToValidate="LowerInjuriesTextBox" ForeColor="Red" MaximumValue="1000000" MinimumValue="0" Type="Integer">* Must be int &gt;= 0</asp:RangeValidator>
                <asp:Label ID="FatalitiesQ1Label" runat="server" Text="Enter the lower bound (integer) on the number of fatalities you are searching for:"></asp:Label>
                <asp:TextBox ID="LowerFatalitiesTextBox" runat="server" OnTextChanged="LowerFatalitiesTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerFatalitiesRequiredFieldValidator" runat="server" ControlToValidate="LowerFatalitiesTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerFatalitiesRangeValidator" runat="server" ControlToValidate="LowerFatalitiesTextBox" ForeColor="Red" MaximumValue="1000000" MinimumValue="0" Type="Integer">* Must be int &gt;= 0</asp:RangeValidator>
                <asp:Label ID="WindSpeedQ1Label" runat="server" Text="Enter the lower bound (integer) on the wind speeds (measured in knots) you are searching for:"></asp:Label>
                <asp:TextBox ID="LowerWindSpeedsTextBox" runat="server" Width="97px" OnTextChanged="LowerWindSpeedsTextBox_TextChanged"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerWindSpeedsRequiredFieldValidator" runat="server" ControlToValidate="LowerWindSpeedsTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerWindSpeedRangeValidator" runat="server" ControlToValidate="LowerWindSpeedsTextBox" ForeColor="Red" MaximumValue="1000000" MinimumValue="0" Type="Integer">* Must be int &gt; =0</asp:RangeValidator>
                <asp:Label ID="HailSizeQ1Label" runat="server" Text="Enter the lower bound (number in inches) on the hail sizes you are searching for:"></asp:Label>
                <asp:TextBox ID="LowerHailSizeTextBox" runat="server" Width="97px" OnTextChanged="LowerHailSizeTextBox_TextChanged"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerHailSizeRequiredFieldValidator" runat="server" ControlToValidate="LowerHailSizeTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerHailSizeRangeValidator" runat="server" ControlToValidate="LowerHailSizeTextBox" ForeColor="Red" MaximumValue="1000000" MinimumValue="0" Type="Double">* Must be double &gt;= 0</asp:RangeValidator>
                <asp:Label ID="StartRangeQ1Label" runat="server" Text="Enter the lower bound of event start ranges (miles from nearest city as integer) you are searching for:"></asp:Label>
                <asp:TextBox ID="LowerStartRangeTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerStartRangeRequiredFieldValidator" runat="server" ControlToValidate="LowerStartRangeTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerStartRangeValidator" runat="server" ControlToValidate="LowerStartRangeTextBox" ForeColor="Red" MaximumValue="1000000" MinimumValue="0" Type="Integer">* Must be int &gt;= 0</asp:RangeValidator>
                <asp:Label ID="EndRangeQ1Label" runat="server" Text="Enter the lower bound of event end ranges (miles from nearest city as integer) you are searching for:"></asp:Label>
                <asp:TextBox ID="LowerEndRangeTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerEndRangeRequiredFieldValidator" runat="server" ControlToValidate="LowerEndRangeTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerEndRangeValidator" runat="server" ControlToValidate="LowerEndRangeTextBox" ForeColor="Red" MaximumValue="1000000" MinimumValue="0" Type="Integer">* Must be int &gt;= 0</asp:RangeValidator>
                <asp:Label ID="StartYearQ1Label" runat="server" Text="Enter the lower bound (as integer) on the event start years you are searching for:"></asp:Label>
                <asp:TextBox ID="LowerStartYearTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerStartYearRequiredFieldValidator" runat="server" ControlToValidate="LowerStartYearTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerStartYearValidator" runat="server" ControlToValidate="LowerStartYearTextBox" ForeColor="Red" MaximumValue="2016" MinimumValue="1951" Type="Integer">* Must be int 1951-2016</asp:RangeValidator>
                <asp:Label ID="StartMonthQ1Label" runat="server" Text="Enter the lower bound (as integer, 1-12) on the event start months you are searching for:"></asp:Label>
                <asp:TextBox ID="LowerStartMonthTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerStartMonthRequiredFieldValidator" runat="server" ControlToValidate="LowerStartMonthTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerStartMonthValidator" runat="server" ControlToValidate="LowerStartMonthTextBox" ForeColor="Red" MaximumValue="12" MinimumValue="1" Type="Integer">* Must be int 1-12</asp:RangeValidator>
                <asp:Label ID="StartDayQ1Label" runat="server" Text="Enter the lower bound (as integer, day of month) on the event start days you are searching for:"></asp:Label>
                <asp:TextBox ID="LowerStartDayTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerStartDayRequiredFieldValidator" runat="server" ControlToValidate="LowerStartDayTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerStartDayValidator" runat="server" ControlToValidate="LowerStartDayTextBox" ForeColor="Red" MaximumValue="31" MinimumValue="1" Type="Integer">* Must be int 1-31</asp:RangeValidator>
                <asp:Label ID="StartTimeQ1Label" runat="server" Text="Enter the lower bound (24 hour time with no ':', Ex: 1425) on the event start times you are searching for:"></asp:Label>
                <asp:TextBox ID="LowerStartTimeTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerStartTimeRequiredFieldValidator" runat="server" ControlToValidate="LowerStartTimeTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerStartTimeValidator" runat="server" ControlToValidate="LowerStartTimeTextBox" ForeColor="Red" MaximumValue="2359" MinimumValue="0" Type="Integer">* Must be int 0-2359</asp:RangeValidator>
                <asp:Label ID="EndYearQ1Label" runat="server" Text="Enter the lower bound (as integer) on the event end years you are searching for:"></asp:Label>
                <asp:TextBox ID="LowerEndYearTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerEndYearRequiredFieldValidator" runat="server" ControlToValidate="LowerEndYearTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerEndYearValidator" runat="server" ControlToValidate="LowerEndYearTextBox" ForeColor="Red" MaximumValue="2016" MinimumValue="1951" Type="Integer">* Must be int 1951-2016</asp:RangeValidator>
                <asp:Label ID="EndMonthQ1Label" runat="server" BorderStyle="None" Text="Enter the lower bound (as integer, 1-12) on the event end months you are searching for:"></asp:Label>
                <asp:TextBox ID="LowerEndMonthTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerEndMonthRequiredFieldValidator" runat="server" ControlToValidate="LowerEndMonthTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerEndMonthValidator" runat="server" ControlToValidate="LowerEndMonthTextBox" ForeColor="Red" MaximumValue="12" MinimumValue="1" Type="Integer">* Must be int 1-12</asp:RangeValidator>
                <asp:Label ID="EndDayQ1Label" runat="server" Text="Enter the lower bound (as integer, day of month) on the event end days you are searching for:"></asp:Label>
                <asp:TextBox ID="LowerEndDayTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerEndDayRequiredFieldValidator" runat="server" ControlToValidate="LowerEndDayTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerEndDayValidator" runat="server" ControlToValidate="LowerEndDayTextBox" ForeColor="Red" MaximumValue="31" MinimumValue="1" Type="Integer">* Must be int 1-31</asp:RangeValidator>
                <asp:Label ID="EndTimeQ1Label" runat="server" Text="Enter the lower bound (24 hour time with no ':', Ex: 1425) on the event end times you are searching for:"></asp:Label>
                <asp:TextBox ID="LowerEndTimeTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerEndTimeRequiredFieldValidator" runat="server" ControlToValidate="LowerEndTimeTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerEndTimeValidator" runat="server" ControlToValidate="LowerEndTimeTextBox" ForeColor="Red" MaximumValue="2359" MinimumValue="0" Type="Integer">* Must be int 0-2359</asp:RangeValidator>
                <asp:Label ID="TornadoLengthQ1Label" runat="server" Text="Enter the lower bound (how far in miles) of tornado lengths (distance traveled) you are searching for:"></asp:Label>
                <asp:TextBox ID="LowerTornadoLengthTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerTornadoLengthRequiredFieldValidator" runat="server" ControlToValidate="LowerTornadoLengthTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerTornadoLengthRangeValidator" runat="server" ControlToValidate="LowerTornadoLengthTextBox" ForeColor="Red" MaximumValue="1000000" MinimumValue="0" Type="Double">* Must be double &gt;= 0</asp:RangeValidator>
                <asp:Label ID="TornadoWidthQ1Label" runat="server" Text="Enter the lower bound (yards) on tornado widths (diameter accross) you are searching for:"></asp:Label>
                <asp:TextBox ID="LowerTornadoWidthTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerTornadoWidthRequiredFieldValidator" runat="server" ControlToValidate="LowerTornadoWidthTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerTornadoWidthRangeValidator" runat="server" ControlToValidate="LowerTornadoWidthTextBox" ForeColor="Red" MaximumValue="1000000" MinimumValue="0" Type="Double">* Must be double &gt;= 0</asp:RangeValidator>
                <asp:Label ID="StartLatitudeQ1Label" runat="server" Text="Enter the lower bound (-90 to 90) on the event start latitudes you are searching for:"></asp:Label>
                <asp:TextBox ID="LowerStartLatitudeTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerStartLatitudeRequiredFieldValidator" runat="server" ControlToValidate="LowerStartLatitudeTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerStartLatitudeRangeValidator" runat="server" ControlToValidate="LowerStartLatitudeTextBox" ForeColor="Red" MaximumValue="90" MinimumValue="-90" Type="Double">* Must be double -90 to 90</asp:RangeValidator>
                <asp:Label ID="StartLongitudeQ1Label" runat="server" Text="Enter the lower bound (-180 to 180) of the event start longitudes you are searching for:"></asp:Label>
                <asp:TextBox ID="LowerStartLongitudeTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerStartLongitudeRequiredFieldValidator" runat="server" ControlToValidate="LowerStartLongitudeTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerStartLongitudeRangeValidator" runat="server" ControlToValidate="LowerStartLongitudeTextBox" ForeColor="Red" MaximumValue="180" MinimumValue="-180" Type="Double">* Must be double -180 to 180</asp:RangeValidator>
                <asp:Label ID="EndLatitudeQ1Label" runat="server" Text="Enter the lower bound (-90 to 90) on the event end latitudes you are searching for:"></asp:Label>
                <asp:TextBox ID="LowerEndLatitudeTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerEndLatitudeRequiredFieldValidator" runat="server" ControlToValidate="LowerEndLatitudeTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerEndLatitudeRangeValidator" runat="server" ControlToValidate="LowerEndLatitudeTextBox" ForeColor="Red" MaximumValue="90" MinimumValue="-90" Type="Double">* Must be double -90 to 90</asp:RangeValidator>
                <asp:Label ID="EndLongitudeQ1Label" runat="server" Text="Enter the lower bound (-180 to 180) of the event end longitudes you are searching for:"></asp:Label>
                <asp:TextBox ID="LowerEndLongitudeTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerEndLongitudeRequiredFieldValidator" runat="server" ControlToValidate="LowerEndLongitudeTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerEndLongitudeRangeValidator" runat="server" ControlToValidate="LowerEndLongitudeTextBox" ForeColor="Red" MaximumValue="180" MinimumValue="-180" Type="Double">* Must be double -180 to 180</asp:RangeValidator>
                <asp:Label ID="PropertyDamageQ1Label" runat="server" Text="Enter the lower bound (as a number without '$' or commas) of property damage you are searching for:"></asp:Label>
                <asp:TextBox ID="LowerPropertyDamageTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerPropertyDamageRequiredFieldValidator" runat="server" ControlToValidate="LowerPropertyDamageTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerPropertyDamageRangeValidator" runat="server" ControlToValidate="LowerPropertyDamageTextBox" ForeColor="Red" MaximumValue="1000000" MinimumValue="0" Type="Double">* Must be &gt;= 0 w/o commas</asp:RangeValidator>
                <asp:Label ID="CropDamageQ1Label" runat="server" Text="Enter the lower bound (as a number without '$' or commas) of crop damage you are searching for:"></asp:Label>
                <asp:TextBox ID="LowerCropDamageTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerCropDamageRequiredFieldValidator" runat="server" ControlToValidate="LowerCropDamageTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerCropDamageRangeValidator" runat="server" ControlToValidate="LowerCropDamageTextBox" ForeColor="Red" MaximumValue="1000000" MinimumValue="0" Type="Double">* Must be &gt;= 0 w/o commas</asp:RangeValidator>
                <br />
                <br />
                <asp:Label ID="InjuriesQ2Label" runat="server" Text="Enter the upper bound (integer) on number of injuries you are searching for:"></asp:Label>
                <asp:TextBox ID="UpperInjuriesTextBox" runat="server" Width="97px" OnTextChanged="UpperInjuriesTextBox_TextChanged"></asp:TextBox>
                <asp:RequiredFieldValidator ID="UpperInjuriesRequiredFieldValidator" runat="server" ControlToValidate="UpperInjuriesTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="UpperInjuriesRangeValidator" runat="server" ControlToValidate="UpperInjuriesTextBox" ForeColor="Red" MaximumValue="1000000" MinimumValue="0" Type="Integer">* Must be int &gt;= 0</asp:RangeValidator>
                <asp:CompareValidator ID="UpperInjuriesCompareValidator" runat="server" ControlToCompare="LowerInjuriesTextBox" ControlToValidate="UpperInjuriesTextBox" ForeColor="Red" Operator="GreaterThanEqual">*Upper bound must be &gt;= lower bound</asp:CompareValidator>
                <asp:Label ID="FatalitiesQ2Label" runat="server" Text="Enter the upper bound (integer) on the number of fatalities you are searching for:"></asp:Label>
                <asp:TextBox ID="UpperFatalitiesTextBox" runat="server" Width="97px" OnTextChanged="UpperFatalitiesTextBox_TextChanged"></asp:TextBox>
                <asp:RequiredFieldValidator ID="UpperFatalitiesRequiredFieldValidator" runat="server" ControlToValidate="UpperFatalitiesTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="UpperFatalitiesRangeValidator" runat="server" ControlToValidate="UpperFatalitiesTextBox" ForeColor="Red" MaximumValue="1000000" MinimumValue="0" Type="Integer">* Must be int &gt;= 0</asp:RangeValidator>
                <asp:CompareValidator ID="UpperFatalitiesCompareValidator" runat="server" ControlToCompare="LowerFatalitiesTextBox" ControlToValidate="UpperFatalitiesTextBox" ForeColor="Red" Operator="GreaterThanEqual">*Upper bound must be &gt;= lower bound</asp:CompareValidator>
                <asp:Label ID="WindSpeedQ2Label" runat="server" Text="Enter the upper bound (integer) on the wind speeds (measured in knots) you are searching for:"></asp:Label>
                <asp:TextBox ID="UpperWindSpeedsTextBox" runat="server" Width="97px" OnTextChanged="UpperWindSpeedsTextBox_TextChanged"></asp:TextBox>
                <asp:RequiredFieldValidator ID="UpperWindSpeedsRequiredFieldValidator" runat="server" ControlToValidate="UpperWindSpeedsTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="UpperWindSpeedRangeValidator" runat="server" ControlToValidate="UpperWindSpeedsTextBox" ForeColor="Red" MaximumValue="1000000" MinimumValue="0" Type="Integer">* Must be int &gt; =0</asp:RangeValidator>
                <asp:CompareValidator ID="UpperWindSpeedCompareValidator" runat="server" ControlToCompare="LowerWindSpeedsTextBox" ControlToValidate="UpperWindSpeedsTextBox" ForeColor="Red" Operator="GreaterThanEqual">*Upper bound must be &gt; lower bound</asp:CompareValidator>
                <asp:Label ID="HailSizeQ2Label" runat="server" Text="Enter the upper bound (number in inches) on the hail sizes you are searching for:"></asp:Label>
                <asp:TextBox ID="UpperHailSizeTextBox" runat="server" Width="97px" OnTextChanged="UpperHailSizeTextBox_TextChanged"></asp:TextBox>
                &nbsp;<asp:RequiredFieldValidator ID="UpperHailSizeRequiredFieldValidator" runat="server" ControlToValidate="UpperHailSizeTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="UpperHailSizeRangeValidator" runat="server" ControlToValidate="UpperHailSizeTextBox" ForeColor="Red" MaximumValue="1000000" MinimumValue="0" Type="Double">* Must be double &gt;= 0</asp:RangeValidator>
                <asp:CompareValidator ID="UpperHailSizeCompareValidator" runat="server" ControlToCompare="LowerHailSizeTextBox" ControlToValidate="UpperHailSizeTextBox" ForeColor="Red" Operator="GreaterThanEqual">*Upper bound must be &gt;= lower bound</asp:CompareValidator>
                <asp:Label ID="StartRangeQ2Label" runat="server" Text="Enter the upper bound of event start ranges (miles from nearest city as integer) you are searching for:"></asp:Label>
                <asp:TextBox ID="UpperStartRangeTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="UpperStartRangeRequiredFieldValidator" runat="server" ControlToValidate="UpperStartRangeTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="UpperStartRangeValidator" runat="server" ControlToValidate="UpperStartRangeTextBox" ForeColor="Red" MaximumValue="1000000" MinimumValue="0" Type="Integer">* Must be int &gt;= 0</asp:RangeValidator>
                <asp:CompareValidator ID="UpperStartRangeCompareValidator" runat="server" ControlToCompare="LowerStartRangeTextBox" ControlToValidate="UpperStartRangeTextBox" ForeColor="Red" Operator="GreaterThanEqual">*Upper bound must be &gt;= lower bound</asp:CompareValidator>
                <asp:Label ID="EndRangeQ2Label" runat="server" Text="Enter the upper bound of event end ranges (miles from nearest city as integer) you are searching for:"></asp:Label>
                <asp:TextBox ID="UpperEndRangeTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="UpperEndRangeRequiredFieldValidator" runat="server" ControlToValidate="UpperEndRangeTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="UpperEndRangeValidator" runat="server" ControlToValidate="UpperEndRangeTextBox" ForeColor="Red" MaximumValue="1000000" MinimumValue="0" Type="Integer">* Must be int &gt;= 0</asp:RangeValidator>
                <asp:CompareValidator ID="UpperEndRangeCompareValidator" runat="server" ControlToCompare="LowerEndRangeTextBox" ControlToValidate="UpperEndRangeTextBox" ForeColor="Red" Operator="GreaterThanEqual">*Upper bound must be &gt;= lower bound</asp:CompareValidator>
                <asp:Label ID="StartYearQ2Label" runat="server" Text="Enter the upper bound (as integer) on the event start years you are searching for:"></asp:Label>
                <asp:TextBox ID="UpperStartYearTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="UpperStartYearRequiredFieldValidator" runat="server" ControlToValidate="UpperStartYearTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="UpperStartYearValidator" runat="server" ControlToValidate="UpperStartYearTextBox" ForeColor="Red" MaximumValue="2016" MinimumValue="1951" Type="Integer">* Must be int 1951-2016</asp:RangeValidator>
                <asp:CompareValidator ID="UpperStartYearCompareValidator" runat="server" ControlToCompare="LowerStartYearTextBox" ControlToValidate="UpperStartYearTextBox" ForeColor="Red" Operator="GreaterThanEqual">*Upper bound must be &gt;= lower bound</asp:CompareValidator>
                <asp:Label ID="StartMonthQ2Label" runat="server" Text="Enter the upper bound (as integer, 1-12) on the event start months you are searching for:"></asp:Label>
                <asp:TextBox ID="UpperStartMonthTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="UpperStartMonthRequiredFieldValidator" runat="server" ControlToValidate="UpperStartMonthTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="UpperStartMonthValidator" runat="server" ControlToValidate="UpperStartMonthTextBox" ForeColor="Red" MaximumValue="12" MinimumValue="1" Type="Integer">* Must be int 1-12</asp:RangeValidator>
                <asp:CompareValidator ID="UpperStartMonthCompareValidator" runat="server" ControlToCompare="LowerStartMonthTextBox" ControlToValidate="UpperStartMonthTextBox" ForeColor="Red" Operator="GreaterThanEqual">*Upper bound must be &gt;= lower bound</asp:CompareValidator>
                <asp:Label ID="StartDayQ2Label" runat="server" Text="Enter the upper bound (as integer, day of month) on the event start days you are searching for:"></asp:Label>
                <asp:TextBox ID="UpperStartDayTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="UpperStartDayRequiredFieldValidator" runat="server" ControlToValidate="UpperStartDayTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="UpperStartDayValidator" runat="server" ControlToValidate="UpperStartDayTextBox" ForeColor="Red" MaximumValue="31" MinimumValue="1" Type="Integer">* Must be int 1-31</asp:RangeValidator>
                <asp:CompareValidator ID="UpperStartDayCompareValidator" runat="server" ControlToCompare="LowerStartDayTextBox" ControlToValidate="UpperStartDayTextBox" ForeColor="Red" Operator="GreaterThanEqual">*Upper bound must be &gt;= lower bound</asp:CompareValidator>
                <asp:Label ID="StartTimeQ2Label" runat="server" Text="Enter the upper bound (24 hour time with no ':', Ex: 1425) on the event start times you are searching for:"></asp:Label>
                <asp:TextBox ID="UpperStartTimeTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="UpperStartTimeRequiredFieldValidator" runat="server" ControlToValidate="UpperStartTimeTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="UpperStartTimeValidator" runat="server" ControlToValidate="UpperStartTimeTextBox" ForeColor="Red" MaximumValue="2359" MinimumValue="0" Type="Integer">* Must be int 0-2359</asp:RangeValidator>
                <asp:CompareValidator ID="UpperStartTimeCompareValidator" runat="server" ControlToCompare="LowerStartTimeTextBox" ControlToValidate="UpperStartTimeTextBox" ForeColor="Red" Operator="GreaterThanEqual">*Upper bound must be &gt;= lower bound</asp:CompareValidator>
                <asp:Label ID="EndYearQ2Label" runat="server" Text="Enter the upper bound (as integer) on the event end years you are searching for:"></asp:Label>
                <asp:TextBox ID="UpperEndYearTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="UpperEndYearRequiredFieldValidator" runat="server" ControlToValidate="UpperEndYearTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="UpperEndYearValidator" runat="server" ControlToValidate="UpperEndYearTextBox" ForeColor="Red" MaximumValue="2016" MinimumValue="1951" Type="Integer">* Must be int 1951-2016</asp:RangeValidator>
                <asp:CompareValidator ID="UpperEndYearCompareValidator" runat="server" ControlToCompare="LowerEndYearTextBox" ControlToValidate="UpperEndYearTextBox" ForeColor="Red" Operator="GreaterThanEqual" Type="Integer">*Upper bound must be &gt;= lower bound</asp:CompareValidator>
                <asp:Label ID="EndMonthQ2Label" runat="server" BorderStyle="None" Text="Enter the upper bound (as integer, 1-12) on the event end months you are searching for:"></asp:Label>
                <asp:TextBox ID="UpperEndMonthTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="UpperEndMonthRequiredFieldValidator" runat="server" ControlToValidate="UpperEndMonthTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="UpperEndMonthValidator" runat="server" ControlToValidate="UpperEndMonthTextBox" ForeColor="Red" MaximumValue="12" MinimumValue="1" Type="Integer">* Must be int 1-12</asp:RangeValidator>
                <asp:CompareValidator ID="UpperEndMonthCompareValidator" runat="server" ControlToCompare="LowerEndMonthTextBox" ControlToValidate="UpperEndMonthTextBox" ForeColor="Red" Operator="GreaterThanEqual">*Upper bound must be &gt;= lower bound</asp:CompareValidator>
                <asp:Label ID="EndDayQ2Label" runat="server" Text="Enter the upper bound (as integer, day of month) on the event end days you are searching for:"></asp:Label>
                <asp:TextBox ID="UpperEndDayTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="UpperEndDayRequiredFieldValidator" runat="server" ControlToValidate="UpperEndDayTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="UpperEndDayValidator" runat="server" ControlToValidate="UpperEndDayTextBox" ForeColor="Red" MaximumValue="31" MinimumValue="1" Type="Integer">* Must be int 1-31</asp:RangeValidator>
                <asp:CompareValidator ID="UpperEndDayCompareValidator" runat="server" ControlToCompare="LowerEndDayTextBox" ControlToValidate="UpperEndDayTextBox" ForeColor="Red" Operator="GreaterThanEqual">*Upper bound must be &gt;= lower bound</asp:CompareValidator>
                <asp:Label ID="EndTimeQ2Label" runat="server" Text="Enter the upper bound (24 hour time with no ':', Ex: 1425) on the event end times you are searching for:"></asp:Label>
                <asp:TextBox ID="UpperEndTimeTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="UpperEndTimeRequiredFieldValidator" runat="server" ControlToValidate="UpperEndTimeTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="UpperEndTimeValidator" runat="server" ControlToValidate="UpperEndTimeTextBox" ForeColor="Red" MaximumValue="2359" MinimumValue="0" Type="Integer">* Must be int 0-2359</asp:RangeValidator>
                <asp:CompareValidator ID="UpperEndTimeCompareValidator" runat="server" ControlToCompare="LowerEndTimeTextBox" ControlToValidate="UpperEndTimeTextBox" ForeColor="Red" Operator="GreaterThanEqual">*Upper bound must be &gt;= lower bound</asp:CompareValidator>
                <asp:Label ID="TornadoLengthQ2Label" runat="server" Text="Enter the upper bound (how far in miles) of tornado lengths (distance traveled) you are searching for:"></asp:Label>
                <asp:TextBox ID="UpperTornadoLengthTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="UpperTornadoLengthRequiredFieldValidator" runat="server" ControlToValidate="UpperTornadoLengthTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="UpperTornadoLengthRangeValidator" runat="server" ControlToValidate="UpperTornadoLengthTextBox" ForeColor="Red" MaximumValue="1000000" MinimumValue="0" Type="Double">* Must be double &gt;= 0</asp:RangeValidator>
                <asp:CompareValidator ID="UpperTornadoLengthCompareValidator" runat="server" ControlToCompare="LowerTornadoLengthTextBox" ControlToValidate="UpperTornadoLengthTextBox" ForeColor="Red" Operator="GreaterThanEqual">*Upper bound must be &gt;= lower bound</asp:CompareValidator>
                <asp:Label ID="TornadoWidthQ2Label" runat="server" Text="Enter the upper bound (yards) on tornado widths (diameter accross) you are searching for:"></asp:Label>
                <asp:TextBox ID="UpperTornadoWidthTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="UpperTornadoWidthRequiredFieldValidator" runat="server" ControlToValidate="UpperTornadoWidthTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="UpperTornadoWidthRangeValidator" runat="server" ControlToValidate="UpperTornadoWidthTextBox" ForeColor="Red" MaximumValue="1000000" MinimumValue="0" Type="Double">* Must be double &gt;= 0</asp:RangeValidator>
                <asp:CompareValidator ID="UpperTornadoWidthCompareValidator" runat="server" ControlToCompare="LowerTornadoWidthTextBox" ControlToValidate="UpperTornadoWidthTextBox" ForeColor="Red" Operator="GreaterThanEqual">*Upper bound must be &gt;= lower bound</asp:CompareValidator>
                <asp:Label ID="StartLatitudeQ2Label" runat="server" Text="Enter the upper bound (-90 to 90) on the event start latitudes you are searching for:"></asp:Label>
                <asp:TextBox ID="UpperStartLatitudeTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="UpperStartLatitudeRequiredFieldValidator" runat="server" ControlToValidate="UpperStartLatitudeTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="UpperStartLatitudeRangeValidator" runat="server" ControlToValidate="UpperStartLatitudeTextBox" ForeColor="Red" MaximumValue="90" MinimumValue="-90" Type="Double">* Must be double -90 to 90</asp:RangeValidator>
                <asp:CompareValidator ID="UpperStartLatitudeCompareValidator" runat="server" ControlToCompare="LowerStartLatitudeTextBox" ControlToValidate="UpperStartLatitudeTextBox" ForeColor="Red" Operator="LessThanEqual">*Upper bound must be &gt;= lower bound</asp:CompareValidator>
                <asp:Label ID="StartLongitudeQ2Label" runat="server" Text="Enter the upper bound (-180 to 180) of the event start longitudes you are searching for:"></asp:Label>
                <asp:TextBox ID="UpperStartLongitudeTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="UpperStartLongitudeRequiredFieldValidator" runat="server" ControlToValidate="UpperStartLongitudeTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="UpperStartLongitudeRangeValidator" runat="server" ControlToValidate="UpperStartLongitudeTextBox" ForeColor="Red" MaximumValue="180" MinimumValue="-180" Type="Double">* Must be double -180 to 180</asp:RangeValidator>
                <asp:CompareValidator ID="UpperStartLongitudeCompareValidator" runat="server" ControlToCompare="LowerStartLongitudeTextBox" ControlToValidate="UpperStartLongitudeTextBox" ForeColor="Red" Operator="GreaterThanEqual">*Upper bound must be &gt;= lower bound</asp:CompareValidator>
                <asp:Label ID="EndLatitudeQ2Label" runat="server" Text="Enter the upper bound (-90 to 90) on the event end latitudes you are searching for:"></asp:Label>
                <asp:TextBox ID="UpperEndLatitudeTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="UpperEndLatitudeRequiredFieldValidator" runat="server" ControlToValidate="UpperEndLatitudeTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="UpperEndLatitudeRangeValidator" runat="server" ControlToValidate="UpperEndLatitudeTextBox" ForeColor="Red" MaximumValue="90" MinimumValue="-90" Type="Double">* Must be double -90 to 90</asp:RangeValidator>
                <asp:CompareValidator ID="UpperEndLatitudeCompareValidator" runat="server" ControlToCompare="LowerEndLatitudeTextBox" ControlToValidate="UpperEndLatitudeTextBox" ForeColor="Red" Operator="GreaterThanEqual" Type="Integer">*Upper bound must be &gt;= lower bound</asp:CompareValidator>
                <asp:Label ID="EndLongitudeQ2Label" runat="server" Text="Enter the upper bound (-180 to 180) of the event end longitudes you are searching for:"></asp:Label>
                <asp:TextBox ID="UpperEndLongitudeTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="UpperEndLongitudeRequiredFieldValidator" runat="server" ControlToValidate="UpperEndLongitudeTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="UpperEndLongitudeRangeValidator" runat="server" ControlToValidate="UpperEndLongitudeTextBox" ForeColor="Red" MaximumValue="180" MinimumValue="-180" Type="Double">* Must be double -180 to 180</asp:RangeValidator>
                <asp:CompareValidator ID="UpperEndLongitudeCompareValidator" runat="server" ControlToCompare="LowerEndLongitudeTextBox" ControlToValidate="UpperEndLongitudeTextBox" ForeColor="Red" Operator="GreaterThanEqual">*Upper bound must be &gt;= lower bound</asp:CompareValidator>
                <asp:Label ID="PropertyDamageQ2Label" runat="server" Text="Enter the upper bound (as a number without '$' or commas) of property damage you are searching for:"></asp:Label>
                <asp:TextBox ID="UpperPropertyDamageTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="UpperPropertyDamageRequiredFieldValidator" runat="server" ControlToValidate="UpperPropertyDamageTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="UpperPropertyDamageRangeValidator" runat="server" ControlToValidate="UpperPropertyDamageTextBox" ForeColor="Red" MaximumValue="1000000" MinimumValue="0" Type="Double">* Must be &gt;= 0 w/o commas</asp:RangeValidator>
                <asp:CompareValidator ID="UpperPropertyDamageCompareValidator" runat="server" ControlToCompare="LowerPropertyDamageTextBox" ControlToValidate="UpperPropertyDamageTextBox" ForeColor="Red" Operator="GreaterThanEqual">*Upper bound must be &gt;= lower bound</asp:CompareValidator>
                <asp:Label ID="CropDamageQ2Label" runat="server" Text="Enter the upper bound (as a number without '$' or commas) of crop damage you are searching for:"></asp:Label>
                <asp:TextBox ID="UpperCropDamageTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="UpperCropDamageRequiredFieldValidator" runat="server" ControlToValidate="UpperCropDamageTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="UpperCropDamageRangeValidator" runat="server" ControlToValidate="UpperCropDamageTextBox" ForeColor="Red" MaximumValue="1000000" MinimumValue="0" Type="Double">* Must be &gt;= 0 w/o commas</asp:RangeValidator>
                <asp:CompareValidator ID="UpperCropDamageCompareValidator" runat="server" ControlToCompare="LowerCropDamageTextBox" ControlToValidate="UpperCropDamageTextBox" ForeColor="Red" Operator="GreaterThanEqual">*Upper bound must be &gt;= lower bound</asp:CompareValidator>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="PropertyDropDown" />
            </Triggers>
        </asp:UpdatePanel>
        <br />
        <br />
        <br />
        <asp:ListBox ID="ResultsListBox" runat="server" Height="130px" Width="1500px"></asp:ListBox>
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="MainMenuButton" runat="server" OnClick="MainMenuButton_Click" Text="Main Menu" />
        <asp:Button ID="SearchButton" runat="server" OnClick="SearchButton_Click" Text="Search" />
    </form>
</body>
</html>
