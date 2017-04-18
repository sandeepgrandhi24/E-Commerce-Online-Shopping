<%@ Page Language="C#" MasterPageFile="~/Customer.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="OnlineShopping.Categories" %>

<asp:Content contentplaceholderid="ContentPlaceHolder1" runat="Server" >  

    <div id="page-wrapper">
    <div class="row">
        <div class="col-lg-12">
            <div class="container">

                <div class="row">
                    <div class="col-lg-12">
                        <h1 class="page-header">
                            Online Shopping</h1>
                    </div>
                </div>
                 <form id="Form1" method="post" runat="server">
                 <asp:Repeater id="Repeater1" runat="server">
         <ItemTemplate>         
                   <div class="col-md-4 portfolio-item">
                        <a href="CategoriesItems.aspx?Id=<%# DataBinder.Eval(Container.DataItem,"CategoryName") %>">
                           
                            <img class="img-responsive" src='Images/CategoryLogos/<%# DataBinder.Eval(Container.DataItem,"CategoryImgUrl") %>' style="width:300px; height:200px;">
                        </a>
                        &nbsp;&nbsp;<label><%# DataBinder.Eval(Container.DataItem,"CategoryName") %></label></div>
              </ItemTemplate>
      </asp:Repeater>
   </form>
            </div>
        </div>
    </div>
</div>

    <script src="@Url.Content("~/Content/bootstrap/js/jquery-1.10.2.js")"></script>


</asp:Content>
