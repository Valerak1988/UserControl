<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProductList.ascx.cs" Inherits="UserControl.UserControl.ProductList" %>

<form id="form1" runat="server">
    <div class="container">
        <div class="row">
            <asp:Repeater ID="RptProducts" runat="server">
                <ItemTemplate>
                    <div class="col-md-4">
                        <div class="card" style="width: 18rem;">
                            <img src="/Uploads/Product/<%# Eval("Picname") %>" class="card-img-top" alt="...">
                            <div class="card-body">
                                <h5 class="card-title"><%#Eval("Pname") %></h5>
                                <p class="card-text"><%#Eval("Price") %></p>
                                <a href="#" class="btn btn-primary">Add To Cart</a>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</form>