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
            this.idDisciplina = 0;
            this.idDocumento = 0;
        }
        public DocumentoDisciplina(int idDocumento, int idDisciplina)
        {
            this.idDisciplina = idDisciplina;
            this.idDocumento = idDocumento;
        }
    }
}