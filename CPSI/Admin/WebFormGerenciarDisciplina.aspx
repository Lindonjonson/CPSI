<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Admin.Master" AutoEventWireup="true" CodeBehind="WebFormGerenciarDisciplina.aspx.cs" Inherits="CPSI.Admin.Disciplina.WebFormGerenciarCategoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:Button ID="ButtonMostrarCadastrarDisciplina" runat="server" Text="Cadastrar disciplina" CssClass="btn" OnClick="ExibirCadatrarClick" />
    <asp:Panel ID="PanelListagemDisciplina" runat="server">
        <h4>Disciplinas</h4>
        <asp:GridView ID="GridViewDisciplina" runat="server" AutoGenerateColumns="False" CssClass="highlight" DataSourceID="ObjectDataSource1" OnRowCommand="GridViewDisciplina_RowCommand"  ShowHeaderWhenEmpty="True" DataKeyNames="idDisciplina" OnSelectedIndexChanged="GridViewDisciplina_SelectedIndexChanged" EnableViewState="False" >
            <Columns>
                <asp:CommandField HeaderText="Operações" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="disciplina" HeaderText="Disciplina" SortExpression="disciplina" />
                <asp:ButtonField ButtonType="link" CommandName="EditarDocumento"  HeaderText="Documentos" ShowHeader="True" Text="Editar Documentos" ItemStyle-CssClass="btn cyan lighten-5" />
            </Columns>
        </asp:GridView>
   <button data-target="ModalExcluirDisciplina" class="btn modal-trigger red darken-1 styleADM_ButtonExcluir">Excluir Disciplina</button>
    </asp:Panel>   
    <div id="ModalExcluirDisciplina" class="modal">
        <div class="modal-content">
            <span>Confirmar exclusão da disciplina</span>
            <asp:Label ID="LabelDisciplina" runat="server" Text="Label"></asp:Label>
            <asp:Button ID="Button4" runat="server" CssClass="btn green darken-1" Text="Cancelar" OnClick="Page_Load" />
            <asp:Button ID="Button3" runat="server" CssClass="btn red darken-1"  Text="Excluir" OnClick="Excluir_Disciplina" />
        </div>
    </div>
    
    <asp:Panel ID="PanelCadastrarDisciplina" Visible="false"  runat="server">
            <asp:TextBox runat="server" ID="TxtNomeDisciplina" PlaceHolder="nome disciplina"></asp:TextBox>
            <label>Documentos obrigatorios para a disciplina</label>
        <asp:GridView ID="GridViewDocumentoDisciplina" CssClass="highlight" runat="server" DataSourceID="ObjectDataSource2" AutoGenerateColumns="False" DataKeyNames="idDocumento" OnRowCommand="GridViewDocumentoDisciplina_RowCommand">
            <Columns>
                <asp:BoundField DataField="documento" HeaderText="Documento" SortExpression="documento"></asp:BoundField>
                <asp:ButtonField CommandName="Adicionar"  ButtonType="Image"  ImageUrl="~/Assets/Icons/baseline_add_circle_outline_black_18dp.png" HeaderText="Adicionar" ></asp:ButtonField>
                <asp:ButtonField CommandName="Remover" Text="Remover" ImageUrl="~/Assets/Icons/baseline_remove_circle_outline_black_18dp.png" ButtonType="Image"  HeaderText="Remover"></asp:ButtonField>
            </Columns>
        </asp:GridView>
        <asp:Button runat="server" Text="Inserir" CssClass="btn green darken-1" OnClick="Inserir_Click"> </asp:Button>
        <asp:Button ID="ButtonCancelarInserir" runat="server" Text="Cancelar" CssClass="btn red darken-1" OnClick="Click_CancelarInsertDisciplina" />
    </asp:Panel>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALDisciplina" DataObjectTypeName="CPSI.Modelo.Disciplina" InsertMethod="Insert" UpdateMethod="Update"></asp:ObjectDataSource>
    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="SelectAll" TypeName="CPSI.DAL.DALDocumento"></asp:ObjectDataSource>
</asp:Content>
 