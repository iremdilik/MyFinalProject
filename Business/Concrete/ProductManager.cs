using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        //inmemory entityframework yok sadece abstract

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            // iş kodları
            //bir iş sınıfı başka sınıfları new'lemez

            //yetkisi var mı vb. if-elseler

            return _productDal.GetAll();
        }
    }
}
