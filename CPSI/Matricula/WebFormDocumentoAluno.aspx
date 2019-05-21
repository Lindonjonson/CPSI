<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Matricula.Master" AutoEventWireup="true" CodeBehind="WebFormDocumentoAluno.aspx.cs" Inherits="CPSI.Matricula.WebFormDocumentoAluno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label>Documentos do Aluno</label>
    <asp:Literal ID="LiteralAluno" runat="server"></asp:Literal>
    <br />
    <label>De CPF</label>
    <asp:Literal ID="LiteralCPF" runat="server"></asp:Literal>
    <asp:GridView ID="GridViewAlunoDocumento" DataKeyNames="idDocumento" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
        <Columns>
            <asp:BoundField DataField="documento" HeaderText="Documento" SortExpression="documento"></asp:BoundField>
            <asp:CheckBoxField DataField="validade" HeaderText="Validade" SortExpression="validade"></asp:CheckBoxField>
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource runat="server" ID="ObjectDataSource1" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALDocumento"></asp:ObjectDataSource>
</asp:Content>
