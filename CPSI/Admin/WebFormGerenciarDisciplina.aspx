<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Admin.Master" AutoEventWireup="true" CodeBehind="WebFormGerenciarDisciplina.aspx.cs" Inherits="CPSI.Admin.Disciplina.WebFormGerenciarCategoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4>Disciplinas</h4>
    <button data-target="ModalCadastrarDisciplina" class="btn modal-trigger">Cadastrar Disciplina</button>
    <asp:GridView ID="GridViewDisciplina" runat="server" AutoGenerateColumns="False" CssClass="highlight" DataSourceID="ObjectDataSource1" OnRowCommand="GridViewDisciplina_RowCommand"  ShowHeaderWhenEmpty="True" DataKeyNames="idDisciplina" OnSelectedIndexChanged="GridViewDisciplina_SelectedIndexChanged" EnableViewState="False" >
        <Columns>
            <asp:CommandField HeaderText="Operações" ShowEditButton="True" ShowSelectButton="True" />
            <asp:BoundField DataField="disciplina" HeaderText="Disciplina" SortExpression="disciplina" />
            <asp:ButtonField ButtonType="link" CommandName="EditarDocumento"  HeaderText="Documentos" ShowHeader="True" Text="Editar Documentos" ItemStyle-CssClass="btn cyan lighten-5" />
        </Columns>
    </asp:GridView>
   <button data-target="ModalExcluirDisciplina" class="btn modal-trigger red darken-1 styleADM_ButtonExcluir">Excluir Disciplina</button>
    <div id="ModalExcluirDisciplina" class="modal">
        <div class="modal-content">
            <span>Confirmar exclusão da disciplina</span>
            <asp:Label ID="LabelDisciplina" runat="server" Text="Label"></asp:Label>
            <asp:Button ID="Button4" runat="server" CssClass="btn green darken-1" Text="Cancelar" OnClick="Page_Load" />
            <asp:Button ID="Button3" runat="server" CssClass="btn red darken-1"  Text="Excluir" OnClick="Excluir_Disciplina" />
        </div>
    </div>
     <div id="ModalCadastrarDisciplina" class="modal">
        <div class="modal-content">
            <label>Nome disciplina</label>
            <asp:TextBox runat="server" ID="TxtNomeDisciplina" PlaceHolder="nome disciplina"></asp:TextBox>
            <label>Documentos obrigatorios para a disciplina</label>
            <asp:GridView ID="GridViewDocumentoDisciplina" runat="server" DataSourceID="ObjectDataSource2" AutoGenerateColumns="False" DataKeyNames="idDocumento" OnRowCommand="GridViewDocumentoDisciplina_RowCommand" ShowHeaderWhenEmpty="false" >
                <Columns>
                    <asp:BoundField DataField="documento" HeaderText="documento" SortExpression="documento"></asp:BoundField>
                    <asp:ButtonField CommandName="Adicionar" Text="Adicionar" ButtonType="Button" HeaderText="Adicionar"></asp:ButtonField>
                    <asp:ButtonField CommandName="Remover" Text="Remover" ButtonType="Button" HeaderText="Remover"></asp:ButtonField>
                </Columns>
            </asp:GridView>
            <asp:Button runat="server" Text="Inserir" CssClass="btn green darken-1" OnClick="Inserir_Click"> </asp:Button>
            <asp:Button ID="Button1" runat="server" Text="Cancelar" CssClass="btn red darken-1" OnClick="Page_Load" />

        </div>
    </div>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALDisciplina" DataObjectTypeName="CPSI.Modelo.Disciplina" InsertMethod="Insert" UpdateMethod="Update"></asp:ObjectDataSource>
    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALDocumento"></asp:ObjectDataSource>
</asp:Content>
 