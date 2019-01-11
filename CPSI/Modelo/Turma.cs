using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CPSI.Modelo
{
    public class Turma
    {
        public int idTurma { get; set; }
        public string nomeTurma { get; set; }
        public int ano { get; set; }
        public string horario { get; set; }
        public DateTime dataInicio { get; set; }
        public DateTime dataFim { get; set; }
        public int qtdVagas { get; set; }
        public int idDisciplina { get; set; }
        public Turma()
        {

        }
        public Turma(int IdTurma, string  NomeTurma, int ano, string horario, DateTime DataInicio, DateTime DataFim, int QtdVagas, int IdDisciplina)
        {

            this.idTurma =IdTurma;
            this.nomeTurma = NomeTurma;
            this.ano = ano;
            this.horario = horario;
            this.dataInicio = DataInicio;
            this.dataFim = DataFim;
            this.qtdVagas = QtdVagas;
            this.idDisciplina = IdDisciplina;

        }

    }
}