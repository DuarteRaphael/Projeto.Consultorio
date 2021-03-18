using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entidades
{
    public class Fila
    {
        public int IdFila { get; set; }
        public DateTime DataFila { get; set; }
        public List<Paciente> Pacientes { get; set; }
    }
}
