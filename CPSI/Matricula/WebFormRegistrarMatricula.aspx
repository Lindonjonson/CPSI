<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Matricula.Master" AutoEventWireup="true" CodeBehind="WebFormRegistrarMatricula.aspx.cs" Inherits="CPSI.Matricula.WebFormRegistrarMatricula" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Matricula em <asp:Label ID="IDTituloDisciplina" runat="server"></asp:Label></h1>
    <asp:DetailsView ID="DetailsViewAluno" runat="server" Height="50px" Width="125px" DataSourceID="ObjectDataSource1" AutoGenerateRows="False" DataKeyNames="IdAluno">
        <Fields>
            <asp:BoundField DataField="IdAluno" HeaderText="IdAluno" SortExpression="IdAluno" />
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
        </Fields>
    </asp:DetailsView> 
   <strong> Documentos necessários </strong>
    <asp:CheckBoxList ID="CheckBoxListDocumento" runat="server" DataSourceID="ObjectDataSource2" DataTextField="documento" DataValueField="idDocumento"></asp:CheckBoxList>
    <asp:Button ID="Button" runat="server" Text="Matricular" OnClick="Click_Matricular" />
    <asp:ObjectDataSource runat="server" ID="ObjectDataSource2" SelectMethod="SelectALL" TypeName="CPSI.DAL.DALDocumentoDisciplina">
        <SelectParameters>
            <asp:SessionParameter DefaultValue="" Name="IdDisciplina" SessionField="IdDisciplina" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:ObjectDataSource runat="server" ID="ObjectDataSource1" SelectMethod="Select" TypeName="CPSI.DAL.DALAluno">
        <SelectParameters>
            <asp:SessionParameter SessionField="IdAluno" Name="id" Type="String"></asp:SessionParameter>
        </SelectParameters>
    </asp:ObjectDataSource>
    
</asp:Content>
