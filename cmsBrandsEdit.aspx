<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Admin.Master" CodeBehind="cmsBrandsEdit.aspx.cs" Inherits="OnlineShopping.cmsBrandsEdit" %>

<asp:Content contentplaceholderid="ContentPlaceHolder1" runat="Server">
    
<div id="page-wrapper">
    <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">Edit-Brand</h1>
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
                            <form runat="server"  method="post">
                               
                                <asp:HiddenField ID="BrandId" runat="server"/>
                                <asp:HiddenField ID="BrandImgUrl" runat="server"/>
                                    <div class="form-group">
                                    <label>Brand Name</label>                                    
                                    <asp:TextBox CssClass="form-control" placeholder="Brand name" Names="BrandName" ID="BrandName" runat="server"></asp:TextBox>
                                </div>

                                <div class="form-group">
                                    <label>Brand Description</label>                                                                        
                                  <asp:TextBox id="BrandDesc" CssClass="form-control" placeholder="Brand description" TextMode="multiline" Columns="50" Rows="5" runat="server" />
                                </div>
                                <div class="form-group">
                                    
                                     <asp:Image ID="Image1" runat="server" Width="200px" Height="200px"  Visible = "true"/>
                                </div>
                                <div class="form-group">
                                    <label>Upload Brand Logo</label>
                                    <asp:FileUpload   CssClass="form-control" ID="file" name="file" runat="server" />
                                </div>
                                <asp:Button ID="EditBrands" class="btn btn-success" runat="server" Text="Submit" OnClick="EditBrands_Click" ></asp:Button>
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
<script src="Scripts/jquery-form-validation-V.1.js"></script>

    </asp:Content>

