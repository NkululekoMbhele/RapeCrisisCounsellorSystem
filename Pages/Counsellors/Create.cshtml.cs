using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RapeCrisisCounsellorSystem.Data;
using RapeCrisisCounsellorSystem.Models;

namespace RapeCrisisCounsellorSystem.Pages.Counsellors
{
    public class CreateModel : PageModel
    {
        private readonly RapeCrisisCounsellorSystem.Data.ApplicationDbContext _context;

        public CreateModel(RapeCrisisCounsellorSystem.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Counsellor Counsellor { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Counsellor == null || Counsellor == null)
            {
                return Page();
            }

            _context.Counsellor.Add(Counsellor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
