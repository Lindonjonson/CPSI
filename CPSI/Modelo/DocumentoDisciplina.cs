using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CPSI.Modelo
{
    public class DocumentoDisciplina
    {
        public int idDisciplina { get; set; }
        public int idDocumento { get; set; }
        public DocumentoDisciplina()
        {
            
        }
        public DocumentoDisciplina(int idDisciplina, int idDocumento)
        {
            this.idDisciplina = idDisciplina;
            this.idDocumento = idDocumento;
        }
       
    }
}