using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CPSI.Modelo
{
    public class AlunoDocumento
    {
        public int idAluno {get; set;}
        public List<int> idDocumento = new List<int>();
        public AlunoDocumento()
        {

        }
        public AlunoDocumento(int idAluno, List<int> idDocumento)
        {
            this.idAluno = idAluno;
            this.idDocumento = idDocumento;

        }

    }
}