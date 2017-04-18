﻿<%@ Page Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="cmsDateWiseOrders.aspx.cs" Inherits="OnlineShopping.cmsDateWiseOrders" %>


<asp:Content contentplaceholderid="ContentPlaceHolder1" runat="Server" >

<div id="page-wrapper">
    <div class="row">
        <div class="col-lg-6">
            <h1 class="page-header">View all Date Wise Orders</h1>
            <p>@ViewBag.sucMsg</p>
        </div>
        <!-- /.col-lg-12 -->
    </div>
    <!-- /.row -->
    <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    These are the available Date Wise Orders at eBuy
                </div>
                <!-- /.panel-heading -->

                <div class="panel-body">
                    <div class="table-responsive">
                        <table class="table table-striped table-bordered table-hover" id="dataTables-example">
                            <thead>
                                <tr>
                                    <th>Costomer</th>
                                    <th>Order Date</th>
                                    <th>Total Amount</th>
                                    <th>Status</th>
                                </tr>
                            </thead>
                            <tbody>
                                @{
                                    string _class = string.Empty;
                                    int _cout = 0;
                                    if (Model != null)
                                    {
                                        foreach (var item in Model)
                                        {
                                            if (_cout == 0)
                                            {
                                                _cout = 1;
                                                _class = "odd gradeA";
                                            }
                                            if (_cout == 1)
                                            {
                                                _cout = 0;
                                                _class = "even gradeA";
                                            }
                                            var Username = DB.Logindetails.Where(x => x.Loginid == item.LoginID).Select(x => new { x.Firstname, x.Lastname }).FirstOrDefault();
                                            var Fullname = Username.Firstname + "  " + Username.Lastname; 
                                    <tr class="@_class">

                                        <td><a href="#" class="btn btn-outline btn-warning btn-xs">@Fullname</a></td>
                                        <td>@item.OrderDate.Value.ToShortDateString()</td>
                                        <td>@item.TotalAmount</td>
                                        @if (item.IsActive == true)
                                        {
                                            <td><a href="#" class="btn btn-outline btn-success btn-xs">Active</a></td>}
                                        else
                                        {<td><a href="#" class="btn btn-outline btn-warning btn-xs">Status</a></td>}
                                    </tr>
                                        }
                                    }}
                            </tbody>
                        </table>
                    </div>
                    <!-- /.table-responsive -->
                </div>
                <!-- /.panel-body -->
            </div>
            <!-- /.panel -->
        </div>
        <!-- /.col-lg-12 -->
    </div>
    <!-- /.row -->
</div>
<script src="@Url.Content("~/Content/bootstrap/js/jquery-1.10.2.js")"></script>
<script  src="@Url.Content("~/scripts/general.js")"></script>
<script  src="@Url.Content("~/scripts/ts_picker.js")"></script>
</asp:Content>
