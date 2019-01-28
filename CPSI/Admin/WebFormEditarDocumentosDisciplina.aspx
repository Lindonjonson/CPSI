<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Admin.Master" AutoEventWireup="true" CodeBehind="WebFormEditarDocumentosDisciplina.aspx.cs" Inherits="CPSI.Admin.WebFormEditarDocumentosDisciplina" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4 class="mt-3 mb-3">Alteração de documentos da disciplina <asp:Label ID="LabelDisciplina" CssClass="font-italic" runat="server"></asp:Label> </h4>
    <asp:GridView ID="GridViewDocumentos" CssClass="table table-hover" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" DataKeyNames="idDocumento" ShowHeaderWhenEmpty="true" OnLoad="GridViewDocumentos_Load" OnRowCommand="GridViewDocumentos_RowCommand">
        <Columns>
            <asp:BoundField DataField="documento" HeaderText="Documento" SortExpression="documento"></asp:BoundField>
            <asp:ButtonField CommandName="Adicionar"  ButtonType="Image"  ImageUrl="~/Assets/Icons/baseline_add_circle_outline_black_18dp.png" HeaderText="Adicionar" ></asp:ButtonField>
            <asp:ButtonField CommandName="Remover" Text="Remover" ImageUrl="~/Assets/Icons/baseline_remove_circle_outline_black_18dp.png" ButtonType="Image"  HeaderText="Remover"></asp:ButtonField>
        </Columns>
    </asp:GridView>
    <button type="button" data-target="#ModalAlterarDocumentos" data-toggle="modal" class="btn btn-danger">Alterar</button> 
    <asp:Button ID="Button1" OnClick="Cancelar_click" CssClass="btn btn-success" runat="server" Text="Cancelar" />
    <div class="modal fade" id="ModalAlterarDocumentos" tabindex="-1" role="dialog" aria-labelledby="ModalAlterarDocumentos" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                     <h5 class="modal-title">Alterar documento</h5>
                     <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                         <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <span>Confirmar alteração dos documentos da disciplina</span>
                </div>
                <div class="modal-footer">
                    <asp:Button ID="Button2" runat="server" Text="Editar" class="btn btn-secondary" OnClick="Editar_Documentos" />
                </div>
            </div>
      </div>
   </div>
    <asp:ObjectDataSource runat="server" ID="ObjectDataSource1" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALDocumento" ></asp:ObjectDataSource>
</asp:Content> 

