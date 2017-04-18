<%@ Page Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="cmsBrandsCreate.aspx.cs" Inherits="OnlineShopping.cmsBrandsCreate" %>

<asp:Content contentplaceholderid="ContentPlaceHolder1" runat="Server">
    
<div id="page-wrapper">
    <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">Create-Brand</h1>
            <h6 class="text-success"><asp:Label runat="server" ID="TxtMsg"></asp:Label></h6>
        </div>
        <!-- /.col-lg-12 -->
    </div>
    <!-- /.row -->
    <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <a href="cmsBrands.aspx">Back to brands</a>
                </div>
                <div class="panel-body">
                    <div class="row">
                        <div class="col-lg-6">

                           <form action="cmsBrandsCreate.aspx" runat="server" method="post" id = "CreateBrandformValidation">
                               
                                <div class="form-group">
                                    <label>Brand Name</label>                                    
                                    <asp:TextBox CssClass="form-control" placeholder="Brand name" Names="BrandName" ID="BrandName" runat="server"></asp:TextBox>
                                </div>
                               <div class="form-group">
                                   <asp:RadioButtonList CssClass="form-control" ID="categorylist" placeholder=" Category name" Names="CategoryName" runat="server"></asp:RadioButtonList>
                               </div>
                                <div class="form-group">
                                    <label>Brand Description</label>                                                                        
                                  <asp:TextBox id="BrandDesc" CssClass="form-control" placeholder="Brand description" TextMode="multiline" Columns="50" Rows="5" runat="server" />
                                </div>

                                <div class="form-group">
                                    <label>Upload Brand Logo</label>
                                    <asp:FileUpload   CssClass="form-control" ID="file" name="file" runat="server" />
                                </div>
                               <asp:Button ID="CreateBrand" class="btn btn-success" runat="server" Text="Submit" OnClick="CreateBrand_Click"></asp:Button>
                                <button type="reset" class="btn btn-default">Reset</button>

                            </form>

                        </div>
                    </div>
                    <!-- /.row (nested) -->
                </div>
                <!-- /.panel-body -->
            </div>
            <!-- /.panel -->
        </div>
        <!-- /.col-lg-12 -->
    </div>
    <!-- /.row -->
</div>

<script src="Scripts/jquery-1.7.1.js"></script>
<script src="Scripts/jquery.validate.js"></script>
<script>
    $(document).ready(function () {
        //$("#CreateBrandformValidation").validate({

        //    rules: {
        //        BrandName: { required: true }
               

        //    },
        //    messages: {
        //        BrandName: { required: 'Please enter category name.' }

        //    },
        //    submitHandler: function (form) {
        //        form.submit();
        //    }
        //});
    })
</script>

    </asp:Content>
