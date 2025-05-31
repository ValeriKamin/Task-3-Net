 Завдання #03 — Web API для управління університетом (ASP.NET Core)

 Опис

Цей репозиторій реалізує багаторівневий застосунок Web API для управління сутностями університету — групами, студентами та курсами. Архітектура заснована на принципах розділення відповідальностей: окремі шари моделей, доступу до даних, логіки та контролерів API. Дані зберігаються у SQLite через Entity Framework Core.

---

 Структура каталогу

```
/
├── Task03/
│   ├── Task03.sln
│   ├── DomainTables/             # Моделі сутностей
│   │   └── Group.cs, Student.cs, Course.cs
│   ├── DataAccessLayer/          # Контекст та репозиторії
│   │   └── AppDbContext.cs, Repositories/
│   ├── Labs3NetUniversityApi/    # ASP.NET Core Web API
│   │   ├── Controllers/
│   │   └── Program.cs
│   ├── Labs3Net/                 # Інтеграційні тести (xUnit)
│   │   └── GroupControllerTests.cs
│   └── README.md
└── 03 621 П’яточкинПП.docx       # Звіт до завдання
```

---

 Основна функціональність

- **CRUD-операції** для Group, Student, Course через REST API
- **SQLite база даних**, налаштована через EF Core (Code First)
- **Swagger UI** для інтерактивної перевірки API
- **Інтеграційні тести** з `WebApplicationFactory`

---

 Використання

 Запуск API:
```bash
dotnet run --project Labs3NetUniversityApi
```
Swagger: [http://localhost:{порт}/swagger](http://localhost:{порт}/swagger)

 Запуск тестів:
```bash
dotnet test Labs3Net
```

---

 SOLID-принципи

| Принцип | Реалізація |
|--------|-------------|
| **S** — Єдина відповідальність | Кожен шар (API, DAL, Domain) має своє призначення |
| **O** — Відкритість/закритість | Репозиторії легко розширювати |
| **L** — Підстановка Лісков | Контролери працюють з інтерфейсами |
| **I** — Розділення інтерфейсу | Репозиторії мають окремі інтерфейси |
| **D** — Інверсія залежностей | Залежності впроваджуються через DI (builder.Services.Add...) |

---

 Приклади (Swagger UI)

| Групи | Студенти |
|-------|----------|

![image](https://github.com/user-attachments/assets/8e454f4e-6419-470c-9c26-8ffbeea7baaf)


---

## ✅ Автор

Мурзін В. А., група 611-Пст  
