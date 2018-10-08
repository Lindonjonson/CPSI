<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Matricula.Master" AutoEventWireup="true" CodeBehind="WebFormRegistrarDocumento.aspx.cs" Inherits="CPSI.Matricula.WebFormRegistrarDocumento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Matricula em <asp:Label ID="IDTituloDisciplina" runat="server"></asp:Label></h1>
    <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" DataSourceID="ObjectDataSource1"></asp:DetailsView> 
    Documentos necessários
    <asp:CheckBoxList ID="CheckBoxListDocumentos" runat="server" DataSourceID="ObjectDataSource2" DataTextField="documento" DataValueField="idDocumento"></asp:CheckBoxList>
    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="SelectALL" TypeName="CPSI.DAL.DALDocumentoDisciplina">
        <SelectParameters>
            <asp:SessionParameter Name="IdDisciplina" SessionField="IdDisciplina" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:ObjectDataSource runat="server" ID="ObjectDataSource1" SelectMethod="Select" TypeName="CPSI.DAL.DALAluno">
        <SelectParameters>
            <asp:SessionParameter SessionField="IdAluno" Name="id" Type="String"></asp:SessionParameter>
        </SelectParameters>
    </asp:ObjectDataSource>
    
</asp:Content>
