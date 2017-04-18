<%@ Page Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="cmsCategoriesEdit.aspx.cs" Inherits="OnlineShopping.cmsCategoriesEdit" %>

<asp:Content ID="Content1" contentplaceholderid="ContentPlaceHolder1" runat="Server">
    
<div id="page-wrapper">
    <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">Edit-Category</h1>
            <h6 class="text-success"><asp:Label runat="server" ID="TxtMsg"></asp:Label></h6>
        </div>
        <!-- /.col-lg-12 -->
    </div>
    <!-- /.row -->
    <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <a href="cmscategories.aspx">Back to Category</a>
                </div>
                <div class="panel-body">
                    <div class="row">
                        <div class="col-lg-6">

                           <form action="cmsCategoriesEdit.aspx" runat="server" method="post" id = "CreateBrandformValidation">
                               <asp:HiddenField ID="CategoryId" runat="server"/>
                                <asp:HiddenField ID="CategoryImgUrl" runat="server"/>
                                <div class="form-group">
                                    <label>Category Name</label>                                    
                                    <asp:TextBox CssClass="form-control" placeholder="Category Name" Names="CategoryName" ID="CategoryName" runat="server"></asp:TextBox>
                                </div>

                                <div class="form-group">
                                    <label>Category Description</label>                                                                        
                                  <asp:TextBox id="CategoryDesc" CssClass="form-control" placeholder="Category description" TextMode="multiline" Columns="50" Rows="5" runat="server" />
                                </div>
                               <div class="form-group">
                                    
                                     <asp:Image ID="Image1" runat="server" Width="200px" Height="200px"  Visible = "true"/>
                                </div>
                                <div class="form-group">
                                    <label>Upload Category Logo</label>
                                    <asp:FileUpload   CssClass="form-control" ID="file" name="file" runat="server" />
                                </div>
                               <asp:Button ID="CreateBrand" class="btn btn-success" runat="server" Text="Submit" OnClick="EditCategory_Click"></asp:Button>
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