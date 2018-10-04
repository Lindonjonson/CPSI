<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Matricula.Master" AutoEventWireup="true" CodeBehind="WebFormVizualizarMatriculados.aspx.cs" Inherits="CPSI.Matricula.WebFormVizualizarMatriculados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
        <Columns>
            <asp:BoundField DataField="Situacao" HeaderText="Situacao" SortExpression="Situacao" />
            <asp:BoundField DataField="DataMatricula" HeaderText="DataMatricula" SortExpression="DataMatricula" />
            <asp:BoundField DataField="AlunoNome" HeaderText="AlunoNome" SortExpression="AlunoNome" />
            <asp:BoundField DataField="Cpf" HeaderText="Cpf" SortExpression="Cpf" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALMatricula">
        <SelectParameters>
            <asp:SessionParameter Name="IdTurma" SessionField="IdTurma" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>
