using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Projeto.Repository.DataSource;

namespace Projeto.DAL.Persistence
{
    public class GenericRepository<T> where T : class
    {
        //método de criação
        public virtual void Insert(T obj)
        {
            using(Conexao con = new Conexao())
            {
                con.Entry(obj).State = EntityState.Added;
                con.SaveChanges();
            }
        }
        //método de atualização
        public virtual void update(T obj)
        {
            using(Conexao con = new Conexao())
            {
                con.Entry(obj).State = EntityState.Modified;
                con.SaveChanges();
            }
        }
    }
}
