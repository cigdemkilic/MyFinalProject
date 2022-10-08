using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace DataAccsess.Abstract
{
    //Dal: Data access layer.
    //IProductDal: data accsess layer katmanında product için Interface oluşturma
    public interface IProductDal:IEntityRepository<Product>
    {
        
        
    }
}
