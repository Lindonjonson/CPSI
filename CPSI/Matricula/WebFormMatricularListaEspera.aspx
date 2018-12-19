 <%@ Page Title="" Language="C#" MasterPageFile="~/Master/Matricula.Master" AutoEventWireup="true" CodeBehind="WebFormMatricularListaEspera.aspx.cs" Inherits="CPSI.Matricula.WebFormMatricularListaEspera" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:Panel ID="PanelConfirmação" runat="server">
         <span>Matricular aluno em lista de espera ? </span>
         <asp:Button ID="Button_Matricular" runat="server" Text="Salvar matrícula" OnClick="Button_Matricular_Click" />
         <asp:Button ID="Button_Cancelar" runat="server" Text="Cancelar" OnClick="Click_Cancelar" />
    </asp:Panel>
</asp:Content>
