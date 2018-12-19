<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Matricula.Master" AutoEventWireup="true" CodeBehind="WebFormMatricular.aspx.cs" Inherits="CPSI.Matricula.WebFormMatricular" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   Filtro:<asp:TextBox ID="TextBoxFiltroTurma" runat="server"></asp:TextBox>
   Ano:<asp:TextBox ID="TextBoxAno" runat="server"></asp:TextBox>
    <asp:Button ID="Button_Consulta" runat="server" Text="Pesquisar turma" OnClick="Pesquisar_Click" />
    <asp:GridView ID="GridViewTurma" runat="server" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True"  DataKeyNames="IdTurma" OnSelectedIndexChanged="GridViewTurma_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ShowSelectButton="True" ButtonType="Button" />
            <asp:BoundField DataField="NomeTurma" HeaderText="NomeTurma" SortExpression="NomeTurma" />
            <asp:BoundField DataField="ano" HeaderText="ano" SortExpression="ano" />
            <asp:BoundField DataField="horario" HeaderText="horario" SortExpression="horario" />
            <asp:BoundField DataField="DataInicio" HeaderText="DataInicio" SortExpression="DataInicio" />
            <asp:BoundField DataField="DataFim" HeaderText="DataFim" SortExpression="DataFim" />
            <asp:BoundField DataField="QtdVagas" HeaderText="QtdVagas" SortExpression="QtdVagas" />
            <asp:BoundField DataField="IdDisciplina" HeaderText="IdDisciplina" SortExpression="IdDisciplina" />
        </Columns>
    </asp:GridView>
     Filtro:<asp:TextBox ID="TextBoxFiltroAluno" runat="server"></asp:TextBox>
     <asp:Button ID="Button_Consultar" runat="server" Text="Pesquisar aluno" OnClick="PesquisarAluno_Click" />
    <asp:GridView ID="GridViewAlunos" runat="server" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True" DataKeyNames="IdAluno" OnSelectedIndexChanged="GridViewAlunos_SelectedIndexChanged" EnableViewState="False">
        <Columns>
            <asp:CommandField ShowSelectButton="True" ButtonType="Button" />
            <asp:BoundField DataField="AlunoNome" HeaderText="AlunoNome" SortExpression="AlunoNome"></asp:BoundField>
            <asp:BoundField DataField="DataNascimento" HeaderText="DataNascimento" SortExpression="DataNascimento"></asp:BoundField>
            <asp:BoundField DataField="Cpf" HeaderText="Cpf" SortExpression="Cpf"></asp:BoundField>
            <asp:BoundField DataField="Telefone1" HeaderText="Telefone1" SortExpression="Telefone1"></asp:BoundField>
            <asp:BoundField DataField="Contato" HeaderText="Contato" SortExpression="Contato"></asp:BoundField>
            <asp:BoundField DataField="ContatoTelefone" HeaderText="ContatoTelefone" SortExpression="ContatoTelefone"></asp:BoundField>
        </Columns>
    </asp:GridView>
    <asp:Button ID="ButtonMatricular" runat="server" Text="Matricular" OnClick="Click_Matricular" />
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="Select" TypeName="CPSI.DAL.DALTurma">
        <SelectParameters>
            <asp:ControlParameter ControlID="TextBoxFiltroTurma" DefaultValue="" Name="filtro" PropertyName="Text" Size="20" Type="String" />
            <asp:ControlParameter ControlID="TextBoxAno" DefaultValue="0" Name="ano" PropertyName="Text" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
    
</asp:Content>
