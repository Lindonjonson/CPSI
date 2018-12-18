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
    <asp:TextBox ID="CalendarDataInicio" runat="server"></asp:TextBox>
    <asp:Label  runat="server" Text="Label">Data fim</asp:Label>
    <asp:TextBox ID="CalendarDataFim" runat="server"></asp:TextBox>
    <asp:Label  runat="server" Text="Label">Quantidade de vagas</asp:Label>
    <asp:TextBox ID="TxtNumVagas" runat="server" TextMode="Number"></asp:TextBox>
    <asp:Label  runat="server" Text="Label">Disciplina</asp:Label>
    <asp:DropDownList ID="DropDownListDisciplina" runat="server"  DataTextField="disciplina" DataValueField="idDisciplina" DataSourceID="ObjectDataSource2"></asp:DropDownList>
    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALDisciplina"></asp:ObjectDataSource>
    <asp:button ID="button_Salvar" runat="server"  text="Salvar" Visible="False" CssClass="auto-style1" OnClick="InserirTurma_Click" />
    <asp:button ID="button_Atualizar" runat="server" Visible="False" text="Salvar" OnClick="AtualizarTurma_Click" />
    <asp:Button ID="Button2" runat="server" Text="Cancelar" OnClick="Cancelar_Click" />
    <asp:Panel  ID="Panel_ButtonExcluir" runat="server" Visible="false">
        <input id="ButtonExcluir" type="button" value="Excluir"  OnClick="ExibirExcluir()"/>
    </asp:Panel>
    
     <asp:Panel CssClass="PanelExcluir" ID="PanelExcluir" runat="server">
        <span>Confirmar alteração dos documentos da disciplina</span>
        <asp:Label ID="LabelTurma" runat="server" Text="Label"></asp:Label>
        <asp:HyperLink ID="HyperLink2" NavigateUrl="~/Admin/WebFormGerenciarDisciplina.aspx" runat="server">Cancelar</asp:HyperLink>
        <asp:button ID="button_Excluir" runat="server" Visible="False" text="Excluir" OnClick="Excluir_Click" />
    </asp:Panel>
    
</asp:Content>
