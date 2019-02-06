<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Matricula.Master" AutoEventWireup="true" CodeBehind="WebFormGerenciarAluno.aspx.cs" Inherits="CPSI.Matricula.WebFormGerenciarAluno1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-group">
       <label> Nome: </label>
       <asp:TextBox ID="TextBoxAlunoNome" CssClass="form-control w-50" runat="server"  />
       <label> Nascimento: </label>
       <asp:TextBox ID="TextBoxCalendarDataNascimento" CssClass="form-control w-50" runat="server"></asp:TextBox>
       <label>  CPF: </label>
       <asp:TextBox ID="TextBoxCpf" CssClass="form-control w-50" runat="server"  />
       <label> RG: </label>
       <asp:TextBox CssClass="form-control w-50" ID="TextBoxRg" runat="server"  />
       <label> RG Orgão: </label>
       <asp:TextBox CssClass="form-control w-50" ID="TextBoxRGOrgao" runat="server"  />
       <label> Estado Civil: </label>
        <asp:DropDownList CssClass="form-control w-50" ID="DropDownListEstadoCivil" runat="server">
            <asp:ListItem Value="1">Solteiro</asp:ListItem>
            <asp:ListItem Value="2">União estável </asp:ListItem>
            <asp:ListItem Value="3">Casado</asp:ListItem>
            <asp:ListItem Value="4">Divorciado </asp:ListItem>
            <asp:ListItem Value="5">Viúvo</asp:ListItem>
       </asp:DropDownList>
       <label> Naturalidade: </label>
       <asp:TextBox ID="TextBoxNaturalidade" CssClass="form-control w-50" runat="server"  />
       <label> Naturalidade Estado: </label>
        <asp:TextBox MaxLength="2" CssClass="form-control w-50" ID="TextBoxNaturalidadeEstado" runat="server"  />
        <label> Endereço: </label>
        <asp:TextBox ID="TextBoxEndereco" CssClass="form-control w-50" runat="server" />
        <label>Estado: </label>
        <asp:TextBox MaxLength="2" CssClass="form-control w-50" ID="TextBoxEstado" runat="server"  />
        <label> Cidade: </label>
        <asp:TextBox CssClass="form-control w-50" ID="TextBoxCidade" runat="server"  />
        <label>Bairro: </label>
        <asp:TextBox  ID="TextBoxBairro" CssClass="form-control w-50" runat="server"  />
        <label>Primeiro Telefone: </label>
        <asp:TextBox ID="TextBoxTelefone1" CssClass="form-control w-50" runat="server"  />
        <label>Segundo Telefone2: </label>
        <asp:TextBox ID="TextBoxTelefone2" CssClass="form-control w-50" runat="server"  />
        <label> Contato: </label>
        <asp:TextBox ID="TextBoxContato" CssClass="form-control w-50" runat="server"  />
        <label> Telefone Contato:  </label>
        <asp:TextBox ID="TextBoxContatoTelefone" CssClass="form-control w-50" runat="server"  />
    </div>
    <asp:Panel ID="PanelAdicionarAluno" Visible="false" runat="server">
       <asp:button ID="button1" runat="server"  text="Cancelar"  CssClass="btn btn-danger" OnClick="Cancelar_Click" />
       <button type="button" data-toggle="modal" data-target="#ModalCadastrarAluno" class="btn btn-success">Salvar</button>
    </asp:Panel>
     <asp:Panel ID="PanelAlterarAluno" runat="server" Visible="false">
         <button type="button" data-toggle="modal" data-target="#ModalEditarAluno" class="btn btn-warning text-white">Salvar</button>
         <button type="button" data-toggle="modal" data-target="#ModalExcluirAluno" class="btn btn-danger">Excluir</button>
         <asp:button ID="button2" runat="server"  text="Cancelar"  CssClass="btn btn-success" OnClick="Cancelar_Click" />
    </asp:Panel>
    <div class="modal fade" id="ModalCadastrarAluno" tabindex="-1" role="dialog" aria-labelledby="ModalCadastrarAluno" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                     <h5 class="modal-title">Confirmar cadastro de Aluno</h5>
                     <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                         <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                   
                 </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>
                    <asp:button ID="button_Inserir" runat="server"  text="Salvar"  CssClass="btn btn-success" OnClick="InserirAluno_Click" />
                </div>
            </div>
      </div>
   </div>
     <div class="modal fade" id="ModalEditarAluno" tabindex="-1" role="dialog" aria-labelledby="ModalEditarAluno" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                     <h5 class="modal-title">Confirmar edição de aluno</h5>
                     <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                         <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                   <span>Cuidado, operação de risco</span>
                 </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>
                    <asp:button ID="button_Atualizar" runat="server"  text="Salvar" CssClass="btn btn-warning" OnClick="EditarAluno_Click" />
                </div>
            </div>
      </div>
   </div>
    <div class="modal fade" id="ModalExcluirAluno" tabindex="-1" role="dialog" aria-labelledby="ModalExcluirAluno" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                     <h5 class="modal-title">Confirmar Exclusão do aluno</h5>
                     <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                         <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                   <span>Excluir turma?</span>
                 </div>
                <div class="modal-footer">
                    <asp:button ID="button3" runat="server" text="Excluir" CssClass="btn btn-danger" OnClick="Excluir_Click" />
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>

                </div>
            </div>
      </div>
   </div>  
</asp:Content>
