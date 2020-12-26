using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Product_Cagetory.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var cateogories = new List<Category>()
            {
                new Category() {Name="Kamera",Description="Kamera Ürünleri" },
                new Category() {Name="Bilgisayar",Description="Bilgisayar Ürünleri" },
                new Category() {Name="Telefon",Description="Telefon Ürünleri" },
                new Category() {Name="Beyaz Esya",Description=" Beyaz Eşya Ürünleri" }
            };
            foreach (var item in cateogories)
            {
                context.Categories.Add(item);
            }
            context.SaveChanges();
            var products = new List<Product>
            {
                 new Product() {  CategoryId=1,Id=5001,Name="Canon Product",Price=5000,Stock=50,Description="Canon Product Desription",IsApproved=true, IsHome=true},
                 new Product() {  CategoryId=1,Id=5002,Name="Kodak Product",Price=2000,Stock=100,Description="Kodak Product Desription", IsApproved=true},

                 new Product() {  CategoryId=2,Id=6001,Name="Asus Product",Price=5000,Stock=50,Description="Asus Product Desription", IsApproved=true, IsHome=true},
                 new Product() {  CategoryId=2,Id=6002,Name="Dell Product",Price=6000,Stock=60,Description="Dell Product Desription", IsApproved=true},
                  new Product() {  CategoryId=2,Id=6003,Name="Toshiba Product",Price=8000,Stock=40,Description="Toshiba Product Desription", IsApproved=true},

                 new Product() {  CategoryId=3,Id=7001,Name="Apple Product",Price=5000,Stock=90,Description="Apple Product Desription", IsApproved=true,IsHome=true},
                 new Product() {  CategoryId=3,Id=7002,Name="Samsung Product",Price=6000,Stock=150,Description="Samsung Product Desription", IsApproved=true},

            };
            foreach (var item in products)
            {
                context.Products.Add(item);
            }
            context.SaveChanges();

            context.SaveChanges();
            base.Seed(context);
        }

    }
}