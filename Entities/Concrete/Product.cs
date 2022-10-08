using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    //public dedik,bu classa diğer katmanlar da erişebilsin diye.
    //çünkü DataAccsess ürünü ekleyecek, Business ürünü kontrol edecek, ConsoleUI ürünü gösterecek
    //bir classın defaultu 'internal'dır. Yani bu classa sadece kendi katmanı Entities erişir demek
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
