using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RapeCrisisCounsellorSystem.Data;
using RapeCrisisCounsellorSystem.Models;

namespace RapeCrisisCounsellorSystem.Pages.Counsellors
{
    public class DeleteModel : PageModel
    {
        private readonly RapeCrisisCounsellorSystem.Data.ApplicationDbContext _context;

        public DeleteModel(RapeCrisisCounsellorSystem.Data.ApplicationDbContext context)
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

            var counsellor = await _context.Counsellor.FirstOrDefaultAsync(m => m.CounsellorId == id);

            if (counsellor == null)
            {
                return NotFound();
            }
            else 
            {
                Counsellor = counsellor;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Counsellor == null)
            {
                return NotFound();
            }
            var counsellor = await _context.Counsellor.FindAsync(id);

            if (counsellor != null)
            {
                Counsellor = counsellor;
                _context.Counsellor.Remove(Counsellor);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
