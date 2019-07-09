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
    <asp:GridView ID="GridViewDocumentos" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" ShowHeaderWhenEmpty="True" DataKeyNames="idDocumento" OnSelectedIndexChanged="GridViewDocumentos_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ShowEditButton="True" ShowSelectButton="True" />
            <asp:BoundField DataField="documento" HeaderText="documento" SortExpression="documento" />
        </Columns>
    </asp:GridView>
    <input type="Button" value="Excluir" OnClick="ExibirExcluir()"> 
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALDocumento" DataObjectTypeName="CPSI.Modelo.Documento" UpdateMethod="Update" DeleteMethod="Delete"></asp:ObjectDataSource>
     <asp:Panel CssClass="PanelExcluir" ID="PanelExcluir" runat="server">
        <span>Confirmar exclusão da disciplina</span>
        <asp:Label ID="LabelDocumento" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="Button4" runat="server" Text="Cancelar" OnClick="Page_Load" />
        <asp:Button ID="Button3" runat="server" Text="Excluir" OnClick="Excluir_Documento" />
    </asp:Panel>
</asp:Content>
