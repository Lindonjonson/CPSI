﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Matricula.Master" AutoEventWireup="true" CodeBehind="WebFormMatriculaInicial.aspx.cs" Inherits="CPSI.Master.WebFormMatriculaInicial" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Menu ID="Menu1" runat="server">
        <Items>
            <asp:MenuItem NavigateUrl="~/Matricula/WebFormGerenciarAluno.aspx" Text="Alunos" Value="Visualizar turmas"></asp:MenuItem>

            <asp:MenuItem Text="Principal" Value="Principal" NavigateUrl="~/Master/WebFormPrincipal.aspx"></asp:MenuItem>
        </Items>
        
    </asp:Menu>
    
</asp:Content>