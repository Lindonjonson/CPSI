<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Matricula.Master" AutoEventWireup="true" CodeBehind="WebFormVisualizarTurmas.aspx.cs" Inherits="CPSI.Matricula.WebFormVisualizarTurmas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4 class="mt-3 mb-3">Turmas cadastradas</h4>   
    <asp:GridView ID="GridViewTurmas" runat="server" CssClass="table table-hover" ShowHeaderWhenEmpty="true" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" OnRowCommand="GridViewTurmas_RowCommand" DataKeyNames="idTurma">
       <Columns>
            <asp:BoundField DataField="NomeTurma" HeaderText="Nome da Turma" SortExpression="NomeTurma"  />
            <asp:BoundField DataField="ano" HeaderText="Ano" SortExpression="ano" />
            <asp:BoundField DataField="horario" HeaderText="Horário" SortExpression="horario" />
            <asp:BoundField DataField="DataInicio" DataFormatString="{0:d}" HeaderText="Data Início" SortExpression="DataInicio" />
            <asp:BoundField DataField="DataFim" DataFormatString="{0:d}" HeaderText="Data Fim" SortExpression="DataFim" />
            <asp:BoundField DataField="QtdVagas" HeaderText="Vagas" SortExpression="QtdVagas" />
            <asp:ButtonField ButtonType="link" CommandName="Matriculados" HeaderText="Matriculados" Text="Matriculados" /> 
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource runat="server" ID="ObjectDataSource1" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALTurma"></asp:ObjectDataSource>
</asp:Content>
