<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Admin.Master" AutoEventWireup="true" CodeBehind="WebFormEditarDocumentosDisciplina.aspx.cs" Inherits="CPSI.Admin.WebFormEditarDocumentosDisciplina" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Documentos cadastrados na disciplina"></asp:Label>
    <asp:CheckBoxList ID="CheckBoxList1" runat="server" DataSourceID="ObjectDataSource2" DataTextField="documento" DataValueField="idDocumento"></asp:CheckBoxList>
    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="SelectALL" TypeName="CPSI.DAL.DALDocumentoDisciplina">
        <SelectParameters>
            <asp:SessionParameter Name="IdDisciplina" SessionField="IdDisciplina" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:Label ID="Label2" runat="server" Text="Novos documentos"></asp:Label>
    <asp:CheckBoxList ID="CheckBoxListDocumento" runat="server" DataSourceID="ObjectDataSource1" DataTextField="documento" DataValueField="idDocumento"></asp:CheckBoxList> >
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALDocumento"></asp:ObjectDataSource>
     <input id="Button"  OnClick="ExibirExcluir()" type="button" value="Alterar" />
    <asp:Panel CssClass="PanelExcluir" ID="PanelExcluir" runat="server">
        <span>Confirmar alteração dos documentos da disciplina</span>
        <asp:Label ID="LabelDisciplina" runat="server" Text="Label"></asp:Label>
        <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Admin/WebFormGerenciarDisciplina.aspx" runat="server">Cancelar</asp:HyperLink>
        <asp:Button ID="Button3" runat="server" Text="Editar" OnClick="Editar_Documentos" />
 
    </asp:Panel>
    
</asp:Content> 

