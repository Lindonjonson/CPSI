<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Matricula.Master" AutoEventWireup="true" CodeBehind="WebFormMatricular.aspx.cs" Inherits="CPSI.Matricula.WebFormMatricular" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
           <asp:Panel ID="PanelMatricula" runat="server">
                Filtro:<asp:TextBox ID="TextBoxFiltroTurma" runat="server"></asp:TextBox>
           Ano:<asp:TextBox ID="TextBoxAno" runat="server"></asp:TextBox>
            <asp:Button ID="Button_Consulta" runat="server" Text="Pesquisar turma" OnClick="Pesquisar_Click" />
            <asp:GridView ID="GridViewTurma" DatasourceId="ObjectDataSource1" runat="server" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True"  DataKeyNames="IdTurma" OnSelectedIndexChanged="GridViewTurma_SelectedIndexChanged" >
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
            <asp:GridView ID="GridViewAlunos" runat="server" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True" DataKeyNames="IdAluno" OnSelectedIndexChanged="GridViewAlunos_SelectedIndexChanged"  DataSourceID="ObjectDataSource2">
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
           <asp:Button ID="ButtonMatricular" runat="server" Text="Matricular" OnClick="Exibir_matricular" />
   </asp:Panel>
    <asp:Panel ID="PanelConfirmação" runat="server" Visible="false">
         <span>Matricular aluno  </span>
         <asp:Label ID="LabelNomeAluno" runat="server" Text="Label"></asp:Label>
         <br />
         <span>na turma</span>
         <asp:Label ID="LabelNomeTurma" runat="server" Text="Label"></asp:Label>
         <asp:Button ID="Button_Matricular" runat="server" Text="Salvar matrícula" OnClick="Button_Matricular_Click" />
         <asp:Button ID="Button_Cancelar" runat="server" Text="Cancelar" OnClick="Page_Load" />
    </asp:Panel>
     <asp:ObjectDataSource runat="server" ID="ObjectDataSource2" SelectMethod="SelectALLFiltro" TypeName="CPSI.DAL.DALAluno">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBoxFiltroAluno" PropertyName="Text" Name="filtro" Type="String"></asp:ControlParameter>
                </SelectParameters>
     </asp:ObjectDataSource>
            
     <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="Select" TypeName="CPSI.DAL.DALTurma">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBoxFiltroTurma" Name="filtro" PropertyName="Text" Size="20" Type="String" />
                    <asp:ControlParameter ControlID="TextBoxAno" DefaultValue="0" Name="ano" PropertyName="Text" Type="String" />
                </SelectParameters>
     </asp:ObjectDataSource>
</asp:Content>
