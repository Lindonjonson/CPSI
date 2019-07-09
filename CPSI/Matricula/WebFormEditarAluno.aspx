<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Matricula.Master" AutoEventWireup="true" CodeBehind="WebFormEditarAluno.aspx.cs" Inherits="CPSI.Matricula.WebFormEditarAluno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DetailsView ID="DetailsViewAluno" runat="server" Height="50px" Width="125px" AutoGenerateRows="False" DataKeyNames="IdAluno" DataSourceID="ObjectDataSource1">
        <Fields>
            
            <asp:BoundField DataField="AlunoNome" HeaderText="AlunoNome" SortExpression="AlunoNome" />
            <asp:BoundField DataField="DataNascimento"  HeaderText="DataNascimento" SortExpression="DataNascimento" DataFormatString="{0:d}" />
            <asp:BoundField DataField="Cpf" HeaderText="Cpf" SortExpression="Cpf" />
            <asp:BoundField DataField="Rg" HeaderText="Rg" SortExpression="Rg" />
            <asp:BoundField DataField="RGOrgao" HeaderText="RGOrgao" SortExpression="RGOrgao" />
            <asp:BoundField DataField="EstadoCivil" HeaderText="EstadoCivil" SortExpression="EstadoCivil" />
            <asp:BoundField DataField="Naturalidade" HeaderText="Naturalidade" SortExpression="Naturalidade" />
            <asp:BoundField DataField="NaturalidadeEstado" HeaderText="NaturalidadeEstado" SortExpression="NaturalidadeEstado" />
            <asp:BoundField DataField="Endereco" HeaderText="Endereco" SortExpression="Endereco" />
            <asp:BoundField DataField="Cidade" HeaderText="Cidade" SortExpression="Cidade" />
            <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado" />
            <asp:BoundField DataField="Telefone1" HeaderText="Telefone1" SortExpression="Telefone1" />
            <asp:BoundField DataField="Telefone2" HeaderText="Telefone2" SortExpression="Telefone2" />
            <asp:BoundField DataField="Contato" HeaderText="Contato" SortExpression="Contato" />
            <asp:BoundField DataField="ContatoTelefone" HeaderText="ContatoTelefone" SortExpression="ContatoTelefone" />
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
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="CPSI.Modelo.Aluno"  SelectMethod="Select" TypeName="CPSI.DAL.DALAluno" UpdateMethod="Update">
        <SelectParameters>
            <asp:SessionParameter Name="id" SessionField="IdAluno" Type="String" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="DataNascimento" Type="DateTime" />
        </UpdateParameters>
    </asp:ObjectDataSource>
    <asp:Panel CssClass="PanelExcluir" ID="PanelExcluir" runat="server">
        <span>Confirmar exclusão de aluno</span>
        <asp:Label ID="LabelAluno" runat="server" Text="Label"></asp:Label>
        <span>de CPF</span>
        <asp:Label ID="LabelCPF" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="Button4" runat="server" Text="Cancelar" OnClick="Page_Load" />
        <asp:Button ID="Button3" runat="server" Text="Excluir" OnClick="Excluir_Click" />
    </asp:Panel>
</asp:Content>
