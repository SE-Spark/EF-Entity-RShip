using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_Rship.Data.Interfaces
{
    public interface IRepo<TEntity> where TEntity : class
    {
        TEntity get();
        IList<TEntity> getAll();
        void insert(TEntity T);
        void update(TEntity T);
        void delete(object Tid);
    }
}
