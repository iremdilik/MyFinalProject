﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //Çıplak class kalmasın
    //Concrete klasöründeki sınıflar bir veri tabanı tablosuna karşılık geliyor
    public class Category : IEntity 
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}