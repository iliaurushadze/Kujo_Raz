using Kujo_RazWeb.Data;
using Kujo_RazWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Kujo_RazWeb.Pages.Categories
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        [BindProperty] // Instead of writing category variable, as OnPost method's parameter.
        public Category Category { get; set; }
        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {
            Category = _db.Category.Find(id);
        }

        public async Task<IActionResult> OnPost()
        {
                var categoryFromDb = _db.Category.Find(Category.Id);
                if(categoryFromDb != null)
                {
                    _db.Category.Remove(categoryFromDb);
                    await _db.SaveChangesAsync();
                    TempData["success"] = "Category Deleted Successfully";
                    return RedirectToPage("Index");
                }

            return Page();
        }
    }

    
}
