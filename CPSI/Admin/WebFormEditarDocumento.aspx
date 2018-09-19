<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Admin.Master" AutoEventWireup="true" CodeBehind="WebFormEditarDocumento.aspx.cs" Inherits="CPSI.Admin.Documento.WebFormEditarDocumento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DetailsView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1" AutoGenerateRows="False">
    <Fields>
        <asp:BoundField DataField="idDocumento" HeaderText="idDocumento" SortExpression="idDocumento" />
        <asp:BoundField DataField="documento" HeaderText="documento" SortExpression="documento" />
        <asp:CommandField ShowEditButton="True" />
    </Fields>
    </asp:DetailsView>
    
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="CPSI.Modelo.Documento" SelectMethod="Select" TypeName="CPSI.DAL.DALDocumento" UpdateMethod="Update">
        <SelectParameters>
            <asp:QueryStringParameter Name="ID" QueryStringField="ID" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
    
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Admin/WebFormGerenciarDocumento.aspx">Voltar</asp:HyperLink>
    <br />
    
</asp:Content>

