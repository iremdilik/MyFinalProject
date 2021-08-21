using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //IProductDal -- I->interface Product Dal->data access layor
    //interface'in metodları default publictir.
    public interface IProductDal : IEntityRepository<Product>
    {

    }
}
