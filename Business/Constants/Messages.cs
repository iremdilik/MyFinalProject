using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenancaTime = "Sistem bakımda.";
        public static string ProductListed = "Ürünler listelendi.";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceded = "Kategori limiti aşıldı, yeni ürün eklenemiyor.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "kullanıcı kayıt oldu.";
        public static string UserNotFound = "kullanıcı bulunamadı.";
        public static string PasswordError = "şifre hatası.";
        public static string SuccessfulLogin = "başarılı giriş";
        public static string UserAlreadyExists = "kullanıcı mevcut";
        public static string AccessTokenCreated = "token oluşturuldu";
    }
}
