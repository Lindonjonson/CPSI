<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Matricula.Master" AutoEventWireup="true" CodeBehind="WebFormEditarAluno.aspx.cs" Inherits="CPSI.Matricula.WebFormEditarAluno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" AutoGenerateRows="False" DataSourceID="ObjectDataSource1">
        <Fields>
            <asp:BoundField DataField="IdAluno" HeaderText="IdAluno" SortExpression="IdAluno" ReadOnly="true" />
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
            <asp:CommandField ShowEditButton="True" />
        </Fields>
    </asp:DetailsView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="CPSI.Modelo.Aluno"  SelectMethod="Select" TypeName="CPSI.DAL.DALAluno" UpdateMethod="Update">
        <SelectParameters>
            <asp:SessionParameter Name="id" SessionField="IdAluno" Type="String" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="DataNascimento" Type="DateTime" />
        </UpdateParameters>
    </asp:ObjectDataSource>
</asp:Content>
