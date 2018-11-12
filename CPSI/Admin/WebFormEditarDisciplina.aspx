<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Admin.Master" AutoEventWireup="true" CodeBehind="WebFormEditarDisciplina.aspx.cs" Inherits="CPSI.Admin.Disciplina.WebFormEditarDisciplina" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DetailsView ID="DetailsViewDisciplina" runat="server" Height="50px" Width="125px" AutoGenerateRows="False" DataSourceID="ObjectDataSource1" DataKeyNames="idDisciplina">
        <Fields>
           
            <asp:BoundField DataField="disciplina" HeaderText="disciplina" SortExpression="disciplina" />
            <asp:TemplateField HeaderText="Documentos obrigatorios">
                <ItemTemplate>
                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource2" DataTextField="documento" DataValueField="idDocumento"></asp:DropDownList>
                    <asp:ObjectDataSource runat="server" ID="ObjectDataSource2" SelectMethod="SelectALL" TypeName="CPSI.DAL.DALDocumentoDisciplina">
                        <SelectParameters>
                            <asp:SessionParameter SessionField="IdDisciplina" Name="IdDisciplina" Type="String"></asp:SessionParameter>
                        </SelectParameters>
                    </asp:ObjectDataSource>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField ShowHeader="False">
                <EditItemTemplate>
                    <asp:Button ID="Button1" runat="server" CausesValidation="True" CommandName="Update" Text="Atualizar" />
                    &nbsp;<asp:Button ID="Button2" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Button ID="Button1" runat="server" CausesValidation="False" CommandName="Edit" Text="Editar" />
                    <input id="Button"  OnClick="ExibirExcluir()" type="button" value="Excluir" />
                </ItemTemplate>
            </asp:TemplateField>
        </Fields>
    </asp:DetailsView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="CPSI.Modelo.Disciplina" SelectMethod="Select" TypeName="CPSI.DAL.DALDisciplina" UpdateMethod="Update">
        <SelectParameters>
            <asp:SessionParameter SessionField="IdDisciplina" Name="ID" Type="String"></asp:SessionParameter>
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:Panel CssClass="PanelExcluir" ID="PanelExcluir" runat="server">
        <span>Confirmar exclusão da disciplina</span>
        <asp:Label ID="Labeldisciplina" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="Button4" runat="server" Text="Cancelar" OnClick="Page_Load" />
        <asp:Button ID="Button3" runat="server" Text="Excluir" OnClick="Excluir_Click" />
    </asp:Panel>
    <br />
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Admin/WebFormGerenciarDisciplina.aspx">Voltar</asp:HyperLink>
</asp:Content>
