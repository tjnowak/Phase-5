<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:scriptmanager id="ScriptManager1" runat="server" enablepartialrendering="true">
</asp:scriptmanager>
 

<asp:dropdownlist id="ddlTeams" runat="server" autopostback="true" onselectedindexchanged="ddlTeams_SelectedIndexChanged"/>
 

<asp:updatepanel id="upMeasures" runat="server" updatemode="Conditional">
<contenttemplate>
<asp:dropdownlist id="ddlMeasures" runat="server"/>
<asp:Label id="lblTime" runat="server" />
</contenttemplate>
<triggers>
<asp:asyncpostbacktrigger controlid="ddlTeams" eventname="SelectedIndexChanged" />
</triggers>
</asp:updatepanel> 
    </div>
    </form>
</body>
</html>
