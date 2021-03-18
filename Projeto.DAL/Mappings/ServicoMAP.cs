using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Projeto.Entidades;

namespace Projeto.DAL.Mappings
{
    public class ServicoMAP : EntityTypeConfiguration<Servico>
    {
        public ServicoMAP()
        {
            //Nome da Tabela
            ToTable("SERVICO");

            //chave primária
            HasKey(s => s.IdServico);

            //colunas
            Property(s => s.IdServico).HasColumnName("IDSERVICO");
            Property(s => s.Nome).HasColumnName("NOME").HasMaxLength(50).IsRequired();
            Property(s => s.Preco).HasColumnName("PRECO").HasPrecision(18, 2).IsRequired();
            Property(s => s.ParteMedico).HasColumnName("COMISSAOMEDICO").HasPrecision(18, 2).IsRequired();
            Property(s => s.ParteClinica).HasColumnName("COMISSAOCLINICA").HasPrecision(18, 2).IsRequired();
        }
    }
}
