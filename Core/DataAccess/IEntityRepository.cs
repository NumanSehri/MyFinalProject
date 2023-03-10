using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //--------------------------------------Generic Constrait-Kısıtlama 
    // class : referans tip olabilir, where T : clas,
    // hangi refensı alacağı(referansabağlı nesneler)
    //new() : new' lene bilir
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        // verileri listele
        List<T> GetAll(Expression<Func<T,bool>> filter=null);

        T Get(Expression<Func<T, bool>> filter);


        //Veri Ekle
        void Add(T entity);

        //Veri Güncelle
        void Update(T entity);

        //Veri Sil
        void Delete(T entity);

        
    }
}
