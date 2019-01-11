using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPSI.Matricula
{
    public partial class WebFormGerenciarAluno1 : System.Web.UI.Page
    {
        Modelo.Aluno Aluno;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Session["IdAluno"] == null))
            {
                DAL.DALAluno dALAluno = new DAL.DALAluno();
                Aluno = dALAluno.select(Session["IdAluno"].ToString());
                Panel_ButtonExcluir.Visible = true;
                ButtonEditarAluno.Visible = true;
                if (!IsPostBack)
                {
                    LabelAluno.Text = Aluno.alunoNome;
                    TextBoxAlunoNome.Text = Aluno.alunoNome;
                    TextBoxCalendarDataNascimento.Text = Aluno.dataNascimento.ToShortDateString();
                    TextBoxCpf.Text = Aluno.cpf;
                    TextBoxRg.Text = Aluno.rg;
                    TextBoxRGOrgao.Text = Aluno.rgOrgao;
                    DropDownListEstadoCivil.SelectedValue = Aluno.estadoCivil.ToString();
                    TextBoxNaturalidade.Text = Aluno.naturalidade;
                    TextBoxNaturalidadeEstado.Text = Aluno.naturalidadeEstado;
                    TextBoxEndereco.Text = Aluno.endereco;
                    TextBoxBairro.Text = Aluno.bairro;
                    TextBoxCidade.Text = Aluno.cidade;
                    TextBoxEstado.Text = Aluno.estado;
                    TextBoxTelefone1.Text = Aluno.telefone1;
                    TextBoxTelefone2.Text = Aluno.telefone2;
                    TextBoxContato.Text = Aluno.contato;
                    TextBoxContatoTelefone.Text = Aluno.contatoTelefone; 
                   
                }
                

            }
            else
            {

                ButtonInserirAluno.Visible = true;

            }
        }

        protected void InserirAluno_Click(object sender, EventArgs e)
        {
            DAL.DALAluno dALAluno = new DAL.DALAluno();
            Aluno = new Modelo.Aluno();
            Aluno.alunoNome = TextBoxAlunoNome.Text;
            Aluno.dataNascimento = DateTime.Parse(TextBoxCalendarDataNascimento.Text);
            Aluno.cpf = TextBoxCpf.Text;
            Aluno.rg = TextBoxRg.Text;
            Aluno.rgOrgao = TextBoxRGOrgao.Text;
            Aluno.estadoCivil = Convert.ToInt32(DropDownListEstadoCivil.SelectedItem.Value);
            Aluno.naturalidade = TextBoxNaturalidade.Text;
            Aluno.naturalidadeEstado = TextBoxNaturalidadeEstado.Text;
            Aluno.endereco = TextBoxEndereco.Text;
            Aluno.bairro = TextBoxBairro.Text;
            Aluno.cidade = TextBoxCidade.Text;
            Aluno.estado = TextBoxEstado.Text;
            Aluno.telefone1 = TextBoxTelefone1.Text;
            Aluno.telefone2 = TextBoxTelefone2.Text;
            Aluno.contato = TextBoxContato.Text;
            Aluno.contatoTelefone = TextBoxContatoTelefone.Text;
            dALAluno.insert(Aluno);
            Response.Redirect("~/Matricula/WebFormVisualizarAlunos.aspx");
        }

        protected void EditarAluno_Click(object sender, EventArgs e)
        {
            DAL.DALAluno dALAluno = new DAL.DALAluno();
            Aluno.alunoNome = TextBoxAlunoNome.Text;
            Aluno.dataNascimento = DateTime.Parse(TextBoxCalendarDataNascimento.Text);
            Aluno.cpf = TextBoxCpf.Text;
            Aluno.rg= TextBoxRg.Text;
            Aluno.rgOrgao =TextBoxRGOrgao.Text;
            Aluno.estadoCivil = Convert.ToInt32(DropDownListEstadoCivil.SelectedItem.Value);
            Aluno.naturalidade=TextBoxNaturalidade.Text;
            Aluno.naturalidadeEstado=TextBoxNaturalidadeEstado.Text;
            Aluno.endereco=TextBoxEndereco.Text;
            Aluno.bairro = TextBoxBairro.Text;
            Aluno.cidade=TextBoxCidade.Text;
            Aluno.estado=TextBoxEstado.Text;
            Aluno.telefone1=TextBoxTelefone1.Text;
            Aluno.telefone2=TextBoxTelefone2.Text;
            Aluno.contato=TextBoxContato.Text;
            Aluno.contatoTelefone=TextBoxContatoTelefone.Text;
            dALAluno.update(Aluno);
            Session.Remove("IdAluno");
            Response.Redirect("~/Matricula/WebFormVisualizarAlunos.aspx");

        }

        protected void Cancelar_Click(object sender, EventArgs e)
        {
            Session.Remove("IdAluno");
            Response.Redirect("~/Matricula/WebFormVisualizarAlunos.aspx");
        }

        protected void Excluir_Click(object sender, EventArgs e)
        {
            DAL.DALAluno dALAluno = new DAL.DALAluno();
            dALAluno.delete(Session["IdAluno"].ToString());
            Session.Remove("IdAluno");
            Response.Redirect("~/Matricula/WebFormVisualizarAlunos.aspx");
        }
    }
}