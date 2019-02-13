using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CPSI.Modelo
{
    public class AlunoDocumento
    {
        public int idAluno {get; set;}
        public int idDocumento { get; set; }
        public AlunoDocumento()
        {

        }
        public AlunoDocumento(int idAluno, int idDocumento)
        {
            this.idAluno = idAluno;
            this.idDocumento = idDocumento;

        }

    }
}