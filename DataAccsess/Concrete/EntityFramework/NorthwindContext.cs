using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccsess.Concrete.EntityFramework
{
    //context: Db tabloları ile proje classlarını bağlamak
    public class NorthwindContext:DbContext
    {
        //projeyi hangi veritabanıyla ilişkilendireceğimizi belirteceğimiz yer
        //override on dediğimizde fonk karşımıza çıkacaktır
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database = Northwind;Trusted_Connection=true"); 
        }

        //benim hangi nesnem veritabanındaki hangi nesneye denk gelecek
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
