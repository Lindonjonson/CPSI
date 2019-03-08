<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Admin.Master" AutoEventWireup="true" CodeBehind="WebFormGerenciarDocumento.aspx.cs" Inherits="CPSI.Admin.Documento.WebFormGerenciarDocumento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="PanelVisualizaçãoDocumento" runat="server">
        <h4 class="mt-3 mb-3"> Tipos de Documento </h4>
        <asp:GridView ID="GridViewDocumentos" DataKeyNames="idDocumento" runat="server" CssClass="table table-hover" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" ShowHeaderWhenEmpty="True" OnSelectedIndexChanged="GridViewDocumentos_SelectedIndexChanged" OnRowCommand="GridViewDocumentos_RowCommand" EnableViewState="False" >
            <Columns>
                <asp:CommandField ShowSelectButton="True" HeaderText="Selecionar" ></asp:CommandField>
                <asp:ButtonField CommandName="Editar" HeaderText="Editar" Text="Editar"></asp:ButtonField>
                <asp:BoundField DataField="documento" HeaderText="Documento" SortExpression="documento"></asp:BoundField>
                <asp:CheckBoxField DataField="validade" HeaderText="Validade" SortExpression="validade"></asp:CheckBoxField>
            </Columns>
        </asp:GridView>
        <button type="button" data-toggle="modal" data-target="#ModalExcluirDocumento" class="btn btn-danger">Excluir Documento</button>
        <button type="button" class="btn btn btn-primary" data-toggle="modal" data-target="#ModalCadastrarDocumento">Cadastrar Documento</button>
    </asp:Panel>
   
    <asp:Panel ID="PanelEdicaoDocumento" Visible="false" runat="server">
      <label>Documento</label>
      <asp:TextBox ID="TextBoxDocumento" runat="server"></asp:TextBox>
      <label>Documento apresenta validade? </label>
      <asp:DropDownList ID="DropDownListValidadeAtualizacao" runat="server">
           <asp:ListItem Value="1">Sim</asp:ListItem>
           <asp:ListItem Value="0">Não</asp:ListItem>
       </asp:DropDownList>
        <label>Tipo de documento</label>
        <asp:DropDownList ID="DropDownListTipoDocumentoAtualizacao" runat="server">
            <asp:ListItem Value="1">Documento ligado ao Aluno </asp:ListItem>
            <asp:ListItem Value="2">Documento ligado à Disciplina </asp:ListItem>
            <asp:ListItem Value="3">Documento não apresentado </asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="ButtonAtualizarDocumento" runat="server" OnClick="ButtonAtualizarDocumento_Click"  Text="Confirmar" />
        <asp:Button ID="ButtonCancelarEdicao" runat="server" Text="Cancelar Edição" OnClick="ButtonCancelarEdicao_Click" />
    </asp:Panel>
    <div class="modal fade" id="ModalCadastrarDocumento" tabindex="-1" role="dialog" aria-labelledby="ModalCadastrarDocumento" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                     <h5 class="modal-title">Inserir documento</h5>
                     <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                         <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <asp:label  runat="server" Text="Nome documento"></asp:label>
                    <asp:textbox runat="server" ID="txtDocumento"></asp:textbox>
                    <br />
                    <asp:label  runat="server" Text="Documento apresenta validade?"></asp:label>
                    <asp:DropDownList ID="DropDownListValidadeInsercao" runat="server">
                        <asp:ListItem Value="1">Sim</asp:ListItem>
                        <asp:ListItem Value="0">Não</asp:ListItem>
                    </asp:DropDownList>
                    <asp:label  runat="server" Text="Tipo do documento"></asp:label>
                    <asp:DropDownList ID="DropDownListTipoDocumentoInsercao" runat="server">
                        <asp:ListItem Value="1">Documento ligado ao Aluno </asp:ListItem>
                        <asp:ListItem Value="2">Documento ligado à Disciplina </asp:ListItem>
                        <asp:ListItem Value="3">Documento não apresentado </asp:ListItem>
                    </asp:DropDownList>
                 </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>
                    <asp:button runat="server" click="CadastrarDocumento" CssClass="btn btn-success" Text="Cadastrar" OnClick="Inserir_Click" />

                </div>
            </div>
      </div>
   </div>
    
    <div class="modal fade" id="ModalExcluirDocumento" tabindex="-1" role="dialog" aria-labelledby="ModalExcluirDocumento" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                     <h5 class="modal-title">Excluir documento</h5>
                     <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                         <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <asp:label  runat="server" Text="Nome documento:"></asp:label>
                   <b> <asp:label runat="server" ID="LabelDocumento"></asp:label> </b>
                 </div>
                <div class="modal-footer">
                     <button type="button" class="btn btn-success" data-dismiss="modal">Cancelar</button>
                     <asp:Button runat="server" ID="Button3"  Text="Excluir" cssclass="btn btn-danger" OnClick="Excluir_Documento" />
                </div>
            </div>
      </div>
   </div>
<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALDocumento" DataObjectTypeName="CPSI.Modelo.Documento" ></asp:ObjectDataSource>  
</asp:Content>
