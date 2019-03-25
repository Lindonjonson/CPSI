<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Matricula.Master" AutoEventWireup="true" CodeBehind="WebFormGerenciarAluno.aspx.cs" Inherits="CPSI.Matricula.WebFormGerenciarAluno1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" src="../Assets/js/GerenciarAluno.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form>
          <div class="form-row">
            <div class="form-group col-md-5">
                 <label> Nome: </label>
                 <asp:TextBox ID="TextBoxAlunoNome" class="form-control" runat="server" placeholder="Digite o nome do aluno" TextMode="SingleLine" />
            </div>
              
              
            <div class="form-group col-md-3">
               <label> Nascimento: </label>
               <asp:TextBox ID="TextBoxCalendarDataNascimento" class="form-control data-nascimento" runat="server" placeholder="00/00/0000" ></asp:TextBox>
            </div>
              <div class="form-group col-md-4">
                   <label>  CPF: </label>
               <asp:TextBox ID="TextBoxCpf"  class="form-control CPF" runat="server" placeholder="000.000.000-00" />
            </div>
          </div>
          <div class="form-row">
            <div class="form-group col-md-3">
                 <label> RG: </label>
               <asp:TextBox class="form-control" ID="TextBoxRg" runat="server" placeholder="000.000"  />
            </div>
            <div class="form-group col-md-3">
                 <label> RG Orgão: </label>
               <asp:TextBox class="form-control" ID="TextBoxRGOrgao" runat="server" placeholder="ex: SSP/RN" />

      
            </div>
            <div class="form-group col-md-4">
                 <label> Naturalidade: </label>
               <asp:TextBox ID="TextBoxNaturalidade" class="form-control" runat="server" placeholder="Digite a naturalidade" />
            </div>
              <div class="form-group col-md-2">
                  <label> Naturalidade Estado: </label>
                <asp:TextBox MaxLength="2" class="form-control" ID="TextBoxNaturalidadeEstado" runat="server"  placeholder="Ex: RN" />
            </div>
          </div>
                <div class="form-row">
            <div class="form-group col-md-4">
                <label> Estado Civil: </label>
                <asp:DropDownList class="form-control" ID="DropDownListEstadoCivil" runat="server">
                    <asp:ListItem Value="1">Solteiro</asp:ListItem>
                    <asp:ListItem Value="2">União estável </asp:ListItem>
                    <asp:ListItem Value="3">Casado</asp:ListItem>
                    <asp:ListItem Value="4">Divorciado </asp:ListItem>
                    <asp:ListItem Value="5">Viúvo</asp:ListItem>
               </asp:DropDownList>
            </div>
            <div class="form-group col-md-5">
                <label> Endereço: </label>
                <asp:TextBox ID="TextBoxEndereco"  class="form-control"  placeholder="Digite o endereço: rua+ cep + n°"   runat="server" />
       

      
            </div>
            <div class="form-group col-md-3">
                <label> Cidade: </label>
                <asp:TextBox class="form-control" ID="TextBoxCidade" runat="server" placeholder="Digite o nome da cidade" />
       
            </div>
            <div class="form-group col-md-6">
                <label>Estado: </label>
                <asp:TextBox MaxLength="2" class="form-control"  ID="TextBoxEstado" runat="server" placeholder="Digite o Estado"  />
            </div>
                    <div class="form-group col-md-6">
                         <label>Bairro: </label>
                <asp:TextBox  ID="TextBoxBairro" class="form-control" runat="server" placeholder="Bairro"  />

            </div>
          </div>
          <div class="form-row">
               <div class="form-group col-md-6">
                    <label>Primeiro Telefone: </label>
                    <asp:TextBox ID="TextBoxTelefone1" class="form-control" runat="server" placeholder="(DDD) 0 0000-0000"  />
               </div>
               <div class="form-group col-md-6">
                    <label>Segundo Telefone: </label>
                    <asp:TextBox ID="TextBoxTelefone2" class="form-control" runat="server"  placeholder="(DDD) 0 0000-0000"   />
               </div>
               <div class="form-group col-md-6">
                    <label>Nome do Contato de emergência: </label>
                    <asp:TextBox ID="TextBoxContato" class="form-control" runat="server" placeholder="Digite o nome de algum parente" />
               </div>
               <div class="form-group col-md-6">
                    <label>Telefone Emergêncial:  </label>
                    <asp:TextBox ID="TextBoxContatoTelefone" class="form-control" runat="server" placeholder="Digite o número do parente"  />
               </div>
               <div class="form-group col-md-6">
                    <label>Documentos obrigatórios </label>
                    <asp:CheckBoxList ID="CheckBoxListDocumentosAluno" runat="server" DataSourceID="ObjectDataSource1" DataTextField="documento" DataValueField="idDocumento"></asp:CheckBoxList>
                              <asp:ObjectDataSource runat="server" ID="ObjectDataSource1" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALDocumento">
                                  <SelectParameters>
                                      <asp:Parameter DefaultValue="1" Name="filtroTipo" Type="String"></asp:Parameter>
                                  </SelectParameters>
                              </asp:ObjectDataSource>
               </div>

    
          </div>

</form>


    <div class="form-group">
       
   
       
    </div>
    <asp:Panel ID="PanelAdicionarAluno" Visible="false" runat="server">
        <div align="center">
       <asp:button ID="button1" runat="server"  text="Cancelar"  CssClass="btn btn-danger" OnClick="Cancelar_Click" />
       <button type="button" data-toggle="modal" data-target="#ModalCadastrarAluno" class="btn btn-success">Salvar</button></div>
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
                  CADASTRO DE ALUNO
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
                   <span>Excluir Aluno?</span>
                 </div>
                <div class="modal-footer">
                    <asp:button ID="button3" runat="server" text="Excluir" CssClass="btn btn-danger" OnClick="Excluir_Click" />
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>

                </div>
            </div>
      </div>
   </div>  
    
</asp:Content>
