<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProdList.aspx.cs" Inherits="UserControl.ProdList" %>
<%@ Register Src="~/UserControl/ProductList.ascx" TagPrefix="UC" TagName="ProductList" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
<meta name="viewport" content="width=device-width, initial-scale=1">
<title></title>
<link rel="stylesheet" type="text/css" href="css/bootstrap.rtl.min.css" />
<link rel="stylesheet" type="text/css" href="css/style.css" />
</head>
<body>
        <UC:ProductList id ="ProductList" runat="server" />
<script src="js/bootstrap.min.js"></script>
</body>
</html>
