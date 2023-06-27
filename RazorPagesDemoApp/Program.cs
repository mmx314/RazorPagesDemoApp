//---------------------------------------------------------------------------------------------------------------------
//https://www.youtube.com/watch?v=ZEwVdAxdzys
//ASP.NET Core Razor Pages CRUD - .NET 6 Razor Pages CRUD Using Entity Framework Core and SQL Server
//Sameer Saini
//---------------------------------------------------------------------------------------------------------------------

using Microsoft.EntityFrameworkCore;
using RazorPagesDemoApp.Data;

namespace RazorPagesDemoApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// Создание экземпляра объекта WebApplication и передача аргументов командной строки
			var builder = WebApplication.CreateBuilder(args);

			// Регистрация сервиса Razor Pages
			builder.Services.AddRazorPages();

			// Регистрация контекста базы данных RazorPagesDemoDbContext
			// с использованием строки подключения из конфигурации
			builder.Services.AddDbContext<RazorPagesDemoDbContext>(options =>
				options.UseSqlServer(builder.Configuration.GetConnectionString("RazorPagesDemoConnectionString")));

			// Построение объекта WebApplication
			var app = builder.Build();

			// Проверка, не является ли текущая среда разработкой
			if (!app.Environment.IsDevelopment())
			{
				// В случае, если текущая среда не является разработкой,
				// перенаправление на страницу ошибки и использование HSTS (HTTP Strict Transport Security)
				app.UseExceptionHandler("/Error");
				app.UseHsts();
			}

			// Перенаправление HTTP-запросов на HTTPS
			app.UseHttpsRedirection();

			// Позволяет приложению обслуживать статические файлы, например, CSS и JavaScript
			app.UseStaticFiles();

			// Маршрутизация HTTP-запросов
			app.UseRouting();

			// Аутентификация и авторизация пользователей
			app.UseAuthorization();

			// Сопоставление Razor Pages
			app.MapRazorPages();

			// Запуск приложения
			app.Run();
		}
	}
}