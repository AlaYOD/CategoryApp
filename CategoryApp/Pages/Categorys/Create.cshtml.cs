using CategoryApp.Data;
using CategoryApp.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace CategoryApp.Pages.Categorys
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Category Category { get; set; } = new();
        private readonly ApplicationDbContext _db;


        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }


        public void OnGet()
        {   

        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
              
                return Page();
            }

            await _db.Category.AddAsync(Category);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
