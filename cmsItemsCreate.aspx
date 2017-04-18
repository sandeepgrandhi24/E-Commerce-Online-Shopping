<%@ Page Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="cmsItemsCreate.aspx.cs" Inherits="OnlineShopping.cmsItemsCreate" %>

<asp:Content contentplaceholderid="ContentPlaceHolder1" runat="Server" >

    <div id="page-wrapper">
    <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">Create-Item</h1>
            <h6 class="text-success"><asp:Label runat="server" ID="TxtMsg"></asp:Label></h6>
        </div>
        <!-- /.col-lg-12 -->
    </div>
    <!-- /.row -->
    <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <a href="cmsItems.aspx">Back to Items</a>
                </div>
                <div class="panel-body">
                    <div class="row">
                        <div class="col-lg-6">
                                <form runat="server" action="cmsItemsCreate.aspx" method="post">
                                <div class="form-group">
                                    <label>Item Brand</label>
                            <asp:DropDownList ID="DDLBrand" class="form-control" runat="server"></asp:DropDownList>
                                </div>
                                <div class="form-group">
                                    <label>Item Category</label>
                                    <asp:DropDownList ID="DDLCategory" class="form-control" runat="server"></asp:DropDownList>
                                </div>
                                <div class="form-group">
                                    <label>Item Name</label>
                                    <asp:TextBox runat="server" class="form-control" placeholder="Enter item name" name="ItemName" ID="ItemName" />
                                </div>
                                <div class="form-group">
                                    <label>Item Description</label>
                                    <asp:TextBox runat="server" class="form-control" placeholder="Enter item description" name="ItemDesc" ID="ItemDesc" />
                                </div>
                                <div class="form-group">
                                    <label>Upload Image</label>
                                    <asp:FileUpload runat="server" name="file" ID="file" />
                                </div>
                                
                                <div class="form-group">
                                    <label>Item Quantity</label>
                                    <asp:TextBox runat="server" class="form-control" placeholder="Enter item quantity" name="ItemQuantity" ID="ItemQuantity" />
                                </div>
                                <div class="form-group">
                                    <label>Item Price</label>
                                    <asp:TextBox runat="server" class="form-control" placeholder="Enter item price" name="ItemPrice" ID="ItemPrice" />
                                </div>
                                <div class="form-group">
                                    <label>Item Offer</label>
                                    <asp:TextBox runat="server" class="form-control" placeholder="Enter item Offer" name="ItemOffer" ID="ItemOffer" />
                                </div>
                                    

                                <div class="form-group">
                                    <asp:Button ID="CreateItem" class="btn btn-success" runat="server" Text="Submit" OnClick="CreateItem_Click"></asp:Button>
                                    <input name="Input" type="reset" value="Reset" class="btn btn-default" />
                                </div>
                                    </form>
                            
                        </div>
                    </div>
                </div>

                <!-- /.panel-body -->
            </div>
            <!-- /.panel -->
        </div>
        <!-- /.col-lg-12 -->
    </div>
</div>
<script src="Scripts/jquery-1.7.1.js"></script>
<script src="Scripts/jquery.validate.js"></script>
<script src="Scripts/jquery-form-validation-V.1.js"></script>

</asp:Content>
