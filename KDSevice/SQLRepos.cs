using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KDControl;
using Microsoft.EntityFrameworkCore;

namespace KDControl
{
    public class SQLRepository<T> : IRepository<T> where T : EntityBase
    {
        protected readonly AppDbContex context;
        private readonly DbSet<T>  entity;
        public SQLRepository(AppDbContex context)
        {
            this.context = context;
            entity = context.Set<T>();
        }
        public void Delete(T obj)
        {

            if (obj == null) throw new ArgumentNullException("Entity");
            if (obj.Id <= 0) throw new ArgumentNullException("Id is Required");
            obj.UpdateAT = DateTime.Now;
            obj.Status = false;

            var temp = entity.Attach(obj);

            temp.State = EntityState.Modified;

            context.SaveChanges();
        }
        public T Get(int Id)
        {
            return entity.SingleOrDefault(x => x.Id == Id);
        }
        public IEnumerable<T> GetAll()
        {
            return entity.AsEnumerable();
        }
        public int Insert(T obj)
        {
            if (obj == null) throw new ArgumentNullException("Entity");
            entity.Add(obj);
            context.SaveChanges();
            return obj.Id;
        }
        public void Update(T obj)
        {
            if (obj == null) throw new ArgumentNullException("Entity");
            if (obj.Id <= 0) throw new ArgumentNullException("Entity");

            obj.UpdateAT = DateTime.Now;

            var temp = entity.Attach(obj);
            temp.State = EntityState.Modified;
            context.SaveChanges();

        }
    }
}