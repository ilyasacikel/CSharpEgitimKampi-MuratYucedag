# 🎓 C# Eğitim Kampı – Murat Yücedağ Serisi Özeti

Bu repo, Youtube [Murat Yücedağ C# Eğitim Serisi](https://youtube.com/playlist?list=PLKnjBHu2xXNPmFMvGKVHA_ijjrgUyNIXr&si=aPy10nR8V6ajDvXP) boyunca adım adım edinilen bilgi ve becerilerin uygulamalı özetidir. Eğitim süresince temel C# bilgilerinden başlayarak ileri seviye .NET mimarilerine, veritabanı işlemlerine ve ORM teknolojilerine kadar birçok konu ele alınmıştır. Bu süreç **.NET Framework** kullanılarak yürütülmüştür.

---

## 🧠 Eğitim Süresince Öğrenilen Konular

### 🔹 Temel C# Programlama

* Değişkenler, veri türleri
* Operatörler, koşullar, döngüler
* Diziler, koleksiyonlar, string işlemleri
* Metotlar, overload, recursion

### 🧱 Nesne Yönelimli Programlama (OOP)

* Class ve nesne mantığı
* Encapsulation, Inheritance, Polymorphism
* Abstract sınıflar ve Interface yapıları

### 🧩 Yazılım Prensipleri ve Yapılar

* SOLID prensipleri
* Katmanlı mimari temel yapısı
* Dependency Injection mantığı
* Repository Pattern

### 🗃️ Veri Tabanı ve ORM

* **MSSQL Server** kullanımı ve ilişkisel veritabanı yapısı
* SQL sorguları (SELECT, INSERT, UPDATE ,JOIN vb.)
* **ADO.NET** ile temel veri işlemleri
* **Entity Framework**: Code First ve Database First yaklaşımları
* **LINQ** sorguları
* Mikro ORM yapısına giriş: **Dapper** (örnek uygulamalarla)

### 🌐 Alternatif Veri Tabanları

* **PostgreSQL**: temel kurulum ve sorgular
* **MongoDB**: NoSQL yapısına giriş ve temel işlemler

---

## 🛠️ Kullanılan Ana Teknolojiler

| Alan        | Teknoloji                            |
| ----------- | ------------------------------------ |
| Programlama | C# (.NET Framework)                  |
| UI          | Windows Forms (WinForms)             |
| ORM         | ADO.NET, Entity Framework (Code First, DB First) |
| Veritabanı  | MSSQL, PostgreSQL, MongoDB           |
| Diğer       | LINQ, Katmanlı Yapılar, OOP          |

---

## 💼 Final Proje: FinancialCRM

### 📌 Proje Tanımı

**FinancialCRM**, eğitim sürecinin sonunda geliştirilen ve öğrenilen kavramların uygulamaya döküldüğü bir masaüstü finans yönetim uygulamasıdır. Uygulama, kullanıcının farklı bankalardaki hesaplarını ve finansal hareketlerini tek bir arayüz üzerinden takip etmesini sağlar. Kullanımı kolay, görsel olarak sade ve işlevsel bir Windows Forms uygulamasıdır.

### 🔍 Uygulama Özellikleri

* Bankalardaki hesap bakiyelerinin görüntülenmesi
* Banka hareketlerinin (gelir/gider) listelenmesi
* Fatura kayıtları ve ödeme durumlarının izlenmesi
* Toplam bakiye ve gider özetlerinin kullanıcı dostu şekilde gösterimi
* Dinamik raporlama ve sıralama imkanı
* Veritabanı bağlantısı **MSSQL** üzerinden sağlanmıştır
* **Entity Framework (DB First)** yaklaşımı kullanılmıştır
* Katmanlı mimari ve Dapper gibi yapılar bu proje özelinde kullanılmamıştır

### 👨‍💻 Teknik Detaylar

* WinForms arayüz
* MSSQL veritabanı
* EF DB First ile otomatik model oluşturma
* Form kontrolleriyle filtreleme ve listeleme
* Kod okunabilirliğine önem verilmiş yapı

### 📁 Proje Klasör Yapısı
```
FinalProject-FinancialCrm/
│
├── FinancialCrm/        # Uygulama arayüzü (WinForms)
├── App.config           # Veritabanı bağlantı ayarları
├── Models/              # EF DB First modelleri
└── Forms/               # Form ekranları
```

### 🚀 Başlatmak İçin
1. Bu repoyu klonlayın:
   ```bash
   git clone https://github.com/ilyasacikel/CSharpEgitimKampi-MuratYucedag.git

2. Visual Studio ile FinancialCrm.sln dosyasını açın.

3. Veritabanı bağlantısını App.config dosyasından kendi MSSQL sunucunuza göre ayarlayın.

4. NuGet paketlerini yükleyin.

5. Uygulamayı çalıştırın (F5).

### 📸 Ekran Görüntüleri

![image](https://github.com/user-attachments/assets/b9309702-4b92-4613-8cd4-b6feb189ac85)
![image](https://github.com/user-attachments/assets/0824d75b-fed1-4e43-b6b8-4b743b113545)
![image](https://github.com/user-attachments/assets/ed49cd82-30df-4f94-931b-e890e35d429c)

## 👤 Geliştirici

- **İlyas Açıkel**
- 🔗 [GitHub Profili](https://github.com/ilyasacikel)

---

## 📚 Eğitim Kaynağı

🎥 [Murat Yücedağ – C# Eğitim Serisi (YouTube)](https://youtube.com/playlist?list=PLKnjBHu2xXNPmFMvGKVHA_ijjrgUyNIXr&si=aPy10nR8V6ajDvXP)

