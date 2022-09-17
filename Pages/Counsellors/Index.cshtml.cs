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
    public class IndexModel : PageModel
    {
        private readonly RapeCrisisCounsellorSystem.Data.ApplicationDbContext _context;

        public IndexModel(RapeCrisisCounsellorSystem.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Counsellor> Counsellor { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Counsellor != null)
            {
                Counsellor = await _context.Counsellor.ToListAsync();
            }
        }
    }
}
