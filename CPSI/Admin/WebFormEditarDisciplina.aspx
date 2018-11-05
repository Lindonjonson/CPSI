﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Admin.Master" AutoEventWireup="true" CodeBehind="WebFormEditarDisciplina.aspx.cs" Inherits="CPSI.Admin.Disciplina.WebFormEditarDisciplina" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" AutoGenerateRows="False" DataSourceID="ObjectDataSource1">
        <Fields>
            <asp:BoundField DataField="idDisciplina" HeaderText="idDisciplina" SortExpression="idDisciplina" />
            <asp:BoundField DataField="disciplina" HeaderText="disciplina" SortExpression="disciplina" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource2" DataTextField="documento" DataValueField="idDocumento"></asp:DropDownList>
                    <asp:ObjectDataSource runat="server" ID="ObjectDataSource2" SelectMethod="SelectALL" TypeName="CPSI.DAL.DALDocumentoDisciplina">
                        <SelectParameters>
                            <asp:SessionParameter SessionField="IdDisciplina" Name="IdDisciplina" Type="String"></asp:SessionParameter>
                        </SelectParameters>
                    </asp:ObjectDataSource>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CommandField ShowEditButton="True"></asp:CommandField>
        </Fields>
    </asp:DetailsView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="CPSI.Modelo.Disciplina" SelectMethod="Select" TypeName="CPSI.DAL.DALDisciplina" UpdateMethod="Update">
        <SelectParameters>
            <asp:SessionParameter SessionField="IdDisciplina" Name="ID" Type="String"></asp:SessionParameter>
        </SelectParameters>
    </asp:ObjectDataSource>
    <br />
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Admin/WebFormGerenciarDisciplina.aspx">Voltar</asp:HyperLink>
</asp:Content>
