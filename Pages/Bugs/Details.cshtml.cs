using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BugTracker;
using BugTracker.Data;

namespace BugTracker.Pages.Bugs
{
    public class DetailsModel : PageModel
    {
        private readonly BugTracker.Data.BugTrackerContext _context;

        public DetailsModel(BugTracker.Data.BugTrackerContext context)
        {
            _context = context;
        }

        public Bug Bug { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Bug = await _context.Bug.FirstOrDefaultAsync(m => m.ID == id);

            if (Bug == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
