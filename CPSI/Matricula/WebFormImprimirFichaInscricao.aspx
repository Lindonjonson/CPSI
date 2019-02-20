<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormImprimirFichaInscricao.aspx.cs" Inherits="CPSI.Matricula.WebFormImprimirFichaInscricao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ficha inscrição</title>
    <link rel="stylesheet" media="print" href="../Assets/css/FichaInscricao.css" />
</head>
<body>
    <form id="form1" class="A4" runat="server">
      <div class="container">
         <header>
            <label>INSTITUTO FEDERAL DE EDUCAÇÃO, CIÊNCIA E TECNOLOGIA DO RIO GRANDE DO NORTE</label>
            <label>CAMPUS NATAL CENTRAL</label>
            <label>DIRETORIA DE EXTENSÃO</label>
         </header>
         <h1>Ficha de inscrição do Aluno <asp:label ID="TextBoxAluno" runat="server"></asp:label> de CPF  <asp:label ID="TextBoxCPF" runat="server"></asp:label> na turma  <asp:label ID="TextBoxTurma" runat="server"></asp:label></h1>
            <p class="Termo">
                Declaro  para  os  devidos  fins,  que  as  informações  fornecidas  acima  são  totalmente  verdadeiras  e  me  comprometo  a  apresentar  a  
                cada  semestre  atestados  médicos  cardiológicos  e  dermatológicos  ou  outros,  caso  seja  necessário  que  comprovem  a  minha  aptidão  para  
                participar  das  atividades  do  referido  Programa  de  Extensão  do  IFRN. 
                <br/>
                <span>Natal(RN),</span> 
                <asp:Label runat="server" ID="LabelData"></asp:Label>
                <br/>
            </p> 
            <p >
                _____________________________________________________________________
                <br />
                Assinatura participante:
            </p> 
      </div>
    </form>
</body>
</html>