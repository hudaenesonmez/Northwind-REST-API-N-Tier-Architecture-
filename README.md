# Northwind API (N-Tier Architecture)

## EN

### Overview
This project is a simple REST API built on the Northwind database.

The idea is to provide a ready-to-use backend service for frontend developers or anyone who wants to build dashboards and test API integrations quickly. It’s not meant to be a production system, more like a clean and extendable base project.

---

### Architecture
The project is structured with a layered approach:

- Entity → Database models  
- DAL → Data access with generic repository  
- Business → Business logic and validations  
- DTO → Data transfer objects  
- API → Controllers and endpoints  

---

### Technologies
- ASP.NET Core Web API  
- Entity Framework Core (Scaffold - Database First)  
- FluentValidation  
- AutoMapper  
- Dependency Injection  
- Generic Repository  

---

### Current State
Right now, the main tables are implemented:

- Order  
- Product  
- Customer  
- Category  

Basic CRUD operations are available for these entities.  
DTO structure, validation, and mapping are in place.

---

### Purpose
This project is mainly useful for:

- Frontend developers who need a quick API  
- Dashboard development  
- Practicing layered architecture  
- Testing API requests  

---

### Next Steps
Planned improvements:

- Add global exception middleware  
- Add controllers and validations for related tables  
- Add filtering and custom query endpoints for UI usage  

For filtering, the preferred approach will be:

- Using query parameters  
  `/api/products?minPrice=10&maxPrice=100`

- Or creating specific endpoints when needed  
  `/api/orders/by-customer/{id}`  

---

### Note
This is a simple and extendable API project, not a production-ready system.

---

## TR

### Genel Bakış
Bu projem, Northwind veritabanı kullanılarak geliştirilmiş, frontend geliştiriciler (özellikle dashboard geliştirecek kişiler) için hızlıca kullanılabilecek backend servisi sunan bir REST API’dir.

Daha çok , temiz ve geliştirilebilir bir temel proje olarak düşünülmeli.

---

### Mimari
Proje katmanlı mimari ile hazırlanmıştır:

- Entity → Veritabanı modelleri  
- DAL → Generic repository ile veri erişimi  
- Business → İş kuralları ve validasyonlar  
- DTO → Veri taşıma nesneleri  
- API → Controller ve endpointler  

---

### Kullanılan Teknolojiler
- ASP.NET Core Web API  
- Entity Framework Core (Scaffold - Database First)  
- FluentValidation  
- AutoMapper  
- Dependency Injection  
- Generic Repository  

---

### Mevcut Durum
Şu an ana tablolar hazır:

- Order  
- Product  
- Customer  
- Category  

Bu tablolar için temel CRUD işlemleri mevcut.  
DTO, validation ve mapping yapıları kurulu durumda.

---

### Amaç
Bu proje özellikle şu durumlar için uygun:

- Frontend geliştirme sırasında hazır API ihtiyacı  
- Dashboard geliştirme  
- Katmanlı mimari pratiği  
- API testleri  

---

### Planlanan Geliştirmeler
- Global exception middleware eklenmesi  
- Yan tablolar için controller ve validasyonlar  
- UI tarafına uygun filtreleme ve özel endpointler  


---

### Not
Bu proje production için değil, öğrenme ve geliştirme amaçlıdır.

---



