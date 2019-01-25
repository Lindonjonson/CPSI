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
        public List<Modelo.DocumentoDisciplina> listDocumentoDaDisciplinas;
        public Disciplina()
        {
            this.idDisciplina = 0;
            this.disciplina = "";

        }
        public Disciplina(int idDisciplina, string disciplina)
        {
            this.idDisciplina = idDisciplina;
            this.disciplina = disciplina;
            listDocumentoDaDisciplinas = new List<DocumentoDisciplina>();

        }
        public void  addDocumentoDisciplina(IList<int> listIddocumento)
        {
            foreach (int i in listIddocumento)
            {
                listDocumentoDaDisciplinas.Add(new Modelo.DocumentoDisciplina(idDisciplina, i));
            }
            
        }
        public bool existDocumento()
        {
            if (listDocumentoDaDisciplinas.Count > 0)
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