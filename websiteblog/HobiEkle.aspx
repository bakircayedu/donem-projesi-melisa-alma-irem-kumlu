<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="HobiEkle.aspx.cs" Inherits="HobiEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
     <form id="Form2" runat="server">

        <div class="form-group">
             <div>
                <asp:Label ID="Label5" runat="server" Text="HOBİ"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br/>
           

            <asp:Button ID="Button2" runat="server" Text="KAYDET" CssClass="btn btn-primary" OnClick="Button2_Click"    />


        </div>
    </form>
</asp:Content>

