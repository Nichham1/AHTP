<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Logout.aspx.cs" Inherits="ATruckingPayroll.Logout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        body{height: 200px; width: 400px; background: black; position: fixed; top: 50%; left: 50%; margin-top: -100px; margin-left: -200px; color:azure; text-align:center;}

        #loading {width: 20%; height: 20%; position:center; display: block; text-align: center; left:20px; float:right;}
        #loading-image { display: block; margin-left: auto; margin-right: auto;  width: 50%;}

    </style>
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
    <asp:Label ID="Label1" Text="" runat="server" />
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick">
                </asp:Timer>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    </form>
     
     <div id="loading">
            <img id="loading-image" src="Content/img/ajax-loader.gif" alt="Loading..." />
       </div>
</body>
</html>
