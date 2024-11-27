using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TaskManager.Data;
using TaskManager.Models;

namespace TaskManager.Pages.Tasks
{
    public class CreateModel : PageModel
    {
        private readonly TaskContext _context;

        public CreateModel(TaskContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TaskItem Task { get; set; } = default!;

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Tasks.Add(Task);
            await _context.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
