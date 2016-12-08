<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="P5_TylerNowakCodyThompson.Modify" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="TitleLabel" runat="server" Font-Size="XX-Large" Text="Modify a Storm Event"></asp:Label>
        <br />
        <br />
        <asp:Label ID="AllStormsLabel" runat="server" Text="Below are all storms:"></asp:Label>
        <br />
        <br />
        <asp:ListBox ID="AllStormsList" runat="server" Height="126px"></asp:ListBox>
        <asp:TextBox ID="MaxIndexTextBox" runat="server" Visible="False"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="WhichEventQLabel" runat="server" Text="Enter the index number of the event you would like to modify:"></asp:Label>
        <asp:TextBox ID="IndexTextBox" runat="server" OnTextChanged="IndexTextBox_TextChanged"></asp:TextBox>
        <asp:RequiredFieldValidator ID="IndexRequiredFieldValidator" runat="server" ControlToValidate="IndexTextBox" ForeColor="Red">* Index Required</asp:RequiredFieldValidator>
        <asp:RangeValidator ID="IndexRangeValidator" runat="server" ControlToValidate="IndexTextBox" ForeColor="Red" MaximumValue="10000000" MinimumValue="0">* Must be &gt;= 0</asp:RangeValidator>
        <asp:CompareValidator ID="IndexCompareValidator" runat="server" ControlToCompare="MaxIndexTextBox" ControlToValidate="IndexTextBox" ForeColor="Red" Operator="LessThanEqual">* Index too large</asp:CompareValidator>
        <br />
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
            <ContentTemplate>
                <asp:Label ID="EnterFieldQLabel" runat="server" Text="Enter field you would like to modify:"></asp:Label>
                <asp:DropDownList ID="PropertyDropDown" runat="server" AutoPostBack="True" OnSelectedIndexChanged="PropertyDropDown_SelectedIndexChanged" Width="135px">
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
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
&nbsp;
        <br />
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                &nbsp;
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="IndexTextBox" EventName="TextChanged" />
            </Triggers>
        </asp:UpdatePanel>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                <asp:Label ID="TornadoTypeQLabel" runat="server">Choose a new tornado type:</asp:Label>
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
                <asp:Label ID="StateQLabel" runat="server">Choose a new state:</asp:Label>
                <asp:DropDownList ID="StateDropDown" runat="server" Height="16px" OnSelectedIndexChanged="StateDropDown_SelectedIndexChanged" Width="132px">
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
                <asp:Label ID="CountyQLabel" runat="server" Text="Enter a new full county name:"></asp:Label>
                <asp:TextBox ID="CountyTextBox" runat="server" OnTextChanged="CountyTextBox_TextChanged" Width="193px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="CountyRequiredFieldValidator" runat="server" ControlToValidate="CountyTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:Label ID="StartAzimuthQlabel" runat="server" Text="Choose a new starting azimuth (Compass direction):"></asp:Label>
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
                <asp:Label ID="StartLocationQlabel" runat="server" Text="Enter a new full start location name (nearest city):"></asp:Label>
                <asp:TextBox ID="StartLocationTextBox" runat="server" OnTextChanged="StartLocationTextBox_TextChanged" Width="197px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="StartLocationRequiredFieldValidator" runat="server" ControlToValidate="StartLocationTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:Label ID="EndAzimuthQLabel" runat="server" Text="Choose a new ending azimuth (Compass direction):"></asp:Label>
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
                <asp:Label ID="EndLocationQLabel" runat="server" Text="Enter a new full end location name (nearest city):"></asp:Label>
                <asp:TextBox ID="EndLocationTextBox" runat="server" OnTextChanged="StartLocationTextBox_TextChanged" Width="197px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="EndLocationRequiredFieldValidator" runat="server" ControlToValidate="EndLocationTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:Label ID="TimeZoneQLabel" runat="server" Text="Choose a new time zone:"></asp:Label>
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
                <asp:Label ID="InjuriesQ1Label" runat="server" Text="Enter a new number of injuries (integer):"></asp:Label>
                <asp:TextBox ID="LowerInjuriesTextBox" runat="server" OnTextChanged="LowerInjuriesTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerInjuriesRequiredFieldValidator" runat="server" ControlToValidate="LowerInjuriesTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerInjuriesRangeValidator" runat="server" ControlToValidate="LowerInjuriesTextBox" ForeColor="Red" MaximumValue="1000000" MinimumValue="0" Type="Integer">* Must be int &gt;= 0</asp:RangeValidator>
                <asp:Label ID="FatalitiesQ1Label" runat="server" Text="Enter a new number of fatalities (integer):"></asp:Label>
                <asp:TextBox ID="LowerFatalitiesTextBox" runat="server" OnTextChanged="LowerFatalitiesTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerFatalitiesRequiredFieldValidator" runat="server" ControlToValidate="LowerFatalitiesTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerFatalitiesRangeValidator" runat="server" ControlToValidate="LowerFatalitiesTextBox" ForeColor="Red" MaximumValue="1000000" MinimumValue="0" Type="Integer">* Must be int &gt;= 0</asp:RangeValidator>
                <asp:Label ID="WindSpeedQ1Label" runat="server" Text="Enter a new wind speed (integer, measured in knots):"></asp:Label>
                <asp:TextBox ID="LowerWindSpeedsTextBox" runat="server" OnTextChanged="LowerWindSpeedsTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerWindSpeedsRequiredFieldValidator" runat="server" ControlToValidate="LowerWindSpeedsTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerWindSpeedRangeValidator" runat="server" ControlToValidate="LowerWindSpeedsTextBox" ForeColor="Red" MaximumValue="1000000" MinimumValue="0" Type="Integer">* Must be int &gt; =0</asp:RangeValidator>
                <asp:Label ID="HailSizeQ1Label" runat="server" Text="Enter a new hail size (number in inches):"></asp:Label>
                <asp:TextBox ID="LowerHailSizeTextBox" runat="server" OnTextChanged="LowerHailSizeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerHailSizeRequiredFieldValidator" runat="server" ControlToValidate="LowerHailSizeTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerHailSizeRangeValidator" runat="server" ControlToValidate="LowerHailSizeTextBox" ForeColor="Red" MaximumValue="1000000" MinimumValue="0" Type="Double">* Must be double &gt;= 0</asp:RangeValidator>
                <asp:Label ID="StartRangeQ1Label" runat="server" Text="Enter a new event start range (miles from nearest city as integer):"></asp:Label>
                <asp:TextBox ID="LowerStartRangeTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerStartRangeRequiredFieldValidator" runat="server" ControlToValidate="LowerStartRangeTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerStartRangeValidator" runat="server" ControlToValidate="LowerStartRangeTextBox" ForeColor="Red" MaximumValue="1000000" MinimumValue="0" Type="Integer">* Must be int &gt;= 0</asp:RangeValidator>
                <asp:Label ID="EndRangeQ1Label" runat="server" Text="Enter a new event end range (miles from nearest city as integer):"></asp:Label>
                <asp:TextBox ID="LowerEndRangeTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerEndRangeRequiredFieldValidator" runat="server" ControlToValidate="LowerEndRangeTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerEndRangeValidator" runat="server" ControlToValidate="LowerEndRangeTextBox" ForeColor="Red" MaximumValue="1000000" MinimumValue="0" Type="Integer">* Must be int &gt;= 0</asp:RangeValidator>
                <asp:Label ID="StartYearQ1Label" runat="server" Text="Enter a new event start year (as an integer):"></asp:Label>
                <asp:TextBox ID="LowerStartYearTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerStartYearRequiredFieldValidator" runat="server" ControlToValidate="LowerStartYearTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerStartYearValidator" runat="server" ControlToValidate="LowerStartYearTextBox" ForeColor="Red" MaximumValue="2016" MinimumValue="1951" Type="Integer">* Must be int 1951-2016</asp:RangeValidator>
                <asp:Label ID="StartMonthQ1Label" runat="server" Text="Enter a new event start month (as an integer, 1-12):"></asp:Label>
                <asp:TextBox ID="LowerStartMonthTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerStartMonthRequiredFieldValidator" runat="server" ControlToValidate="LowerStartMonthTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerStartMonthValidator" runat="server" ControlToValidate="LowerStartMonthTextBox" ForeColor="Red" MaximumValue="12" MinimumValue="1" Type="Integer">* Must be int 1-12</asp:RangeValidator>
                <asp:Label ID="StartDayQ1Label" runat="server" Text="Enter a new event start day (as an integer, day of month):"></asp:Label>
                <asp:TextBox ID="LowerStartDayTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerStartDayRequiredFieldValidator" runat="server" ControlToValidate="LowerStartDayTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerStartDayValidator" runat="server" ControlToValidate="LowerStartDayTextBox" ForeColor="Red" MaximumValue="31" MinimumValue="1" Type="Integer">* Must be int 1-31</asp:RangeValidator>
                <asp:Label ID="StartTimeQ1Label" runat="server" Text="Enter a new event start time (24 hour time with no ':', Ex: 1425):"></asp:Label>
                <asp:TextBox ID="LowerStartTimeTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerStartTimeRequiredFieldValidator" runat="server" ControlToValidate="LowerStartTimeTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerStartTimeValidator" runat="server" ControlToValidate="LowerStartTimeTextBox" ForeColor="Red" MaximumValue="2359" MinimumValue="0" Type="Integer">* Must be int 0-2359</asp:RangeValidator>
                <asp:Label ID="EndYearQ1Label" runat="server" Text="Enter a new event end year (as an integer):"></asp:Label>
                <asp:TextBox ID="LowerEndYearTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerEndYearRequiredFieldValidator" runat="server" ControlToValidate="LowerEndYearTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerEndYearValidator" runat="server" ControlToValidate="LowerEndYearTextBox" ForeColor="Red" MaximumValue="2016" MinimumValue="1951" Type="Integer">* Must be int 1951-2016</asp:RangeValidator>
                <asp:Label ID="EndMonthQ1Label" runat="server" BorderStyle="None" Text="Enter a new event end month (as an integer, 1-12):"></asp:Label>
                <asp:TextBox ID="LowerEndMonthTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerEndMonthRequiredFieldValidator" runat="server" ControlToValidate="LowerEndMonthTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerEndMonthValidator" runat="server" ControlToValidate="LowerEndMonthTextBox" ForeColor="Red" MaximumValue="12" MinimumValue="1" Type="Integer">* Must be int 1-12</asp:RangeValidator>
                <asp:Label ID="EndDayQ1Label" runat="server" Text="Enter a new event end day (as an integer, day of month):"></asp:Label>
                <asp:TextBox ID="LowerEndDayTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerEndDayRequiredFieldValidator" runat="server" ControlToValidate="LowerEndDayTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerEndDayValidator" runat="server" ControlToValidate="LowerEndDayTextBox" ForeColor="Red" MaximumValue="31" MinimumValue="1" Type="Integer">* Must be int 1-31</asp:RangeValidator>
                <asp:Label ID="EndTimeQ1Label" runat="server" Text="Enter a new event end time (24 hour time with no ':', Ex: 1425):"></asp:Label>
                <asp:TextBox ID="LowerEndTimeTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerEndTimeRequiredFieldValidator" runat="server" ControlToValidate="LowerEndTimeTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerEndTimeValidator" runat="server" ControlToValidate="LowerEndTimeTextBox" ForeColor="Red" MaximumValue="2359" MinimumValue="0" Type="Integer">* Must be int 0-2359</asp:RangeValidator>
                <asp:Label ID="TornadoLengthQ1Label" runat="server" Text="Enter a new tornado length (how far in miles):"></asp:Label>
                <asp:TextBox ID="LowerTornadoLengthTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerTornadoLengthRequiredFieldValidator" runat="server" ControlToValidate="LowerTornadoLengthTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerTornadoLengthRangeValidator" runat="server" ControlToValidate="LowerTornadoLengthTextBox" ForeColor="Red" MaximumValue="1000000" MinimumValue="0" Type="Double">* Must be double &gt;= 0</asp:RangeValidator>
                <asp:Label ID="TornadoWidthQ1Label" runat="server" Text="Enter a new tornado width (yards, diameter across):"></asp:Label>
                <asp:TextBox ID="LowerTornadoWidthTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerTornadoWidthRequiredFieldValidator" runat="server" ControlToValidate="LowerTornadoWidthTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerTornadoWidthRangeValidator" runat="server" ControlToValidate="LowerTornadoWidthTextBox" ForeColor="Red" MaximumValue="1000000" MinimumValue="0" Type="Double">* Must be double &gt;= 0</asp:RangeValidator>
                <asp:Label ID="StartLatitudeQ1Label" runat="server" Text="Enter a new start latitude (-90 to 90):"></asp:Label>
                <asp:TextBox ID="LowerStartLatitudeTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerStartLatitudeRequiredFieldValidator" runat="server" ControlToValidate="LowerStartLatitudeTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerStartLatitudeRangeValidator" runat="server" ControlToValidate="LowerStartLatitudeTextBox" ForeColor="Red" MaximumValue="90" MinimumValue="-90" Type="Double">* Must be double -90 to 90</asp:RangeValidator>
                <asp:Label ID="StartLongitudeQ1Label" runat="server" Text="Enter a new event start longitude (-180 to 180):"></asp:Label>
                <asp:TextBox ID="LowerStartLongitudeTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerStartLongitudeRequiredFieldValidator" runat="server" ControlToValidate="LowerStartLongitudeTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerStartLongitudeRangeValidator" runat="server" ControlToValidate="LowerStartLongitudeTextBox" ForeColor="Red" MaximumValue="180" MinimumValue="-180" Type="Double">* Must be double -180 to 180</asp:RangeValidator>
                <asp:Label ID="EndLatitudeQ1Label" runat="server" Text="Enter a new event end latitude (-90 to 90):"></asp:Label>
                <asp:TextBox ID="LowerEndLatitudeTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerEndLatitudeRequiredFieldValidator" runat="server" ControlToValidate="LowerEndLatitudeTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerEndLatitudeRangeValidator" runat="server" ControlToValidate="LowerEndLatitudeTextBox" ForeColor="Red" MaximumValue="90" MinimumValue="-90" Type="Double">* Must be double -90 to 90</asp:RangeValidator>
                <asp:Label ID="EndLongitudeQ1Label" runat="server" Text="Enter a new event end longitude (-180 to 180):"></asp:Label>
                <asp:TextBox ID="LowerEndLongitudeTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerEndLongitudeRequiredFieldValidator" runat="server" ControlToValidate="LowerEndLongitudeTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerEndLongitudeRangeValidator" runat="server" ControlToValidate="LowerEndLongitudeTextBox" ForeColor="Red" MaximumValue="180" MinimumValue="-180" Type="Double">* Must be double -180 to 180</asp:RangeValidator>
                <asp:Label ID="PropertyDamageQ1Label" runat="server" Text="Enter a new property damage amount (as a number without '$' or commas):"></asp:Label>
                <asp:TextBox ID="LowerPropertyDamageTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerPropertyDamageRequiredFieldValidator" runat="server" ControlToValidate="LowerPropertyDamageTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerPropertyDamageRangeValidator" runat="server" ControlToValidate="LowerPropertyDamageTextBox" ForeColor="Red" MaximumValue="1000000" MinimumValue="0" Type="Double">* Must be &gt;= 0 w/o commas</asp:RangeValidator>
                <asp:Label ID="CropDamageQ1Label" runat="server" Text="Enter a new crop damage amount (as a number without '$' or commas):"></asp:Label>
                <asp:TextBox ID="LowerCropDamageTextBox" runat="server" OnTextChanged="LowerStartRangeTextBox_TextChanged" Width="97px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LowerCropDamageRequiredFieldValidator" runat="server" ControlToValidate="LowerCropDamageTextBox" ForeColor="Red">* Required Field</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="LowerCropDamageRangeValidator" runat="server" ControlToValidate="LowerCropDamageTextBox" ForeColor="Red" MaximumValue="1000000" MinimumValue="0" Type="Double">* Must be &gt;= 0 w/o commas</asp:RangeValidator>
                <br />
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="PropertyDropDown">
                </asp:AsyncPostBackTrigger>
            </Triggers>
        </asp:UpdatePanel>
    
    </div>
    </form>
</body>
</html>
