using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BugTracker;
using BugTracker.Data;

namespace BugTracker.Pages.Bugs
{
    public class CreateModel : PageModel
    {
        private readonly BugTracker.Data.BugTrackerContext _context;

        public CreateModel(BugTracker.Data.BugTrackerContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Bug Bug { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Bug.Add(Bug);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
