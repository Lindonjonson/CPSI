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
    <asp:GridView ID="GridViewDisciplina" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" OnRowCommand="GridView1_RowCommand" EnableViewState="False" ShowHeaderWhenEmpty="True" DataKeyNames="idDisciplina">
        <Columns>
            <asp:BoundField DataField="disciplina" HeaderText="disciplina" SortExpression="disciplina" />
            <asp:ButtonField ButtonType="Button" CommandName="Editar" HeaderText="Editar" Text="Editar" />
        </Columns>
    </asp:GridView>
    
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALDisciplina" DataObjectTypeName="CPSI.Modelo.Disciplina" InsertMethod="Insert"></asp:ObjectDataSource>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Insira o nome da disciplina" ControlToValidate="TxtNomeDisciplina"></asp:RequiredFieldValidator>
 
</asp:Content>
 