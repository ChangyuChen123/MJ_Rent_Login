using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MJ_Rent_Login.Data;
using MJ_Rent_Login.Models;

namespace MJ_Rent_Login.Pages.BorrowRecords
{
    public class CreateModel : PageModel
    {
        private readonly MJ_Rent_Login.Data.ApplicationDbContext _context;

        public CreateModel(MJ_Rent_Login.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public SelectList? Names { get; set; }


        public IActionResult OnGet()
        {
            var roomQuery = from m in _context.MeetRoom
                            orderby m.Name
                            select new { m.Name, m.Id };

            Names = new SelectList(roomQuery, "Id", "Name");
            return Page();
        }

        [BindProperty]
        public BorrowRecord BorrowRecord { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.BorrowRecord.Add(BorrowRecord);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
