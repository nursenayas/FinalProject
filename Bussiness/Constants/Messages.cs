using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalıd = "Ürün İsmi Geçersiz";
        public static string MaintenanceTime="sistem Bakımda";
        public static string ProductListed= "Ürünler Listelendi";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists="Bu isimde zaten başka bir ürün kayıtlı";
        public static string CategoryLimitExceded="Kategori limiti  15 i aştığı için yeni ürün eklenemez";
        public static string AuthorizationDenied="Yetkiniz yok.";
        public static string UserRegistered="Kayıt Oldu";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin="Başarılı giriş";
        public static string UserAlreadyExists="Kullanıcı Mevcut";
        public static string AccessTokenCreated="Token oluşturuldu.";
    }
}
