﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BugTracker.Data;
using BugTracker.Models;

namespace BugTracker.Pages.Projects
{
    public class DeleteModel : PageModel
    {
        private readonly BugTracker.Data.BugTrackerContext _context;

        public DeleteModel(BugTracker.Data.BugTrackerContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Project Project { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Project = await _context.Project.FirstOrDefaultAsync(m => m.ID == id);

            if (Project == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Project = await _context.Project.FindAsync(id);

            if (Project != null)
            {
                _context.Project.Remove(Project);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
