using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccsess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductManager : IProductServices
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
           _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            // iş kodları
            //yetkisi var mı? vsvs varsa ürünleri listele
            return _productDal.GetAll();
 
        }
    }
}
