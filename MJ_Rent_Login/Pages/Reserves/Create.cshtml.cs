using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MJ_Rent_Login.Data;
using MJ_Rent_Login.Models;

namespace MJ_Rent_Login.Pages.Reserves
{
    public class CreateModel : PageModel
    {
        private readonly MJ_Rent_Login.Data.ApplicationDbContext _context;

        public CreateModel(MJ_Rent_Login.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public SelectList? Names { get; set; }
        //public string? MeetRoomName { get; set; } //包含內容類型清單

        public async Task<IActionResult> OnGetAsync()
        {
            //下拉式清單顯示
            var roomQuery = from m in _context.MeetRoom
                                            orderby m.Name
                                            select new { m.Name, m.Id };

            Names = new SelectList(roomQuery,"Id","Name");

            //var meetroom = from m in _context.MeetRoom
            //             select m;

            //if (!string.IsNullOrEmpty(MeetRoomName))
            //{
            //    meetroom = meetroom.Where(x => x.Name == MeetRoomName);
            //}







            return Page();
        }

        [BindProperty]
        public Reserve Reserve { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Reserve.Add(Reserve);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
