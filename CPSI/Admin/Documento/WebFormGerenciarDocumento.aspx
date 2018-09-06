<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Admin.Master" AutoEventWireup="true" CodeBehind="WebFormGerenciarDocumento.aspx.cs" Inherits="CPSI.Admin.Documento.WebFormGerenciarDocumento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:label runat="server" Text="Codigo"></asp:label>
    <asp:textbox runat="server" ID="txtIdDocumento"></asp:textbox>
    <asp:label runat="server" Text="Nome documento"></asp:label>
    <asp:textbox runat="server" ID="txtDocumento"></asp:textbox>
    <asp:button runat="server" click="CadastrarDocumento" Text="Cadastrar" OnClick="Inserir_Click" />
    <asp:GridView ID="GridViewDocumentos" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" OnRowCommand="GridViewDocumentos_RowCommand">
        <Columns>
            <asp:BoundField DataField="idDocumento" HeaderText="idDocumento" SortExpression="idDocumento" />
            <asp:BoundField DataField="documento" HeaderText="documento" SortExpression="documento" />
            <asp:ButtonField ButtonType="Button" CommandName="Excluir" HeaderText="Excluir" Text="Excluir" />
            <asp:ButtonField ButtonType="Button" CommandName="Editar" HeaderText="Editar" Text="Editar" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectALL" TypeName="CPSI.DAL.DALDocumento"></asp:ObjectDataSource>
</asp:Content>
