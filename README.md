# Task & Notification Management API
Bu proje, modern yazılım geliştirme pratiklerini ve veri güvenliği standartlarını sergilemek amacıyla ASP.NET Core 8 Web API kullanılarak geliştirilmiştir. Projede özellikle veri transfer süreçlerinde güvenliği sağlamak için DTO (Data Transfer Object) deseni uygulanmıştır.

Öne Çıkan Özellikler & Teknik Detaylar
In-Memory Database: Prototipleme aşamasında hız kazanmak ve harici bir SQL kurulumuna ihtiyaç duymadan test edilebilirliği artırmak için Entity Framework Core In-Memory veritabanı kullanılmıştır.
DTO (Data Transfer Object) Pattern: Veritabanı varlıklarını (Entities) doğrudan dış dünyaya açmak yerine, sadece gerekli alanların paylaşıldığı DTO katmanı oluşturulmuştur. Bu sayede SecretNote gibi hassas verilerin API yanıtlarında yer alması engellenmiştir.
Dependency Injection (DI): Servis ve veritabanı bağlamı yönetimi için .NET'in yerleşik bağımlılık enjeksiyonu mekanizması kullanılarak Scoped servis kayıtları yapılmıştır.
Swagger OpenAPI: API uç noktalarının dokümantasyonu ve kolayca test edilebilmesi için Swagger entegrasyonu sağlanmıştır.

Proje Yapısı
Models: Veritabanı şemasını temsil eden temel varlıklar.
DTOs: Kullanıcıya sunulan veya kullanıcıdan alınan veri transfer nesneleri.
Services: İş mantığının (Business Logic) yürütüldüğü ve verilerin modellere/DTO'lara dönüştürüldüğü katman.
Controllers: HTTP isteklerini karşılayan API uç noktaları.

Kullanılan Teknolojiler
.NET 8.0 SDK
Entity Framework Core (In-Memory)
C# 
