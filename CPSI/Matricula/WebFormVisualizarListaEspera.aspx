<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Matricula.Master" AutoEventWireup="true" CodeBehind="WebFormVisualizarListaEspera.aspx.cs" Inherits="CPSI.Matricula.WebFormVisualizarListaEspera" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4 class="mt-3 mb-3">
        Lista de espera Turma 
       <i> <asp:Label ID="LabelNomeTurma" runat="server" Text="Label"></asp:Label> </i>
    </h4>   
    <asp:GridView ID="GridViewMatriculados" CssClass="table table-hover" runat="server" DataSourceID="ObjectDataSource1" ShowHeaderWhenEmpty="True"></asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALListaEspera">
        <SelectParameters>
            <asp:SessionParameter Name="IdTurma" SessionField="IdTurma" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>
