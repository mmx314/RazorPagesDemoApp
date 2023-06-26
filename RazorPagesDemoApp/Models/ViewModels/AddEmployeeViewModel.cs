/*
В этой части кода объявляется пространство имен RazorPagesDemoApp.Models.ViewModels, 
которое используется для организации классов и типов данных. 
Пространства имен позволяют избежать конфликтов имен между различными компонентами приложения.
Затем объявляется публичный класс AddEmployeeViewModel, 
который является моделью представления (view model) для добавления нового сотрудника. 
Модели представления используются для передачи данных между представлением и контроллером в архитектуре MVC (Model-View-Controller).
Класс AddEmployeeViewModel содержит пять свойств: Name, Email, Salary, DateOfBirth и Deparment, 
каждое из которых представляет определенный атрибут сотрудника, такой как имя, электронная почта, зарплата, 
дата рождения и отдел соответственно. Эти свойства используются для хранения и передачи данных, 
связанных с новым сотрудником.
 */

// Объявление пространства имен RazorPagesDemoApp.Models.ViewModels
namespace RazorPagesDemoApp.Models.ViewModels
{
	// Объявление публичного класса AddEmployeeViewModel
	public class AddEmployeeViewModel
	{
		// Объявление свойства Name типа string
		public string Name { get; set; }

		// Объявление свойства Email типа string
		public string Email { get; set; }

		// Объявление свойства Salary типа long
		public long Salary { get; set; }

		// Объявление свойства DateOfBirth типа DateTime
		public DateTime DateOfBirth { get; set; }

		// Объявление свойства Deparment типа string
		public string Deparment { get; set; }
	}
}
