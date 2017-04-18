<%@ Page Language="C#" MasterPageFile="~/Customer.Master" AutoEventWireup="true" CodeBehind="CardDetails.aspx.cs" Inherits="OnlineShopping.CardDetails" %>

<asp:content contentplaceholderid="ContentPlaceHolder1" runat="Server">   
      <script type="text/javascript" >

        function ccdetails() {
            var name = document.getElementById("CName").value;
            var number = document.getElementById("CcNumber").value;
            var cv = document.getElementById("Cvv").value;
            var street = document.getElementById("Street").value;
            var city = document.getElementById("CityID").value;
            var state = document.getElementById("StateID").value;
            var country = document.getElementById("CountryID").value;
            var zip = document.getElementById("Zipcode").value;
            var regex = "/^[A-Za-z]+$/";

            var msg = "";

            var error = false;


            if (name == '') {

                error = true;
                msg += "Please Enter CreditCard holder Nmae \n";



            }
            if (name != '') {
                if (!name.match(regex)) {
                    error = true;

                    msg += ("Name must contain only alphabets \n");


                }

            }

            if (number == '') {
                // document.getElementById("CcNumber").focus();
                error = true;
                msg += "Please Enter CreditCard  number \n";



            }

            if (cv == '') {
                // document.getElementById(" Cvv").focus();
                error = true;
                msg += ("Please Enter CVV \n");



            }

            if (street == '') {
                // document.getElementById(" Cvv").focus();
                error = true;
                msg += ("Please Enter Street \n");



            }
            if (city == '') {
                // document.getElementById(" Cvv").focus();
                error = true;
                msg += ("Please Enter city \n");



            }
            if (state == '') {
                // document.getElementById(" Cvv").focus();
                error = true;
                msg += ("Please Enter state \n");



            }
            if (country == '') {
                // document.getElementById(" Cvv").focus();
                error = true;
                msg += ("Please Enter country \n");



            }

            if (zip == '') {
                // document.getElementById(" Cvv").focus();
                error = true;
                msg += ("Please Enter zip \n");



            }



            if (error) {
                alert("Please enter all the necessary details!! \n" + msg);
                return false;
            }

            return true;
        }







    </script>

    <div id="page-wrapper">
    <div class="row">
        <div class="col-lg-4">
            
          <h4>  Total Amount: </h4> 
            
                    <asp:Label runat="server" ID="lblamount">

                    </asp:Label>
          
            <h3>Credit Card Details</h3>
            <h5><asp:Label CssClass="text-danger" ID="TxtMsg" runat="server"></asp:Label></h5>
           <form id="Form1" method="post" runat="server"> 
                
                <div class="form-group">
                    <label>Credit Card Type</label>

                    <asp:DropDownList class="form-control" ID="CardType" runat="server">
                        <asp:ListItem Value="">--Select--</asp:ListItem>                          
                        <asp:ListItem value="VISA">VISA</asp:ListItem>
                        <asp:ListItem value="MASTER">MASTER</asp:ListItem>
                        <asp:ListItem value="AmEx">AmEx</asp:ListItem>
                        <asp:ListItem value="DISCOVER">DISCOVER</asp:ListItem>
                    </asp:DropDownList>                    
                </div>

                <div class="form-group" >
                    <asp:TextBox runat="server" class="form-control" placeholder="Credit Card Number" type="text" ID="CcNumber"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:TextBox runat="server" class="form-control" placeholder="Name on Card" type="text" ID="CName"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:TextBox runat="server" class="form-control" placeholder="Card Expiration, MM/YY" type="text" ID="Exp"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:TextBox runat="server" class="form-control" placeholder="CVV Numver" type="text" ID="Cvv"></asp:TextBox>
                </div>
                <label>Billing Address</label>
                <div class="form-group">
                    <asp:TextBox runat="server" class="form-control" placeholder="Street Address and Apt Number" type="text" ID="Street"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:TextBox runat="server" class="form-control" placeholder="City" type="text" ID="CityID"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:TextBox runat="server" class="form-control" placeholder="State" type="text" ID="StateID"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:TextBox runat="server" class="form-control" placeholder="Country" type="text" ID="CountryID"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:TextBox runat="server" class="form-control" placeholder="Zipcode" type="text" ID="Zipcode"></asp:TextBox>
                </div>
               <asp:HiddenField runat="server"  ID="OrderQuantity" ></asp:HiddenField>
                <asp:HiddenField runat="server"  ID="OrderItemId" ></asp:HiddenField>

                <div class="form-group">
                    <asp:Button ID="ConfirmOrder" runat="server" Text="Confirm Order" class="btn btn-success" OnClientClick="return ccdetails(); " OnClick="ConfirmOrder_Click"></asp:Button>
                    <a href="Home.aspx" class="btn btn-default">Cancel Order</a>
                </div>

            </form>
        </div>
    </div>
</div>
<script src="Scripts/jquery-1.7.1.js"></script>
    <script src="Scripts/jquery-form-validation-V.1.js"></script>
    <script src="Scripts/jquery.validate.js"></script>
    
<%--<script src="@Url.Content("~/Scripts/jquery.validate.js")"></script>
<script src="@Url.Content("~/Scripts/jquery-form-validation-V.1.js")"></script>

<script src="@Url.Content("~/scripts/general.js")"></script>
<script src="@Url.Content("~/scripts/ts_picker.js")"></script>--%>
    </asp:content>
