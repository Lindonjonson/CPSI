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
        public List<Modelo.DocumentoDisciplina> listDocumento;
        public Disciplina()
        {
            this.idDisciplina = 0;
            this.disciplina = "";
            listDocumento = new List<DocumentoDisciplina>();
    }
        public Disciplina(int idDisciplina, string disciplina)
        {
            this.idDisciplina = idDisciplina;
            this.disciplina = disciplina;
            listDocumento = new List<DocumentoDisciplina>();

        }
        public bool existDocumento()
        {
            if (listDocumento.Count > 0)
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