<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Matricula.Master" AutoEventWireup="true" CodeBehind="WebFormGerenciarAluno.aspx.cs" Inherits="CPSI.Matricula.WebFormGerenciarAluno1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        AlunoNome:
        <asp:TextBox ID="TextBoxAlunoNome" runat="server"  />
        DataNascimento:
        <asp:TextBox ID="TextBoxCalendarDataNascimento"  runat="server"></asp:TextBox>
        Cpf:
        <asp:TextBox ID="TextBoxCpf" runat="server"  />
        Rg:
        <asp:TextBox ID="TextBoxRg" runat="server"  />
        RGOrgao:
        <asp:TextBox ID="TextBoxRGOrgao" runat="server"  />
        EstadoCivil:
        <asp:DropDownList ID="DropDownListEstadoCivil" runat="server">
            <asp:ListItem Value="1">Solteiro</asp:ListItem>
            <asp:ListItem Value="2">União estável </asp:ListItem>
            <asp:ListItem Value="3">Casado</asp:ListItem>
            <asp:ListItem Value="4">Divorciado </asp:ListItem>
            <asp:ListItem Value="5">Viúvo</asp:ListItem>
       </asp:DropDownList>
        Naturalidade:
        <asp:TextBox ID="TextBoxNaturalidade" runat="server"  />
        NaturalidadeEstado:
        <asp:TextBox MaxLength="2" ID="TextBoxNaturalidadeEstado" runat="server"  />
        Endereco:
        <asp:TextBox ID="TextBoxEndereco" runat="server" />
        Estado:
        <asp:TextBox MaxLength="2" ID="TextBoxEstado" runat="server"  />
        Cidade:
        <asp:TextBox ID="TextBoxCidade" runat="server"  />
        Bairro:
        <asp:TextBox  ID="TextBoxBairro" runat="server"  />
        Telefone1:
        <asp:TextBox ID="TextBoxTelefone1" runat="server"  />
        Telefone2:
        <asp:TextBox ID="TextBoxTelefone2" runat="server"  />
        Contato:
        <asp:TextBox ID="TextBoxContato" runat="server"  />
        ContatoTelefone:
        <asp:TextBox ID="TextBoxContatoTelefone" runat="server"  />
        <asp:Button ID="ButtonEditarAluno"  runat="server" Text="Salvar" OnClick="EditarAluno_Click" Visible="false" />
        <asp:Button ID="ButtonInserirAluno"  runat="server" Text="Salvar" OnClick="InserirAluno_Click" visible="false"/>
        <asp:Button ID="ButtonCancelar" OnClick="Cancelar_Click" runat="server" Text="Cancelar" />
        <asp:Panel  ID="Panel_ButtonExcluir" runat="server" Visible="false">
           <input id="ButtonExcluir" type="button" value="Excluir"  OnClick="ExibirExcluir()"/>
        </asp:Panel>
        <asp:Panel CssClass="PanelExcluir" ID="PanelExcluir" runat="server">
            <span>Confirmar alteração dos documentos da disciplina</span>
            <asp:Label ID="LabelAluno" runat="server" Text="Label"></asp:Label>
            <asp:HyperLink ID="HyperLink2" NavigateUrl="~/Admin/WebFormVisualizacaoTurma.aspx" runat="server">Cancelar</asp:HyperLink>
            <asp:button ID="button_Excluir" runat="server"  text="Excluir" OnClick="Excluir_Click" />
    </asp:Panel>
</asp:Content>
