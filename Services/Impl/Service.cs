using Prj_Gestion_Evénement_UPF.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Gestion_Evénement_UPF.Services.Impl
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly IDao<T> _dao;

        public Service(IDao<T> dao)
        {
            _dao = dao;
        }

        public T GetById(int id)
        {
            return _dao.GetById(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _dao.GetAll();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _dao.Find(predicate);
        }

        public void Add(T entity)
        {
            _dao.Add(entity);

        }

        public void AddRange(IEnumerable<T> entities)
        {
            _dao.AddRange(entities);
        }

        public void Remove(T entity)
        {
            _dao.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _dao.RemoveRange(entities);
        }
        public void Update(T entity)
        {
            _dao.Update(entity);
        }
    }
}
