using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RapeCrisisCounsellorSystem.Data;
using RapeCrisisCounsellorSystem.Models;

namespace RapeCrisisCounsellorSystem.Pages.Schedules
{
    public class CreateModel : PageModel
    {
        private readonly RapeCrisisCounsellorSystem.Data.ApplicationDbContext _context;

        public CreateModel(RapeCrisisCounsellorSystem.Data.ApplicationDbContext context)
        {
            this._context = context;
        }

        public IActionResult OnGet()
        {
            this.Counsellors = new SelectList(this._context.Counsellor, "CounsellorId", "Name");
            return Page();
        }
        public SelectList Counsellors { get; set; }

        [BindProperty]
        public Schedule Schedule { get; set; }
        
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
           
          if (!ModelState.IsValid || _context.Schedule == null || Schedule == null)
            {
                _context.Schedule.Add(Schedule);

                //There is an issue with saving to the database. The error we are receiving states that the CounsellorID(which is a FK in the schedule table) 
                await _context.SaveChangesAsync();

                return RedirectToPage("./Index");
            }
                return Page();

        }
    }
}
