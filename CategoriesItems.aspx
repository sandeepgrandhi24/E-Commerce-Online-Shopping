<%@ Page Language="C#" MasterPageFile="~/Customer.Master" AutoEventWireup="true" CodeBehind="CategoriesItems.aspx.cs" Inherits="OnlineShopping.CategoriesItems" %>

<asp:Content contentplaceholderid="ContentPlaceHolder1" runat="Server">  

    
<div id="page-wrapper">
    <div class="row">
        <div class="col-lg-12">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12">
                        <h1 class="page-header">
                            <small>Onlineshopping </small>
                        </h1>
                    </div>
                </div>
               <form id="Form1" method="post" runat="server"> 
                 


                    <div class="row">
                       <asp:Label runat="server" ID="Msg" CssClass="text-danger"></asp:Label>
                        <div class="col-md-4 portfolio-item">

                            <asp:HyperLink ID="HyperLink1" runat="server">
                                <asp:Label ID="ItemName" runat="server"></asp:Label>
                                <asp:Image ID="Imgrl" class="img-responsive" runat="server"></asp:Image>
                                <asp:Label ID="ItemDesc" runat="server"></asp:Label>
                                <asp:Label ID="Price" runat="server"></asp:Label>

                 
</asp:HyperLink>
                            <br />
                            <br />

                             <asp:HyperLink ID="HyperLink2" runat="server">
                                <asp:Label ID="ItemName2" runat="server"></asp:Label>
                                <asp:Image ID="Imgrl2" class="img-responsive" runat="server"></asp:Image>
                                <asp:Label ID="ItemDesc2" runat="server"></asp:Label>
                                <asp:Label ID="Price2" runat="server"></asp:Label>

                 
</asp:HyperLink>
                             <asp:HyperLink ID="HyperLink3" runat="server">
                                <asp:Label ID="ItemName3" runat="server"></asp:Label>
                                <asp:Image ID="Imgrl3" class="img-responsive" runat="server"></asp:Image>
                                <asp:Label ID="ItemDesc3" runat="server"></asp:Label>
                                <asp:Label ID="Price3" runat="server"></asp:Label>

                 
</asp:HyperLink>
                        </div>
                       
                      </div>
          
              </form>               </div>
        </div>
    </div>
</div>
 <!-- Core Scripts - Include with every page -->
    <script src="Content/bootstrap/js/jquery-1.10.2.js"></script>

 </asp:Content>