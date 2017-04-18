<%@ Page Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="cmsItems.aspx.cs" Inherits="OnlineShopping.cmsItems" %>

<asp:Content ID="Content1" contentplaceholderid="ContentPlaceHolder1" runat="Server">
        <script src="Content/bootstrap/js/jquery-1.10.2.js"></script>    
    <script>
        $(document).ready(function () {
            window.onload = function () {
                var grid = document.getElementById('<%= dataTables.ClientID %>');
                    var tbody = grid.getElementsByTagName("tbody")[0];
                    var firstTr = tbody.getElementsByTagName("tr")[0];
                    tbody.removeChild(firstTr);
                    var newTh = document.createElement('thead');
                    newTh.appendChild(firstTr);
                    grid.insertBefore(newTh, tbody);
                }
                $("#ContentPlaceHolder1_dataTables").dataTable();
            });
    </script>
<div id="page-wrapper">
    <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">Items List</h1>
            <h5 class="text-danger"><asp:Label ID="TxtMsg" runat="server"></asp:Label></h5>
        </div>
        <!-- /.col-lg-12 -->
    </div>
    <!-- /.row -->
    <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <a href="cmsItemsCreate.aspx">Create new item</a>
                </div>
                <!-- /.panel-heading -->
                <div class="panel-body">
                    <div class="table-responsive">
                        <form id="Form1" runat="server">
                            
             <asp:GridView class="table table-striped table-bordered table-hover" ID="dataTables" runat="server" PageSize="10" 
                  AutoGenerateColumns="false" AllowPaging="true" DataKeyNames="ItemID" OnPaging="dataTables_SelectedIndexChanged"
                 OnRowDataBound="GridView1_RowDataBound"
                  >
            <Columns>
                <asp:BoundField DataField="ItemID" HeaderText="ItemID" ReadOnly="True" 
                    SortExpression="ItemID" />
                <asp:BoundField DataField="ItemName" HeaderText="Item Name" 
                    SortExpression="BrandName" />
                <asp:BoundField DataField="BrandName" HeaderText="Brand Name" 
                    SortExpression="BrandName" />               
                <asp:BoundField DataField="CategoryName" HeaderText="Category Name" 
                    SortExpression="CategoryName" />
                <asp:TemplateField HeaderText="Edit">
                 <ItemTemplate>
                <asp:LinkButton ID="lnkEdit" runat="server"   OnClick="Edit_Click" class="glyphicon glyphicon-edit"></asp:LinkButton>
                </ItemTemplate>
                  </asp:TemplateField>
                             
                <asp:TemplateField HeaderText="Delete">
                 <ItemTemplate>
                <asp:LinkButton ID="lnkdelete" runat="server"   OnClick="lnkdelete_Click"  class="glyphicon glyphicon-trash" ></asp:LinkButton>
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

</asp:Content>
