<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Admin.Master" AutoEventWireup="true" CodeBehind="WebFormGerenciarDisciplina.aspx.cs" Inherits="CPSI.Admin.Disciplina.WebFormGerenciarCategoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label>Nome disciplina</label>
    <asp:TextBox runat="server" ID="TxtNomeDisciplina" PlaceHolder="nome disciplina"></asp:TextBox>
    <asp:CheckBoxList ID="CheckBoxListDocumento" runat="server" DataSourceID="ObjectDataSource2" DataTextField="documento" DataValueField="idDocumento"></asp:CheckBoxList>
    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALDocumento"></asp:ObjectDataSource>
    <asp:Button runat="server" Text="Inserir" OnClick="Inserir_Click"> </asp:Button>
    <asp:GridView ID="GridViewDisciplina" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" OnRowCommand="GridView1_RowCommand" EnableViewState="False" ShowHeaderWhenEmpty="True" DataKeyNames="IdDisciplina">
        <Columns>
            <asp:BoundField DataField="disciplina" HeaderText="Disciplina" SortExpression="disciplina" />
            <asp:ButtonField ButtonType="Button"  CommandName="Editar" HeaderText="Editar" Text="Editar" />
            <asp:ButtonField  ButtonType="Button" CommandName="Excluir"  HeaderText="Excluir" Text="Excluir" />
        </Columns>
    </asp:GridView>
    
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALDisciplina"></asp:ObjectDataSource>
</asp:Content>
