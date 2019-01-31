<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Admin.Master" AutoEventWireup="true" CodeBehind="WebFormGerenciarTurma.aspx.cs" Inherits="CPSI.Admin.WebFormVisualizarTurmas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-right: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-group">
        <asp:Label  runat="server" Text="Label">Nome turma</asp:Label>
        <asp:TextBox ID="TxtNomeTurma" CssClass="form-control w-50" runat="server" ValidationGroup="InserirTurma"></asp:TextBox>
        <asp:Label  runat="server" Text="Label">Ano</asp:Label>
        <asp:TextBox ID="TxtAno"  CssClass="form-control w-50" runat="server" TextMode="Number"></asp:TextBox>
        <asp:Label  runat="server" Text="Label">Horário</asp:Label>
        <asp:TextBox ID="TxtHorário"  CssClass="form-control w-50" runat="server"></asp:TextBox>
        <asp:Label  runat="server" Text="Label">Data início</asp:Label>
        <asp:TextBox ID="CalendarDataInicio"  CssClass="form-control w-50" runat="server"></asp:TextBox>
        <asp:Label  runat="server" Text="Label">Data fim</asp:Label>
        <asp:TextBox ID="CalendarDataFim"  CssClass="form-control w-50" runat="server"></asp:TextBox>
        <asp:Label  runat="server" Text="Label">Quantidade de vagas</asp:Label>
        <asp:TextBox ID="TxtNumVagas"  CssClass="form-control w-50" runat="server" TextMode="Number"></asp:TextBox>
        <asp:Label  runat="server" Text="Label">Disciplina</asp:Label>
        <asp:DropDownList ID="DropDownListDisciplina" runat="server"   CssClass="form-control w-50" DataTextField="disciplina" DataValueField="idDisciplina" DataSourceID="ObjectDataSource2"></asp:DropDownList>
    </div>
    <asp:Panel ID="PanelAdicionarTurma" runat="server" Visible="false">
         <asp:button ID="button_Inserir" runat="server"  text="Salvar"  CssClass="auto-style1" OnClick="InserirTurma_Click" />
    </asp:Panel>
    <asp:Panel ID="PanelAlterarTurma" runat="server" Visible="false">
         <asp:button ID="button_Atualizar" runat="server"  text="Salvar" OnClick="AtualizarTurma_Click" />
         <asp:button ID="button_Excluir" runat="server" text="Excluir" OnClick="Excluir_Click" />
    </asp:Panel>
   
   
    
   
   
    
    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALDisciplina"></asp:ObjectDataSource>
</asp:Content>
