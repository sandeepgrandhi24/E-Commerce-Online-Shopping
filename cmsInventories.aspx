<%@ Page Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="cmsInventories.aspx.cs" Inherits="OnlineShopping.cmsInventories" %>

<asp:content contentplaceholderid="ContentPlaceHolder1" runat="Server" >
    <div id="page-wrapper">
    <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">Inventories List</h1>
            <h5 class="sucMsg text-success"><asp:Label runat="server" ID="TxtMsg"></asp:Label></h5>
        </div>
        <!-- /.col-lg-12 -->
    </div>
    <!-- /.row -->
    <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    these are the available Inventories at eBuy
                </div>
                <!-- /.panel-heading -->
                <div class="panel-body">
                    <div class="table-responsive">
                         <form id="Form1" runat="server">
                             <asp:HiddenField ID="NewQuantity_" runat="server" />
                             <asp:HiddenField ID="NewPrice_" runat="server" />
             <asp:GridView class="table table-striped table-bordered table-hover" ID="dataTables" runat="server" PageSize="10" 
                  AutoGenerateColumns="false" AllowPaging="true" DataKeyNames="ItemID" OnPaging="dataTables_SelectedIndexChanged"
                 OnRowDataBound="GridView1_RowDataBound"
                  >
                 
            <Columns>
                <asp:BoundField DataField="ItemID" HeaderText="ItemID" ReadOnly="True" 
                    SortExpression="ItemID" />
                <asp:BoundField DataField="BrandName" HeaderText="Brand Name" ReadOnly="True" 
                    SortExpression="BrandName" />
                <asp:BoundField DataField="CategoryName" HeaderText="Category Name" 
                    SortExpression="CategoryName" />
                <asp:BoundField DataField="ItemName" HeaderText="Item Name" 
                    SortExpression="ItemName" />               
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" 
                    SortExpression="Quantity" />
                 <asp:BoundField DataField="Price" HeaderText="Price" 
                    SortExpression="Price" />
                <asp:TemplateField HeaderText="New Quantity">
                 <ItemTemplate>
                     <asp:TextBox ID="NewQuantity" runat="server"></asp:TextBox>
                </ItemTemplate>
                    </asp:TemplateField>
                <asp:TemplateField HeaderText="New Price">
                 <ItemTemplate>
                     <asp:TextBox ID="NewPrice" runat="server"></asp:TextBox>
                </ItemTemplate>
                    </asp:TemplateField>
                <asp:TemplateField HeaderText="Edit">
                 <ItemTemplate>
                <asp:LinkButton ID="lnkEdit" runat="server"   OnClick="Inventory_Click" class="btn btn-outline btn-warning btn-xs InventoryId_">Update</asp:LinkButton>
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
<script src="Content/bootstrap/js/jquery-1.10.2.js"></script>
<script src="Scripts/jquery-1.7.1.js"></script>

<script>
    $(document).ready(function () {
        $("#ContentPlaceHolder1_NewQuantity_").hide();
        $("#ContentPlaceHolder1_NewPrice_").hide();
        $(".InventoryId_").click(function () {
            var existquantity = $(this).closest("tr").find("td").eq(4).text();
            var existprice = $(this).closest("tr").find("td").eq(5).text();
            var newQuantity = $(this).closest("tr").find("td").eq(6).children().val();
            var newPrice = $(this).closest("tr").find("td").eq(7).children().val();
            var Items = $(this).closest("tr").find("td").eq(8).text();

            if (Items != '') {
                $(this).closest("tr").find("td").eq(4).text(parseInt(existquantity) + parseInt(newQuantity));
                $(this).closest("tr").find("td").eq(5).text(parseInt(existprice) + parseInt(newPrice));
                $(this).closest("tr").find("td").eq(6).children().val(0);
                $(this).closest("tr").find("td").eq(7).children().val(0);
                $("#ContentPlaceHolder1_NewQuantity_").val(parseInt(existquantity) + parseInt(newQuantity));
                $("#ContentPlaceHolder1_NewPrice_").val(parseInt(existprice) + parseInt(newPrice));
               
            }
        });

    });
</script>


<script src="Content/bootstrap/js/jquery-1.10.2.js"></script>
</asp:content>
