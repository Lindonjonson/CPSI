<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Admin.Master" AutoEventWireup="true" CodeBehind="WebFormVisualizacaoTurma.aspx.cs" Inherits="CPSI.Admin.WebFormVisualizacaoTurma1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Turmas cadastradas</h1>   
    <asp:GridView ID="GridViewTurmas" runat="server" ShowHeaderWhenEmpty="true" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" OnRowCommand="GridViewTurmas_RowCommand" DataKeyNames="idTurma">
       <Columns>
            <asp:BoundField DataField="NomeTurma" HeaderText="NomeTurma" SortExpression="NomeTurma"  />
            <asp:BoundField DataField="ano" HeaderText="ano" SortExpression="ano" />
            <asp:BoundField DataField="horario" HeaderText="horario" SortExpression="horario" />
            <asp:BoundField DataField="DataInicio" DataFormatString="{0:d}" HeaderText="DataInicio" SortExpression="DataInicio" />
            <asp:BoundField DataField="DataFim" DataFormatString="{0:d}" HeaderText="DataFim" SortExpression="DataFim" />
            <asp:BoundField DataField="QtdVagas" HeaderText="QtdVagas" SortExpression="QtdVagas" />
            <asp:ButtonField ButtonType="Button" CommandName="Editar" HeaderText="Editar" Text="Editar" /> 
        </Columns>
    </asp:GridView>
        <asp:Button ID="ButtonInserir" runat="server" Text="Cadastrar nova turma" OnClick="ChamarTelaInserir_Click" />
    <asp:ObjectDataSource runat="server" ID="ObjectDataSource1" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALTurma"></asp:ObjectDataSource>
</asp:Content>
