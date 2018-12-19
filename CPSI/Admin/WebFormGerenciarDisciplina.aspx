<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Admin.Master" AutoEventWireup="true" CodeBehind="WebFormGerenciarDisciplina.aspx.cs" Inherits="CPSI.Admin.Disciplina.WebFormGerenciarCategoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label>Nome disciplina</label>
    <asp:TextBox runat="server" ID="TxtNomeDisciplina" PlaceHolder="nome disciplina"></asp:TextBox>
    <label>Documentos obrigatorios para a disciplina</label>
    <asp:CheckBoxList ID="CheckBoxListDocumento" runat="server" DataSourceID="ObjectDataSource2" DataTextField="documento" DataValueField="idDocumento"></asp:CheckBoxList>
    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALDocumento"></asp:ObjectDataSource>
    <asp:Button runat="server" Text="Inserir" OnClick="Inserir_Click"> </asp:Button>
    <asp:GridView ID="GridViewDisciplina" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" OnRowCommand="GridView1_RowCommand"  ShowHeaderWhenEmpty="True" DataKeyNames="idDisciplina" OnSelectedIndexChanged="GridViewDisciplina_SelectedIndexChanged" EnableViewState="False" >
        <Columns>
            <asp:CommandField ShowEditButton="True" ShowSelectButton="True" />
            <asp:BoundField DataField="disciplina" HeaderText="disciplina" SortExpression="disciplina" />
            <asp:ButtonField ButtonType="Button" CommandName="EditarDocumento" HeaderText="Documentos" ShowHeader="True" Text="Editar Documentos" />
        </Columns>
    </asp:GridView>
     <input  type="button" value="Excluir" OnClick="ExibirExcluir()" />
    <asp:Panel CssClass="PanelExcluir" ID="PanelExcluir" runat="server">
        <span>Confirmar exclusão da disciplina</span>
        <asp:Label ID="LabelDisciplina" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="Button4" runat="server" Text="Cancelar" OnClick="Page_Load" />
        <asp:Button ID="Button3" runat="server" Text="Excluir" OnClick="Excluir_Disciplina" />
    </asp:Panel>
   
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALDisciplina" DataObjectTypeName="CPSI.Modelo.Disciplina" InsertMethod="Insert" UpdateMethod="Update"></asp:ObjectDataSource>
   
</asp:Content>
 