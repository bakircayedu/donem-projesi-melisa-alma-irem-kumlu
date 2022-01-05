﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminEgitimler.aspx.cs" Inherits="AdminEgitimler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

     <form id="Form1" runat="server">
    <table class="table table-bordered">

        <tr>
            <th>ID </th>
             <th>BAŞLIK </th>
             <th>ALTBAŞLIK </th>
             <th>AÇIKLAMA </th>
             <th>TARİH</th>
            <th>İŞLEMLER</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>

                    <tr>
                        <th> <%#Eval("ID") %>         </th>
                        <th>  <%#Eval("BASLIK") %>   </th>
                          <td>   <%#Eval("ALTBASLIK") %>    </td>
                          <td>   <%#Eval("ACIKLAMA") %>   </td>
                          <td>  <%#Eval("TARIH_id") %>    </td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%#  "AdminEgitimSil.Aspx?ID=" + Eval("ID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%# "AdminEgitimGuncelle.Aspx?ID=" + Eval("ID") %>'    ID="HyperLink2" runat="server" CssClass="btn btn-warning">Güncelle</asp:HyperLink>
                        </td>
                    

                    </tr>
       </ItemTemplate>
         </asp:Repeater>   
        </tbody>

    </table>
        <asp:HyperLink NavigateUrl="~/AdminEgitimEkle.aspx" ID="HyperLink3" runat="server" CssClass="btn btn-info">EĞİTİM EKLE</asp:HyperLink>

        </form>



</asp:Content>
