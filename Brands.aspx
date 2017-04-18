<%@ Page Language="C#" MasterPageFile="~/Customer.Master" AutoEventWireup="true" CodeBehind="Brands.aspx.cs" Inherits="OnlineShopping.Brands" %>


<asp:Content contentplaceholderid="ContentPlaceHolder1" runat="Server" >


    
<div id="page-wrapper">
    <div class="row">
        <div class="">
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
             <div class="col-md-3 portfolio-item">
                        <a href="BrandItems.aspx?Id=<%# DataBinder.Eval(Container.DataItem,"BrandID") %>">
                           
                            <img class="img-responsive" src='Images/BrandLogos/<%# DataBinder.Eval(Container.DataItem,"BrandImgUrl") %>' style="width:300px; height:200px;">
                        </a>
              &nbsp;<label><%# DataBinder.Eval(Container.DataItem,"BrandName") %></label></div>
	 </ItemTemplate>
      </asp:Repeater>
   </form>

            </div>
        </div>
    </div>
</div>
 <!-- Core Scripts - Include with every page -->
    <script src="/Content/bootstrap/js/jquery-1.10.2.js"></script>


</asp:Content>