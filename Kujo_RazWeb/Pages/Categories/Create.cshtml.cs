using Kujo_RazWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Kujo_RazWeb.Pages.Categories
{
    public class CreateModel : PageModel
    {
        public Category Category { get; set; }
        public void OnGet()
        {
        }
    }
}
