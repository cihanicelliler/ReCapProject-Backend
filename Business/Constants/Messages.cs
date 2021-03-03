using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Ürün eklendi";
        public static string CarDeleted = "Ürün silindi";
        public static string CarUpdated = "Ürün güncellendi";
        public static string CarNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string CarsListed = "Araçlar Listelendi";
        public static string CarsDetailed = "Araç Detayları Listelendi";
        public static string SuccessMessage = "İşlem Başarılı";
        public static string CarCountOfCategoryError = "Bir kategoride en fazla 10 araba olabilir";
        public static string CarDescriptionAlreadyExists = "Böyle bir açıklama zaten mevcut";
        public static string BrandLimitExceded = "Marka limiti aşıldığı için yeni ürün eklenemiyor";
        public static string ImageLimit = "Maksimum fotoğraf sayısına ulaşıldı";
        public static string ImageAdded = "Resim eklendi";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Erişim Tokeni oluşturuldu";
    }
}
