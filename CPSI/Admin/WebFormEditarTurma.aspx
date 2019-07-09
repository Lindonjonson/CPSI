<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Admin.Master" AutoEventWireup="true" CodeBehind="WebFormEditarTurma.aspx.cs" Inherits="CPSI.Admin.Turma.WebFormEditarTurma" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-decoration: underline;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" AutoGenerateRows="False" DataSourceID="ObjectDataSource1" CssClass="auto-style1">
        <Fields>
            <asp:BoundField DataField="IdTurma" HeaderText="IdTurma" SortExpression="IdTurma" />
            <asp:BoundField DataField="NomeTurma" HeaderText="NomeTurma" SortExpression="NomeTurma" />
            <asp:BoundField DataField="ano" HeaderText="ano" SortExpression="ano" />
            <asp:BoundField DataField="horario" HeaderText="horario" SortExpression="horario" />
            <asp:BoundField DataField="DataInicio" HeaderText="DataInicio" SortExpression="DataInicio" />
            <asp:BoundField DataField="DataFim" HeaderText="DataFim" SortExpression="DataFim" />
            <asp:BoundField DataField="QtdVagas" HeaderText="QtdVagas" SortExpression="QtdVagas" />
            <asp:BoundField DataField="IdDisciplina" HeaderText="IdDisciplina" SortExpression="IdDisciplina" />
            <asp:CommandField ShowEditButton="True" />
        </Fields>
    </asp:DetailsView>

    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="CPSI.Modelo.Turma" SelectMethod="Select" TypeName="CPSI.DAL.DALTurma" UpdateMethod="Update">
        <SelectParameters>
            <asp:SessionParameter SessionField="IdTurma" DefaultValue="" Name="ID" Type="String"></asp:SessionParameter>

        </SelectParameters>
    </asp:ObjectDataSource>
    
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Admin/WebFormGerenciarTurma.aspx">Voltar</asp:HyperLink>
    <br />
    
</asp:Content>
