using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RapeCrisisCounsellorSystem.Data;
using RapeCrisisCounsellorSystem.Models;

namespace RapeCrisisCounsellorSystem.Pages.Counsellors
{
    public class EditModel : PageModel
    {
        private readonly RapeCrisisCounsellorSystem.Data.ApplicationDbContext _context;

        public EditModel(RapeCrisisCounsellorSystem.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Counsellor Counsellor { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Counsellor == null)
            {
                return NotFound();
            }

            var counsellor =  await _context.Counsellor.FirstOrDefaultAsync(m => m.CounsellorId == id);
            if (counsellor == null)
            {
                return NotFound();
            }
            Counsellor = counsellor;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Counsellor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CounsellorExists(Counsellor.CounsellorId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CounsellorExists(int id)
        {
          return (_context.Counsellor?.Any(e => e.CounsellorId == id)).GetValueOrDefault();
        }
    }
}
