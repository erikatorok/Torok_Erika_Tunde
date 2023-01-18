using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Torok_Erika_Tunde.Data;
using Torok_Erika_Tunde.Models;

namespace Torok_Erika_Tunde.Pages.Clienti
{
    public class IndexModel : PageModel
    {
        private readonly Torok_Erika_Tunde.Data.Torok_Erika_TundeContext _context;

        public IndexModel(Torok_Erika_Tunde.Data.Torok_Erika_TundeContext context)
        {
            _context = context;
        }

        public IList<Client> Client { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Client = await _context.Client
                .Include(b => b.Material)
                .ToListAsync();
          
        }
    }
}
