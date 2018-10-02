<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Admin.Master" AutoEventWireup="true" CodeBehind="WebFormGerenciarAluno.aspx.cs" Inherits="CPSI.Matricula.WebFormGerenciarAluno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<label>Alunos</label>
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" DataKeyNames="IdAluno" OnRowCommand="GridView1_RowCommand">
    <Columns>
        <asp:BoundField DataField="AlunoNome" HeaderText="AlunoNome" SortExpression="AlunoNome" />
        <asp:BoundField DataField="DataNascimento" HeaderText="DataNascimento" SortExpression="DataNascimento" />
        <asp:BoundField DataField="Cpf" HeaderText="Cpf" SortExpression="Cpf" />
        <asp:BoundField DataField="Rg" HeaderText="Rg" SortExpression="Rg" />
        <asp:BoundField DataField="RGOrgao" HeaderText="RGOrgao" SortExpression="RGOrgao" />
        <asp:BoundField DataField="EstadoCivil" HeaderText="EstadoCivil" SortExpression="EstadoCivil" />
        <asp:BoundField DataField="Naturalidade" HeaderText="Naturalidade" SortExpression="Naturalidade" />
        <asp:BoundField DataField="NaturalidadeEstado" HeaderText="NaturalidadeEstado" SortExpression="NaturalidadeEstado" />
        <asp:BoundField DataField="Endereco" HeaderText="Endereco" SortExpression="Endereco" />
        <asp:BoundField DataField="Cidade" HeaderText="Cidade" SortExpression="Cidade" />
        <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado" />
        <asp:BoundField DataField="Telefone1" HeaderText="Telefone1" SortExpression="Telefone1" />
        <asp:BoundField DataField="Telefone2" HeaderText="Telefone2" SortExpression="Telefone2" />
        <asp:BoundField DataField="Contato" HeaderText="Contato" SortExpression="Contato" />
        <asp:BoundField DataField="ContatoTelefone" HeaderText="ContatoTelefone" SortExpression="ContatoTelefone" />
        <asp:ButtonField ButtonType="Button" CommandName="Excluir" Text="Excluir" />
        <asp:ButtonField ButtonType="Button" CommandName="Editar" Text="Editar" />
    </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectALL" TypeName="CPSI.DAL.DALAluno"></asp:ObjectDataSource>
</asp:Content>
