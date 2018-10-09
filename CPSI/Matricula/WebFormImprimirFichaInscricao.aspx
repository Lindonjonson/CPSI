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
                <h3>Dados Alunos</h3>
                IdAluno:
                <asp:TextBox ID="IdAlunoTextBox" runat="server" Text='<%# Bind("IdAluno") %>' />
                <br />
                AlunoNome:
                <asp:TextBox ID="AlunoNomeTextBox" runat="server" Text='<%# Bind("AlunoNome") %>' />
                <br />
                DataNascimento:
                <asp:TextBox ID="DataNascimentoTextBox" runat="server" Text='<%# Bind("DataNascimento") %>' />
                <br />
                Cpf:
                <asp:TextBox ID="CpfTextBox" runat="server" Text='<%# Bind("Cpf") %>' />
                <br />
                Rg:
                <asp:TextBox ID="RgTextBox" runat="server" Text='<%# Bind("Rg") %>' />
                <br />
                RGOrgao:
                <asp:TextBox ID="RGOrgaoTextBox" runat="server" Text='<%# Bind("RGOrgao") %>' />
                <br />
                EstadoCivil:
                <asp:TextBox ID="EstadoCivilTextBox" runat="server" Text='<%# Bind("EstadoCivil") %>' />
                <br />
                Naturalidade:
                <asp:TextBox ID="NaturalidadeTextBox" runat="server" Text='<%# Bind("Naturalidade") %>' />
                <br />
                NaturalidadeEstado:
                <asp:TextBox ID="NaturalidadeEstadoTextBox" runat="server" Text='<%# Bind("NaturalidadeEstado") %>' />
                <br />
                Endereco:
                <asp:TextBox ID="EnderecoTextBox" runat="server" Text='<%# Bind("Endereco") %>' />
                <br />
                Cidade:
                <asp:TextBox ID="CidadeTextBox" runat="server" Text='<%# Bind("Cidade") %>' />
                <br />
                Estado:
                <asp:TextBox ID="EstadoTextBox" runat="server" Text='<%# Bind("Estado") %>' />
                <br />
                Telefone1:
                <asp:TextBox ID="Telefone1TextBox" runat="server" Text='<%# Bind("Telefone1") %>' />
                <br />
                Telefone2:
                <asp:TextBox ID="Telefone2TextBox" runat="server" Text='<%# Bind("Telefone2") %>' />
                <br />
                Contato:
                <asp:TextBox ID="ContatoTextBox" runat="server" Text='<%# Bind("Contato") %>' />
                <br />
                ContatoTelefone:
                <asp:TextBox ID="ContatoTelefoneTextBox" runat="server" Text='<%# Bind("ContatoTelefone") %>' />
                <br />
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
