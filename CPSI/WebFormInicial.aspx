<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormInicial.aspx.cs" Inherits="CPSI.WebFormInicial" %>

<!DOCTYPE html>

<html>
<head runat="server">
<link rel="stylesheet" href="../Assets/css/bootstrap.min.css">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>CPSI</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1 class="mt-3 mb-3">CENTRO DE PROMOÇÃO À SAUDE DO IDOSO</h1>
            <div class="row mt-3 mb-3">
                <div class="col-md-12">
                     <div class="card w-100" style="width: 18rem;">
                        <div class="card-body">
                            <h5 class="card-title">Módulo administrador</h5>
                            <h6 class="card-subtitle mb-2 text-muted"></h6>
                            <p class="card-text">Gerenciar Documentos,Gerenciar Disciplinas, Gerenciar Turmas</p>
                            <asp:HyperLink ID="HyperLink1" CssClass="card-link" NavigateUrl="~/Admin/AdministradorInicial.aspx" runat="server">Entrar</asp:HyperLink>
                        </div>
                    </div>
                </div>
             </div>
               <div class="row mt-3 mb-3">
                <div class="col-md-12">
                     <div class="card w-100" style="width: 18rem;">
                        <div class="card-body">
                            <h5 class="card-title">Módulo Matrícula</h5>
                            <h6 class="card-subtitle mb-2 text-muted"></h6>
                            <p class="card-text">Visualizar turmas, Realizar Matrícula, Gerenciar Aluno</p>
                            <asp:HyperLink ID="HyperLink2" CssClass="card-link" NavigateUrl="~/Matricula/MatriculaInicial.aspx" runat="server">Entrar</asp:HyperLink>
                        </div>
                    </div>
                </div>
             </div>
              <div class="row mt-3 mb-3">
                <div class="col-md-12">
                     <div class="card w-100" style="width: 18rem;">
                        <div class="card-body">
                            <h5 class="card-title">Módulo Coordenação</h5>
                            <h6 class="card-subtitle mb-2 text-muted"></h6>
                            <p class="card-text">Visualizar Documentação, Registrar Trancamento de Matrícula <br />
                                Registrar Atestado Médico, Registrar Mudança de Turma, Visualizar Contato de Emergência
                            </p>
                            <asp:HyperLink ID="HyperLink3" CssClass="card-link" NavigateUrl="~/Coordenacao/CoordenacaoInicial.aspx" runat="server">Entrar</asp:HyperLink>
                        </div>
                    </div>
                </div>
             </div>
        </div>
    </form>
   <script type="text/javascript" src="../Assets/js/jquery-3.3.1.min.js"></script>
   <script type="text/javascript" src="../Assets/js/bootstrap.min.js"></script>
</body>
</html>
