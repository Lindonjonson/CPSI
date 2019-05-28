<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Matricula.Master" AutoEventWireup="true" CodeBehind="WebFormDocumentoAluno.aspx.cs" Inherits="CPSI.Matricula.WebFormDocumentoAluno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label>Documentos do Aluno</label>
    <asp:Literal ID="LiteralAluno" runat="server"></asp:Literal>
    <br />
    <label>De CPF</label>
    <asp:Literal ID="LiteralCPF" runat="server"></asp:Literal>
     <h3>Documentos entregues no cadastro</h3>
    <asp:GridView ID="GridViewDocumentosCadastro"  ShowHeaderWhenEmpty="true" OnLoad="GridViewDocumentosCadastro_Load"  CssClass="table table-hover" DataKeyNames="idDocumento" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
        <Columns>
            <asp:BoundField DataField="documento" HeaderText="Documento" SortExpression="documento"></asp:BoundField>
            <asp:CheckBoxField DataField="validade" HeaderText="Validade" SortExpression="validade"></asp:CheckBoxField>
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource runat="server" ID="ObjectDataSource1" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALDocumento">
        <SelectParameters>
            <asp:Parameter DefaultValue="1" Name="filtroTipo" Type="String"></asp:Parameter>
        </SelectParameters>
    </asp:ObjectDataSource>
    <h3>Documentos entregues na matrícula</h3>
    <asp:GridView ID="GridViewDocumentosMatricula" ShowHeaderWhenEmpty="true"  OnLoad="GridViewDocumentosMatricula_Load" CssClass="table table-hover" DataKeyNames="idDocumento" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2">
        <Columns>
            <asp:BoundField DataField="documento" HeaderText="documento" SortExpression="documento"></asp:BoundField>
            <asp:CheckBoxField DataField="validade" HeaderText="Validade" SortExpression="validade"></asp:CheckBoxField>
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource runat="server" ID="ObjectDataSource2" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALDocumento">
        <SelectParameters>
            <asp:Parameter DefaultValue="2" Name="filtroTipo" Type="String"></asp:Parameter>
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>
