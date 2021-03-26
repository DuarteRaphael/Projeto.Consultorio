using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Projeto.Entidades;

namespace Projeto.DAL.Mappings
{
    public class PacienteMAP : EntityTypeConfiguration<Paciente>
    {
        public PacienteMAP()
        {
            //nome da tabela
            ToTable("PACIENTE");

            //chave primaria
            HasKey(p => p.IdPaciente);

            //colunas
            Property(p => p.IdPaciente).HasColumnName("IDPACIENTE");
            Property(p => p.Nome).HasColumnName("NOME").HasMaxLength(50).IsRequired();
            Property(p => p.DataNacimento).HasColumnName("DATANASCIMENTO").IsRequired();
            Property(p => p.Sexo).HasColumnName("GENERO").IsRequired();
            Property(p => p.CPF).HasColumnName("CPF").HasMaxLength(20).IsOptional();
            Property(p => p.RG).HasColumnName("RG").HasMaxLength(20).IsOptional();
            Property(p => p.Telefone).HasColumnName("TELEFONE").HasMaxLength(20).IsRequired();
            Property(p => p.IdFila).HasColumnName("IDFILA").IsRequired();
            //toda fila tem uma lista de pacientes
            HasRequired(p => p.Fila).WithMany(f => f.Pacientes).HasForeignKey(p => p.IdFila); //chave estrangeire
        }
    }
}
