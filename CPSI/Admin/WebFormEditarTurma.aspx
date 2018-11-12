<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Admin.Master" AutoEventWireup="true" CodeBehind="WebFormEditarTurma.aspx.cs" Inherits="CPSI.Admin.Turma.WebFormEditarTurma" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-decoration: underline;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DetailsView ID="DetailsViewTurma" runat="server" Height="50px" Width="125px" AutoGenerateRows="False" DataSourceID="ObjectDataSource1" CssClass="auto-style1"  DataKeyNames="IdTurma">
        <Fields>
           
            <asp:BoundField DataField="NomeTurma" HeaderText="NomeTurma" SortExpression="NomeTurma" />
            <asp:BoundField DataField="ano" HeaderText="ano" SortExpression="ano" />
            <asp:BoundField DataField="horario" HeaderText="horario" SortExpression="horario" />
            <asp:BoundField DataField="DataInicio" HeaderText="DataInicio" SortExpression="DataInicio" />
            <asp:BoundField DataField="DataFim" HeaderText="DataFim" SortExpression="DataFim" />
            <asp:BoundField DataField="QtdVagas" HeaderText="QtdVagas" SortExpression="QtdVagas" />
            <asp:BoundField DataField="IdDisciplina" HeaderText="IdDisciplina" SortExpression="IdDisciplina" />
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

    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="CPSI.Modelo.Turma" SelectMethod="Select" TypeName="CPSI.DAL.DALTurma" UpdateMethod="Update" DeleteMethod="Delete">
        <DeleteParameters>
            <asp:Parameter Name="id" Type="String"></asp:Parameter>
        </DeleteParameters>
        <SelectParameters>
            <asp:SessionParameter  SessionField="IdTurma" DefaultValue="" Name="ID" Type="String"></asp:SessionParameter>

        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:Panel CssClass="PanelExcluir" ID="PanelExcluir" runat="server">
        <span>Confirmar exclusão da turma</span>
        <asp:Label ID="LabelTurma" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="Button4" runat="server" Text="Cancelar" OnClick="Page_Load" />
        <asp:Button ID="Button3" runat="server" Text="Excluir" OnClick="Excluir_Click" />
    </asp:Panel>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Admin/WebFormGerenciarTurma.aspx">Voltar</asp:HyperLink>
    <br />
    
</asp:Content>
