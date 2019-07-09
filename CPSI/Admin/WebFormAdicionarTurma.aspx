<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Admin.Master" AutoEventWireup="true" CodeBehind="WebFormAdicionarTurma.aspx.cs" Inherits="CPSI.Admin.WebFormVisualizarTurmas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label  runat="server" Text="Label">Nome turma</asp:Label>
    <asp:TextBox ID="TxtNomeTurma" runat="server" ValidationGroup="InserirTurma"></asp:TextBox>
    <asp:Label  runat="server" Text="Label">Ano</asp:Label>
    <asp:TextBox ID="TxtAno" runat="server" TextMode="Number"></asp:TextBox>
    <asp:Label  runat="server" Text="Label">Horário</asp:Label>
    <asp:TextBox ID="TxtHorário" runat="server"></asp:TextBox>
    <asp:Label  runat="server" Text="Label">Data início</asp:Label>
    <asp:TextBox ID="CalendarDataInicio" runat="server" TextMode="Date"></asp:TextBox>
    <asp:Label  runat="server" Text="Label">Data fim</asp:Label>
    <asp:Textbox ID="CalendarDataFim" TextMode="Date" runat="server"></asp:Textbox>
    <asp:Label  runat="server" Text="Label">Quantidade de vagas</asp:Label>
    <asp:TextBox ID="TxtNumVagas" runat="server" TextMode="Number"></asp:TextBox>
    <asp:Label  runat="server" Text="Label">Disciplina</asp:Label>
    <asp:DropDownList ID="DropDownListDisciplina" runat="server"  DataTextField="disciplina" DataValueField="idDisciplina" DataSourceID="ObjectDataSource2"></asp:DropDownList>
    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALDisciplina"></asp:ObjectDataSource>
    <asp:button runat="server" Click="InserirTurma" text="inserir" OnClick="InserirTurma_Click" />

    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Entre com o nome da turma" ControlToValidate="TxtNomeTurma"></asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Entre com o ano" ControlToValidate="TxtAno"></asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Entre com o horário" ControlToValidate="TxtHorário"></asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Entre com a data" ControlToValidate="CalendarDataInicio"></asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Entre com a data" ControlToValidate="CalendarDataFim"></asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Entre com a quantidade de vaga" ControlToValidate="TxtNumVagas"></asp:RequiredFieldValidator>
   

</asp:Content>
