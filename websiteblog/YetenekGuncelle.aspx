﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="YetenekGuncelle.aspx.cs" Inherits="YetenekGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
      <form id="Form2" runat="server">

        <div class="form-group">
            <div>
                <asp:Label ID="Label2" runat="server" Text="ID"></asp:Label>
                <asp:TextBox ID="Txtid" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br/>
           
             <div>
                <asp:Label ID="Label1" runat="server" Text="YETENEK"></asp:Label>
                <asp:TextBox ID="Txtyetenek" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br/>
           

            <asp:Button ID="Button2" runat="server" Text="GÜNCELLE" CssClass="btn btn-primary" OnClick="Button2_Click"    />


        </div>
    </form>
</asp:Content>

