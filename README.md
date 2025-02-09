# :gem:MVC5 ile Admin Panelli Dinamik CV Sitesi
Bu repository, Murat Yücedağ'ın Mvc5 ile Sıfırdan Admin Panelli Dinamik CV Sitesi kursunu içermektedir. Bu eğitimde bana yol gösteren Murat Yücedağ'a çok teşekkür ederim.

## :arrow_forward: CV Sayfası
Bu kursta öncelikle CV yapısının görüntüleneceği sayfa üzerinde çalıştım. Bu sayfada Hakkımda, Deneyimlerim, Eğitim Hayatım, Yeteneklerim, İlgi Alanlarım, Sertifikalarım ve İletişim bölümlerini tasarladım. Buradaki bilgileri kendime göre düzenledim. Bu bölümler veri tabanı ile doğrudan bağlantılı bir şekilde bilgileri MS SQL veritabanı üzerinden çekmektedir.

<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_CV_WebSite/blob/176f1227cae25b3a7350df677a3e857e97428b87/ss/cvAboutme.jpg" alt="image alt">
</div>

<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_CV_WebSite/blob/176f1227cae25b3a7350df677a3e857e97428b87/ss/cvAboutme.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Login ve Register Form
Projemde birden fazla kullanıcının aynı anda kullanmasını sağlamak için oluşturmuş olduğum Tbl_Users tablosuna birkaç kişi ekledim. Bu kişiler kullanıcı adlarını ve şifrelerini LoginForm'a girerek sisteme giriş yapabilir durumdalar. Entity Framework ile oluşturmuş olduğum model üzerinde kullanıcı adını ve şifreyi tablo içerisinde sorgulayarak kullanıcı kontrolü yaptım. Eğer şifre veya kullanıcı adı yanlış girilirse bir hata mesajı gösterilecektir. Bir kullanıcı daha önce kayıt olmadıysa "Kayıt Ol" linkLabel aracına tıklayarak RegisterForm'a gidebilir. Register formda kullanıcı, Kullanıcı Adı, Adı ve Soyadı, E-Mail, Şifre ve Şifre Tekrar textBox'larını doldurur ve "Kayıt Ol" butonuna basarsa Tbl_Users tablosuna kullanıcı kaydedilir. Sonrasında uygulamayı yeniden başlatıp LoginForm üzerinden uygulamaya giriş yapabilir. Her kullanıcının kendi banka hesapları ve hesap hareketleri bulunmaktadır.

![image_alt](https://github.com/melihcolak0/MVC5_CV_WebSite/blob/176f1227cae25b3a7350df677a3e857e97428b87/ss/cvAboutme.jpg)

### :arrow_forward: Dashboard Form
Bir kullanıcı uygulamaya giriş yaptığında ilk karşılaşacağı form DashboardForm'dur. Dashboard aslında ana formumuzdur. Diğer formlardaki Geri butonu ile tekrar Dashboard formuna dönebiliriz. Dashboard da dahil tüm formlarda kullanıcı güncel tarih ve saati görüntüleyebilmektedir. Saat için SharedTime isminde bir sınıf oluşturup bu oluşturduğum sınıftaki Timer'ın Tick olayı ile tüm formlardaki saati kontrol edebiliyorum. Dashboard formunu inceleyecek olursak, formda kullanıcı, kendi adını ve soyadını görebilir. Bu her formda olan bir özelliktir. Devamında bankalardaki toplam bakiyesini görebilir. Tbl_Bills tablosundaki faturalarının isimlerini ve miktarlarını 1 saniyelik geçişlerle görebilir. Tbl_BankProcesses tablosundaki banka hesap hareketlerinden son hareketin detaylarını da görebilir. Formun alt kısmındaki grafiklerde ise kullanıcı hangi bankada ne kadar bakiyesinin bulunduğunu görebilir. Bir diğer grafikte de faturaların tutarlarını görebilir. Kullanıcı form değiştirme esnasında zaten o an bulunduğu formun butonuna basacak olursa bir uyarı mesajı ile karşılaşır.

<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_CV_WebSite/blob/176f1227cae25b3a7350df677a3e857e97428b87/ss/cvAboutme.jpg" alt="image alt">
</div>

