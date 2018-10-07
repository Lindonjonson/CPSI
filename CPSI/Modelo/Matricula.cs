using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CPSI.Modelo
{
    public class Matricula:Aluno
    {
  
        public int IdTurma { get; set;}
        public int Situacao { get; set;}
        public DateTime DataMatricula { get; set;}

        public Matricula()
        {



        }
        public Matricula(int IdAluno,int IdTurma,int Situacao ,DateTime DataMatricula,string AlunoNome, string Cpf)
        {

            this.IdAluno = IdAluno;
            this.IdTurma = IdTurma;
            this.Situacao = Situacao;
            this.DataMatricula = DataMatricula;
            this.Cpf = Cpf;
            this.AlunoNome = AlunoNome;

        }
        public Matricula(int IdAluno, int IdTurma, int Situacao, DateTime DataMatricula)
        {

            this.IdAluno = IdAluno;
            this.IdTurma = IdTurma;
            this.Situacao = Situacao;
            this.DataMatricula = DataMatricula;

        }
        public void CancelarMatricula()
        {

            Situacao = 0;

        }
    }
}