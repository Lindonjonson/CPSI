<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Admin.Master" AutoEventWireup="true" CodeBehind="WebFormGerenciarTurma.aspx.cs" Inherits="CPSI.Admin.WebFormVisualizarTurmas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-group">
        <asp:Label  runat="server" Text="Label">Nome turma</asp:Label>
        <asp:TextBox ID="TxtNomeTurma" CssClass="form-control w-50" runat="server" ValidationGroup="InserirTurma"></asp:TextBox>
        <asp:Label  runat="server" Text="Label">Ano</asp:Label>
        <asp:TextBox ID="TxtAno"  CssClass="form-control w-50" runat="server" TextMode="Number"></asp:TextBox>
        <asp:Label  runat="server" Text="Label">Horário</asp:Label>
        <asp:TextBox ID="TxtHorário"  CssClass="form-control w-50" runat="server"></asp:TextBox>
        <asp:Label  runat="server" Text="Label">Data início</asp:Label>
        <asp:TextBox ID="CalendarDataInicio"  CssClass="form-control w-50" runat="server"></asp:TextBox>
        <asp:Label  runat="server" Text="Label">Data fim</asp:Label>
        <asp:TextBox ID="CalendarDataFim"  CssClass="form-control w-50" runat="server"></asp:TextBox>
        <asp:Label  runat="server" Text="Label">Quantidade de vagas</asp:Label>
        <asp:TextBox ID="TxtNumVagas"  CssClass="form-control w-50" runat="server" TextMode="Number"></asp:TextBox>
        <asp:Label  runat="server" Text="Label">Disciplina</asp:Label>
        <asp:DropDownList ID="DropDownListDisciplina" runat="server"   CssClass="form-control w-50" DataTextField="disciplina" DataValueField="idDisciplina" DataSourceID="ObjectDataSource2"></asp:DropDownList>
    </div>
    <asp:Panel ID="PanelAdicionarTurma" runat="server" Visible="false">
       <asp:button ID="button1" runat="server"  text="Cancelar"  CssClass="btn btn-danger" OnClick="Cancelar_Click" />
       <button type="button" data-toggle="modal" data-target="#ModalCadastrarTurma" class="btn btn-success">Salvar</button>
    </asp:Panel>
    <asp:Panel ID="PanelAlterarTurma" runat="server" Visible="false">
         <button type="button" data-toggle="modal" data-target="#ModalEditarTurma" class="btn btn-warning text-white">Salvar</button>
         <button type="button" data-toggle="modal" data-target="#ModalExcluirTurma" class="btn btn-danger">Excluir</button>
         <asp:button ID="button2" runat="server"  text="Cancelar"  CssClass="btn btn-success" OnClick="Cancelar_Click" />
    </asp:Panel>

    <div class="modal fade" id="ModalCadastrarTurma" tabindex="-1" role="dialog" aria-labelledby="ModalCadastrarTurma" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                     <h5 class="modal-title">Confirmar cadastro de turma</h5>
                     <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                         <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                   
                 </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>
                    <asp:button ID="button_Inserir" runat="server"  text="Salvar"  CssClass="btn btn-success" OnClick="InserirTurma_Click" />

                </div>
            </div>
      </div>
   </div>
   <div class="modal fade" id="ModalEditarTurma" tabindex="-1" role="dialog" aria-labelledby="ModalEditarTurma" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                     <h5 class="modal-title">Confirmar edição de turma de turma</h5>
                     <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                         <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                   <span>Cuidado, operação de risco</span>
                 </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>
                    <asp:button ID="button_Atualizar" runat="server"  text="Salvar" CssClass="btn btn-warning" OnClick="AtualizarTurma_Click" />

                </div>
            </div>
      </div>
   </div>
<div class="modal fade" id="ModalExcluirTurma" tabindex="-1" role="dialog" aria-labelledby="ModalEditarTurma" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                     <h5 class="modal-title">Confirmar edição de turma de turma</h5>
                     <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                         <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                   <span>Excluir turma?</span>
                 </div>
                <div class="modal-footer">
                    <asp:button ID="button_Excluir" runat="server" text="Excluir" CssClass="btn btn-danger" OnClick="Excluir_Click" />
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>

                </div>
            </div>
      </div>
   </div>   
    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALDisciplina"></asp:ObjectDataSource>
</asp:Content>
