<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormImprimirFichaInscricao.aspx.cs" Inherits="CPSI.Matricula.WebFormImprimirFichaInscricao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>INSTITUTO  FEDERAL  DE  EDUCAÇÃO,  CIÊNCIA  E  TECNOLOGIA  DO  RN  DIRETORIA  DE  EXTENSÃO  PROGRAMA  SAÚDE  E  CIDADANIA  NA  MELHOR  IDADE </h1>
        </div>
        <div>   
            <asp:FormView ID="FormView1" runat="server" DataSourceID="ObjectDataSource2">
                <ItemTemplate>
                    IdAluno:
                    <asp:Label Text='<%# Bind("IdAluno") %>' runat="server" ID="IdAlunoLabel" /><br />
                    AlunoNome:
                    <asp:Label Text='<%# Bind("AlunoNome") %>' runat="server" ID="AlunoNomeLabel" /><br />
                    DataNascimento:
                    <asp:Label Text='<%# Bind("DataNascimento") %>' runat="server" ID="DataNascimentoLabel" /><br />
                    Cpf:
                    <asp:Label Text='<%# Bind("Cpf") %>' runat="server" ID="CpfLabel" /><br />
                    Rg:
                    <asp:Label Text='<%# Bind("Rg") %>' runat="server" ID="RgLabel" /><br />
                    RGOrgao:
                    <asp:Label Text='<%# Bind("RGOrgao") %>' runat="server" ID="RGOrgaoLabel" /><br />
                    EstadoCivil:
                    <asp:Label Text='<%# Bind("EstadoCivil") %>' runat="server" ID="EstadoCivilLabel" /><br />
                    Naturalidade:
                    <asp:Label Text='<%# Bind("Naturalidade") %>' runat="server" ID="NaturalidadeLabel" /><br />
                    NaturalidadeEstado:
                    <asp:Label Text='<%# Bind("NaturalidadeEstado") %>' runat="server" ID="NaturalidadeEstadoLabel" /><br />
                    Endereco:
                    <asp:Label Text='<%# Bind("Endereco") %>' runat="server" ID="EnderecoLabel" /><br />
                    Cidade:
                    <asp:Label Text='<%# Bind("Cidade") %>' runat="server" ID="CidadeLabel" /><br />
                    Estado:
                    <asp:Label Text='<%# Bind("Estado") %>' runat="server" ID="EstadoLabel" /><br />
                    Telefone1:
                    <asp:Label Text='<%# Bind("Telefone1") %>' runat="server" ID="Telefone1Label" /><br />
                    Telefone2:
                    <asp:Label Text='<%# Bind("Telefone2") %>' runat="server" ID="Telefone2Label" /><br />
                    Contato:
                    <asp:Label Text='<%# Bind("Contato") %>' runat="server" ID="ContatoLabel" /><br />
                    ContatoTelefone:
                    <asp:Label Text='<%# Bind("ContatoTelefone") %>' runat="server" ID="ContatoTelefoneLabel" /><br />

                </ItemTemplate>
            </asp:FormView>
            <asp:ObjectDataSource runat="server" ID="ObjectDataSource2" SelectMethod="Select" TypeName="CPSI.DAL.DALAluno">
                <SelectParameters>
                    <asp:SessionParameter SessionField="IdAluno" Name="id" Type="String"></asp:SessionParameter>
                </SelectParameters>
            </asp:ObjectDataSource>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" Height="16px">
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
        <label>Declaro  para  os  devidos  fins,  que  as  informações  fornecidas  acima  são  totalmente  verdadeiras  e  me  comprometo  a  apresentar  a  cada  semestre  atestados  médicos  cardiológi
        cos  e  dermatológicos  ou  outros,  caso  seja  necessário  que  comprovem  a  minha  aptidão  para  participar  das  atividades  do  referido  Programa  de  Extensão  do  IFRN. </label>
        <br />
        <span>Natal(RN),</span> 
        <asp:Label runat="server" ID="LabelData"></asp:Label>
        <br/>
        <label>Assinatura participante:</label>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="Select" TypeName="CPSI.DAL.DALTurma">
            <SelectParameters>
                <asp:SessionParameter Name="ID" SessionField="IdTurma" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </form>
</body>
</html>
