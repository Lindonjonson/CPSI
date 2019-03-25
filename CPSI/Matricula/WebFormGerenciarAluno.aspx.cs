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
                carregarItemEdicao();
                PanelAlterarAluno.Visible = true;
            }
            else
            {
               PanelAdicionarAluno.Visible = true;
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
            foreach (ListItem I in CheckBoxListDocumentosAluno.Items)
            {
                if (I.Selected)
                    Aluno.ListAlunoDocumento.Add(new Modelo.AlunoDocumento(0, int.Parse(I.Value)));
            }
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
        protected void Excluir_Click(object sender, EventArgs e)
        {
            DAL.DALAluno dALAluno = new DAL.DALAluno();
            dALAluno.delete(Session["IdAluno"].ToString());
            Session.Remove("IdAluno");
            Response.Redirect("~/Matricula/WebFormVisualizarAlunos.aspx");
        }
        protected void Cancelar_Click(object sender, EventArgs e)
        {
            Session.Remove("IdAluno");
            Response.Redirect("~/Matricula/WebFormVisualizarAlunos.aspx");
        }
        public void carregarItemEdicao()
        {
            DAL.DALAluno dALAluno = new DAL.DALAluno();
            Aluno = dALAluno.select(Session["IdAluno"].ToString());
            if (!IsPostBack)
            {
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

        protected void Button_Validar_Click(object sender, EventArgs e)
        {
            bool exibir = false; 
            if (!String.IsNullOrEmpty(TextBoxAlunoNome.Text))
            {
                TextBoxAlunoNome.ReadOnly = true;
                exibir = true;
                TextBoxAlunoNome.BorderColor = System.Drawing.Color.Green;
            }
            else
            {
                TextBoxAlunoNome.BorderColor = System.Drawing.Color.Red;
                exibir = false;
            }
               
                
            if (!String.IsNullOrEmpty(TextBoxCalendarDataNascimento.Text) && TextBoxCalendarDataNascimento.Text.Length==10)
            {
                TextBoxCalendarDataNascimento.ReadOnly = true;
                exibir = true;
                TextBoxCalendarDataNascimento.BorderColor = System.Drawing.Color.Green;
            }

            else
            {
                TextBoxCalendarDataNascimento.BorderColor = System.Drawing.Color.Red;
                exibir = false;
            }
           
            if (!String.IsNullOrEmpty(TextBoxCpf.Text) && TextBoxCpf.Text.Length == 14) 
            {
                TextBoxCpf.ReadOnly = true;
                exibir = true;
                TextBoxCpf.BorderColor = System.Drawing.Color.Green;
            }

            else
            {
                TextBoxCpf.BorderColor = System.Drawing.Color.Red;
                exibir = false;
            }
            
            if (!String.IsNullOrEmpty(TextBoxRg.Text))
            {
                TextBoxRg.ReadOnly = true;
                exibir = true;
                TextBoxRg.BorderColor = System.Drawing.Color.Green;
            }
            else
            {
                TextBoxRg.BorderColor = System.Drawing.Color.Red;
                exibir = false;
            }
            
            if (!String.IsNullOrEmpty(TextBoxRGOrgao.Text))
            {
                TextBoxRGOrgao.ReadOnly = true;
                exibir = true;
                TextBoxRGOrgao.BorderColor = System.Drawing.Color.Green;
            }
            else
            {
                TextBoxRGOrgao.BorderColor = System.Drawing.Color.Red;
                exibir = false;
            }
            
            if (!String.IsNullOrEmpty(TextBoxNaturalidade.Text))
            {
                TextBoxNaturalidade.ReadOnly = true;
                exibir = true;
                TextBoxNaturalidade.BorderColor = System.Drawing.Color.Green;
            }
            else
            {
                TextBoxNaturalidade.BorderColor = System.Drawing.Color.Red;
                exibir = false;
            }
           
            if (!String.IsNullOrEmpty(TextBoxNaturalidadeEstado.Text))
            {
                TextBoxNaturalidadeEstado.ReadOnly = true;
                exibir = true;
                TextBoxNaturalidadeEstado.BorderColor = System.Drawing.Color.Green;
            }
            else
            {
                TextBoxNaturalidadeEstado.BorderColor = System.Drawing.Color.Red;
                exibir = false;
            }
            
            if (!String.IsNullOrEmpty(TextBoxEndereco.Text))
            {
                TextBoxEndereco.ReadOnly = true;
                exibir = true;
                TextBoxEndereco.BorderColor = System.Drawing.Color.Green;
            }
            else
            {
                TextBoxEndereco.BorderColor = System.Drawing.Color.Red;
                exibir = false;
            }
           
            if (!String.IsNullOrEmpty(TextBoxBairro.Text))
            {
                TextBoxBairro.ReadOnly = true;
                exibir = true;
                TextBoxBairro.BorderColor = System.Drawing.Color.Green;
            }
            else
            {
                TextBoxBairro.BorderColor = System.Drawing.Color.Red;
                exibir = false;
            }
           
            if (!String.IsNullOrEmpty(TextBoxCidade.Text))
            {
                TextBoxCidade.ReadOnly = true;
                exibir = true;
                TextBoxCidade.BorderColor = System.Drawing.Color.Green;
            }
            else
            {
                TextBoxCidade.BorderColor = System.Drawing.Color.Red;
                exibir = false;
            }
            
            if (!String.IsNullOrEmpty(TextBoxEstado.Text))
            {
                TextBoxEstado.ReadOnly = true;
                exibir = true;
                TextBoxEstado.BorderColor = System.Drawing.Color.Green;
            }
            else
            {
                TextBoxEstado.BorderColor = System.Drawing.Color.Red;
                exibir = false;
            }
           
            if (!String.IsNullOrEmpty(TextBoxTelefone1.Text))
            {
                TextBoxTelefone1.ReadOnly = true;
                exibir = true;
                TextBoxTelefone1.BorderColor = System.Drawing.Color.Green;
            }
            else
            {
                TextBoxTelefone1.BorderColor = System.Drawing.Color.Red;
                exibir = false;
            }
           
            if (!String.IsNullOrEmpty(TextBoxTelefone2.Text))
            {
                TextBoxTelefone2.ReadOnly = true;
                exibir = true;
                TextBoxTelefone2.BorderColor = System.Drawing.Color.Green;
            }
            else
            {
                TextBoxTelefone2.BorderColor = System.Drawing.Color.Red;
                exibir = false;
            }
           
            if (!String.IsNullOrEmpty(TextBoxContato.Text))
            {
                TextBoxContato.ReadOnly = true;
                exibir = true;
                TextBoxContato.BorderColor = System.Drawing.Color.Green;
            }
            else
            {
                TextBoxContato.BorderColor = System.Drawing.Color.Red;
                exibir = false;
            }
           
            if (!String.IsNullOrEmpty(TextBoxContatoTelefone.Text))
            {
                TextBoxContatoTelefone.ReadOnly = true;
                exibir = true;
                TextBoxContatoTelefone.BorderColor = System.Drawing.Color.Green;
            }
            else
            {
                TextBoxContatoTelefone.BorderColor = System.Drawing.Color.Red;
                exibir = false;
            }
            if (exibir)
            {
                button_Inserir.Visible = true;
                Button_Validar_Inserir.Visible = false;
                button_Atualizar.Visible = true;
                Button_Validar_Atualizar.Visible= false;
            }
           

        }
    }
}