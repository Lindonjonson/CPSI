using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CPSI.Modelo
{
    public class Aluno
    {
        public int IdAluno { get; set; }
        public string AlunoNome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string RGOrgao { get; set; }
        public int EstadoCivil { get; set; }
        public string Naturalidade { get; set; }
        public string NaturalidadeEstado { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Bairro { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Contato { get; set; }
        public string ContatoTelefone { get; set; }

        public Aluno()
        {



        }

        public Aluno(int IdAluno,string AlunoNome,DateTime DataNascimento, string Cpf, string Rg, string RGOrgao, int EstadoCivil,string Naturalidade,string NaturalidadeEstado,string Endereco,
                     string Bairro,string Cidade,string Estado,string Telefone1,string Telefone2,string Contato,string ContatoTelefone)
        {

            this.IdAluno = IdAluno;
            this.AlunoNome = AlunoNome;
            this.DataNascimento = DataNascimento;
            this.Cpf = Cpf;
            this.Rg = Rg;
            this.RGOrgao = RGOrgao;
            this.EstadoCivil = EstadoCivil;
            this.Naturalidade = Naturalidade;
            this.NaturalidadeEstado = NaturalidadeEstado;
            this.Endereco = Endereco;
            this.Bairro = Bairro;
            this.Cidade = Cidade;
            this.Estado = Estado;
            this.Telefone1 = Telefone1;
            this.Telefone2 = Telefone2;
            this.Contato = Contato;
            this.ContatoTelefone=ContatoTelefone;



        }

    }
}