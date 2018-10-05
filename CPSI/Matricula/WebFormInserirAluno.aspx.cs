using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPSI.Matricula
{
    public partial class WebFormInserirAluno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void InserirAluno_Click(object sender, EventArgs e)
        {
            Modelo.Aluno Aluno = new Modelo.Aluno(0, TextBoxAlunoNome.Text, CalendarDataNascimento.SelectedDate.Date, TextBoxCpf.Text
                                                 , TextBoxRg.Text, TextBoxRGOrgaox.Text, int.Parse(TextBoxEstadoCivil.Text),
                                                 TextBoxNaturalidade.Text, TextBoxNaturalidadeEstado.Text, TextBoxEndereco.Text,
                                                 TextBoxCidade.Text, TextBoxEstado.Text, TextBoxTelefone1.Text, TextBoxTelefone2.Text, TextBoxContato.Text, TextBoxContatoTelefone.Text);
            DAL.DALAluno Insert = new DAL.DALAluno();
            Insert.Insert(Aluno);
            Response.Redirect("~//Matricula//WebFormGerenciarAluno.aspx");
        }
    }
}