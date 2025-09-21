using CategoryApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CategoryApp.Model;
namespace CategoryApp.Pages.Categorys

{
    public class IndexModel : PageModel
    {

        private readonly ApplicationDbContext _db;

        public IEnumerable<Category> Categories { get; set; }

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
    
        public void OnGet()
        {
            Categories = _db.Category.ToList();
        }
    }
}
