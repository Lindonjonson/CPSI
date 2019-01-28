<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Admin.Master" AutoEventWireup="true" CodeBehind="WebFormGerenciarDisciplina.aspx.cs" Inherits="CPSI.Admin.Disciplina.WebFormGerenciarCategoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <h4 class="mt-3 mb-3">Disciplinas</h4>
        <asp:GridView ID="GridViewDisciplina" runat="server" AutoGenerateColumns="False" CssClass="table table-hover" DataSourceID="ObjectDataSource1" OnRowCommand="GridViewDisciplina_RowCommand"  ShowHeaderWhenEmpty="True" DataKeyNames="idDisciplina" OnSelectedIndexChanged="GridViewDisciplina_SelectedIndexChanged" EnableViewState="False" >
            <Columns>
                <asp:CommandField HeaderText="Operações" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="disciplina" HeaderText="Disciplina" SortExpression="disciplina" />
                <asp:ButtonField ButtonType="link" CommandName="EditarDocumento"  HeaderText="Documentos" ShowHeader="True" Text="Editar Documentos"  />
            </Columns>
        </asp:GridView>
    <button type="button" data-target="#ModalExcluirDisciplina" data-toggle="modal" class="btn btn-danger">Excluir Disciplina</button> 
    <Button  type="button" Class="btn btn btn-primary" data-toggle="modal" data-target="#ModalCadastrarDisciplina">Cadastrar disciplina</Button>

    <div class="modal fade" id="ModalCadastrarDisciplina" tabindex="-1" role="dialog" aria-labelledby="ModalCadastrarDisciplina" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                     <h5 class="modal-title">Cadastrar disciplina</h5>
                     <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                         <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <span>Nome da disciplina</span>
                    <asp:TextBox runat="server" ID="TxtNomeDisciplina" PlaceHolder="nome disciplina"></asp:TextBox>
                    <label>Documentos obrigatorios para a disciplina</label>
                    <asp:CheckBoxList ID="CheckBoxListDocumentos" runat="server" DataSourceID="ObjectDataSource2" DataTextField="documento" DataValueField="idDocumento"></asp:CheckBoxList>
                 </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>
                    <asp:Button runat="server" Text="Inserir"  CssClass="btn btn-success" OnClick="Inserir_Click"> </asp:Button>
                </div>
            </div>
      </div>
   </div>
    <div class="modal fade" id="ModalExcluirDisciplina" tabindex="-1" role="dialog" aria-labelledby="ModalExcluirDisciplina" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                     <h5 class="modal-title">Excluir disciplina</h5>
                     <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                         <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                     <span>Confirmar exclusão da disciplina</span>
                    <b> <asp:Label ID="LabelDisciplina" runat="server"></asp:Label> </b>
                 </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-success" data-dismiss="modal">Cancelar</button>
                    <asp:Button ID="Button3" runat="server" class="btn btn-danger"  Text="Excluir" OnClick="Excluir_Disciplina" />
                </div>
            </div>
      </div>
   </div>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALDisciplina" DataObjectTypeName="CPSI.Modelo.Disciplina" InsertMethod="Insert" UpdateMethod="Update"></asp:ObjectDataSource>
    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALDocumento"></asp:ObjectDataSource>
</asp:Content>
 

    
    