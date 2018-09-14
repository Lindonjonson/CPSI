using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CPSI.Modelo
{
    public class Turma
    {
        public int IdTurma { get; set; }
        public string NomeTurma { get; set; }
        public int ano { get; set; }
        public string horario { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int QtdVagas { get; set; }
        public int IdDisciplina { get; set; }
        public Turma()
        {

        }
        public Turma(int IdTurma, string  NomeTurma, int ano, string horario, DateTime DataInicio, DateTime DataFim, int QtdVagas, int IdDisciplina)
        {

            this.IdTurma =IdTurma;
            this.NomeTurma = NomeTurma;
            this.ano = ano;
            this.horario = horario;
            this.DataInicio = DataInicio;
            this.DataFim = DataFim;
            this.QtdVagas = QtdVagas;
            this.IdDisciplina = IdDisciplina;

        }

    }
}