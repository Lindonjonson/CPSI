using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CPSI.Modelo
{
    public class Disciplina
    {
        public int idDisciplina { get; set; }
        public string disciplina { get; set; }
        public string codigo { get; set; }

        public Disciplina()
        {
            this.idDisciplina = 0;
            this.disciplina = "";
            this.codigo = "";
        }
        public Disciplina(int idDisciplina, string disciplina, string codigo)
        {
            this.idDisciplina = idDisciplina;
            this.disciplina = disciplina;
            this.codigo = codigo;
        }
        public Disciplina(string disciplina, string codigo)
        {
            this.idDisciplina = idDisciplina;
            this.disciplina = disciplina;
            this.codigo = codigo;
        }
    }
}