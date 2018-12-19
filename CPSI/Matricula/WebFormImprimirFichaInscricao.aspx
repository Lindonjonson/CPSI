<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormImprimirFichaInscricao.aspx.cs" Inherits="CPSI.Matricula.WebFormImprimirFichaInscricao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <asp:HyperLink runat="server">Inicial</asp:HyperLink>
    <form id="form1" runat="server">
        <asp:Button ID="Button_Imprimir" OnClick="Imprimir" runat="server" Text="Imprimir" />
        <asp:Panel Visible="false" ID="PanelImpressao" runat="server">
           

          <asp:FormView ID="FormViewAluno" runat="server" DataSourceID="ObjectDataSource1">
              <ItemTemplate>
                  Nome:
                  <asp:Label ID="AlunoNomeLabel" runat="server" Text='<%# Bind("AlunoNome") %>' />
                  <br />
                  Data Nascimento:
                  <asp:Label ID="DataNascimentoLabel" runat="server" Text='<%# Bind("DataNascimento") %>' />
                  <br />
                  CPF:
                  <asp:Label ID="CpfLabel" runat="server" Text='<%# Bind("Cpf") %>' />
                  <br />
                  RG:
                  <asp:Label ID="RgLabel" runat="server" Text='<%# Bind("Rg") %>' />
                  <br />
                  RG Orgão:
                  <asp:Label ID="RGOrgaoLabel" runat="server" Text='<%# Bind("RGOrgao") %>' />
                  <br />
                  Estado Civil:
                  <asp:Label ID="EstadoCivilLabel" runat="server" Text='<%# Bind("EstadoCivil") %>' />
                  <br />
                  Naturalidade:
                  <asp:Label ID="NaturalidadeLabel" runat="server" Text='<%# Bind("Naturalidade") %>' />
                  <br />
                  Naturalidade Estado:
                  <asp:Label ID="NaturalidadeEstadoLabel" runat="server" Text='<%# Bind("NaturalidadeEstado") %>' />
                  <br />
                  Endereço:
                  <asp:Label ID="EnderecoLabel" runat="server" Text='<%# Bind("Endereco") %>' />
                  <br />
                  Cidade:
                  <asp:Label ID="CidadeLabel" runat="server" Text='<%# Bind("Cidade") %>' />
                  <br />
                  Estado:
                  <asp:Label ID="EstadoLabel" runat="server" Text='<%# Bind("Estado") %>' />
                  <br />
                  Telefone1:
                  <asp:Label ID="Telefone1Label" runat="server" Text='<%# Bind("Telefone1") %>' />
                  <br />
                  Telefone2:
                  <asp:Label ID="Telefone2Label" runat="server" Text='<%# Bind("Telefone2") %>' />
                  <br />
                  Contato:
                  <asp:Label ID="ContatoLabel" runat="server" Text='<%# Bind("Contato") %>' />
                  <br />
                  Contato Telefone:
                  <asp:Label ID="ContatoTelefoneLabel" runat="server" Text='<%# Bind("ContatoTelefone") %>' />
                  <br />
              </ItemTemplate>
          </asp:FormView>
            <br/>
          
            <asp:FormView ID="FormViewTurma" runat="server" DataSourceID="ObjectDataSource2">
              <ItemTemplate>
                  NomeTurma:
                  <asp:Label Text='<%# Bind("NomeTurma") %>' runat="server" ID="NomeTurmaLabel" /><br />
                  ano:
                  <asp:Label Text='<%# Bind("ano") %>' runat="server" ID="anoLabel" /><br />
                  horario:
                  <asp:Label Text='<%# Bind("horario") %>' runat="server" ID="horarioLabel" /><br />
                  DataInicio:
                  <asp:Label Text='<%# Bind("DataInicio") %>' runat="server" ID="DataInicioLabel" /><br />
                  DataFim:
                  <asp:Label Text='<%# Bind("DataFim") %>' runat="server" ID="DataFimLabel" /><br />

              </ItemTemplate>
          </asp:FormView>
           
            <label>Declaro  para  os  devidos  fins,  que  as  informações  fornecidas  acima  são  totalmente  verdadeiras  e  me  comprometo  a  apresentar  a  cada  semestre  atestados  médicos  cardiológi
                cos  e  dermatológicos  ou  outros,  caso  seja  necessário  que  comprovem  a  minha  aptidão  para  participar  das  atividades  do  referido  Programa  de  Extensão  do  IFRN. </label>
                <br />
                <span>Natal(RN),</span> 
                <asp:Label runat="server" ID="LabelData"></asp:Label>
                <br/>
                <label>Assinatura participante:</label>
        </asp:Panel>
        <asp:ObjectDataSource runat="server" ID="ObjectDataSource1" SelectMethod="Select" TypeName="CPSI.DAL.DALAluno">
              <SelectParameters>
                  <asp:SessionParameter SessionField="IdAluno" DefaultValue="0" Name="id" Type="String"></asp:SessionParameter>
              </SelectParameters>
          </asp:ObjectDataSource>
         <asp:ObjectDataSource runat="server" ID="ObjectDataSource2" SelectMethod="Select" TypeName="CPSI.DAL.DALTurma">
                <SelectParameters>
                    <asp:SessionParameter SessionField="IdTurma" DefaultValue="0" Name="ID" Type="String"></asp:SessionParameter>
                </SelectParameters>
            </asp:ObjectDataSource>
    </form>
</body>
</html>