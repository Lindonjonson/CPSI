using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CPSI.Modelo
{
    public class ListaEspera : Aluno
    {
        public int IdTurma { get; set; }
        public DateTime DataMatricula { get; set; }

        public ListaEspera()
        {



        }
        public ListaEspera(int IdAluno, int IdTurma, int Situacao, DateTime DataMatricula, string AlunoNome, string Cpf)
        {

            this.IdAluno = IdAluno;
            this.IdTurma = IdTurma;
            this.DataMatricula = DataMatricula;
            this.Cpf = Cpf;
            this.AlunoNome = AlunoNome;

        }
        public ListaEspera(int IdAluno, int IdTurma, DateTime DataMatricula)
        {

            this.IdAluno = IdAluno;
            this.IdTurma = IdTurma;
            this.DataMatricula = DataMatricula;

        }

    }
}