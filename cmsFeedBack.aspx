<%@ Page Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="cmsFeedBack.aspx.cs" Inherits="OnlineShopping.cmsFeedBack" %>

<asp:Content contentplaceholderid="ContentPlaceHolder1" runat="Server" xmlns:asp="#unknown">
    <div id="page-wrapper">
    <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">Customer Feedback List</h1>
            <h5></h5>
        </div>
        <!-- /.col-lg-12 -->
    </div>
    <!-- /.row -->
    <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                  these are the available Feedback at Onlineshopping
                </div>
                <!-- /.panel-heading -->
                <div class="panel-body">
                    <div class="table-responsive">

                         <form id="Form1" runat="server">                             
             <asp:GridView class="table table-striped table-bordered table-hover" ID="dataTables" runat="server" PageSize="10" 
                  AutoGenerateColumns="false" EmptyDataText="No records found" AllowPaging="true">
                 
            <Columns>
                <asp:BoundField DataField="LoginName" HeaderText="Customer Name" ReadOnly="True" 
                    SortExpression="LoginName" />
                <asp:BoundField DataField="CategoryName" HeaderText="Category Name" ReadOnly="True" 
                    SortExpression="CategoryName" />
                <asp:BoundField DataField="BrandName" HeaderText="Brand Name" 
                    SortExpression="BrandName" />
                <asp:BoundField DataField="Feedbackdesc" HeaderText="Feedback desc" 
                    SortExpression="Feedbackdesc" />
                              <asp:BoundField DataField="CreatedDate" HeaderText="Created Date" 
                    SortExpression="CreatedDate" />

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
</asp:Content>
