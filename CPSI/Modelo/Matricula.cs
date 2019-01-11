using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CPSI.Modelo
{
    public class Matricula
    {
        public int idAluno { get; set; }
        public int idTurma { get; set;}
        public int situacao { get; set;}
        public DateTime dataMatricula { get; set;}

        public Matricula()
        {



        }
       
        public Matricula(int IdAluno, int IdTurma, int Situacao, DateTime DataMatricula)
        {

            this.idAluno = IdAluno;
            this.idTurma = IdTurma;
            this.situacao = Situacao;
            this.dataMatricula = DataMatricula;

        }
       
    }
}