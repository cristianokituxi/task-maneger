using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TaskManager.Data;
using TaskManager.Models;

namespace TaskManager.Pages.Tasks
{
    public class DeleteModel : PageModel
    {
        private readonly TaskContext _context;

        public DeleteModel(TaskContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TaskItem Task { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Task = await _context.Tasks.FindAsync(id);

            if (Task == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            var task = await _context.Tasks.FindAsync(id);

            if (task == null)
            {
                return NotFound();
            }

            _context.Tasks.Remove(task);
            await _context.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
