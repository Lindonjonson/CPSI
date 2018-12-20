<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Matricula.Master" AutoEventWireup="true" CodeBehind="WebFormGerenciarAluno.aspx.cs" Inherits="CPSI.Matricula.WebFormGerenciarAluno1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     AlunoNome:
        <asp:TextBox ID="TextBoxAlunoNome" runat="server"  />
        <br />
        DataNascimento:
        <asp:TextBox ID="TextBoxCalendarDataNascimento"  runat="server"></asp:TextBox>
        <br />
        Cpf:
        <asp:TextBox ID="TextBoxCpf" runat="server"  />
        <br />
        Rg:
        <asp:TextBox ID="TextBoxRg" runat="server"  />
        <br />
        RGOrgao:
        <asp:TextBox ID="TextBoxRGOrgao" runat="server"  />
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
        Estado:
        <asp:TextBox MaxLength="2" ID="TextBoxEstado" runat="server"  />
        <br />
        Cidade:
        <asp:TextBox ID="TextBoxCidade" runat="server"  />
        <br />
        Bairro:
        <asp:TextBox  ID="TextBoxBairro" runat="server"  />
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
