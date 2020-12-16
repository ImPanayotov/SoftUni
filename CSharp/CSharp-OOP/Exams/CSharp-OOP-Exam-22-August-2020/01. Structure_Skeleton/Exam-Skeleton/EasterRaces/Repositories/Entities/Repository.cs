using EasterRaces.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Repositories.Entities
{
    public abstract class Repository<T> : IRepository<T>
    {
        private List<T> models;
        public Repository()
        {
            models = new List<T>();
        }
        public void Add(T model)
        {
            models.Add(model);
        }

        public IReadOnlyCollection<T> GetAll()
        {
            return models.ToList().AsReadOnly();
        }

        public T GetByName(string name)
        {
            return models.FirstOrDefault(x => x.GetType().Name == name);
        }

        public bool Remove(T model)
        {
            return models.Remove(model);
        }
    }
}
