<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Matricula.Master" AutoEventWireup="true" CodeBehind="WebFormMatricular.aspx.cs" Inherits="CPSI.Matricula.WebFormMatricular" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Literal ID="LiteralErro" Visible="false" runat="server"></asp:Literal>
    <asp:Panel ID="PanelSelecaoTurma" runat="server">
      <div class="form-inline w-50 mt-3 mb-3">
              <div class="form-group">
                  <label class="mr-2">Filtro:</label>
                  <asp:TextBox ID="TextBoxFiltroTurma" CssClass="form-control mr-2" runat="server"></asp:TextBox>
                  <label class="mr-2"> Ano:</label>
                  <asp:TextBox ID="TextBoxAno" CssClass="form-control mr-2" runat="server"></asp:TextBox>
                  <asp:Button ID="Button_Consulta" runat="server" CssClass="btn btn-secondary" Text="Pesquisar turma" OnClick="Pesquisar_Click" />
              </div>
      </div> 
      <asp:GridView ID="GridViewTurma" CssClass="table table-hover" DataSourceID="ObjectDataSource1"  ViewStateMode="Disabled" runat="server" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True" DataKeyNames="IdTurma" OnSelectedIndexChanged="GridViewTurma_SelectedIndexChanged" AllowPaging="True" PageSize="5">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" ButtonType="Link" HeaderText="Selecionar" />
                    <asp:BoundField DataField="NomeTurma" HeaderText="Turma" SortExpression="NomeTurma" />
                    <asp:BoundField DataField="ano" HeaderText="Ano" SortExpression="ano" />
                    <asp:BoundField DataField="horario" HeaderText="Horario" SortExpression="horario" />
                    <asp:BoundField DataField="DataInicio" HeaderText="Data Início" SortExpression="DataInicio" />
                    <asp:BoundField DataField="DataFim" HeaderText="Data Fim" SortExpression="DataFim" />
                    <asp:BoundField DataField="QtdVagas" HeaderText="Nº Vagas" SortExpression="QtdVagas" />
                    <asp:BoundField DataField="IdDisciplina" HeaderText="IdDisciplina" SortExpression="IdDisciplina" />
                </Columns>
     </asp:GridView>
  </asp:Panel>
  <asp:Panel ID="PanelSelecaoAluno" runat="server">
     <div class="form-inline w-50 mt-3 mb-3">
         <div class="form-group">
            <label class="mr-2">Filtro:</label>
            <asp:TextBox ID="TextBoxFiltroAluno" CssClass="form-control mr-2" runat="server"></asp:TextBox>
            <asp:Button ID="Button_Consultar"  CssClass="btn btn-secondary" runat="server" Text="Pesquisar aluno" OnClick="Pesquisar_Click" />
          </div>
     </div>
      <asp:GridView ID="GridViewAlunos" runat="server" AutoGenerateColumns="False" CssClass="table table-hover" ViewStateMode="Disabled" ShowHeaderWhenEmpty="True" DataKeyNames="IdAluno" OnSelectedIndexChanged="GridViewAlunos_SelectedIndexChanged" DataSourceID="ObjectDataSource2" AllowPaging="True" PageSize="5">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" ButtonType="link" HeaderText="Selecionar" />
                    <asp:BoundField DataField="AlunoNome" HeaderText="Nome" SortExpression="AlunoNome"></asp:BoundField>
                    <asp:BoundField DataField="DataNascimento" HeaderText="Data Nascimento" SortExpression="DataNascimento"></asp:BoundField>
                    <asp:BoundField DataField="Cpf" HeaderText="CPF" SortExpression="Cpf"></asp:BoundField>
                    <asp:BoundField DataField="Telefone1" HeaderText="Telefone" SortExpression="Telefone1"></asp:BoundField>
                    <asp:BoundField DataField="Contato" HeaderText="Contato" SortExpression="Contato"></asp:BoundField>
                    <asp:BoundField DataField="ContatoTelefone" HeaderText="Contato Telefone" SortExpression="ContatoTelefone"></asp:BoundField>
                </Columns>
   </asp:GridView>
  </asp:Panel>           
  
    <asp:Panel CssClass="card mb-3 mt-2" ID="PanelTurma" Visible="false" runat="server">
        <div class="card-body">
            <asp:Label Visible="false" CssClass=" text-white font-weight-bold bg-danger" ID="LabelTurmaStatus" runat="server" Text="Turma cheia, disponível apenas para lista de espera"></asp:Label>
            <br />
            <span class="font-weight-bold">Turma selecionada </span>
            <asp:Label ID="LabelTurma" runat="server" Text="Label"></asp:Label>
            <br />
            <span>Com inicio em </span>
            <asp:TextBox ID="LabelDataInicio" CssClass="m-2" ReadOnly="true"  runat="server" Text="Label"></asp:TextBox>
            <span>e fim </span>
            <asp:TextBox CssClass="m-2" ID="LabelDataFim" ReadOnly="true"  runat="server" Text="Label"></asp:TextBox>
            <asp:Button ID="Button_CancelarSelecaoTurma" CssClass="btn btn-link" runat="server" Text="Trocar" OnClick="Button_CancelarSelecaoTurma_Click" />
        </div>
    </asp:Panel>
    <asp:Panel CssClass="card  mb-3" ID="PanelAluno" Visible="false" runat="server">
        <div class="card-body">
             <span class="font-weight-bold">Aluno selecionado </span>
            <asp:Label ID="LabelAlunoNome" runat="server" Text="Label"></asp:Label>
            <br />
            <span>de CPF </span>
            <asp:TextBox ID="LabelAlunoCPF" CssClass="m-2" ReadOnly="true"  runat="server" Text="Label"></asp:TextBox>
            <span>e RG </span>
            <asp:TextBox CssClass="m-2" ID="LabelBoxAlunoRG" ReadOnly="true"  runat="server" Text="Label"></asp:TextBox>
            <asp:Button ID="Button_CancelarSelecaoAluno" runat="server" CssClass="btn btn-link" Text="Trocar" OnClick="Button_CancelarSelecaoAluno_Click" />
        </div>
    </asp:Panel>
    <button type="button" class="btn btn btn-primary" data-toggle="modal" data-target="#ModalMatricular">Matricular</button>
    <div class="modal fade" id="ModalMatricular" tabindex="-1" role="dialog" aria-labelledby="ModalMatricular" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                     <h5 class="modal-title">Matrícula</h5>
                     <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                         <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                     <asp:Panel ID="PanelMatricular" runat="server" Visible="false">
                         <span>Confirmar Matricula de aluno </span>
                         <span>Documentos Obrigatorios à disciplina</span>
                         <asp:CheckBoxList ID="CheckBoxListDocumentoDisciplina" DataTextField="Documento" DataValueField="iddocumento" runat="server"></asp:CheckBoxList>
                         <asp:Button ID="ButtonMatricular" CssClass="btn btn-success" runat="server" Text="Confirmar" OnClick="ButtonMatricular_Click" />
                     </asp:Panel>
                     <asp:Panel ID="PanelListaEspera" Visible="false" runat="server" >
                          <span>Confirmar Matricula de aluno </span>
                          <span class="font-weight-bold text-danger">Na lista de espera</span>
                          <asp:Button ID="ButtonListaEspera" CssClass="btn btn-success" runat="server" Text="Confirmar" OnClick="ButtonListaEspera_Click" />
                     </asp:Panel>
                 </div>
               
            </div>
      </div>
   </div>
     <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="Select" TypeName="CPSI.DAL.DALTurma">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBoxFiltroTurma" Name="filtro" PropertyName="Text" Size="20" Type="String" />
                    <asp:ControlParameter ControlID="TextBoxAno" DefaultValue="0" Name="ano" PropertyName="Text" Type="String" />
                </SelectParameters>
     </asp:ObjectDataSource>
     <asp:ObjectDataSource runat="server" ID="ObjectDataSource2" SelectMethod="SelectALLFiltro" TypeName="CPSI.DAL.DALAluno">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBoxFiltroAluno" PropertyName="Text" Name="filtro" Type="String"></asp:ControlParameter>
                </SelectParameters>
     </asp:ObjectDataSource>
    <asp:ObjectDataSource runat="server" ID="ObjectDataSource3" SelectMethod="selectALLData" TypeName="CPSI.DAL.DALDocumentoDisciplina">
           <SelectParameters>
               <asp:Parameter  Name="idDisciplina"   Type="String"></asp:Parameter>
           </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>
