# :gem:MVC5 ile Admin Panelli Dinamik CV Sitesi
Bu repository, Murat Yücedağ'ın Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi kursunu içermektedir. Bu eğitimde bana yol gösteren Murat Yücedağ'a çok teşekkür ederim.

MVC5 ve ASP.NET Web Application (.NET Framework) kullanarak dinamik bir CV sitesi oluşturdum Bu projede, tamamen işlevsel, duyarlı ve özelleştirilebilir bir CV'yi sergiliyorum. Proje dahilinde klasör düzenine dikkat etmeye çalıştım. Repository Design Pattern kullanarak CRUD işlemlerinde kod tekrarını azaltmaya çalıştım. Entity Framework ile  veri tabanı bağlantılarını oluşturdum.

Repository Design Pattern, CRUD işlemlerinde kod tekrarını azaltmak için kullanılan bir tasarım desenidir.

Repository Pattern, veri erişim işlemlerini soyutlamak ve veri tabanı işlemlerini daha düzenli yönetmek için kullanılan bir tasarım desenidir. MVC (Model-View-Controller) mimarisinde genellikle veri tabanı işlemlerini yönetmek için kullanılır.

GenericRepository ve diğer bölüm Repository'leri ile kodlarımı düzenledim. EF Designer from database (Database First) yaklaşımı ile öncelikle MS SQL üzerinde bir veri tabanı ve veri tabanı içerisinde tablolarımı oluşturup bu veri tabanını bir ADO.NET Entity Data Model içerisinde projeme dahil ettim.


## :arrow_forward: CV Sayfası
Bu kursta öncelikle CV yapısının görüntüleneceği sayfa üzerinde çalıştım. Bu sayfada Hakkımda, Deneyimlerim, Eğitim Hayatım, Yeteneklerim, İlgi Alanlarım, Sertifikalarım ve İletişim bölümlerini tasarladım. Buradaki bilgileri kendime göre düzenledim. Bu bölümler veri tabanı ile doğrudan bağlantılı bir şekilde bilgileri MS SQL veritabanı üzerinden çekmektedir.

### :triangular_flag_on_post: Hakkımda Bölümü
Hakkımda bölümünde isim, soyisim, adres, telefon numarası (istenirse verilecektir) ve mail adresi bilgilerim yer almaktadır. Bunun yanında kendim hakkında bir yazı ve LinkedIn, GitHub ve Youtube hesaplarımın bağlantıları bulunmaktadır. Sol taraftaki Navigation Bar aracında ise resmim ve diğer bölümler bulunmaktadır.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_CV_WebSite/blob/176f1227cae25b3a7350df677a3e857e97428b87/ss/cvAboutme.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Deneyimlerim Bölümü
Deneyimlerim bölümünde bugüne kadar yaptığım stajlarımın bilgileri yer almaktadır. Staj yaptığım firma, pozisyonum, staj yaptığım tarih ve staj süresince bulunduğum faaliyetler gibi bilgiler bu sayfada yer almaktadır.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_CV_WebSite/blob/d9a0fc326f649a43b3747e00457fa7827811f216/ss/cvExperiences.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Eğitim Hayatım Bölümü
Eğitim hayatım bölümünde bugüne kadarki aldığım lisans ve ön lisans eğitimlerimin bilgileri yer almaktadır. Üniversitem, fakültem, bölümüm, başlangıç ve bitiş tarihleri ve GANO bilgilerim yer almaktadır.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_CV_WebSite/blob/d9a0fc326f649a43b3747e00457fa7827811f216/ss/cvEducations.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Yeteneklerim Bölümü
Yeteneklerim bölümünde eğitim hayatım boyunca öğrenmiş olduğum ve mezun olduktan sonra almış olduğum eğitimler sonucunda kazandığım yetenekleri sergiledim.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_CV_WebSite/blob/d9a0fc326f649a43b3747e00457fa7827811f216/ss/cvAbilities.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: İlgi Alanlarım Bölümü
İlgi alanlarım bölümünde hayatım boyunca ve özellikle bu zamanlarda ilgi duyduğum konular ve alanlar ile ilgili kısa bir yazı yazdım.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_CV_WebSite/blob/d9a0fc326f649a43b3747e00457fa7827811f216/ss/cvInterests.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Sertifikalarım Bölümü
Sertifikalarım bölümünde eğitim hayatım boyunca ve mezun olduktan sonra almış olduğum eğitimler sonucunda aldığım sertifikalarım yer almaktadır.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_CV_WebSite/blob/d9a0fc326f649a43b3747e00457fa7827811f216/ss/cvCertificates.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: İletişim Bölümü
Sitemi ziyaret eden kişilerin bana iletmek istediği herhangi bir konu varsa iletişim bölümünde bulunan araçlar ile bana ulaşmaları mümkündür. Burada gönderilen mesajlar veri tabanında tutulmaktadır. Ayrıca admin panelinden de görüntülenebilmektedir.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_CV_WebSite/blob/d9a0fc326f649a43b3747e00457fa7827811f216/ss/cvContact.jpg" alt="image alt">
</div>

