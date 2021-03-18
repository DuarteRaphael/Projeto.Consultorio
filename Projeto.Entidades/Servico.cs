using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entidades
{
    public class Servico
    {
        public int IdServico { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public decimal ParteMedico { get; set; }
        public decimal ParteClinica { get; set; }
    }
}
