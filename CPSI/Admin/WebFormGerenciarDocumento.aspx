<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Admin.Master" AutoEventWireup="true" CodeBehind="WebFormGerenciarDocumento.aspx.cs" Inherits="CPSI.Admin.Documento.WebFormGerenciarDocumento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Tipos de Documento
    <hr />
    <br />
    <br />
    <asp:label runat="server" Text="Nome documento"></asp:label>
    <asp:textbox runat="server" ID="txtDocumento"></asp:textbox>
    <br />
    <asp:button runat="server" click="CadastrarDocumento" Text="Cadastrar" OnClick="Inserir_Click" />
    <br />
    <hr />
    <br />
    <asp:GridView ID="GridViewDocumentos" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" OnRowCommand="GridViewDocumentos_RowCommand" ShowHeaderWhenEmpty="True">
        <Columns>
            <asp:BoundField DataField="idDocumento" HeaderText="Código" SortExpression="idDocumento" />
            <asp:BoundField DataField="documento" HeaderText="Tipos de Documento" SortExpression="documento" />
            <asp:ButtonField ButtonType="Button" CommandName="Excluir" HeaderText="Excluir" Text="Excluir" />
            <asp:ButtonField ButtonType="Button" CommandName="Editar" HeaderText="Editar" Text="Editar" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectALL" TypeName="CPSI.DAL.DALDocumento"></asp:ObjectDataSource>
</asp:Content>
