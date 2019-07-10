using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CPSI.Modelo
{
    public class Aluno
    {
        public int idAluno { get; set; }
        public string alunoNome { get; set; }
        public DateTime dataNascimento { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public string rgOrgao { get; set; }
        public int estadoCivil { get; set; }
        public string naturalidade { get; set; }
        public string naturalidadeEstado { get; set; }
        public string endereco { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string bairro { get; set; }
        public string telefone1 { get; set; }
        public string telefone2 { get; set; }
        public string contato { get; set; }
        public string contatoTelefone { get; set; }
        public IList<Modelo.AlunoDocumento> ListAlunoDocumento;
        public Aluno()
        {

            ListAlunoDocumento = new List<Modelo.AlunoDocumento>();

        }

        public Aluno(int IdAluno,string AlunoNome,DateTime DataNascimento, string Cpf, string Rg, string RGOrgao, int EstadoCivil,string Naturalidade,string NaturalidadeEstado,string Endereco,
                     string Bairro,string Cidade,string Estado,string Telefone1,string Telefone2,string Contato,string ContatoTelefone)
        {

            this.idAluno = IdAluno;
            this.alunoNome = AlunoNome;
            this.dataNascimento = DataNascimento;
            this.cpf = Cpf;
            this.rg = Rg;
            this.rgOrgao = RGOrgao;
            this.estadoCivil = EstadoCivil;
            this.naturalidade = Naturalidade;
            this.naturalidadeEstado = NaturalidadeEstado;
            this.endereco = Endereco;
            this.bairro = Bairro;
            this.cidade = Cidade;
            this.estado = Estado;
            this.telefone1 = Telefone1;
            this.telefone2 = Telefone2;
            this.contato = Contato;
            this.contatoTelefone=ContatoTelefone;
            ListAlunoDocumento = new List<Modelo.AlunoDocumento>();
        }
        public bool existDocumento()
        {
            if (ListAlunoDocumento.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}