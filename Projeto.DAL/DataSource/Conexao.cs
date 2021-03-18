using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration; //connectionstring..
using System.Data.Entity; //entityframework..
using Projeto.Entidades; //entidades..
using Projeto.DAL.Mappings; //mapeamento..

namespace Projeto.Repository.DataSource
{
    //Regra 1) Classe de conexão deverá HERDAR DbContext..
    public class Conexao : DbContext
    {
        //Regra 2) Construtor que envie para o DbContext a connectionString..
        public Conexao()
            : base(ConfigurationManager.ConnectionStrings["aula"].ConnectionString)
        {

        }

        //Regra 3) Sobrescrever o método OnModelCreating..
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //definir para o DbContext cada classe de mapeamento..
            modelBuilder.Configurations.Add(new MedicoMAP());
            modelBuilder.Configurations.Add(new PacienteMAP());
            modelBuilder.Configurations.Add(new ServicoMAP());
        }

        //Regra 4) Declarar um DbSet para cada entidade..
        public DbSet<Medico> Medico { get; set; } //LAMBDA..
        public DbSet<Paciente> Paciente { get; set; } //LAMBDA..
        public DbSet<Servico> Servico { get; set; } //LAMBDA..

    }
}
