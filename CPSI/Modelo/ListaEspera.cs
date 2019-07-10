using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CPSI.Modelo
{
    public class ListaEspera
    {
          public int idTurma { get; set; }
          public int IdAluno { get; set; }
          public DateTime dataInscricao { get; set; }

          public ListaEspera()
          {



          }
          public ListaEspera(int IdTurma, int IdAluno,DateTime DataInscricao)
          {

            this.dataInscricao = DataInscricao;
            this.IdAluno = IdAluno;
            this.idTurma = IdTurma;

          }
    }
}