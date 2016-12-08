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
        <asp:DropDownList ID="StartMonthDropDown" runat="server">
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
        <asp:Label ID="StartDayLabel" runat="server" Text="Enter the start day (day of month):"></asp:Label>
        <asp:TextBox ID="StartDayTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="StartTimeLabel" runat="server" Text="Enter the time (24-hr time with no ':' ) the storm began:"></asp:Label>
        <asp:TextBox ID="StartTimeTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="EndYearLabel" runat="server" Text="Enter event end year (Ex: 1976):"></asp:Label>
        <asp:TextBox ID="EndYearTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="EndMonthLabel" runat="server" Text="Choose event end month:  "></asp:Label>
        <asp:DropDownList ID="EndMonthDropDown" runat="server">
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
        <asp:Label ID="EndDayLabel" runat="server" Text="Enter the end day (day of month):"></asp:Label>
        <asp:TextBox ID="EndDayTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="EndTimeLabel" runat="server" Text="Enter the time (24-hr time with no ':' ) the storm ended:"></asp:Label>
        <asp:TextBox ID="EndTimeTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="StateLabel" runat="server" Text="Choose the state the storm happened in:"></asp:Label>
        <asp:DropDownList ID="SelectStateDropDown" runat="server" OnSelectedIndexChanged="StateDropDown0_SelectedIndexChanged">
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
        <asp:Label ID="CountyLabel" runat="server" Text="Enter the county the storm happened in:"></asp:Label>
        <asp:TextBox ID="CountyTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="TimeZoneLabel" runat="server" Text="Choose the time zone the event took place in:"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Atlantic Standard Time (AST)</asp:ListItem>
            <asp:ListItem>Eastern Standard Time (EST)</asp:ListItem>
            <asp:ListItem>Central Standard Time (CST)</asp:ListItem>
            <asp:ListItem>Eastern Daylight Time (EDT)</asp:ListItem>
            <asp:ListItem>Mountain Standard Time (MST)</asp:ListItem>
            <asp:ListItem>Pacific Standard Time (PST)</asp:ListItem>
            <asp:ListItem>Alaskan Standard Time (AKST)</asp:ListItem>
            <asp:ListItem>Hawaii-Aleutian Standard Time (HST)</asp:ListItem>
            <asp:ListItem>Samoa standard time (UTC-11)</asp:ListItem>
            <asp:ListItem>Chamorro Standard Time (UTC+10)</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="InjuriesLabel" runat="server" Text="Enter the number of injuries due to the storm:"></asp:Label>
        <asp:TextBox ID="InjuriesTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="DeathsLabel" runat="server" Text="Enter the number of fatalities due to the storm:"></asp:Label>
        <asp:TextBox ID="DeathsTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="MainMenuButton" runat="server" OnClick="Button1_Click" Text="Main Menu" />
    </form>
</body>
</html>
