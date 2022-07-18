# TestTask
i made zis, thank you, very much ^o^

## Инструкция по запуску:
1) Склонируйте репозиторий
2) Установите все необходимые зависимости
    * Microsoft.EntityFrameworkCore
    * Microsoft.EntityFrameworkCore.Design
    * Microsoft.EntityFrameworkCore.SqlServer
    * Microsoft.EntityFrameworkCore.Tools
3) В файле appsettings.json добавьте свою строку соединения с БД
4) Выполните команды `dotnet ef migrations add InitialCreate`, а затем `dotnet ef database update` в корне проекта
5) Создайте записи в таблице Messages
6) Запустите: `dotnet run`
