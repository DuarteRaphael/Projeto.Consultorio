using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Projeto.Entidades;

namespace Projeto.DAL.Mappings
{
    public class MedicoMAP : EntityTypeConfiguration<Medico>
    {
        public MedicoMAP()
        {
            //nome da Tabela
            ToTable("MEDICO");
            //chave primária
            HasKey(m => m.IdMedico);
            //demais propiedades
            Property(m => m.IdMedico).HasColumnName("IDMEDICO");
            Property(m => m.Nome).HasColumnName("NOME").HasMaxLength(50).IsRequired();
            Property(m => m.CRM).HasColumnName("CRM").HasMaxLength(20).IsRequired();
        }
    }
}
