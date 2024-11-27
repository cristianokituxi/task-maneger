using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TaskManager.Data;
using TaskManager.Models;

namespace TaskManager.Pages.Tasks
{
    public class IndexModel : PageModel
    {
        private readonly TaskContext _context;

        public IndexModel(TaskContext context)
        {
            _context = context;
        }

        public IList<TaskItem> Tasks { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Tasks = await _context.Tasks.ToListAsync();
        }
    }
}
