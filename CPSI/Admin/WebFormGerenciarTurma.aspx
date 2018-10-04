<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Admin.Master" AutoEventWireup="true" CodeBehind="WebFormGerenciarTurma.aspx.cs" Inherits="CPSI.Admin.Turma.WebFormGerenciarTurma" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label  runat="server" Text="Label">Nome turma</asp:Label>
    <asp:TextBox ID="TxtNomeTurma" runat="server"></asp:TextBox>
    <asp:Label  runat="server" Text="Label">Ano</asp:Label>
    <asp:TextBox ID="TxtAno" runat="server"></asp:TextBox>
    <asp:Label  runat="server" Text="Label">Horário</asp:Label>
    <asp:TextBox ID="TxtHorário" runat="server"></asp:TextBox>
    <asp:Label  runat="server" Text="Label">Data início</asp:Label>
    <asp:Calendar ID="CalendarDataInicio" runat="server"></asp:Calendar>
    <asp:Label  runat="server" Text="Label">Data fim</asp:Label>
    <asp:Calendar ID="CalendarDataFim" runat="server"></asp:Calendar>
    <asp:Label  runat="server" Text="Label">Quantidade de vagas</asp:Label>
    <asp:TextBox ID="TxtNumVagas" runat="server"></asp:TextBox>
    <asp:Label  runat="server" Text="Label">Disciplina</asp:Label>
    <asp:DropDownList ID="DropDownListDisciplina" runat="server"  DataTextField="disciplina" DataValueField="idDisciplina" DataSourceID="ObjectDataSource2"></asp:DropDownList>
    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALDisciplina"></asp:ObjectDataSource>
    <asp:button runat="server" Click="InserirTurma" text="inserir" OnClick="InserirTurma_Click" />
    <asp:gridview ID="GridViewTurmas" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" ShowHeaderWhenEmpty="True" OnRowCommand="Turmas_RowCommand" DataKeyNames="IdTurma">
        <Columns>
            <asp:BoundField DataField="NomeTurma" HeaderText="NomeTurma" SortExpression="NomeTurma" />
            <asp:BoundField DataField="ano" HeaderText="ano" SortExpression="ano" />
            <asp:BoundField DataField="horario" HeaderText="horario" SortExpression="horario" />
            <asp:BoundField DataField="DataInicio" DataFormatString="{0:d}" HeaderText="DataInicio" SortExpression="DataInicio" />
            <asp:BoundField DataField="DataFim" DataFormatString="{0:d}" HeaderText="DataFim" SortExpression="DataFim" />
            <asp:BoundField DataField="QtdVagas" HeaderText="QtdVagas" SortExpression="QtdVagas" />
            <asp:ButtonField ButtonType="Button" CommandName="Editar" HeaderText="Editar" Text="Editar" />
            <asp:ButtonField ButtonType="Button" CommandName="Excluir" HeaderText="Excluir" Text="Excluir" />
            <asp:ButtonField ButtonType="Button" CommandName="VizualizarMatriculados " HeaderText="Vizualizar Matriculados " Text="Vizualizar Matriculados " />
            <asp:ButtonField ButtonType="Button" CommandName="Matricular" HeaderText="Matricular " Text="Matricular " />
        </Columns>
    </asp:gridview>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALTurma"></asp:ObjectDataSource>
    <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALDisciplina"></asp:ObjectDataSource>
</asp:Content>

