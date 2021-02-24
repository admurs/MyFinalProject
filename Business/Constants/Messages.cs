using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime="Sistem bakımı";
        public static string ProductsListed="Ürün listelendi";
        public static string ProductCountOfCategoryError = "Kategoriye sahip yanlızca 10 adet ürün olabilir.";
        public static string ProductNameAlreadyExists = "Bu isimde ürün mevcuttur.";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemez.";
    }
}
