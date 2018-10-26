<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Matricula.Master" AutoEventWireup="true" CodeBehind="WebFormVisualizarListaEspera.aspx.cs" Inherits="CPSI.Matricula.WebFormVisualizarListaEspera" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" ShowHeaderWhenEmpty="true" DataSourceID="ObjectDataSource1"></asp:GridView>
    <asp:ObjectDataSource runat="server" ID="ObjectDataSource1" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALListaEspera">
        <SelectParameters>
            <asp:SessionParameter SessionField="IdTurma" Name="IdTurma" Type="String"></asp:SessionParameter>
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>
