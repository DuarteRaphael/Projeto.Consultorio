using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entidades
{
    public class Paciente
    {
        public int IdPaciente { get; set; }
        public string Nome { get; set; }
        public DateTime DataNacimento { get; set; }
        public Genero Sexo { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Telefone { get; set; }
        public int IdFila { get; set; }
        public Fila Fila { get; set; }
    }
}
