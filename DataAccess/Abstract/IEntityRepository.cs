using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint - generic kısıt 
    //class - referans tip olabilir demek
    //IEntity - IEntity olabilir ya da IEntity'i implemente eden bir ensne olabilir
    //new()- new'lenebilir olmalı. IEntity interface olduğundan new'lenemez.

    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null); 
        T Get(Expression<Func<T, bool>> filter);  // belli bir şeye göre filtrelemek için
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
