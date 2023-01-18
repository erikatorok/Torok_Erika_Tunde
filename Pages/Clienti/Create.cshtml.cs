using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Torok_Erika_Tunde.Data;
using Torok_Erika_Tunde.Models;

namespace Torok_Erika_Tunde.Pages.Clienti
{
    public class CreateModel : PageModel
    {
        private readonly Torok_Erika_Tunde.Data.Torok_Erika_TundeContext _context;

        public CreateModel(Torok_Erika_Tunde.Data.Torok_Erika_TundeContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["MaterialID"] = new SelectList(_context.Set<Material>(), "ID",
"MaterialName");
            return Page();
        }

        [BindProperty]
        public Client Client { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Client.Add(Client);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
