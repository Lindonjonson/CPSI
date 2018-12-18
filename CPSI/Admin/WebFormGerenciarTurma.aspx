<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Admin.Master" AutoEventWireup="true" CodeBehind="WebFormGerenciarTurma.aspx.cs" Inherits="CPSI.Admin.WebFormVisualizarTurmas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-right: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label  runat="server" Text="Label">Nome turma</asp:Label>
    <asp:TextBox ID="TxtNomeTurma" runat="server" ValidationGroup="InserirTurma"></asp:TextBox>
    <asp:Label  runat="server" Text="Label">Ano</asp:Label>
    <asp:TextBox ID="TxtAno" runat="server" TextMode="Number"></asp:TextBox>
    <asp:Label  runat="server" Text="Label">Horário</asp:Label>
    <asp:TextBox ID="TxtHorário" runat="server"></asp:TextBox>
    <asp:Label  runat="server" Text="Label">Data início</asp:Label>
    <asp:Calendar ID="CalendarDataInicio" runat="server" ViewStateMode="Disabled"></asp:Calendar>
    <asp:Label  runat="server" Text="Label">Data fim</asp:Label>
    <asp:Calendar ID="CalendarDataFim" runat="server"></asp:Calendar>
    <asp:Label  runat="server" Text="Label">Quantidade de vagas</asp:Label>
    <asp:TextBox ID="TxtNumVagas" runat="server" TextMode="Number"></asp:TextBox>
    <asp:Label  runat="server" Text="Label">Disciplina</asp:Label>
    <asp:DropDownList ID="DropDownListDisciplina" runat="server"  DataTextField="disciplina" DataValueField="idDisciplina" DataSourceID="ObjectDataSource2"></asp:DropDownList>
    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALDisciplina"></asp:ObjectDataSource>
    <asp:button ID="button_Salvar" runat="server"  text="Salvar" Visible="False" CssClass="auto-style1" OnClick="InserirTurma_Click" />
    <asp:button ID="button_Atualizar" runat="server" Visible="False" text="Salvar" OnClick="AtualizarTurma_Click" />
    <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Admin/WebFormVisualizacaoTurma.aspx" runat="server">Cancelar</asp:HyperLink>

</asp:Content>
