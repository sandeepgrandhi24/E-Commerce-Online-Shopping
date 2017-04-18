﻿<%@ Page Language="C#" MasterPageFile="~/Customer.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="OnlineShopping.ChangePassword" %>

<asp:Content contentplaceholderid="ContentPlaceHolder1" runat="Server" xmlns:asp="#unknown">  

    <div id="page-wrapper">
    <div class="row">
        <div class="col-lg-6">
            <h1>Change Password</h1>
            <span class="style5">@ViewBag.sucMsg</span>

            @using (Html.BeginForm("addnewpassword", "ChangePassword", FormMethod.Post, new { role = "form" }))
            {
                <div class="form-group">
                    <label>User Name</label>
                    <input class="form-control" type="text" name="username" placeholder="Login name is reuired" />
                </div>
                <div class="form-group">
                    <label>Old Password</label>
                    <input class="form-control" type="password" name="oldpassword" placeholder="Password is required" />
                </div>
                <div class="form-group">
                    <label>New Password</label>
                    <input class="form-control" type="password" name="newpassword" placeholder="Password is required" />
                </div>
                <input type="submit" name="Submit" value="Change" class="btn btn-success" />
                <input type="reset" name="Submit2" value="Reset" class="btn ntn-primary" />
            }
        </div>
    </div>
</div>

    </asp:Content>