<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Admin.Master" AutoEventWireup="true" CodeBehind="WebFormGerenciarTurma.aspx.cs" Inherits="CPSI.Admin.Turma.WebFormGerenciarTurma" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

       <h1>Turmas cadastradas</h1>
       <asp:gridview Cssclass="table table-striped" ID="GridViewTurmas" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" ShowHeaderWhenEmpty="True" OnRowCommand="Turmas_RowCommand" DataKeyNames="IdTurma">
        <Columns>
            <asp:BoundField DataField="NomeTurma" HeaderText="NomeTurma" SortExpression="NomeTurma" />
            <asp:BoundField DataField="ano" HeaderText="ano" SortExpression="ano" />
            <asp:BoundField DataField="horario" HeaderText="horario" SortExpression="horario" />
            <asp:BoundField DataField="DataInicio" DataFormatString="{0:d}" HeaderText="DataInicio" SortExpression="DataInicio" />
            <asp:BoundField DataField="DataFim" DataFormatString="{0:d}" HeaderText="DataFim" SortExpression="DataFim" />
            <asp:BoundField DataField="QtdVagas" HeaderText="QtdVagas" SortExpression="QtdVagas" />
            <asp:ButtonField ButtonType="Button" CommandName="Editar" HeaderText="Editar" Text="Editar" />
            <asp:ButtonField ButtonType="Button" CommandName="Excluir" HeaderText="Excluir" Text="Excluir" />
            <asp:ButtonField ButtonType="Button" CommandName="VizualizarMatriculados " HeaderText="Vizualizar Matriculados " Text="Vizualizar Matriculados "  />
        </Columns>
    </asp:gridview>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALTurma"></asp:ObjectDataSource>
    <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALDisciplina"></asp:ObjectDataSource>
    <asp:HyperLink CssClass="btn btn-primary" ID="HyperLink1" runat="server" NavigateUrl="~/Admin/WebFormAdicionarTurma.aspx">Cadastrar Nova Turma</asp:HyperLink>
</asp:Content>

