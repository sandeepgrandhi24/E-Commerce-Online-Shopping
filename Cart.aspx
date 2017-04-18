<%@ Page Language="C#" MasterPageFile="~/Customer.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="OnlineShopping.Cart" %>


<asp:Content contentplaceholderid="ContentPlaceHolder1" runat="Server" xmlns:asp="#unknown">   

    <div id="page-wrapper">
    <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">Cart List</h1>
        </div>
        <!-- /.col-lg-12 -->
    </div>
    <!-- /.row -->
    <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    These are the available cart at Online Shopping
                </div>
                <!-- /.panel-heading -->
                <div class="panel-body">
                    <div class="table-responsive">
                       
                     <form id="Form1" runat="server">                             
             <asp:GridView class="table table-striped table-bordered table-hover" ID="dataTables" runat="server" PageSize="10" 
                  AutoGenerateColumns="false" AllowPaging="true" DataKeyNames="ItemID" OnPaging="dataTables_SelectedIndexChanged"
                 
                  >
            <Columns>
                <asp:BoundField DataField="CategoryName" HeaderText="Category Name" ReadOnly="True" 
                    SortExpression="CategoryName" />
                <asp:BoundField DataField="BrandName" HeaderText="Brand Name" 
                    SortExpression="BrandName" />
                <asp:BoundField DataField="ItemName" HeaderText="Item Name" 
                    SortExpression="ItemName" />               
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" 
                    SortExpression="Quantity" />
                <asp:BoundField DataField="Price" HeaderText="Price" 
                    SortExpression="Price" />
                <asp:TemplateField HeaderText="Buy">
                 <ItemTemplate>
                <asp:LinkButton ID="lnkEdit" runat="server"   OnClick="Edit_Click" class="btn btn-success">Buy</asp:LinkButton>
                </ItemTemplate>
                  </asp:TemplateField>
                             
                
            </Columns>
                
        </asp:GridView>
             
                          </form>
                    
                    </div>
                    <!-- /.table-responsive -->

                </div>
                <!-- /.panel-body -->
            </div>
            <!-- /.panel -->
        </div>
        <!-- /.col-lg-12 -->
    </div>
</div>



 <!-- Core Scripts - Include with every page -->
    <script src="@Url.Content("~/Content/bootstrap/js/jquery-1.10.2.js")"></script>


    </asp:Content>