<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Matricula.Master" AutoEventWireup="true" CodeBehind="WebFormVisualizarAlunos.aspx.cs" Inherits="CPSI.Matricula.WebFormVisualizarAlunos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-inline w-25 mt-3 mb-3">
        <div class="form-group">
            <label class="mr-1">Filtro:</label> 
            <asp:TextBox CssClass="form-control mr-1" ToolTip="Entre com informações sobre o aluno" ID="TextBoxFiltroAluno" runat="server" ></asp:TextBox>
            <asp:Button ID="Button_Consultar" runat="server" CssClass="btn btn-secondary" Text="Pesquisar aluno" OnClick="PesquisarAluno_Click" />
        </div>
    </div>
    
    <asp:GridView ID="GridViewAlunos" CssClass="table table-hover" runat="server" ShowHeaderWhenEmpty="true" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" DataKeyNames="IdAluno" OnRowCommand="GridViewAlunos_RowCommand">
        <Columns>
            
            <asp:BoundField DataField="AlunoNome" HeaderText="AlunoNome" SortExpression="AlunoNome"></asp:BoundField>
            <asp:BoundField DataField="DataNascimento" HeaderText="DataNascimento" SortExpression="DataNascimento"></asp:BoundField>
            <asp:BoundField DataField="Cpf" HeaderText="Cpf" SortExpression="Cpf"></asp:BoundField>
            <asp:BoundField DataField="Telefone1" HeaderText="Telefone1" SortExpression="Telefone1"></asp:BoundField>
            <asp:BoundField DataField="Telefone2" HeaderText="Telefone2" SortExpression="Telefone2"></asp:BoundField>
            <asp:BoundField DataField="Contato" HeaderText="Contato" SortExpression="Contato"></asp:BoundField>
            <asp:BoundField DataField="ContatoTelefone" HeaderText="ContatoTelefone" SortExpression="ContatoTelefone"></asp:BoundField>
            <asp:ButtonField CommandName="Editar" HeaderText="Editar Aluno" Text="Editar Aluno" ButtonType="link" />
        </Columns>
    </asp:GridView>
    <asp:Button ID="ButtonInserir" CssClass="btn btn-primary" runat="server" Text="Cadastrar novo aluno" OnClick="ChamarTelaInserir_Click" />
    <asp:ObjectDataSource runat="server" ID="ObjectDataSource1" SelectMethod="SelectALLFiltro" TypeName="CPSI.DAL.DALAluno">
        <SelectParameters>
            <asp:ControlParameter ControlID="TextBoxFiltroAluno" PropertyName="Text" Name="filtro" Type="String"></asp:ControlParameter>
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>
