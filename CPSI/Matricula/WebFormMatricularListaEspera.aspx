 <%@ Page Title="" Language="C#" MasterPageFile="~/Master/Matricula.Master" AutoEventWireup="true" CodeBehind="WebFormMatricularListaEspera.aspx.cs" Inherits="CPSI.Matricula.WebFormMatricularListaEspera" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:Panel ID="PanelConfirmação" runat="server">
         <span>Matricular aluno em lista de espera ? </span>
         <asp:Button ID="Button_Cancelar" runat="server" Text="Cancelar" OnClick="Click_Cancelar" />
    </asp:Panel>
    <div id="ModalConfirmacao" class="modal fade" role="dialog">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title">Confirmação</h4>
                </div>
                <div class="modal-body">
                    <p>
                        Confirmar matrícula do Aluno  

                    </p>
                </div>
                <div class="modal-footer">
                     <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                     <asp:Button ID="Button_Matricular" runat="server" Text="Salvar matrícula" OnClick="Button_Matricular_Click" />
                </div>
             </div>
        </div>
      
</div>
</asp:Content>
