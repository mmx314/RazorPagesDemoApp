using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using RazorPagesDemoApp.Data;
using RazorPagesDemoApp.Models.Domain;
using RazorPagesDemoApp.Models.ViewModels;

namespace RazorPagesDemoApp.Pages.Employees
{
    public class AddModel : PageModel
    {
		private readonly RazorPagesDemoDbContext dbContext;

		public AddModel(RazorPagesDemoDbContext dbContext)
        {
			this.dbContext = dbContext;
		}

        [BindProperty]
        public AddEmployeeViewModel AddEmployeeRequest { get; set; }
        
        public void OnGet()
        {
        }

		public void OnPost()
		{
			/*
						//Convert ViewModel to DomainModel
						var employeeDamainModel = new Employee
						{ 
							Name = 
						}
			*/
		}
	}
}
