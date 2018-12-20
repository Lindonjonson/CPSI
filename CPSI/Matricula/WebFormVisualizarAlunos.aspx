<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Matricula.Master" AutoEventWireup="true" CodeBehind="WebFormVisualizarAlunos.aspx.cs" Inherits="CPSI.Matricula.WebFormVisualizarAlunos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     Filtro:<asp:TextBox ID="TextBoxFiltroAluno" runat="server"></asp:TextBox>
             <asp:Button ID="Button_Consultar" runat="server" Text="Pesquisar aluno" OnClick="PesquisarAluno_Click" />
    <asp:GridView ID="GridViewAlunos" runat="server" ShowHeaderWhenEmpty="true" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" DataKeyNames="IdAluno" OnRowCommand="GridViewAlunos_RowCommand">
        <Columns>
            
            <asp:BoundField DataField="AlunoNome" HeaderText="AlunoNome" SortExpression="AlunoNome"></asp:BoundField>
            <asp:BoundField DataField="DataNascimento" HeaderText="DataNascimento" SortExpression="DataNascimento"></asp:BoundField>
            <asp:BoundField DataField="Cpf" HeaderText="Cpf" SortExpression="Cpf"></asp:BoundField>
            <asp:BoundField DataField="Rg" HeaderText="Rg" SortExpression="Rg"></asp:BoundField>
            <asp:BoundField DataField="RGOrgao" HeaderText="RGOrgao" SortExpression="RGOrgao"></asp:BoundField>
            <asp:BoundField DataField="EstadoCivil" HeaderText="EstadoCivil" SortExpression="EstadoCivil"></asp:BoundField>
            <asp:BoundField DataField="Telefone1" HeaderText="Telefone1" SortExpression="Telefone1"></asp:BoundField>
            <asp:BoundField DataField="Telefone2" HeaderText="Telefone2" SortExpression="Telefone2"></asp:BoundField>
            <asp:BoundField DataField="Contato" HeaderText="Contato" SortExpression="Contato"></asp:BoundField>
            <asp:BoundField DataField="ContatoTelefone" HeaderText="ContatoTelefone" SortExpression="ContatoTelefone"></asp:BoundField>
            <asp:ButtonField CommandName="Editar" HeaderText="Editar Aluno" Text="Editar Aluno" ButtonType="Button" />
        </Columns>
    </asp:GridView>
    <asp:Button ID="ButtonInserir" runat="server" Text="Cadastrar novo aluno" OnClick="ChamarTelaInserir_Click" />
    <asp:ObjectDataSource runat="server" ID="ObjectDataSource1" SelectMethod="SelectALLFiltro" TypeName="CPSI.DAL.DALAluno">
        <SelectParameters>
            <asp:ControlParameter ControlID="TextBoxFiltroAluno" PropertyName="Text" Name="filtro" Type="String"></asp:ControlParameter>
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>