## :arrow_forward: Admin Paneli Sayfası
Admin panelinde CV sayfasında görüntülenen bölümleri düzenleyebiliriz. Yeni bölüm ekleme, bölüm güncelleme ve bölüm silme gibi işlemleri admin panelinden yapabiliriz. Bu sayfada Hakkımda, Deneyimlerim, Eğitim Hayatım, Yeteneklerim, İlgi Alanlarım, Sertifikalarım, İletişim, Sosyal Medya Ayarlar ve Çıkış bölümleri ile ilgili işlemler yer almaktadır.

### :triangular_flag_on_post: LogIn Bölümü
LogIn bölümünde kullanıcı Kullanıcı Adı'nı ve Şifre'sini girerek sisteme giriş yapabilecektir. Kimse giriş yapmadan Admin Paneli sayfasındaki hiçbir alana doğrudan ulaşamaz. Giriş yapmadan yalnızca CV Sitesi ve LogIn sayfalarına ulaşım sağlanabilir.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_CV_WebSite/blob/d9a0fc326f649a43b3747e00457fa7827811f216/ss/adminLogin.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Hakkımda Bölümü
Hakkımda bölümünde veri tabanı üzerindeki Tbl_AboutMe tablosundaki verileri görüntülemekteyiz. Burada textBox araçlarında yapılan değişiklikler sonucu "Güncelle" butonuna tıklanırsa veriler veri tabanı üzerinde güncellenecektir.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_CV_WebSite/blob/d9a0fc326f649a43b3747e00457fa7827811f216/ss/adminAboutMe.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Eğitimlerim Bölümü
Eğitimlerim bölümünde veri tabanı üzerindeki Tbl_Educations tablosundaki verileri görüntülemekteyiz. Burada bulunan "Yeni Eğitim Ekle" butonu ile yeni bir sayfaya gidip veri tabanına yeni bir eğitim ekleyebiliriz. "Güncelle" butonuna tıklarsak hangi satırdaki butona tıkladığımıza göre o satırdaki bilgiler eğitim güncelleme sayfasına taşınır ve o sayfada bize güncelleme yapma imkanı sunar. TextBox araçlarında yapılan değişiklikler sonucu "Güncelle" butonuna tıklanırsa veriler veri tabanı üzerinde güncellenecektir. "Sil" butonuna tıklanırsa hangi satırdaki sil butonu kullanıldıysa o satırdaki veriler veri tabanından silinecektir. 
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_CV_WebSite/blob/d9a0fc326f649a43b3747e00457fa7827811f216/ss/adminEducations.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_CV_WebSite/blob/d9a0fc326f649a43b3747e00457fa7827811f216/ss/adminAddEducation.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_CV_WebSite/blob/d9a0fc326f649a43b3747e00457fa7827811f216/ss/adminUpdateEducation.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Deneyimlerim Bölümü
Deneyimlerim bölümünde veri tabanı üzerindeki Tbl_Experiences tablosundaki verileri görüntülemekteyiz. Burada bulunan "Yeni Deneyim Ekle" butonu ile yeni bir sayfaya gidip veri tabanına yeni bir deneyim ekleyebiliriz. "Güncelle" butonuna tıklarsak hangi satırdaki butona tıkladığımıza göre o satırdaki bilgiler deneyim güncelleme sayfasına taşınır ve o sayfada bize güncelleme yapma imkanı sunar. TextBox araçlarında yapılan değişiklikler sonucu "Güncelle" butonuna tıklanırsa veriler veri tabanı üzerinde güncellenecektir. "Sil" butonuna tıklanırsa hangi satırdaki sil butonu kullanıldıysa o satırdaki veriler veri tabanından silinecektir. 
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_CV_WebSite/blob/d9a0fc326f649a43b3747e00457fa7827811f216/ss/adminExperiences.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: İlgi Alanlarım Bölümü
İlgi alanlarım bölümünde veri tabanı üzerindeki Tbl_Interests tablosundaki verileri görüntülemekteyiz. Burada textArea araçlarında yapılan değişiklikler sonucu "Güncelle" butonuna tıklanırsa veriler veri tabanı üzerinde güncellenecektir.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_CV_WebSite/blob/d9a0fc326f649a43b3747e00457fa7827811f216/ss/adminInterests.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Yeteneklerim Bölümü
Yeteneklerim bölümünde veri tabanı üzerindeki Tbl_Abilities tablosundaki verileri görüntülemekteyiz. Yeteneklerin yanında hangi oranda o yetenekte başarlı olduğuma dair bir bar bulunmakatdır. Burada bulunan "Yeni Yetenek Ekle" butonu ile yeni bir sayfaya gidip veri tabanına yeni bir yetenek ekleyebiliriz. "Güncelle" butonuna tıklarsak hangi satırdaki butona tıkladığımıza göre o satırdaki bilgiler yetenek güncelleme sayfasına taşınır ve o sayfada bize güncelleme yapma imkanı sunar. TextBox araçlarında yapılan değişiklikler sonucu "Güncelle" butonuna tıklanırsa veriler veri tabanı üzerinde güncellenecektir. "Sil" butonuna tıklanırsa hangi satırdaki sil butonu kullanıldıysa o satırdaki veriler veri tabanından silinecektir. 
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_CV_WebSite/blob/d9a0fc326f649a43b3747e00457fa7827811f216/ss/adminAbilities.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Sertifikalarım Bölümü
Sertifikalarım bölümünde veri tabanı üzerindeki Tbl_Certificates tablosundaki verileri görüntülemekteyiz. Burada bulunan "Yeni Sertifika Ekle" butonu ile yeni bir sayfaya gidip veri tabanına yeni bir sertifika ekleyebiliriz. "Güncelle" butonuna tıklarsak hangi satırdaki butona tıkladığımıza göre o satırdaki bilgiler sertifika güncelleme sayfasına taşınır ve o sayfada bize güncelleme yapma imkanı sunar. TextBox araçlarında yapılan değişiklikler sonucu "Güncelle" butonuna tıklanırsa veriler veri tabanı üzerinde güncellenecektir. "Sil" butonuna tıklanırsa hangi satırdaki sil butonu kullanıldıysa o satırdaki veriler veri tabanından silinecektir. 
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_CV_WebSite/blob/d9a0fc326f649a43b3747e00457fa7827811f216/ss/adminCertificates.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: İletişim Bölümü
İletişim bölümünde veri tabanı üzerindeki Tbl_Contact tablosundaki verileri görüntülemekteyiz. Burada bulunan veriler CV sayfasında sayfamı ziyaret eden kişilerin bana gönderdiği mesajlardır. Bu veriler de yine veri tabanı üzerinde tutulmaktadır. Tüm mesajları bu bölümden görüntüleyebiliriz.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_CV_WebSite/blob/d9a0fc326f649a43b3747e00457fa7827811f216/ss/adminContact.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Sosyal Medya Bölümü
Sosyal medya bölümünde CV sayfasındaki Hakkımda bölümünde bulunan sosyal medya hesap bağlantılarının olduğu bölüm ile ilgili bilgiler tutulmaktadır. Burada bulunan "Yeni Sosyal Medya Hesabı Ekle" butonu ile yeni bir sayfaya gidip veri tabanına yeni bir sosyal medya hesabı ekleyebiliriz. "Güncelle" butonuna tıklarsak hangi satırdaki butona tıkladığımıza göre o satırdaki bilgiler sosyal medya hesabı güncelleme sayfasına taşınır ve o sayfada bize güncelleme yapma imkanı sunar. TextBox araçlarında yapılan değişiklikler sonucu "Güncelle" butonuna tıklanırsa veriler veri tabanı üzerinde güncellenecektir. "Sil" butonuna tıklanırsa hangi satırdaki sil butonu kullanıldıysa o satırdaki veriler pasif duruma alınır. CV sayfası üzerinde ise yalnızca aktif durumdaki sosyal medya hesapları bulunur. Veri tabanında sosyal medya sitesinin adı, link'i ve ikonu bulunmaktadır.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_CV_WebSite/blob/d9a0fc326f649a43b3747e00457fa7827811f216/ss/adminSocialMedia.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Ayarlar Bölümü
Ayarlar bölümünde LogIn form üzerinde giriş yapacak olan kullanıcı bilgileri yer almaktadır. Burada bulunan "Yeni Kullanıcı Ekle" butonu ile yeni bir sayfaya gidip veri tabanına yeni bir kullanıcı ekleyebiliriz. "Güncelle" butonuna tıklarsak hangi satırdaki butona tıkladığımıza göre o satırdaki bilgiler kullanıcı güncelleme sayfasına taşınır ve o sayfada bize güncelleme yapma imkanı sunar. TextBox araçlarında yapılan değişiklikler sonucu "Güncelle" butonuna tıklanırsa veriler veri tabanı üzerinde güncellenecektir. "Sil" butonuna tıklanırsa hangi satırdaki sil butonu kullanıldıysa o satırdaki kullanıcı veri tabanından silinecektir.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_CV_WebSite/blob/d9a0fc326f649a43b3747e00457fa7827811f216/ss/adminSettings.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Çıkış Bölümü
Çıkış bölümüne tıklandığında kullanıcı LogIn formuna geri döndürülecektir ve hesabı doğrulanmamış duruma alınacaktır.
