<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Matricula.Master" AutoEventWireup="true" CodeBehind="WebFormVisualizarMatriculados.aspx.cs" Inherits="CPSI.Matricula.WebFormVizualizarMatriculados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="LabelNomeTurma" runat="server" Text="Label"></asp:Label>
     <br />
    <asp:Button ID="Button1" runat="server" Text="Matricular" OnClick="Matricular" />
    <asp:GridView ID="GridViewMatriculados" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" OnRowCommand="RowCommand" DataKeyNames="IdAluno" ShowHeaderWhenEmpty="True">
        <Columns>
            <asp:BoundField DataField="Situacao" HeaderText="Situacao" SortExpression="Situacao" />
            <asp:BoundField DataField="DataMatricula" HeaderText="DataMatricula" SortExpression="DataMatricula" />
            <asp:BoundField DataField="AlunoNome" HeaderText="AlunoNome" SortExpression="AlunoNome" />
            <asp:BoundField DataField="Cpf" HeaderText="Cpf" SortExpression="Cpf" />
            <asp:ButtonField CommandName="RemoverAluno" Text="Remover Aluno" ButtonType="Button" HeaderText="Remover aluno"></asp:ButtonField>
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALMatricula">
        <SelectParameters>
            <asp:SessionParameter Name="IdTurma" SessionField="IdTurma" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>
