<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Matricula.Master" AutoEventWireup="true" CodeBehind="WebFormVisualizarMatriculados.aspx.cs" Inherits="CPSI.Matricula.WebFormVisualizarMatriculados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4 class="mt-3 mb-3">
        Alunos Matriculados na turma 
       <i> <asp:Label ID="LabelNomeTurma" runat="server" Text="Label"></asp:Label> </i>
    </h4>   
    <asp:GridView ID="GridViewMatriculados" CssClass="table table-hover" runat="server" DataSourceID="ObjectDataSource1" DataKeyNames="IdAluno,IdTurma" ShowHeaderWhenEmpty="True"></asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALMatricula">
        <SelectParameters>
            <asp:SessionParameter Name="IdTurma" SessionField="IdTurma" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>
