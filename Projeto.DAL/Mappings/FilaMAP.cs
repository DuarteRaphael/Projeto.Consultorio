using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Projeto.Entidades;

namespace Projeto.DAL.Mappings
{
    public class FilaMAP : EntityTypeConfiguration<Fila>
    {
        public FilaMAP()
        {
            //Nome da tabela
            ToTable("FILA");
            //Chave primárica
            HasKey(f => f.IdFila);
            //Colunas
            Property(f => f.IdFila).HasColumnName("IDFILA");
            Property(f => f.DataFila).HasColumnName("DATAFILA").IsRequired();
            Property(f => f.IdPaciente).HasColumnName("IDPACIENTE").IsRequired();

        }
    }
}
