<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AvgTorDamg.aspx.cs" Inherits="P5_TylerNowakCodyThompson.AvgTorDamg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Button ID="AvgTorDamgToMain" runat="server" OnClick="FatalToMain_Click" Text="Go Back To Main Menu" />
&nbsp;
        <asp:Button ID="AvgTorDamgToStats" runat="server" OnClick="FatalToStats_Click" Text="Go Back To Statistics Options" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Pick the time frame you are interested in seeing the averge tornado damage for (by state):"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="From (year):"></asp:Label>
        <br />
        <asp:DropDownList ID="StartYearDropDown" runat="server" OnSelectedIndexChanged="StartYearDropDown_SelectedIndexChanged">
            <asp:ListItem>Pick One</asp:ListItem>
            <asp:ListItem>1951</asp:ListItem>
            <asp:ListItem>1952</asp:ListItem>
            <asp:ListItem>1953</asp:ListItem>
            <asp:ListItem>1954</asp:ListItem>
            <asp:ListItem>1955</asp:ListItem>
            <asp:ListItem>1956</asp:ListItem>
            <asp:ListItem>1957</asp:ListItem>
            <asp:ListItem>1958</asp:ListItem>
            <asp:ListItem>1959</asp:ListItem>
            <asp:ListItem>1960</asp:ListItem>
            <asp:ListItem>1961</asp:ListItem>
            <asp:ListItem>1962</asp:ListItem>
            <asp:ListItem>1963</asp:ListItem>
            <asp:ListItem>1964</asp:ListItem>
            <asp:ListItem>1965</asp:ListItem>
            <asp:ListItem>1966</asp:ListItem>
            <asp:ListItem>1967</asp:ListItem>
            <asp:ListItem>1968</asp:ListItem>
            <asp:ListItem>1969</asp:ListItem>
            <asp:ListItem>1970</asp:ListItem>
            <asp:ListItem>1971</asp:ListItem>
            <asp:ListItem>1972</asp:ListItem>
            <asp:ListItem>1973</asp:ListItem>
            <asp:ListItem>1974</asp:ListItem>
            <asp:ListItem>1975</asp:ListItem>
            <asp:ListItem>1976</asp:ListItem>
            <asp:ListItem>1977</asp:ListItem>
            <asp:ListItem>1978</asp:ListItem>
            <asp:ListItem>1979</asp:ListItem>
            <asp:ListItem>1980</asp:ListItem>
            <asp:ListItem>1981</asp:ListItem>
            <asp:ListItem>1982</asp:ListItem>
            <asp:ListItem>1983</asp:ListItem>
            <asp:ListItem>1984</asp:ListItem>
            <asp:ListItem>1985</asp:ListItem>
            <asp:ListItem>1986</asp:ListItem>
            <asp:ListItem>1987</asp:ListItem>
            <asp:ListItem>1988</asp:ListItem>
            <asp:ListItem>1989</asp:ListItem>
            <asp:ListItem>1990</asp:ListItem>
            <asp:ListItem>1991</asp:ListItem>
            <asp:ListItem>1992</asp:ListItem>
            <asp:ListItem>1993</asp:ListItem>
            <asp:ListItem>1994</asp:ListItem>
            <asp:ListItem>1995</asp:ListItem>
            <asp:ListItem>1996</asp:ListItem>
            <asp:ListItem>1997</asp:ListItem>
            <asp:ListItem>1998</asp:ListItem>
            <asp:ListItem>1999</asp:ListItem>
            <asp:ListItem>2000</asp:ListItem>
            <asp:ListItem>2001</asp:ListItem>
            <asp:ListItem>2002</asp:ListItem>
            <asp:ListItem>2003</asp:ListItem>
            <asp:ListItem>2004</asp:ListItem>
            <asp:ListItem>2005</asp:ListItem>
            <asp:ListItem>2006</asp:ListItem>
            <asp:ListItem>2007</asp:ListItem>
            <asp:ListItem>2008</asp:ListItem>
            <asp:ListItem>2009</asp:ListItem>
            <asp:ListItem>2010</asp:ListItem>
            <asp:ListItem>2011</asp:ListItem>
            <asp:ListItem>2012</asp:ListItem>
            <asp:ListItem>2013</asp:ListItem>
            <asp:ListItem>2014</asp:ListItem>
            <asp:ListItem>2015</asp:ListItem>
            <asp:ListItem>2016</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="To (year):"></asp:Label>
        <br />
        <asp:DropDownList ID="EndYearDropDown" runat="server" OnSelectedIndexChanged="EndYearDropDown_SelectedIndexChanged">
            <asp:ListItem>Pick One</asp:ListItem>
            <asp:ListItem>1951</asp:ListItem>
            <asp:ListItem>1952</asp:ListItem>
            <asp:ListItem>1953</asp:ListItem>
            <asp:ListItem>1954</asp:ListItem>
            <asp:ListItem>1955</asp:ListItem>
            <asp:ListItem>1956</asp:ListItem>
            <asp:ListItem>1957</asp:ListItem>
            <asp:ListItem>1958</asp:ListItem>
            <asp:ListItem>1959</asp:ListItem>
            <asp:ListItem>1960</asp:ListItem>
            <asp:ListItem>1961</asp:ListItem>
            <asp:ListItem>1962</asp:ListItem>
            <asp:ListItem>1963</asp:ListItem>
            <asp:ListItem>1964</asp:ListItem>
            <asp:ListItem>1965</asp:ListItem>
            <asp:ListItem>1966</asp:ListItem>
            <asp:ListItem>1967</asp:ListItem>
            <asp:ListItem>1968</asp:ListItem>
            <asp:ListItem>1969</asp:ListItem>
            <asp:ListItem>1970</asp:ListItem>
            <asp:ListItem>1971</asp:ListItem>
            <asp:ListItem>1972</asp:ListItem>
            <asp:ListItem>1973</asp:ListItem>
            <asp:ListItem>1974</asp:ListItem>
            <asp:ListItem>1975</asp:ListItem>
            <asp:ListItem>1976</asp:ListItem>
            <asp:ListItem>1977</asp:ListItem>
            <asp:ListItem>1978</asp:ListItem>
            <asp:ListItem>1979</asp:ListItem>
            <asp:ListItem>1980</asp:ListItem>
            <asp:ListItem>1981</asp:ListItem>
            <asp:ListItem>1982</asp:ListItem>
            <asp:ListItem>1983</asp:ListItem>
            <asp:ListItem>1984</asp:ListItem>
            <asp:ListItem>1985</asp:ListItem>
            <asp:ListItem>1986</asp:ListItem>
            <asp:ListItem>1987</asp:ListItem>
            <asp:ListItem>1988</asp:ListItem>
            <asp:ListItem>1989</asp:ListItem>
            <asp:ListItem>1990</asp:ListItem>
            <asp:ListItem>1991</asp:ListItem>
            <asp:ListItem>1992</asp:ListItem>
            <asp:ListItem>1993</asp:ListItem>
            <asp:ListItem>1994</asp:ListItem>
            <asp:ListItem>1995</asp:ListItem>
            <asp:ListItem>1996</asp:ListItem>
            <asp:ListItem>1997</asp:ListItem>
            <asp:ListItem>1998</asp:ListItem>
            <asp:ListItem>1999</asp:ListItem>
            <asp:ListItem>2000</asp:ListItem>
            <asp:ListItem>2001</asp:ListItem>
            <asp:ListItem>2002</asp:ListItem>
            <asp:ListItem>2003</asp:ListItem>
            <asp:ListItem>2004</asp:ListItem>
            <asp:ListItem>2005</asp:ListItem>
            <asp:ListItem>2006</asp:ListItem>
            <asp:ListItem>2007</asp:ListItem>
            <asp:ListItem>2008</asp:ListItem>
            <asp:ListItem>2009</asp:ListItem>
            <asp:ListItem>2010</asp:ListItem>
            <asp:ListItem>2011</asp:ListItem>
            <asp:ListItem>2012</asp:ListItem>
            <asp:ListItem>2013</asp:ListItem>
            <asp:ListItem>2014</asp:ListItem>
            <asp:ListItem>2015</asp:ListItem>
            <asp:ListItem>2016</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Visible="False"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Button ID="CalcDamage" runat="server" OnClick="CalcDamage_Click" Text="Get Damage stats" Visible="False" />
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Results (in format state = average damage):" Visible="False"></asp:Label>
        <br />
        <asp:ListBox ID="DisplayDmgStats" runat="server" Visible="False"></asp:ListBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="If you would like to select new values and try again, click the button below:" Visible="False"></asp:Label>
        <br />
        <asp:Button ID="TryAgain1" runat="server" OnClick="TryAgain1_Click" Text="Try again" Visible="False" />
        <br />
    </form>
</body>
</html>
