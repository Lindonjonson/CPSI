﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Matricula.Master" AutoEventWireup="true" CodeBehind="WebFormMatricular.aspx.cs" Inherits="CPSI.Matricula.WebFormMatricular" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
   <asp:Button  runat="server" Text="Matricular" OnClick="VerificarDisponibilidade_Click"  />
   <asp:Panel ID="PanelMatricular" runat="server" Visible="false">
       <span>Confirmar Matricula de aluno </span>
       <asp:label ID="TextBoxMatricularAluno" CssClass="font-weight-bold" runat="server"></asp:label>
       <span>Na Turma</span>
       <asp:label ID="TextBoxMatricularTurma" CssClass="font-weight-bold" runat="server"></asp:label>
       <span>Documentos Obrigatorios à disciplina</span>
       <asp:CheckBoxList ID="CheckBoxListDocumentoDisciplina" DataTextField="Documento" DataValueField="iddocumento" runat="server"></asp:CheckBoxList>
       <asp:Button ID="ButtonMatricular" CssClass="btn btn-success" runat="server" Text="Confirmar" OnClick="ButtonMatricular_Click" />
   </asp:Panel>
   <asp:Panel ID="PanelListaEspera" runat="server" >
       <span>Confirmar Matricula de aluno </span>
       <asp:label ID="TextBoxEsperaAluno"  CssClass="m-2 font-weight-bold" runat="server"></asp:label>
       <span class="font-weight-bold text-danger">Na lista de espera Turma</span>
       <asp:label ID="TextBoxEsperaTurma" runat="server"></asp:label>
       <asp:Button ID="ButtonListaEspera" CssClass="btn btn-success" runat="server" Text="Confirmar" OnClick="ButtonListaEspera_Click" />
   </asp:Panel>
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
