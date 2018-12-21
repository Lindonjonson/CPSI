<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Admin.Master" AutoEventWireup="true" CodeBehind="WebFormGerenciarDocumento.aspx.cs" Inherits="CPSI.Admin.Documento.WebFormGerenciarDocumento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <h4> Tipos de Documento </h4>
   <button data-target="ModalCadastrarDocumento" class="btn modal-trigger">Cadastrar Documento</button>
    <asp:GridView ID="GridViewDocumentos" runat="server" CssClass="responsive-table" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" ShowHeaderWhenEmpty="True" DataKeyNames="idDocumento" OnSelectedIndexChanged="GridViewDocumentos_SelectedIndexChanged" EnableViewState="False">
        <Columns>
            <asp:CommandField ShowEditButton="True" ShowSelectButton="True" />
            <asp:BoundField DataField="documento" HeaderText="Documento" SortExpression="documento" />
        </Columns>
    </asp:GridView>
    <button data-target="ModalExcluirDocumento" class="btn modal-trigger red darken-1 styleADM_ButtonExcluir">Excluir Documento</button>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALDocumento" DataObjectTypeName="CPSI.Modelo.Documento" UpdateMethod="Update" DeleteMethod="Delete"></asp:ObjectDataSource>
    <div id="ModalCadastrarDocumento" class="modal">
        <div class="modal-content">
            <asp:label  runat="server" Text="Nome documento:" CssClass="styleADM_labelTitle"></asp:label>
            <asp:textbox runat="server" ID="txtDocumento"></asp:textbox>
            <asp:button runat="server" click="CadastrarDocumento" CssClass="waves-effect waves-light" Text="Cadastrar" OnClick="Inserir_Click" />
            <asp:Button ID="Button1" runat="server" Text="Cancelar" CssClass="btn red darken-1 waves-light " OnClick="Page_Load" />
        </div>
    </div>
    <div class="modal" id="ModalExcluirDocumento">
        <asp:Panel CssClass="modal-content" ID="PanelExcluir" runat="server">
        <span>Confirmar exclusão do documento</span>
        <asp:Label ID="LabelDocumento" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="Button4" runat="server" Text="Cancelar" CssClass="btn btn green darken-1" OnClick="Page_Load" />
        <asp:Button ID="Button3" runat="server" Text="Excluir" class="btn red darken-1" OnClick="Excluir_Documento" />
    </asp:Panel>
    </div>
     
</asp:Content>
