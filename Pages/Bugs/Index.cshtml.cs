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
    public class IndexModel : PageModel
    {
        private readonly BugTracker.Data.BugTrackerContext _context;

        public IndexModel(BugTracker.Data.BugTrackerContext context)
        {
            _context = context;
        }

        public IList<Bug> Bug { get;set; }

        public async Task OnGetAsync()
        {
            Bug = await _context.Bug.ToListAsync();
        }
    }
}
