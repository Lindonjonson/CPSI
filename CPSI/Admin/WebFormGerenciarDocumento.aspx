<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Admin.Master" AutoEventWireup="true" CodeBehind="WebFormGerenciarDocumento.aspx.cs" Inherits="CPSI.Admin.Documento.WebFormGerenciarDocumento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <h4 class="mt-3 mb-3"> Tipos de Documento </h4>
    <asp:GridView ID="GridViewDocumentos" DataKeyNames="idDocumento" runat="server" CssClass="table table-hover" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" ShowHeaderWhenEmpty="True" OnSelectedIndexChanged="GridViewDocumentos_SelectedIndexChanged" EnableViewState="False" >
        <Columns>
            <asp:CommandField ShowEditButton="True" ShowSelectButton="True" HeaderText="Opera&#231;&#245;es" />
            <asp:BoundField DataField="documento" HeaderText="Documento" SortExpression="documento"></asp:BoundField>
            <asp:CheckBoxField DataField="validade" HeaderText="Validade" SortExpression="validade"></asp:CheckBoxField>
            <asp:BoundField DataField="tipo" HeaderText="Tipo" SortExpression="tipo" />
        </Columns>
    </asp:GridView>
    <button type="button" data-toggle="modal" data-target="#ModalExcluirDocumento" class="btn btn-danger">Excluir Documento</button>
    <button type="button" class="btn btn btn-primary" data-toggle="modal" data-target="#ModalCadastrarDocumento">Cadastrar Documento</button>
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
                    <asp:RadioButtonList ID="RadioButtonListValidadeDocumento" runat="server">
                        <asp:ListItem Value="1">Sim</asp:ListItem>
                        <asp:ListItem Value="0">Não</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:label  runat="server" Text="Tipo do documento"></asp:label>
                    <asp:DropDownList ID="DropDownListDocumentostipo" runat="server">
                        <asp:ListItem Value="1">Documento ligado oa Aluno </asp:ListItem>
                        <asp:ListItem Value="2">Documento ligado à Disciplina </asp:ListItem>
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
<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALDocumento" DataObjectTypeName="CPSI.Modelo.Documento" UpdateMethod="Update" DeleteMethod="Delete"></asp:ObjectDataSource>  
</asp:Content>
