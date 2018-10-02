<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Admin.Master" AutoEventWireup="true" CodeBehind="WebFormGerenciarAluno.aspx.cs" Inherits="CPSI.Matricula.WebFormGerenciarAluno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<label>Cadastrar aluno</label>
  
        
        <br />
        AlunoNome:
        <asp:TextBox ID="TextBoxAlunoNome" runat="server"  />
        <br />
        DataNascimento:
        <asp:Calendar ID="CalendarDataNascimento" runat="server"></asp:Calendar>
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
        <asp:TextBox ID="TextBoxEstadoCivil" runat="server"  />
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
       
 <br />
<label>Alunos Matrículados</label>
<asp:GridView ID="GridViewAlunos" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" OnRowCommand="GridView1_RowCommand" DataKeyNames="IdAluno" ShowHeaderWhenEmpty="True">
    <Columns>
        <asp:BoundField DataField="IdAluno" HeaderText="IdAluno" SortExpression="IdAluno" />
        <asp:BoundField DataField="AlunoNome" HeaderText="AlunoNome" SortExpression="AlunoNome" />
        <asp:BoundField DataField="DataNascimento" HeaderText="DataNascimento" SortExpression="DataNascimento" />
        <asp:BoundField DataField="Cpf" HeaderText="Cpf" SortExpression="Cpf" />
        <asp:BoundField DataField="Rg" HeaderText="Rg" SortExpression="Rg" />
        <asp:BoundField DataField="RGOrgao" HeaderText="RGOrgao" SortExpression="RGOrgao" />
        <asp:BoundField DataField="EstadoCivil" HeaderText="EstadoCivil" SortExpression="EstadoCivil" />
        <asp:BoundField DataField="Naturalidade" HeaderText="Naturalidade" SortExpression="Naturalidade" />
        <asp:BoundField DataField="NaturalidadeEstado" HeaderText="NaturalidadeEstado" SortExpression="NaturalidadeEstado" />
        <asp:BoundField DataField="Endereco" HeaderText="Endereco" SortExpression="Endereco" />
        <asp:BoundField DataField="Cidade" HeaderText="Cidade" SortExpression="Cidade" />
        <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado" />
        <asp:BoundField DataField="Telefone1" HeaderText="Telefone1" SortExpression="Telefone1" />
        <asp:BoundField DataField="Telefone2" HeaderText="Telefone2" SortExpression="Telefone2" />
        <asp:BoundField DataField="Contato" HeaderText="Contato" SortExpression="Contato" />
        <asp:BoundField DataField="ContatoTelefone" HeaderText="ContatoTelefone" SortExpression="ContatoTelefone" />
        <asp:ButtonField CommandName="Editar" HeaderText="Editar" Text="Editar" ButtonType="Button" />
        <asp:ButtonField ButtonType="Button" CommandName="Excluir" HeaderText="Excluir" Text="Excluir" />
    </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectALL" TypeName="CPSI.DAL.DALAluno" DataObjectTypeName="CPSI.Modelo.Aluno" InsertMethod="Insert"></asp:ObjectDataSource>
</asp:Content>
