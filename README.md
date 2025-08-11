# 🪵 Stump - Kütük Kesim Optimizasyonu ve 3D Görselleştirme Sistemi

Bu proje, ahşap kütüklerin kesim optimizasyonu için geliştirilmiş kapsamlı bir sistemdir. Hem C# console uygulaması hem de web tabanlı 3D görselleştirme arayüzü içerir.

## 🚀 Özellikler

### 📊 Console Uygulaması (C#)
- Kütük boyutu ve adet girişi
- Parça boyutları ve adet belirleme
- Matematiksel kesim optimizasyonu
- Fire (atık) hesaplama
- Ekstra optimizasyon algoritması
- Testere payı hesaplama

### 🌐 Web Uygulaması (Three.js)
- 3D kütük görselleştirme
- Gerçek zamanlı kesim simülasyonu
- İnteraktif kullanıcı arayüzü
- Zoom ve kamera kontrolleri
- Ana kesim ve ekstra optimizasyon görselleştirmesi

## 🛠️ Teknolojiler

### Backend
- **.NET 6.0** - C# Console Application
- **C#** - Ana programlama dili
- **Matematiksel Algoritmalar** - Kesim optimizasyonu

### Frontend
- **HTML5** - Web sayfası yapısı
- **CSS3** - Stil ve düzen
- **JavaScript (ES6+)** - Etkileşim ve hesaplama
- **Three.js** - 3D grafik kütüphanesi

### Algoritmalar
- **Greedy Algorithm** - Parça yerleştirme
- **Matematiksel Hesaplama** - Fire ve testere payı
- **Optimizasyon** - Ekstra parça yerleştirme

## 📁 Proje Yapısı

```
Stump/
├── Program.cs              # C# Console uygulaması
├── Yenikutuk.csproj       # .NET proje dosyası
├── index.html             # Web arayüzü
├── .gitignore            # Git ignore dosyası
└── README.md             # Bu dosya
```

## 🚀 Kurulum ve Çalıştırma

### C# Console Uygulaması

1. **Gereksinimler:**
   - .NET 6.0 SDK veya üzeri

2. **Kurulum:**
   ```bash
   git clone https://github.com/EcrinAvci/Stump.git
   cd Stump
   ```

3. **Çalıştırma:**
   ```bash
   dotnet build
   dotnet run
   ```

### Web Uygulaması

1. **Python HTTP Server ile:**
   ```bash
   python3 -m http.server 8000
   ```

2. **Tarayıcıda açın:**
   ```
   http://localhost:8000
   ```

## 📖 Kullanım

### Console Uygulaması

1. Kütük boyunu girin (cm)
2. Kütük adedini girin
3. Parça boyutlarını girin (3 farklı tip)
4. Her parça tipinden kaç adet istediğinizi belirtin
5. Sistem otomatik olarak:
   - Üretilecek parça adetlerini hesaplar
   - Toplam testere kaybını hesaplar
   - Fire miktarını hesaplar
   - Ekstra optimizasyon yapar

### Web Uygulaması

1. **Giriş Alanları:**
   - Kütük Boyu (cm)
   - Kütük Adedi
   - Testere Payı (cm)
   - Parça Boyutları (3 tip)
   - Parça Adetleri (3 tip)

2. **Görselleştirme:**
   - Ana kütük (mavi silindir)
   - Ana kesim parçaları (kırmızı, yeşil, mavi)
   - Ekstra optimizasyon parçaları
   - Fire (atık) parçaları

3. **Kontroller:**
   - `+` / `-` tuşları ile zoom
   - Mouse ile görüntüyü kaydırma

## 🔧 Algoritma Detayları

### Kesim Optimizasyonu
1. **Ana Kesim:** Kullanıcının belirlediği parça adetlerine göre
2. **Ekstra Optimizasyon:** Kalan alana sığabilecek ek parçalar
3. **Fire Hesaplama:** Toplam kütük boyu - kullanılan uzunluk

### Matematiksel Formüller
- **Toplam Kütük Boyu:** `kütük_boyu × kütük_adedi`
- **Testere Kaybı:** `(toplam_parça_adeti - 1) × testere_payı`
- **Fire:** `toplam_kütük_boyu - toplam_kullanılan_uzunluk`

## 🎯 Kullanım Senaryoları

- **Ahşap işleme atölyeleri**
- **Mobilya üretimi**
- **İnşaat sektörü**
- **Eğitim ve öğretim**
- **Araştırma ve geliştirme**

## 🚧 Geliştirme Planları

- [ ] Daha gelişmiş optimizasyon algoritmaları
- [ ] Çoklu kütük tipi desteği
- [ ] Maliyet hesaplama
- [ ] Veritabanı entegrasyonu
- [ ] API endpoint'leri
- [ ] Mobil uygulama

## 🤝 Katkıda Bulunma

1. Fork yapın
2. Feature branch oluşturun (`git checkout -b feature/AmazingFeature`)
3. Değişikliklerinizi commit edin (`git commit -m 'Add some AmazingFeature'`)
4. Branch'inizi push edin (`git push origin feature/AmazingFeature`)
5. Pull Request oluşturun

## 📝 Lisans

Bu proje MIT lisansı altında lisanslanmıştır. Detaylar için `LICENSE` dosyasına bakın.

## 👨‍💻 Geliştirici

**Ecrin Avcı** - [GitHub Profili](https://github.com/EcrinAvci)

## 📞 İletişim

- **GitHub:** [@EcrinAvci](https://github.com/EcrinAvci)
- **Proje Linki:** [https://github.com/EcrinAvci/Stump](https://github.com/EcrinAvci/Stump)

## 🙏 Teşekkürler

- **Three.js** - 3D grafik kütüphanesi
- **.NET Community** - C# ve .NET desteği
- **Open Source Community** - Açık kaynak katkıları

---

⭐ Bu projeyi beğendiyseniz yıldız vermeyi unutmayın!
