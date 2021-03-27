using Clippy.Data;
using Clippy.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace Clippy.Pages.Admin.Resources
{
    public class DetailsModel : PageModel
    {
        private ClippyContext _context;

        public DetailsModel(ClippyContext context) {
            _context = context;
        }

        [BindProperty]
        public Resource Resource { get; set; }

        public async Task<IActionResult> OnGetAsync(int id) {
            Resource = await _context.GetResourceAsync(id);
            if (Resource == null)
            {
                TempData["Message"] = $"Resource not found. Id = {id}.";
                return RedirectToPage("./Index");
            }

            return Page();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var resource = await _context.GetResourceAsync(id);

            if (resource == null)
            {
                TempData["Message"] = $"Resource not found. Id = {id}.";
                return RedirectToPage("./Index");
            }

            _context.Remove(resource);

            await _context.SaveChangesAsync();

            TempData["Message"] = $"The resource was successfully deleted.";

            return RedirectToPage("./Index");
        }

    }
}
