using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccsess.Abstract;
using Entities.Concrete;

namespace DataAccsess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        //ctor tabtab
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                //projeyi çalıştırdığımızda kendi bir ürün listesi oluşturmuş oldu
                //sanki bu veriler sqlden oracledan geliyomuş gibi ve bunu simüle ettik
                new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},
                new Product{ProductId=2,CategoryId=1,ProductName="Kamera",UnitPrice=500,UnitsInStock=3},
                new Product{ProductId=3,CategoryId=2,ProductName="Telefon",UnitPrice=15000,UnitsInStock=2},
                new Product{ProductId=4,CategoryId=2,ProductName="Klavye",UnitPrice=150,UnitsInStock=65},
                new Product{ProductId=5,CategoryId=2,ProductName="Fare",UnitPrice=85,UnitsInStock=1},
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //_product.Remove(product) dediğimizde silme gerçekleşmez. 
            //Bilgilerin aynı olması veya olmaması farketmez. Çünkü referans tipler referans numarası üzerinden giderler
            //Referans numaraları aynı olmadığı için istediğimiz ürünü silme gerçekleşmez.

            //Id her zaman farklıdır ve istediğimiz Idyi bulup referans numarasına erişerek silmeyi gerçekleştireceğiz.
            //LINQ kullanarak!!!!!!!!!!!!!!!!!
            ////linq kullanmadan nasıl yapabiliriz diye denendi proje ismi DenemeAltProje1

            Product productToDelete ;
            productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            //her p için listeyi dolaşıyo ve kontrol gerçekleşştiriyo

            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products; 
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün Id'sine sahip olan listedeki ürünü bul 
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
