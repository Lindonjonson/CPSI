<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Admin.Master" AutoEventWireup="true" CodeBehind="WebFormEditarDocumento.aspx.cs" Inherits="CPSI.Admin.Documento.WebFormEditarDocumento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DetailsView ID="DetailsViewDocumento" runat="server" DataSourceID="ObjectDataSource1" AutoGenerateRows="False"  DataKeyNames="idDocumento">
    <Fields>
        
        <asp:BoundField DataField="documento" HeaderText="documento" SortExpression="documento" />
        <asp:TemplateField ShowHeader="False">
            <EditItemTemplate>
                <asp:Button ID="Button1" runat="server" CausesValidation="True" CommandName="Update" Text="Atualizar" />
                &nbsp;<asp:Button ID="Button2" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Button ID="Button1" runat="server" CausesValidation="False" CommandName="Edit" Text="Editar" />
                <input id="Button"  OnClick="ExibirExcluir()" type="button" value="Excluir" />
            </ItemTemplate>
        </asp:TemplateField>
    </Fields>
    </asp:DetailsView>
    
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="CPSI.Modelo.Documento" SelectMethod="Select" TypeName="CPSI.DAL.DALDocumento" UpdateMethod="Update">
        <SelectParameters>
            <asp:SessionParameter SessionField="IdDocumento" Name="ID" Type="String"></asp:SessionParameter>

        </SelectParameters>
    </asp:ObjectDataSource>
     <asp:Panel CssClass="PanelExcluir" ID="PanelExcluir" runat="server">
        <span>Confirmar exclusão de documento</span>
        <asp:Label ID="LabelDocumento" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="Button4" runat="server" Text="Cancelar" OnClick="Page_Load" />
        <asp:Button ID="Button3" runat="server" Text="Excluir" OnClick="Excluir_Click" />
    </asp:Panel>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Admin/WebFormGerenciarDocumento.aspx">Voltar</asp:HyperLink>
    <br />
    
</asp:Content>

