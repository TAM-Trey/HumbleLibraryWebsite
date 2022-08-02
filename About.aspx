<%@ Page Language="C#" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 609px">
    <form id="form1" runat="server">
    <div style="height: 636px">
    
        <asp:Panel ID="Panel1" runat="server" BackImageUrl="~/about.jpg" 
            Height="1000px">
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/humlogo.png" 
                onclick="ImageButton1_Click" />
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
