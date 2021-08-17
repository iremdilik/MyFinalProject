using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //IProductDal -- I->interface Product Dal->data access layor
    //interface'in metodları default publictir.
    public interface IProductDal
    {
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);

        List<Product> GetAllByCategory(int categoryId); //ürünleri kategoriue göre filtrele

    }
}
