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
			// �������� ���������� ������� WebApplication � �������� ���������� ��������� ������
			var builder = WebApplication.CreateBuilder(args);

			// ����������� ������� Razor Pages
			builder.Services.AddRazorPages();

			// ����������� ��������� ���� ������ RazorPagesDemoDbContext
			// � �������������� ������ ����������� �� ������������
			builder.Services.AddDbContext<RazorPagesDemoDbContext>(options =>
				options.UseSqlServer(builder.Configuration.GetConnectionString("RazorPagesDemoConnectionString")));

			// ���������� ������� WebApplication
			var app = builder.Build();

			// ��������, �� �������� �� ������� ����� �����������
			if (!app.Environment.IsDevelopment())
			{
				// � ������, ���� ������� ����� �� �������� �����������,
				// ��������������� �� �������� ������ � ������������� HSTS (HTTP Strict Transport Security)
				app.UseExceptionHandler("/Error");
				app.UseHsts();
			}

			// ��������������� HTTP-�������� �� HTTPS
			app.UseHttpsRedirection();

			// ��������� ���������� ����������� ����������� �����, ��������, CSS � JavaScript
			app.UseStaticFiles();

			// ������������� HTTP-��������
			app.UseRouting();

			// �������������� � ����������� �������������
			app.UseAuthorization();

			// ������������� Razor Pages
			app.MapRazorPages();

			// ������ ����������
			app.Run();
		}
	}
}