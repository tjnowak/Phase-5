<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Count.aspx.cs" Inherits="P5_TylerNowakCodyThompson.Count" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="TitleLabel" runat="server" Text="Weather Event Count" Font-Size="XX-Large"></asp:Label>
        <br />
        <br />
        <asp:Label ID="EventCountLabel" runat="server" Text="The number of events currently stored is:"></asp:Label>
&nbsp;
        <asp:Label ID="TheCountLabel" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Button ID="MainMenuButton" runat="server" Text="Main Menu" OnClick="MainMenuButton_Click" />
        <br />
    </form>
</body>
</html>
