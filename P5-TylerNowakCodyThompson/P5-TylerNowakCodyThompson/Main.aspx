<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="P5_TylerNowakCodyThompson.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label3" runat="server" Font-Size="XX-Large" Text="Inclement Weather Events"></asp:Label>
    
    </div>
        <br />
        <asp:Label ID="Label1" runat="server">Please select an option below.</asp:Label>
        <br />
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
            <asp:ListItem>Add an event</asp:ListItem>
            <asp:ListItem>Modify an event</asp:ListItem>
            <asp:ListItem>Search for events</asp:ListItem>
            <asp:ListItem>Display count of stored events</asp:ListItem>
            <asp:ListItem>Get statistics</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Select " />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label>
    </form>
</body>
</html>
