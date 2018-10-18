<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Matricula.Master" AutoEventWireup="true" CodeBehind="WebFormVisualizarMatriculados.aspx.cs" Inherits="CPSI.Matricula.WebFormVizualizarMatriculados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="LabelNomeTurma" runat="server" Text="Label"></asp:Label>
     <br />
    <asp:Button ID="Button1" runat="server" Text="Matricular" OnClick="Matricular" />
    <asp:GridView  ID="GridViewMatriculados" ShowHeaderWhenEmpty="true" OnRowCommand="RowCommand" runat="server" Datakeynames="IdAluno" DataSourceID="ObjectDataSource1">
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="RemoverAluno" HeaderText="Remover Aluno" Text="Remover Aluno" />
            <asp:ButtonField ButtonType="Button" CommandName="Editar" HeaderText=" Editar" Text="Editar" />
        </Columns>
    </asp:GridView>
    
   
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALMatricula">
        <SelectParameters>
            <asp:SessionParameter Name="IdTurma" SessionField="IdTurma" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
    
   
   
    
   
</asp:Content>
