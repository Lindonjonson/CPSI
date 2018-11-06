﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Matricula.Master" AutoEventWireup="true" CodeBehind="WebFormInserirAluno.aspx.cs" Inherits="CPSI.Matricula.WebFormInserirAluno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
        AlunoNome:
        <asp:TextBox ID="TextBoxAlunoNome" runat="server"  />
        <br />
        DataNascimento:
        <asp:TextBox ID="CalendarDataNascimento" TextMode="Date" runat="server"></asp:TextBox>
        <br />
        Cpf:
        <asp:TextBox ID="TextBoxCpf" runat="server"  />
        <br />
        Rg:
        <asp:TextBox ID="TextBoxRg" runat="server"  />
        <br />
        RGOrgao:
        <asp:TextBox ID="TextBoxRGOrgaox" runat="server"  />
        <br />
        EstadoCivil:
        <asp:DropDownList ID="DropDownListEstadoCivil" runat="server">
            <asp:ListItem Value="1">Solteiro</asp:ListItem>
            <asp:ListItem Value="2">União estável </asp:ListItem>
            <asp:ListItem Value="3">Casado</asp:ListItem>
            <asp:ListItem Value="4">Divorciado </asp:ListItem>
            <asp:ListItem Value="5">Viúvo</asp:ListItem>
    </asp:DropDownList>
        <br />
        Naturalidade:
        <asp:TextBox ID="TextBoxNaturalidade" runat="server"  />
        <br />
        NaturalidadeEstado:
        <asp:TextBox MaxLength="2" ID="TextBoxNaturalidadeEstado" runat="server"  />
        <br />
        Endereco:
        <asp:TextBox ID="TextBoxEndereco" runat="server" />
        <br />
        Cidade:
        <asp:TextBox ID="TextBoxCidade" runat="server"  />
        <br />
        Estado:
        <asp:TextBox MaxLength="2" ID="TextBoxEstado" runat="server"  />
        <br />
        Telefone1:
        <asp:TextBox ID="TextBoxTelefone1" runat="server"  />
        <br />
        Telefone2:
        <asp:TextBox ID="TextBoxTelefone2" runat="server"  />
        <br />
        Contato:
        <asp:TextBox ID="TextBoxContato" runat="server"  />
        <br />
        ContatoTelefone:
        <asp:TextBox ID="TextBoxContatoTelefone" runat="server"  />
        <br />
       <asp:Button ID="InserirAluno" Click="InserirAluno" runat="server" Text="inserir aluno" OnClick="InserirAluno_Click" />
</asp:Content>
