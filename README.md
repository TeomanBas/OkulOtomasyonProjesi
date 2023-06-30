# OkulOtomasyonProjesi
Burada Okul Otomasyonu olan bir proje yer alıyor.Bu projede örnek olarak bir okul otomasyon sistemi tasarlanıp geliştirilmeye çalışılacak ve dökümantasyonu sağlanmaya çalışılacak.Proje C# dili ile ve önyüz tasarımı DevExpress ile yapılacak.

# AnaModul
AnaModul anasayfa gibi tüm bileşenleri üzerinde barındıyor ve tüm fonksiyonlar ana AnaModul üzerinden erişiliyor.
## Tasarim
Tasarım aşağıda görüldüğü gibi
![AnaModul-Tasarim](./img/ana-modul-tasarimi.PNG)
## Veritabanı
Veri tabanı yapısı **DB_Script** dizininde daha ayrıntılı açıklanır.Burada belli başlı proje ilerlemeleri için notlar ve açıklamalar bulunur.
ilk aşama olarak database, öğretmenler tablosu ve düşük yetkili kullanıcı oluşturuldu.Oluşturulan kullanıcı ile bağlantı sağlandı ve öğretmenlerin verileri öğretmenler penceresindeki data source'e çekildi.Bunu yapmak için Solution üzerine yeni bir dev express windows form tempalate i oluşturuldu ve bu proje üzerinde oluşturulan Veritabanı class'ında veritabanı bağlantı ve kodları oluşturuldu.daha sonra öğretmenler modülüne bu proje referans olarak eklenerek Veritabanı sınıfının nesnelerine erişim sağlandı.Bu şekilde yapılmasının nedeni Devexpress .Net 4.8 versiyonunu kullanıyor diğer ve derleme için oluşturulan yeni class library leri .Net 6 ve 5 gibi sürümleri kullanıyor  devexpress in kullandığı sürümleri kullanmıyor.Derleme esnasında derlenen class library dll leri dev express windows formları ile çalışmıyor bunun için devexpress projeleri içerisinde onun beraber derlenecek ve derleme hatası vermeyecek bir çözüm bulmam gerekiyordu.Daha pratik kullanışlı yöntemler tabiki vardır.Bu Veritabani için gerekli kodlar oluşturulduktan sonra OgretmenlerModul üzerinden namaspace dahil edildi ve veritabanı nesnesi oluşturularak bu nesne üzerinden veritabanı bağlantısı yapılarak öğretmenler tablosundaki veriler çekilmiş oldu.

öğretmenler penceresi;
![ogretmenler-modulu-1](./img/ogretmenler-modulu-veritabani-baglanti.PNG)


