﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Admin.Master" AutoEventWireup="true" CodeBehind="WebFormGerenciarDisciplina.aspx.cs" Inherits="CPSI.Admin.Disciplina.WebFormGerenciarCategoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label>Código disciplina</label>
    <asp:TextBox runat="server" ID="TxtCodigo" PlaceHolder="Código disciplina"></asp:TextBox>
    <label>Nome disciplina</label>
    <asp:TextBox runat="server" ID="TxtNomeDisciplina" PlaceHolder="nome disciplina"></asp:TextBox>
    <asp:Button runat="server" Text="Inserir" OnClick="Inserir_Click"> </asp:Button>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" OnRowCommand="GridView1_RowCommand">
        <Columns>
            <asp:BoundField DataField="idDisciplina" HeaderText="idDisciplina" SortExpression="idDisciplina" />
            <asp:BoundField DataField="codigo" HeaderText="codigo" SortExpression="codigo" />
            <asp:BoundField DataField="disciplina" HeaderText="disciplina" SortExpression="disciplina" />
            <asp:ButtonField ButtonType="Button"  CommandName="Editar" HeaderText="Editar" Text="Editar" />
            <asp:ButtonField  ButtonType="Button" CommandName="Excluir"  HeaderText="Excluir" Text="Excluir" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALDisciplina"></asp:ObjectDataSource>
</asp:Content>
