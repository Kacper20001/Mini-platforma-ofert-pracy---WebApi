# 🌍 Mini Platforma Ofert Pracy – ASP.NET WebAPI

**Mini Platforma Ofert Pracy** to aplikacja webowa napisana w C# z użyciem ASP.NET Core WebAPI oraz Entity Framework. Projekt umożliwia zarządzanie ofertami pracy, krajami, stanowiskami i firmami z podziałem na moduły i warstwy (API, CrossCutting, Storage). Został stworzony w ramach przedmiotu *Szkolenie Techniczne 1*.

## 🔧 Funkcje aplikacji

- Dodawanie, edytowanie, usuwanie i przeglądanie ofert pracy
- Historia zmian ofert pracy
- Lista krajów, firm i stanowisk
- Encje tłumaczeń (np. CountryTranslation, JobPositionTranslation)
- Architektura warstwowa z repozytoriami, DTO i usługami
- Dependency Injection, FluentValidation, automatyczne mapowania (AutoMapper)
- Migracje EF Core i seedowanie danych

## 🧱 Technologie

- C# / .NET 8
- ASP.NET Core WebAPI
- Entity Framework Core
- SQL Server / LocalDb
- Visual Studio
- Git

## 💻 Wymagania

- Visual Studio 2022+
- .NET 8 SDK
- SQL Server Express / LocalDb
- Przeglądarka (do testów w Swagger UI)

## ▶️ Jak odpalić

Sklonuj repozytorium:  
`git clone https://github.com/Kacper20001/Mini-platforma-ofert-pracy---WebApi.git`  
Przejdź do folderu rozwiązania i otwórz projekt w Visual Studio.  
Skonfiguruj connection string do bazy danych w pliku `GeoDbContext.cs`.  
W konsoli Package Manager wpisz:  
`Add-Migration InitialCreate`  
`Update-Database`  
Uruchom aplikację – interfejs Swagger uruchomi się automatycznie pod `https://localhost:xxxx/swagger`.

## 🧠 Autor

**Kacper Kulig**  
Numer albumu: w69199  
Projekt wykonany w ramach laboratorium **Szkolenie Techniczne 1**

---
