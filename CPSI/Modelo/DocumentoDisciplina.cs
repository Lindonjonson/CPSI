using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CPSI.Modelo
{
    public class DocumentoDisciplina
    {
        public int idDisciplina { get; set; }
        public List<int> idDocumento = new List<int>(); 
        public DocumentoDisciplina()
        {
            
        }
        public DocumentoDisciplina(List<int> idDocumento,int idDisciplina)
        {
            this.idDocumento = idDocumento;
            this.idDisciplina = idDisciplina;
        }
    }
}