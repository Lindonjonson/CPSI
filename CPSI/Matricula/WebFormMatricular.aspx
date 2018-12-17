<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Matricula.Master" AutoEventWireup="true" CodeBehind="WebFormMatricular.aspx.cs" Inherits="CPSI.Matricula.WebFormMatricular" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   Filtro:<asp:TextBox ID="TextBoxFiltro" runat="server"></asp:TextBox>
 Ano:<asp:TextBox ID="TextBoxAno" runat="server"></asp:TextBox>
    <asp:Button ID="Button_Consulta" runat="server" Text="Consultar" OnClick="Pesquisar_Click" />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
        <Columns>
            <asp:BoundField DataField="IdTurma" HeaderText="IdTurma" SortExpression="IdTurma" />
            <asp:BoundField DataField="NomeTurma" HeaderText="NomeTurma" SortExpression="NomeTurma" />
            <asp:BoundField DataField="ano" HeaderText="ano" SortExpression="ano" />
            <asp:BoundField DataField="horario" HeaderText="horario" SortExpression="horario" />
            <asp:BoundField DataField="DataInicio" HeaderText="DataInicio" SortExpression="DataInicio" />
            <asp:BoundField DataField="DataFim" HeaderText="DataFim" SortExpression="DataFim" />
            <asp:BoundField DataField="QtdVagas" HeaderText="QtdVagas" SortExpression="QtdVagas" />
            <asp:BoundField DataField="IdDisciplina" HeaderText="IdDisciplina" SortExpression="IdDisciplina" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="Select" TypeName="CPSI.DAL.DALTurma">
        <SelectParameters>
            <asp:ControlParameter ControlID="TextBoxFiltro" DefaultValue="" Name="filtro" PropertyName="Text" Size="20" Type="String" />
            <asp:ControlParameter ControlID="TextBoxAno" DefaultValue="0" Name="ano" PropertyName="Text" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>
