<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Matricula.Master" AutoEventWireup="true" CodeBehind="WebFormMatriculaInicial.aspx.cs" Inherits="CPSI.Master.WebFormMatriculaInicial" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Menu ID="Menu1" runat="server">
        <Items>
            <asp:MenuItem NavigateUrl="~/Matricula/WebFormVisualizarTurma.aspx" Text="Visualizar turmas" Value="Visualizar turmas"></asp:MenuItem>
        </Items>
    </asp:Menu>
</asp:Content>
