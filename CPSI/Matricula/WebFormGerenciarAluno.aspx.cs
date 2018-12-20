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
                Aluno = dALAluno.Select(Session["IdAluno"].ToString());
                Panel_ButtonExcluir.Visible = true;
                ButtonEditarAluno.Visible = true;
                if (!IsPostBack)
                {
                    LabelAluno.Text = Aluno.AlunoNome;
                    TextBoxAlunoNome.Text = Aluno.AlunoNome;
                    TextBoxCalendarDataNascimento.Text = Aluno.DataNascimento.ToShortDateString();
                    TextBoxCpf.Text = Aluno.Cpf;
                    TextBoxRg.Text = Aluno.Rg;
                    TextBoxRGOrgao.Text = Aluno.RGOrgao;
                    DropDownListEstadoCivil.SelectedValue = Aluno.EstadoCivil.ToString();
                    TextBoxNaturalidade.Text = Aluno.Naturalidade;
                    TextBoxNaturalidadeEstado.Text = Aluno.NaturalidadeEstado;
                    TextBoxEndereco.Text = Aluno.Endereco;
                    TextBoxBairro.Text = Aluno.Bairro;
                    TextBoxCidade.Text = Aluno.Cidade;
                    TextBoxEstado.Text = Aluno.Estado;
                    TextBoxTelefone1.Text = Aluno.Telefone1;
                    TextBoxTelefone2.Text = Aluno.Telefone2;
                    TextBoxContato.Text = Aluno.Contato;
                    TextBoxContatoTelefone.Text = Aluno.ContatoTelefone; 
                   
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
            Aluno.AlunoNome = TextBoxAlunoNome.Text;
            Aluno.DataNascimento = DateTime.Parse(TextBoxCalendarDataNascimento.Text);
            Aluno.Cpf = TextBoxCpf.Text;
            Aluno.Rg = TextBoxRg.Text;
            Aluno.RGOrgao = TextBoxRGOrgao.Text;
            Aluno.EstadoCivil = Convert.ToInt32(DropDownListEstadoCivil.SelectedItem.Value);
            Aluno.Naturalidade = TextBoxNaturalidade.Text;
            Aluno.NaturalidadeEstado = TextBoxNaturalidadeEstado.Text;
            Aluno.Endereco = TextBoxEndereco.Text;
            Aluno.Bairro = TextBoxBairro.Text;
            Aluno.Cidade = TextBoxCidade.Text;
            Aluno.Estado = TextBoxEstado.Text;
            Aluno.Telefone1 = TextBoxTelefone1.Text;
            Aluno.Telefone2 = TextBoxTelefone2.Text;
            Aluno.Contato = TextBoxContato.Text;
            Aluno.ContatoTelefone = TextBoxContatoTelefone.Text;
            dALAluno.Insert(Aluno);
            Response.Redirect("~/Matricula/WebFormVisualizarAlunos.aspx");
        }

        protected void EditarAluno_Click(object sender, EventArgs e)
        {
            DAL.DALAluno dALAluno = new DAL.DALAluno();
            Aluno.AlunoNome = TextBoxAlunoNome.Text;
            Aluno.DataNascimento = DateTime.Parse(TextBoxCalendarDataNascimento.Text);
            Aluno.Cpf = TextBoxCpf.Text;
            Aluno.Rg= TextBoxRg.Text;
            Aluno.RGOrgao =TextBoxRGOrgao.Text;
            Aluno.EstadoCivil = Convert.ToInt32(DropDownListEstadoCivil.SelectedItem.Value);
            Aluno.Naturalidade=TextBoxNaturalidade.Text;
            Aluno.NaturalidadeEstado=TextBoxNaturalidadeEstado.Text;
            Aluno.Endereco=TextBoxEndereco.Text;
            Aluno.Bairro = TextBoxBairro.Text;
            Aluno.Cidade=TextBoxCidade.Text;
            Aluno.Estado=TextBoxEstado.Text;
            Aluno.Telefone1=TextBoxTelefone1.Text;
            Aluno.Telefone2=TextBoxTelefone2.Text;
            Aluno.Contato=TextBoxContato.Text;
            Aluno.ContatoTelefone=TextBoxContatoTelefone.Text;
            dALAluno.Update(Aluno);
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
            dALAluno.Delete(Session["IdAluno"].ToString());
            Session.Remove("IdAluno");
            Response.Redirect("~/Matricula/WebFormVisualizarAlunos.aspx");
        }
    }
}