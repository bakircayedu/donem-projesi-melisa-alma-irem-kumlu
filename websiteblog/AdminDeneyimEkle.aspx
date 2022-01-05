<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminDeneyimEkle.aspx.cs" Inherits="AdminDeneyimEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">


 <form id="Form2" runat="server">

        <div class="form-group">
             <div>
                <asp:Label ID="Label5" runat="server" Text="BAŞLIK"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br/>
            <div>
                <asp:Label ID="Label6" runat="server" Text="ALTBAŞLIK"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br/>
            <div>
                <asp:Label ID="Label7" runat="server" Text="AÇIKLAMA"></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" Height="100px"></asp:TextBox>

            </div>
            
            <div>
                <asp:Label ID="Label8" runat="server" Text="TARİH"></asp:Label>

            </div>
            
             <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource2" DataTextField="Tarih" DataValueField="Tarihid">
             </asp:DropDownList>
             <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ProjeBaglantisi %>" SelectCommand="SELECT [Tarihid], [Tarih] FROM [Tarih]"></asp:SqlDataSource>
             <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:websiteblogDBConnectionString2 %>" SelectCommand="SELECT [Tarih] FROM [Tarih]"></asp:SqlDataSource>
            
            <br />
            <asp:Button ID="Button2" runat="server" Text="KAYDET" CssClass="btn btn-primary" OnClick="Button2_Click"  />


        </div>
    </form>
    </asp:Content>