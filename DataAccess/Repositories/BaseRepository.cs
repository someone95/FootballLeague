using Common.Entities;
using DataAccess.DatabaseContext;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataAccess.Repositories
{
    public class BaseRepository<T> where T : BaseEntity
    {
        private GenericContext<T> Context { get; set; }
        private DbSet<T> Items { get; set; }

        public BaseRepository()
        {
            Context = new GenericContext<T>();
            Items = this.Context.Set<T>();
        }

        public List<T> GetAll()
        {
            return this.Items.ToList();
        }

        public void Save(T item)
        {
            if (item.Id <= 0)
            {
                Items.Add(item);
            }
            else
            {
                Context.Entry(item).State = EntityState.Modified;
            }
            Context.SaveChanges();
        }

        public void Delete(T item)
        {
            Context.Entry(item).State = EntityState.Deleted;
            Items.Remove(item);
            Context.SaveChanges();
        }

        public T GetById(int id)
        {
            return Items.Where(item => item.Id == id).FirstOrDefault();
        }
    }
}
