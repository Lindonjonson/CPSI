<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Admin.Master" AutoEventWireup="true" CodeBehind="WebFormEditarDocumentosDisciplina.aspx.cs" Inherits="CPSI.Admin.WebFormEditarDocumentosDisciplina" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Edição de documentos </h3>
    <asp:Label ID="Label1" runat="server" Text="Documentos cadastrados na disciplina"></asp:Label>
    <asp:Label ID="LabelDisciplina" runat="server" Text="Label"></asp:Label>
    <h4>Novos documentos</h4>
    <asp:GridView ID="GridViewDocumentos" CssClass="highlight" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" DataKeyNames="idDocumento" ShowHeaderWhenEmpty="true">
        <Columns>
            <asp:BoundField DataField="documento" HeaderText="Documento" SortExpression="documento"></asp:BoundField>
        </Columns>
    </asp:GridView>
    <input id="Button"  OnClick="ExibirExcluir()" type="button" value="Alterar" />
    <asp:Panel CssClass="PanelExcluir" ID="PanelExcluir" runat="server">
        <span>Confirmar alteração dos documentos da disciplina</span>
        <asp:Button ID="Button_Cancelar" Onclick="Cancelar_click" runat="server" Text="Cancelar" />
        <asp:Button ID="Button3" runat="server" Text="Editar" OnClick="Editar_Documentos" />
    </asp:Panel>
    <asp:ObjectDataSource runat="server" ID="ObjectDataSource1" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALDocumento" ></asp:ObjectDataSource>
</asp:Content> 

